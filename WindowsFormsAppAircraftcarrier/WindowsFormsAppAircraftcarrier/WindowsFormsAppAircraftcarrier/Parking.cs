using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsAppAircraftcarrier
{
    class Parking<T> where T : class, WaterITransport
    {
        private readonly List<T> places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        private readonly int maxCount;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private const int placeSizeWidth = 500;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private const int placeSizeHeight = 170;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / placeSizeWidth;
            int height = picHeight / placeSizeHeight;
            places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            maxCount = width * height;
        }
        public static bool operator +(Parking<T> p, T Ship)
        {
            if (p.places.Count >= p.maxCount)
            {
                throw new ParkingOverflowException("Переполнено");
            }
            p.places.Add(Ship);
            return true;
        }
        /// <summary>
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p.places.Count)
            {
                throw new ParkingNotFoundException(index);
            }
            T car = p.places[index];
            p.places.RemoveAt(index);
            return car;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Count; i++)
            {
                places[i].SetPosition(5 + i / 3 * placeSizeWidth + 5, i % 3 * placeSizeHeight + 15, pictureWidth, pictureHeight);
                places[i]?.Drawship(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / placeSizeWidth; i++)

            {
                for (int j = 0; j < pictureHeight / placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + placeSizeWidth / 2, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, (pictureHeight / placeSizeHeight) * placeSizeHeight);
            }
        }
        public T GetNext(int index)
        {
            if (index < 0 || index >= places.Count)
            {
                return null;
            }
            return places[index];
        }
    }
}
