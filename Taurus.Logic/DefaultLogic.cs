using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taurus.Core;
using Taurus.Logic.Tables;
using Taurus.Logic;
using CYQ.Data.Orm;
using System.Web;

namespace Taurus.Logic
{
    public class DefaultLogic : LogicBase
    {
        public DefaultLogic(IController controller)
            : base(controller)
        {

        }
        #region 页面共用部分
        public void BindMenu()
        {
            using (Menu m = new Menu())
            {
                m.Select("order by ordernum").Bind(View);
            }
        }
        #endregion
        #region 首页
        public void BindHomePhoto()
        {
            using (HomePhoto h = new HomePhoto())
            {
                h.Select("TypeName='首页左侧图' order by OrderNum").Bind(View, "homephoto1");
                h.Select("TypeName='首页下侧图' order by OrderNum").Bind(View, "homephoto3");
            }
        }

        #endregion
        #region 关于我们
        public void Bindothermenu()
        {
            using (OtherMenu o = new OtherMenu())
            {
                o.Select("TypeName='关于我们' order by OrderNum").Bind(View, "othermenuView");
            }
        }
        public void Bindabout()
        {
            using (Article a = new Article())
            {
                if (a.Fill(Query<string>("id")))
                {
                    View.Set("txtTitle", a.Title);
                    string b = ArticleBody.Get(a.ID);
                    if (Query<string>("id") == "3")
                    {
                        using (Photo p = new Photo())
                        {
                            p.Select("CateID=" + Query<string>("id")).Bind(View, "photomsg");
                        }
                    }
                    else if (Query<string>("id") == "2")
                    {
                        using (Photo p = new Photo())
                        {
                            p.Select("CateID=" + Query<string>("id")).Bind(View, "photoenvioronment");
                        }
                    }
                    else
                    {
                        View.Set("txtBody", ArticleBody.Get(a.ID));
                    }
                    View.Set("title", "您现在的位置：首页 > " + a.Title);
                }
            }
        }

        public void BindPhoto()
        {

        }
        #endregion
        #region 新闻中心
        public void BindNewsMenu()
        {
            using (OtherMenu o = new OtherMenu())
            {
                o.Select("TypeName='新闻中心' order by OrderNum").Bind(View, "othernewsView");
            }
        }
        public void Bindothernewsmenu()
        {
            using (OtherMenu o = new OtherMenu())
            {
                o.Select("TypeName='新闻中心' order by OrderNum").Bind(View, "othermenuView");
            }
        }

        public void Bindnews()
        {
            using (News a = new News())
            {
                a.Select(" order by OrderNum").Bind(View);
            }
        }
        public void Bindnewsdetail()
        {
            using (News a = new News())
            {
                if (a.Fill(Query<string>("id")))
                {
                    View.Set("txtTitle", a.Title);
                    View.Set("txtBody", ArticleBody.Get(a.ID));
                    View.Set("title", a.Title);
                }
            }
        }
        #endregion
    }
}
