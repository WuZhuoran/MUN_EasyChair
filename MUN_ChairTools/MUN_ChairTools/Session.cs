using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MUN_ChairTools
{
    /// <summary>
    /// 每一个Conference包含多个Session
    /// </summary>
    class Session
    {
        private string SessionName;

        private int SessonNum;

        private int countryNum;

        private int simpleMajority;

        private int twothirdsMajority;

        private int twentyMajority;

        private Country[] countryList;//每一次的国家列表，用来统计到场的国家


    }
}
