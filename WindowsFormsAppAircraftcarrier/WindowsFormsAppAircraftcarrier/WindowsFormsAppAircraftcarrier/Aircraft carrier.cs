using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsAppAircraftcarrier
{
   public class Aircraft_carrier : Warship

    {
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
            g.FillEllipse(Brushes.Teal, _startPosX + 30, _startPosY + 20, 385, 100);
            base.Drawship(g);
            if (Plaines)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 55, 270, 30);
                g.FillEllipse(Brushes.Teal, _startPosX + 100, _startPosY + 110, 160, 40);
                g.FillRectangle(Brushes.Teal, _startPosX + 80, _startPosY + 111, 40, 30);
                g.FillEllipse(spoiler, _startPosX + 200, _startPosY + 127, 25, 10);
                g.FillEllipse(spoiler, _startPosX + 210, _startPosY + 123, 5, 18);
                g.FillEllipse(spoiler, _startPosX + 150, _startPosY + 127, 25, 10);
                g.FillEllipse(spoiler, _startPosX + 160, _startPosY + 123, 5, 18);
                g.FillEllipse(spoiler, _startPosX + 120, _startPosY + 127, 25, 10);
                g.FillEllipse(spoiler, _startPosX + 130, _startPosY + 123, 5, 18);
                g.FillEllipse(spoiler, _startPosX + 90, _startPosY + 127, 25, 10);
                g.FillEllipse(spoiler, _startPosX + 100, _startPosY + 123, 5, 18);
            }
            if (Aerodrom)
            {
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








    

