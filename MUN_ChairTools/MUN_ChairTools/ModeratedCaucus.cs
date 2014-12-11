using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MUN_ChairTools
{
    public class ModeratedCaucus
    {
        public string MotionCountry { get; set; }

        public string MotionTopic { get; set; }

        public int TotalTime { get; set; }

        public int PerTime { get; set; }

        public List<string> SpeechCountryList;

        /// <summary>
        /// 在结束动议的时候给这个动议的总结信息 直接写到record里面
        /// </summary>
        public string MotionInfomationToRecord { get; set; }

        public ModeratedCaucus()
        {
            this.MotionCountry = "null";
            this.MotionTopic = "Null";
            this.TotalTime = 0;
            this.PerTime = 0;
            this.SpeechCountryList = new List<string>(0);
            this.MotionInfomationToRecord = string.Empty;
        }

        public ModeratedCaucus(string motionCountry, string topic, int totalTime, int perTime)
        {
            this.MotionCountry = motionCountry;
            this.MotionTopic = topic;
            this.TotalTime = totalTime;
            this.PerTime = perTime;
            this.SpeechCountryList = new List<string>(this.TotalTime / this.PerTime + 10);
            this.MotionInfomationToRecord = string.Empty;
        }
    }
}
