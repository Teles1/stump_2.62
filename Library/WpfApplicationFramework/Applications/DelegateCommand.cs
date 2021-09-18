﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;

namespace System.Waf.Applications
{
    /// <summary>
    /// Provides an <see cref="ICommand"/> implementation which relays the <see cref="Execute"/> and <see cref="CanExecute"/> 
    /// method to the specified delegates.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;
        private List<WeakReference> weakHandlers;


        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="execute">Delegate to execute when Execute is called on the command.</param>
        /// <exception cref="ArgumentNullException">The execute argument must not be null.</exception>
        public DelegateCommand(Action execute) : this(execute, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="execute">Delegate to execute when Execute is called on the command.</param>
        /// <exception cref="ArgumentNullException">The execute argument must not be null.</exception>
        public DelegateCommand(Action<object> execute) : this(execute, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="execute">Delegate to execute when Execute is called on the command.</param>
        /// <param name="canExecute">Delegate to execute when CanExecute is called on the command.</param>
        /// <exception cref="ArgumentNullException">The execute argument must not be null.</exception>
        public DelegateCommand(Action execute, Func<bool> canExecute)
            : this(execute != null ? p => execute() : (Action<object>)null, canExecute != null ? p => canExecute() : (Func<object, bool>)null)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="execute">Delegate to execute when Execute is called on the command.</param>
        /// <param name="canExecute">Delegate to execute when CanExecute is called on the command.</param>
        /// <exception cref="ArgumentNullException">The execute argument must not be null.</exception>
        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            if (execute == null) { throw new ArgumentNullException("execute"); }

            this.execute = execute;
            this.canExecute = canExecute;
        }


        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (weakHandlers == null)
                {
                    weakHandlers = new List<WeakReference>(new[] { new WeakReference(value) });
                }
                else
                {
                    weakHandlers.Add(new WeakReference(value));
                }
            }
            remove
            {
                if (weakHandlers == null) { return; }

                for (int i = weakHandlers.Count - 1; i >= 0; i--)
                {
                    WeakReference weakReference = weakHandlers[i];
                    EventHandler handler = weakReference.Target as EventHandler;
                    if (handler == null || handler == value)
                    {
                        weakHandlers.RemoveAt(i);
                    }
                }
            }
        }


        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            return canExecute != null ? canExecute(parameter) : true;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <exception cref="InvalidOperationException">The <see cref="CanExecute"/> method returns <c>false.</c></exception>
        public void Execute(object parameter)
        {
            if (!CanExecute(parameter))
            {
                throw new InvalidOperationException("The command cannot be executed because the canExecute action returned false.");
            }

            execute(parameter);
        }

        /// <summary>
        /// Raises the CanExecuteChanged event.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            OnCanExecuteChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Raises the CanExecuteChanged event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnCanExecuteChanged(EventArgs e)
        {
            PurgeWeakHandlers();

            if (weakHandlers == null) { return; }

            WeakReference[] handlers = weakHandlers.ToArray();
            foreach (WeakReference reference in handlers)
            {
                EventHandler handler = reference.Target as EventHandler;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
        }

        private void PurgeWeakHandlers()
        {
            if (weakHandlers == null) { return; }

            for (int i = weakHandlers.Count - 1; i >= 0; i--)
            {
                if (!weakHandlers[i].IsAlive)
                {
                    weakHandlers.RemoveAt(i);
                }
            }

            if (weakHandlers.Count == 0) { weakHandlers = null; }
        }
    }
}
