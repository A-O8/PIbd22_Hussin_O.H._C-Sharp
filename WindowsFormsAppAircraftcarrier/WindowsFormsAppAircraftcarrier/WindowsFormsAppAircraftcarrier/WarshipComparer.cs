using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsAppAircraftcarrier
{
    class WarshipComparer: IComparer<Ship>
	{
		public int Compare(Ship x, Ship y)
	{
		if (x is Aircraft_carrier && y is Aircraft_carrier)
		{
			return CompareAircraft_carrier((Aircraft_carrier)x, (Aircraft_carrier)y);
		}
		else if (x is Aircraft_carrier)
		{
			return 1;
		}
		else if (y is Aircraft_carrier)
		{
			return -1;
		}
		return CompareWarship((Warship)x, (Warship)y);
	}
	private int CompareWarship(Warship x, Warship y)
	{
		if (x.MaxSpeed != y.MaxSpeed)
		{
			return x.MaxSpeed.CompareTo(y.MaxSpeed);
		}
		if (x.Weight != y.Weight)
		{
			return x.Weight.CompareTo(y.Weight);
		}
		if (x.MainColor != y.MainColor)
		{
			return x.MainColor.Name.CompareTo(y.MainColor.Name);
		}
		return 0;
	}
	private int CompareAircraft_carrier(Aircraft_carrier x, Aircraft_carrier y)
	{
		var res = CompareWarship(x, y);
		if (res != 0)
		{
			return res;
		}
		if (x.DopColor != y.DopColor)
		{
			return x.DopColor.Name.CompareTo(y.DopColor.Name);
		}
		if (x.Plaines != y.Plaines)
		{
			return x.Plaines.CompareTo(y.Plaines);
		}
		if (x.Aerodrom != y.Aerodrom)
			{
			return x.Aerodrom.CompareTo(y.Aerodrom);
		}
		return 0;
	}
}
}