using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MUN_ChairTools
{
    /// <summary>
    /// 每一场会议是本类的实例化
    /// </summary>
    public class Conference
    {
        private Dictionary<string, string> KeyWordInBothLanguage = new Dictionary<string, string>();

        public string ConferenceName { get; set; }

        public string CommitteeName { get; set; }

        public static int SessionNumber { get; set; }

        //TODO 总计发言次数，用来评估用
        //public int SpeakerListTime { get; set; }

        public int CountryTotalNumber { get; set; }

        public List<Country> MainCountryList;

        public List<Country> ObserverCountryList;

        public List<Session> TotalSessionList;

        public Conference()
        {
            this.ConferenceName = string.Empty;
            this.CommitteeName = string.Empty;
            this.MainCountryList = new List<Country>();
            this.ObserverCountryList = new List<Country>();
            Conference.SessionNumber = 0;
            this.TotalSessionList = new List<Session>(1);
        }

        public Conference(string conferenceName, string committeeName, int mainCountryListNumber, int ObserverCountryListNumber)
        {
            this.ConferenceName = conferenceName;
            this.CommitteeName = committeeName;
            this.MainCountryList.Capacity = mainCountryListNumber;
            this.ObserverCountryList.Capacity = ObserverCountryListNumber;
            Conference.SessionNumber = 0;
            this.CountryTotalNumber = mainCountryListNumber + ObserverCountryListNumber;
            this.TotalSessionList = new List<Session>(10); //最高会期值是10
        }

        public Conference(string conferenceName, string committeeName, List<Country> mainCountryList, List<Country> observerCountryList)
        {
            this.ConferenceName = conferenceName;
            this.CommitteeName = committeeName;
            this.MainCountryList = mainCountryList;
            this.ObserverCountryList = observerCountryList;
            Conference.SessionNumber = 0;
            this.CountryTotalNumber = this.MainCountryList.Count + this.ObserverCountryList.Count;
            this.TotalSessionList = new List<Session>(10);
        }

        public void ShowInfo()
        {
            Console.WriteLine(this.ConferenceName);
            Console.WriteLine(this.CommitteeName);
            for (int i = 0; i < this.MainCountryList.Count; i++)
            {
                Console.WriteLine(this.MainCountryList[i].ChineseName);
            }

            for (int i = 0; i < this.ObserverCountryList.Count; i++)
            {
                Console.WriteLine(this.ObserverCountryList[i].ChineseName);
            }
            Console.WriteLine("Done");
        }
        /// <summary>
        /// 每一场会议初始化时加载字典类
        /// </summary>
        private void LoadDictionary()
        {
            this.KeyWordInBothLanguage.Add("中文", "Chinese");
            this.KeyWordInBothLanguage.Add("会议记录", "Session Record");
            this.KeyWordInBothLanguage.Add("计时工具", "Timer");
            this.KeyWordInBothLanguage.Add("信息", "Information");
        }
    }
}
