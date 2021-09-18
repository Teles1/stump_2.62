using System.Collections.Generic;
using Stump.DofusProtocol.Enums;
using Stump.Server.WorldServer.Database.World;

namespace Stump.Server.WorldServer.Game.Maps.Cells.Shapes
{
    public class Zone : IShape
    {
        private IShape m_shape;

        private SpellShapeEnum m_shapeType;

        public Zone(SpellShapeEnum shape, byte radius)
        {
            Radius = radius;
            ShapeType = shape;
        }

        public Zone(SpellShapeEnum shape, byte radius, DirectionsEnum direction)
        {
            Radius = radius;
            Direction = direction;
            ShapeType = shape;
        }

        public SpellShapeEnum ShapeType
        {
            get { return m_shapeType; }
            set
            {
                m_shapeType = value;
                InitializeShape();
            }
        }

        public IShape Shape
        {
            get { return m_shape; }
        }

        #region IShape Members

        public uint Surface
        {
            get { return m_shape.Surface; }
        }

        public byte MinRadius
        {
            get { return m_shape.MinRadius; }
            set { m_shape.MinRadius = value; }
        }

        public DirectionsEnum Direction
        {
            get
            {
                return m_direction;
            }
            set
            {
                m_direction = value;
                if (m_shape != null)
                    m_shape.Direction = value;
            }
        }

        private byte m_radius;
        private DirectionsEnum m_direction;

        public byte Radius
        {
            get { return m_radius; }
            set
            {
                m_radius = value; 
                if (m_shape != null)
                    m_shape.Radius = value;
            }
        }

        public Cell[] GetCells(Cell centerCell, Map map)
        {
            return m_shape.GetCells(centerCell, map);
        }

        #endregion

        private void InitializeShape()
        {
            switch (ShapeType)
            {
                case SpellShapeEnum.X:
                    m_shape = new Cross(0, Radius);
                    break;
                case SpellShapeEnum.L:
                    m_shape = new Line(Radius);
                    break;
                case SpellShapeEnum.T:
                    m_shape = new Cross(0, Radius)
                                  {
                                      OnlyPerpendicular = true
                                  };
                    break;
                case SpellShapeEnum.D:
                    m_shape = new Cross(0, Radius);
                    break;
                case SpellShapeEnum.C:
                    m_shape = new Lozenge(0, Radius);
                    break;
                case SpellShapeEnum.I:
                    m_shape = new Lozenge(Radius, 63);
                    break;
                case SpellShapeEnum.O:
                    m_shape = new Cross(1, Radius);
                    break;
                case SpellShapeEnum.Q:
                    m_shape = new Cross(1, Radius);
                    break;
                case SpellShapeEnum.V:
                    m_shape = new Cone(0, Radius);
                    break;
                case SpellShapeEnum.W:
                    m_shape = new Square(0, Radius)
                                  {
                                      DiagonalFree = true
                                  };
                    break;
                case SpellShapeEnum.plus:
                    m_shape = new Cross(0, Radius)
                                  {
                                      Diagonal = true
                                  };
                    break;
                case SpellShapeEnum.sharp:
                    m_shape = new Cross(1, Radius)
                                  {
                                      Diagonal = true
                                  };
                    break;
                case SpellShapeEnum.star:
                    m_shape = new Cross(0, Radius)
                                  {
                                      AllDirections = true
                                  };
                    break;
                case SpellShapeEnum.slash:
                    m_shape = new Line(Radius);
                    break;
                case SpellShapeEnum.U:
                    m_shape = new HalfLozenge(0, Radius);
                    break;
                case SpellShapeEnum.A:
                    m_shape = new Lozenge(0, 63);
                    break;
                case SpellShapeEnum.P:
                    m_shape = new Single();
                    break;
                case SpellShapeEnum.Hammer:
                    m_shape = new Cross(0, Radius)
                    {
                        DisabledDirections = new List<DirectionsEnum>
                        {
                            (DirectionsEnum) ((int)Direction - 4 > 0 ? (int)Direction - 4 : (int)Direction + 4)
                        }
                    };
                    break;
                default:
                    m_shape = new Cross(0, 0);
                    break;
            }

            m_shape.Direction = Direction;
        }
    }
}