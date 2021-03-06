﻿using System;
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
        public static int SessionNumber { get; set; }

        private Dictionary<string, string> KeyWordInBothLanguage = new Dictionary<string, string>();

        public string ConferenceName { get; set; }

        public string CommitteeName { get; set; }

        //TODO 总计发言次数，用来评估用
        //public int SpeakerListTime { get; set; }

        public int CountryTotalNumber { get; set; }

        public int MainCountryNumber { get; set; }

        public int ObserverCountryNumber { get; set; }

        public List<Country> MainCountryList;

        public List<Country> ObserverCountryList;

        public List<Session> TotalSessionList;

        public List<string> SpeakersList { get; set; }

        public Conference()
        {
            this.ConferenceName = string.Empty;
            this.CommitteeName = string.Empty;
            this.MainCountryList = new List<Country>();
            this.ObserverCountryList = new List<Country>();
            this.MainCountryNumber = 0;
            this.ObserverCountryNumber = 0;
            Conference.SessionNumber = 0;
            this.TotalSessionList = new List<Session>(1);
            this.SpeakersList = new List<string>(1);
        }

        public Conference(string conferenceName, string committeeName, int mainCountryListNumber, int ObserverCountryListNumber)
        {
            this.ConferenceName = conferenceName;
            this.CommitteeName = committeeName;
            this.MainCountryList.Capacity = mainCountryListNumber;
            this.ObserverCountryList.Capacity = ObserverCountryListNumber;
            Conference.SessionNumber = 0;
            this.MainCountryNumber = mainCountryListNumber;
            this.ObserverCountryNumber = ObserverCountryListNumber;
            this.CountryTotalNumber = mainCountryListNumber + ObserverCountryListNumber;
            this.TotalSessionList = new List<Session>(10); //最高会期值是10
            this.SpeakersList = new List<string>(MainCountryList.Count * 2);
        }

        public Conference(string conferenceName, string committeeName, List<Country> mainCountryList, List<Country> observerCountryList)
        {
            this.ConferenceName = conferenceName;
            this.CommitteeName = committeeName;
            this.MainCountryList = mainCountryList;
            this.ObserverCountryList = observerCountryList;
            Conference.SessionNumber = 0;
            this.MainCountryNumber = mainCountryList.Count;
            this.ObserverCountryNumber = observerCountryList.Count;
            this.CountryTotalNumber = this.MainCountryList.Count + this.ObserverCountryList.Count;
            this.TotalSessionList = new List<Session>(10);
            this.SpeakersList = new List<string>(MainCountryList.Count * 2);
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
