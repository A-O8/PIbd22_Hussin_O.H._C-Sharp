using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
namespace WindowsFormsAppAircraftcarrier
{
   public class Parking<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, WaterITransport
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
        
        /// </summary>
        private const int placeSizeWidth = 500;
        /// <summary>
       
        /// </summary>
        private const int placeSizeHeight = 170;
        private int _currentIndex;
        public T Current => places[_currentIndex];
        object IEnumerator.Current => places[_currentIndex];
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
        public static bool operator +(Parking<T> p, T ship)
        {
            if (p.places.Count >= p.maxCount)
            {
                throw new ParkingOverflowException("Переполнено");
            }
            if (p.places.Contains(ship))
            {
                throw new ParkingAlreadyHaveException();
            }
            p.places.Add(ship);
            return true;
        }
        /// <summary>
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p.places.Count)
            {
                throw new ParkingNotFoundException(index);
            }
            T ship = p.places[index];
            p.places.RemoveAt(index);
            return ship;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Count; i++)
            {
                places[i].SetPosition(5 + i / 3 * placeSizeWidth + 5, i % 3 * placeSizeHeight + 15, pictureWidth, pictureHeight);
                places[i].Drawship(g);
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
        public void Sort() => places.Sort((IComparer<T>)new WarshipComparer());
        public void Dispose()
        {
        }
        public bool MoveNext()
        {
            if (_currentIndex + 1 == places.Count)
            {
                return false;
            }
            _currentIndex++;
            return true;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
