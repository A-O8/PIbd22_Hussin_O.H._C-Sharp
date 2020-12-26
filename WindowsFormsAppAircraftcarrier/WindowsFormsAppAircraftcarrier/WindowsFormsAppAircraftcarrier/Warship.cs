using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAircraftcarrier
{
   public class Warship : Ship
    {
        protected readonly int АвианосецWidth = 100;
        protected readonly int АвианосецHeight = 100;
        protected double chWidth = 1.1;
        protected double chHeight = 3.2;
        public Warship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        protected Warship(int maxSpeed, float weight, Color mainColor, int АвианосецWidth, int АвианосецHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.АвианосецWidth = АвианосецWidth;
            this.АвианосецHeight = АвианосецHeight;
        }
        public override void MoveShip(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - АвианосецWidth * chHeight)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево                
                case Direction.Left:
                    if (_startPosX - step > 0)

                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх                 
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }

                    break;
                //вниз                
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - АвианосецHeight * chWidth)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void Drawship(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            Brush brRed = new SolidBrush(Color.Red);
            g.FillEllipse(brRed, _startPosX + 270, _startPosY + 12, 35, 120);

            g.FillRectangle(Brushes.Teal, _startPosX + 2, _startPosY + 20, 240, 102);
            PointF[] sours =
                     {
            new PointF(_startPosX, _startPosY+50),
            new PointF(_startPosX + 160, _startPosY + 20),
            new PointF(_startPosX + 250, _startPosY + 20),
            new PointF(_startPosX + 390, _startPosY + 70),
            new PointF(_startPosX + 250, _startPosY + 120),
            new PointF(_startPosX + 160, _startPosY + 120),
           new PointF(_startPosX, _startPosY+90),
             };
            g.FillPolygon(new SolidBrush(MainColor), sours);

        }
    }
}
