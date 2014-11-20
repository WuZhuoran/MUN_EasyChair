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
        private string countryChineseName; //国家中文名

        private string countryEnghlishName; //国家英文名

        private int countrySpeechTime; //发言次数
        
        private Bitmap CountryFlag; //国家国旗 默认为Default

        private CountryType countryType;//：国家，组织，个人等

        private bool isPresent; //某一个session是否到场

        //TODO

        public Country()
        {
            this.countryChineseName = null;
            this.countryEnghlishName = null;
            this.countrySpeechTime = 0;
            this.countryType = CountryType.UNDEFINED;
            this.CountryFlag = new Bitmap(new Bitmap("E:\\Coding Files\\VisualStdio2010_C#\\MUN_ChairTools\\MUN_ChairTools\\Image\\Default.png"), 66, 44);
            this.isPresent = false;
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
