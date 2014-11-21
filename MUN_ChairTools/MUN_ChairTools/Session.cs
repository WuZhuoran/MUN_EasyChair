using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MUN_ChairTools
{
    /// <summary>
    /// 每一个Conference包含多个Session
    /// </summary>
    class Session : Conference
    {
        public int SessionNumber { get; set; }
        public int CountryNumber { get; set; }
        public int SimpleMajority { get; set; }
        public int TwoThirdsMajority { get; set; }
        public int TwentyMajority { get; set; }
        public int CustomMajority { get; set; }

        public List<Country> CountryList;//每一次的国家列表，用来统计到场的国家

        public Session()
        {
        
        }


    }
}
