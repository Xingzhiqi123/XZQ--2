using BlankApp1.Conmmon;
using BlankApp1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlankApp1.ViewModels
{
    public class ViewsModel : ModelBase
    {
        private BindingList<Persons> _people;
        //BindingList 是一个泛型类，它实现了 IList 接口，同时还实现了 IBindingList 接口，IBindingList 接口继承了 IList 接口，所以 BindingList 既是一个 IList，也是一个 IBindingList。
        public BindingList<Persons> People
        {
            get { return _people ?? (_people = new BindingList<Persons>()); }
            set { _people = value; OnPropertyChanged("People"); }
        }
        //ViewModel 是一个公共类，它的构造函数是公共的，所以可以在任何地方实例化它，这里在 MainWindow.xaml.cs 中实例化了它，然后把它赋值给了 DataContext 属性。
        public ViewsModel()
        {
            People = GetAll();
        }



        public BindingList<Persons> GetAll()
        {
            var list = HttpHelper.Get("https://localhost:44311/api/services/app/APJUserAppServices/GetAll");
            //SystemHomePageModel1接收list数据

            var show = JsonConvert.DeserializeObject<Roots>(list);
            //var root = JsonConvert.DeserializeObject<BindingList<Root>>(list);
            var items = show.result.items;
            var bindingList = new BindingList<Persons>(items);
            return bindingList;
        }


        public class HttpHelper
        {
            public static string Get(string url)
            {
                //请求后台接口
                var result = HttpHelper.HttpGet(url);
                //返回结果
                return result;
            }

            public static string HttpGet(string url)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "textml;charset=UTF-8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
        }
        //添加
        private Persons _person;
        public Persons person
        {
            get { return _person ?? (_person = new Persons()); }
            set { _person = value; OnPropertyChanged("person"); }
        }
        private CustomCommand _addCmd;
        //CustomCommand
        public CustomCommand AddCmd
        {
            get { return _addCmd ?? (_addCmd = new CustomCommand(Add, CanAdd)); }
        }
        public void Add()
        {
            var jsonadd = JsonConvert.SerializeObject(person);
            var i = HttpRequest.PostAsyncJson("https://localhost:44311/api/services/app/APJUserAppServices/Create", jsonadd);
            People.Add(person);
        }
        public bool CanAdd()
        {
            return People != null && person != null;
        }
    }
}
