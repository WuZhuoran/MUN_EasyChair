using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MUN_ChairTools
{
    /// <summary>
    /// 每一场会议是本类的实例化
    /// </summary>
    class Conference
    {
        private Dictionary<string, string> KeyWordInBothLanguage = new Dictionary<string, string>();

        private string conferenceName;

        private int sessionNum;

        
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
