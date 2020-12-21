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
            g.FillEllipse(brRed, _startPosX + 190, _startPosY + 13, 35, 80);
            // dbadh
            g.FillEllipse(Brushes.Coral, _startPosX + 95, _startPosY - 2, 40, 30);

            g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY - 30, 10, 30);
            g.FillRectangle(Brushes.Teal, _startPosX + 30, _startPosY + 15, 150, 72);
            g.FillEllipse(Brushes.Teal, _startPosX + 30, _startPosY + 20, 285, 62);
            g.FillEllipse(Brushes.Goldenrod, _startPosX + 170, _startPosY + 35, 120, 30);

            g.FillRectangle(Brushes.Goldenrod, _startPosX + 40, _startPosY + 30, 140, 40);
            g.FillRectangle(Brushes.Goldenrod, _startPosX + 80, _startPosY + 35, 150, 30);
            g.FillRectangle(Brushes.Maroon, _startPosX + 190, _startPosY + 38, 10, 25);

            g.FillRectangle(Brushes.Maroon, _startPosX + 170, _startPosY + 38, 10, 25);
            g.FillRectangle(Brushes.Maroon, _startPosX + 150, _startPosY + 38, 10, 25);
            g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY + 9, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY + 9, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY + 9, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 2, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY - 2, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY - 2, 8, 8);

        }
    }
}

