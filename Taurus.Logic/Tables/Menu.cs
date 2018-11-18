using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taurus.Logic.Tables
{
    public class Menu : CYQ.Data.Orm.OrmBase
    {
        public Menu()
        {
            base.SetInit(this);
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
        private string _MenuUrl;

        public string MenuUrl
        {
            get { return _MenuUrl; }
            set { _MenuUrl = value; }
        }
        private bool _IsNewWindow;
        /// <summary>
        /// 是否新开空白
        /// </summary>
        public bool IsNewWindow
        {
            get { return _IsNewWindow; }
            set { _IsNewWindow = value; }
        }
        private int _OrderNum;
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderNum
        {
            get { return _OrderNum; }
            set { _OrderNum = value; }
        }

    }
}
