using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taurus.Logic;

namespace Taurus.Controllers
{
    public partial class DefaultController:Taurus.Core.Controller
    {
        DefaultLogic logic;
        public DefaultController()
        {
            logic = new DefaultLogic(this);
        }
        public override void Default()
        {
            if (!IsHttpPost)
            {
                logic.BindMenu();
                logic.Bindothermenu();
                logic.BindHomePhoto();
                logic.BindNewsMenu();
            }
        }
        public void about()
        {
            logic.BindMenu();
            logic.Bindothermenu();
            logic.Bindabout();
        }
        public void newslist()
        {
            logic.BindMenu();
            logic.BindNewsMenu();
            logic.Bindothernewsmenu();
            logic.Bindnews();
        }
        public void newsdetail()
        {
            logic.BindMenu();
            logic.BindNewsMenu();
            logic.Bindnewsdetail();
        }
        public void items()
        {
            logic.BindMenu();
        }
        public void productlist()
        {
            logic.BindMenu();
        }
        public void worldcustomer()
        {
            logic.BindMenu();
        }
        public void invitebusniess()
        {
            logic.BindMenu();
        }
        public void contactus()
        {
            logic.BindMenu();
        }
        
    }
}
