using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MUN_ChairTools
{
    static class MainProgram
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ConferenceLoadAndInit());

            Session session = new Session(0); // TODO: 初始化为适当的值
            session.CommitteeName = "TestConference";
            session.ConferenceName = "TestConference";
            List<Country> country = new List<Country>(10);
            country.Add(new Country("A", CountryType.COUNTRY));
            country.Add(new Country("B", CountryType.COUNTRY));
            country.Add(new Country("C", CountryType.COUNTRY));
            country.Add(new Country("D", CountryType.COUNTRY));
            country.Add(new Country("E", CountryType.COUNTRY));
            country.Add(new Country("F", CountryType.COUNTRY));
            country.Add(new Country("G", CountryType.COUNTRY));
            country.Add(new Country("H", CountryType.COUNTRY));
            country.Add(new Country("I", CountryType.COUNTRY));
            country.Add(new Country("J", CountryType.COUNTRY));
            country.Add(new Country("K", CountryType.COUNTRY));
            country.Add(new Country("L", CountryType.COUNTRY));
            country.Add(new Country("M", CountryType.COUNTRY));
            country.Add(new Country("N", CountryType.COUNTRY));
            country.Add(new Country("O", CountryType.COUNTRY));
            country.Add(new Country("P", CountryType.COUNTRY));
            country.Add(new Country("Q", CountryType.COUNTRY));
            country.Add(new Country("R", CountryType.COUNTRY));
            country.Add(new Country("S", CountryType.COUNTRY));
            country.Add(new Country("T", CountryType.COUNTRY));


            session.CountryList = country;
            session.MainCountryList = country;
            session.CountryTotalNumber = 10;
            
            Application.Run(new DocumentVote(session));
        }   
    }
}
