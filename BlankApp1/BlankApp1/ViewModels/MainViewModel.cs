using BlankApp1.Base;
using BlankApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlankApp1.ViewModels
{
    public class MainViewModel : NotifyBase
    {
        // 菜单 集合
        public List<MenuItemModel> TreeList { get; set; }
        // 页面 集合
        public ObservableCollection<PageItemModel> Pages { get; set; }
            = new ObservableCollection<PageItemModel>();

        public MainViewModel()
        {
            #region 菜单初始化
            TreeList = new List<MenuItemModel>();
            {
                MenuItemModel tim = new MenuItemModel();
                tim.Header = "部门管理";
                TreeList.Add(tim);
                tim.Children.Add(new MenuItemModel
                {
                    Header = "部门信息",
                    TargetView = "PageShow",
                    OpenViewCommand = new Command<MenuItemModel>(OpenView)
                });
                tim.Children.Add(new MenuItemModel
                {
                    Header = "部门-维护",
                    TargetView = "MessageWindow",
                    OpenViewCommand = new Command<MenuItemModel>(OpenView)
                });

                MenuItemModel tims = new MenuItemModel();
                tims.Header = "班组管理";
                TreeList.Add(tims);
                tims.Children.Add(new MenuItemModel
                {
                    Header = "班组信息",
                    TargetView = "BanzuShow",
                    OpenViewCommand = new Command<MenuItemModel>(OpenView)
                });
                tims.Children.Add(new MenuItemModel
                {
                    Header = "班组-维护",
                    TargetView = "BanzuAdd",
                    OpenViewCommand = new Command<MenuItemModel>(OpenView)
                });

                MenuItemModel subMenu = new MenuItemModel();
                subMenu.Header = "二级菜单";
                subMenu.Children.Add(
                    new MenuItemModel
                    {
                        Header = "三级菜单"
                    }
                   );
                tim.Children.Add(subMenu);
            }
            #endregion
        }

        private void OpenView(MenuItemModel menu)
        {
            // 两个问题：
            // 1、每点击一次都会有一个新的页面！  解决方案：从集合中判断是否存在
            // 2、新打开一个页面后，不能马上显示 

            //MenuItemModel mim = menu as MenuItemModel;
            // 需要进行页面的打开 
            //Pages.Add("EEEE");

            var page = Pages.ToList().FirstOrDefault(p => p.Header == menu.Header);

            if (page == null)
            {
                Type type = Assembly.GetExecutingAssembly().
                    GetType("BlankApp1.Views." + menu.TargetView);
                object p = Activator.CreateInstance(type);

                Pages.Add(new PageItemModel
                {
                    Header = menu.Header,
                    PageView = p,
                    IsSelected = true,
                    CloseTabCommand = new Command<PageItemModel>(ClosePage)
                });
            }
            else
                page.IsSelected = true;
        }

        private void ClosePage(PageItemModel menu)
        {
            Pages.Remove(menu);
        }
    }
}
