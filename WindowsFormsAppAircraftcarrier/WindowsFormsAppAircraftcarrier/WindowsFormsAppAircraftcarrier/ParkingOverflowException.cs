using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsAppAircraftcarrier
{
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException(string s) : base(s)
        { }
    }
}

