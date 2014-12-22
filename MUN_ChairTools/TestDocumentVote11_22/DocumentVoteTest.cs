using MUN_ChairTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestDocumentVote11_22
{
    
    
    /// <summary>
    ///这是 DocumentVoteTest 的测试类，旨在
    ///包含所有 DocumentVoteTest 单元测试
    ///</summary>
    [TestClass()]
    public class DocumentVoteTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///DocumentVote 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void DocumentVoteConstructorTest()
        {
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
            session.CountryList = country;
            session.CountryTotalNumber = 10;
            
            DocumentVote target = new DocumentVote(session);

            target.Show();

            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///Dispose 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MUN_ChairTools.exe")]
        public void DisposeTest()
        {
            PrivateObject param0 = null; // TODO: 初始化为适当的值
            DocumentVote_Accessor target = new DocumentVote_Accessor(param0); // TODO: 初始化为适当的值
            bool disposing = false; // TODO: 初始化为适当的值
            target.Dispose(disposing);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///InitializeComponent 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MUN_ChairTools.exe")]
        public void InitializeComponentTest()
        {
            PrivateObject param0 = null; // TODO: 初始化为适当的值
            DocumentVote_Accessor target = new DocumentVote_Accessor(param0); // TODO: 初始化为适当的值
            target.InitializeComponent();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///pictureBoxVoteAbsence_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MUN_ChairTools.exe")]
        public void pictureBoxVoteAbsence_ClickTest()
        {
            PrivateObject param0 = null; // TODO: 初始化为适当的值
            DocumentVote_Accessor target = new DocumentVote_Accessor(param0); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.pictureBoxVoteAbsence_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///pictureBoxVoteNo_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MUN_ChairTools.exe")]
        public void pictureBoxVoteNo_ClickTest()
        {
            PrivateObject param0 = null; // TODO: 初始化为适当的值
            DocumentVote_Accessor target = new DocumentVote_Accessor(param0); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.pictureBoxVoteNo_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///pictureBoxVotePass_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MUN_ChairTools.exe")]
        public void pictureBoxVotePass_ClickTest()
        {
            PrivateObject param0 = null; // TODO: 初始化为适当的值
            DocumentVote_Accessor target = new DocumentVote_Accessor(param0); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.pictureBoxVotePass_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///pictureBoxVoteYes_Click 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MUN_ChairTools.exe")]
        public void pictureBoxVoteYes_ClickTest()
        {
            PrivateObject param0 = null; // TODO: 初始化为适当的值
            DocumentVote_Accessor target = new DocumentVote_Accessor(param0); // TODO: 初始化为适当的值
            object sender = null; // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.pictureBoxVoteYes_Click(sender, e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }
    }
}
