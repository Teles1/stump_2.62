﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Data;

namespace Stump.Tools.QuickItemEditor.Converters
{
    //
    // ComparisonBinding is a Binding that should be used in a DataTrigger.Binding.
    // It supports a comparison operator and a comparand, so that you can use it as a
    // conditional DataTrigger.  The trick is to set {x:Null} as the DataTrigger.Value.
    // E.g.:
    //
    //  <DataTrigger Value={x:Null}
    //               Binding={h:ComparisonBinding Width, EQ, 100}"
    //
    // The operator can be EQ, LT, LTE, GT, GTE.
    //

    public class ComparaisonBinding : Binding
    {
        // Default constructor

        public ComparaisonBinding()
            : this(null, ComparisonOperators.EQ, null)
        {
        }

        // Construction with an operator & comparand

        public ComparaisonBinding(string path, ComparisonOperators op, object comparand)
            : base(path)
        {
            Comparand = comparand;
            Operator = op;
            Converter = new ComparisonConverter(this);
        }

        // Operator and comparand

        public ComparisonOperators Operator
        {
            get;
            set;
        }

        public object Comparand
        {
            get;
            set;
        }

    }

    // Supported types of comparisons

    public enum ComparisonOperators
    {
        EQ = 0,
        GT,
        GTE,
        LT,
        LTE
    }

    //
    // Thie IValueConverter is used by the StyleBinding to
    // implement the logical comparisson.  ConvertBack isn't supported.
    // Convert returns null if the condition is met, non-null otherwise.
    //

    internal class ComparisonConverter : IValueConverter
    {
        // Keep a back reference to the StyleBinding
        ComparaisonBinding _styleBinding;

        // Return this if the condition isn't met
        static object _notNull = new Object();

        // In construction, get a reference to the StyleBinding
        public ComparisonConverter(ComparaisonBinding styleBinding)
        {
            _styleBinding = styleBinding;
        }


        //
        //  IValueConverter.Convert
        //
        //  Return null of the condition is met, non-null if not.
        //

        public object Convert(
            object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Simple check for null

            if (value == null || _styleBinding.Comparand == null)
            {
                return ReturnHelper(value == _styleBinding.Comparand);
            }

            // Convert the comparand so that it matches the value

            object convertedComparand = _styleBinding.Comparand;
            try
            {
                // Only support simple conversions in here. 
                convertedComparand = System.Convert.ChangeType(_styleBinding.Comparand, value.GetType());
            }
            catch (InvalidCastException)
            {
                // If Convert.ChangeType didn't work, try a type converter
                TypeConverter typeConverter = TypeDescriptor.GetConverter(value);
                if (typeConverter != null)
                {
                    if (typeConverter.CanConvertFrom(_styleBinding.Comparand.GetType()))
                    {
                        convertedComparand = typeConverter.ConvertFrom(_styleBinding.Comparand);
                    }
                }
            }

            // Simple check for the equality case

            if (_styleBinding.Operator == ComparisonOperators.EQ)
            {
                // Actually, equality is a little more interesting, so put it in
                // a helper routine

                return ReturnHelper(
                            CheckEquals(value.GetType(), value, convertedComparand));
            }

            // For anything other than Equals, we need IComparable

            if (!( value is IComparable ) || !( convertedComparand is IComparable ))
            {
                Trace(value, "One of the values was not an IComparable");
                return ReturnHelper(false);
            }

            // Compare the values

            int comparison = ( value as IComparable ).CompareTo(convertedComparand);

            // And return the comparisson result

            switch (_styleBinding.Operator)
            {
                case ComparisonOperators.GT:
                    return ReturnHelper(comparison > 0);

                case ComparisonOperators.GTE:
                    return ReturnHelper(comparison >= 0);

                case ComparisonOperators.LT:
                    return ReturnHelper(comparison < 0);

                case ComparisonOperators.LTE:
                    return ReturnHelper(comparison <= 0);
            }

            return _notNull;
        }

        //
        // This helper produces the return value; null if the values
        // match, non-null otherwise.
        //

        object ReturnHelper(bool result)
        {
            return result ? null : _notNull;
        }

        //
        // Trace output to the debugger
        //

        void Trace(object value, string message)
        {
            if (Debugger.IsAttached)
            {
                Debug.WriteLine("StyleBinding couldn't convert '"
                                 + value.GetType()
                                 + "' to '"
                                 + _styleBinding.Comparand.GetType()
                                 + "'");
                Debug.WriteLine("(" + message + ")");
            }
        }

        //
        // Check for equality of two values
        //

        private bool CheckEquals(Type type, object value1, object value2)
        {
            if (type.IsValueType || type == typeof(string))
            {
                return Object.Equals(value1, value2);
            }

            else
            {
                return Object.ReferenceEquals(value1, value2);
            }
        }

        //
        //  IValueConverter.ConvertBack isn't supported.
        //

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}