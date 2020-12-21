using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsAppAircraftcarrier
{
    class Aircraft_carrier : Warship

    {
        public enum Direction
        {
            Up,

            Down,

            Left,

            Right
        }

        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        public bool Plaines { private set; get; }
        public bool Aerodrom { private set; get; }

        public Aircraft_carrier(int maxSpeed, float weight, Color mainColor, Color dopColor,
 bool plaines, bool aerodrom)

             : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Plaines = plaines;
            Aerodrom = aerodrom;
        }

        public override void Drawship(Graphics g)
        {

            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            g.DrawRectangle(pen, _startPosX + 40, _startPosY + 30, 140, 40);

            g.FillRectangle(Brushes.Coral, _startPosX + 40, _startPosY + 30, 140, 40);


            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 35, 150, 30);

            g.FillRectangle(Brushes.Coral, _startPosX + 80, _startPosY + 35, 150, 30);

            g.DrawEllipse(pen, _startPosX + 190, _startPosY + 13, 35, 80);
            g.FillRectangle(Brushes.Teal, _startPosX + 15, _startPosY + 15, 185, 72);

            base.Drawship(g);
            g.FillEllipse(Brushes.Teal, _startPosX + 60, _startPosY + 80, 150, 30);
            g.FillRectangle(Brushes.Teal, _startPosX + 40, _startPosY + 81, 40, 20);

            if (Plaines)
            {
                g.DrawEllipse(pen, _startPosX + 45, _startPosY + 37, 25, 25);
                g.DrawEllipse(pen, _startPosX + 160, _startPosY + 45, 10, 10);
                g.DrawRectangle(pen, _startPosX + 55, _startPosY + 33, 140, 33);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 45, 140, 10);
                g.DrawRectangle(pen, _startPosX + 190, _startPosY + 38, 10, 25);
                g.DrawRectangle(pen, _startPosX + 170, _startPosY + 38, 10, 25);
                g.DrawRectangle(pen, _startPosX + 150, _startPosY + 38, 10, 25);

            }

            if (Aerodrom)
            {
                // plaines
                g.FillEllipse(Brushes.Coral, _startPosX + 160, _startPosY + 87, 25, 10);
                g.FillEllipse(Brushes.Coral, _startPosX + 170, _startPosY + 83, 5, 18);

                g.FillEllipse(Brushes.Coral, _startPosX + 130, _startPosY + 87, 25, 10);
                g.FillEllipse(Brushes.Coral, _startPosX + 140, _startPosY + 83, 5, 18);

                g.FillEllipse(Brushes.Coral, _startPosX + 100, _startPosY + 87, 25, 10);
                g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY + 83, 5, 18);

                g.FillEllipse(Brushes.Coral, _startPosX + 70, _startPosY + 87, 25, 10);
                g.FillEllipse(Brushes.Coral, _startPosX + 80, _startPosY + 83, 5, 18);


            }

           
        }

    }

    

}








    

