using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace MUN_ChairTools
{
    /// <summary>
    /// 国家类
    /// </summary>
    class Country
    {
        public string ChineseName { get; set; }
        public string EnglishName { get; set; }
        public int SpeechTime { get; set; }
        public Bitmap CountryFlag { get; set; }
        public CountryType CountryProperty { get; set; }
        public bool IsPresent { get; set; }

        //TODO

        public Country()
        {
            this.ChineseName = string.Empty;
            this.EnglishName = string.Empty;
            this.SpeechTime = 0;
            this.CountryProperty = CountryType.UNDEFINED;
            this.IsPresent = false;
            this.CountryFlag = Properties.Resources.UnitedNationFlag;
            
        }

        public Country(string chineseName, CountryType countryType)
        {
            this.ChineseName = chineseName;
            this.EnglishName = string.Empty;
            this.CountryProperty = countryType;
        }

        public Country(string chineseName, string englishName, Bitmap countryFlag, CountryType countryType)
        {
            this.ChineseName = chineseName;
            this.EnglishName = englishName;
            this.CountryFlag = countryFlag;
            this.CountryProperty = countryType;
        }
    }

    enum CountryType
    {
        UNDEFINED = 0,
        COUNTRY = 1,
        PERSON = 2,
        ORGINZATION = 3,
        OBVERSEVER = 4
    }
}
