using System;
using System.Data;
using System.Configuration;
using System.Web;


namespace Taurus.Logic
{
    /// <summary>
    /// ����
    /// </summary>
    public class OtherMenu : CYQ.Data.Orm.OrmBase
    {
        public OtherMenu()
        {
            base.SetInit(this);
        }
        private string _TypeName;
        public string TypeName
        {
            get { return _TypeName; }
            set{_TypeName=value;}
        }
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private int _Count;
        /// <summary>
        /// �������������
        /// </summary>
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        private int _LastArticleID;
        /// <summary>
        /// ��������һ��ID��
        /// </summary>
        public int LastArticleID
        {
            get { return _LastArticleID; }
            set { _LastArticleID = value; }
        }
        private int _OrderNum;
        /// <summary>
        /// ����
        /// </summary>
        public int OrderNum
        {
            get { return _OrderNum; }
            set { _OrderNum = value; }
        }
    }
}
