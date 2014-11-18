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
    class Country
    {
        private string CountryChineseName;

        private string CountryEnghlishName;

        private int CountryNumber;

        private int CountrySpeechTime;

        public Bitmap CountryFlag;
        //TODO

        public Country()
        {
            this.CountryChineseName = null;
            this.CountryEnghlishName = null;
            this.CountryNumber = 0;
            this.CountrySpeechTime = 0;
            this.CountryFlag = new Bitmap(new Bitmap("E:\\Coding Files\\VisualStdio2010_C#\\MUN_ChairTools\\MUN_ChairTools\\Image\\Default.png"), 66, 44);
            
        }
    }
}
