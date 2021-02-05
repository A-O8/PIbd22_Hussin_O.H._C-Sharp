using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsAppAircraftcarrier
{
    class ParkingCollection
    {
		readonly Dictionary<string, Parking<WaterITransport>> parkingStages;

		/// Возвращение списка названий праковок
		public List<string> Keys => parkingStages.Keys.ToList();
		private readonly int pictureWidth;
		private readonly int pictureHeight;
        private readonly char separator = ':';
        public ParkingCollection(int pictureWidth, int pictureHeight)
		{
			parkingStages = new Dictionary<string, Parking<WaterITransport>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}
		public void AddParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				return;
			}
			parkingStages.Add(name, new Parking<WaterITransport>(pictureWidth, pictureHeight));

		}
		public void DelParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				parkingStages.Remove(name);
			}
		}
		public Parking<WaterITransport> this[string ind]
		{
			get
			{
				if (parkingStages.ContainsKey(ind))
				{
					return parkingStages[ind];
				}
				return null;
            }
        }
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8))
            {
                sw.WriteLine("ParkingCollection");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    WaterITransport ship = null;
                    for (int i = 0; (ship = level.Value.GetNext(i)) != null; i++)
                    {
                        if (ship != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (ship.GetType().Name == "Warship")
                            {
                                sw.Write($"Warship{separator}");
                            }
                            if (ship.GetType().Name == "Aircraft_carrier")
                            {
                                sw.Write($"Aircraft_carrier{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(ship.ToString());
                        }
                    }
                }
            }  
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string line = sr.ReadLine();
                string key = string.Empty;
                if (line.Contains("ParkingCollection"))
                {
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FormatException("Неверный формат файла");
                }
                while ((line = sr.ReadLine()) != null)
                {
                    Ship ship = null;
                    if (line.Contains("Parking"))
                    {
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<WaterITransport>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "Warship")
                    {
                        ship = new Warship(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Aircraft_carrier")
                    {
                        ship = new Aircraft_carrier(line.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + ship;
                    if (!result)
                    {
                        throw new ParkingOverflowException("Не удалось загрузить ship на парковку");
                    }
                }
            }
        }
    }
}
