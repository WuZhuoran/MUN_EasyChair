using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MUN_ChairTools
{
    /// <summary>
    /// 每一个Conference包含多个Session
    /// </summary>
    public class Session : Conference
    {
        public int SessionNumber { get; set; }
        public int PresentMainCountryNumber { get; set; }
        public int PresentObserverCountryNumber { get; set; }
        public int SimpleMajority { get; set; }
        public int TwoThirdsMajority { get; set; }
        public int TwentyMajority { get; set; }
        public int CustomMajority { get; set; } //自定义多数

        public List<Country> CountryList;//每一次的国家列表，用来统计到场的国家

        public Session(int sessionNumber)
        {
            this.SessionNumber = sessionNumber;
            this.PresentMainCountryNumber = 0;
            this.PresentObserverCountryNumber = 0;
            this.SimpleMajority = 0;
            this.TwoThirdsMajority = 0;
            this.TwentyMajority = 0;
            this.CustomMajority = 0;
            
        }
    }
}
