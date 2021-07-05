using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherModels
    {
        int t,p;
        public string TEMPERATURE { get { return $"{t.ToString()} 'C"; } set { int.TryParse(value, out t); } }
        public string PRESSURE { get{ return $"{p.ToString()} мм рт ст"; } set { int.TryParse(value, out p); } }

        public string CityName { get; internal set; }
        //public override string ToString()
        //{
        //    return $"{TEMPERATURE} {PRESSURE}";
        //}
    }
}
