﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAircraftcarrier
{
    class ParkingCollection
    {
		readonly Dictionary<string, Parking<WaterITransport>> parkingStages;

		/// Возвращение списка названий праковок
		public List<string> Keys => parkingStages.Keys.ToList();

		private readonly int pictureWidth;

		private readonly int pictureHeight;

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
	}
}
