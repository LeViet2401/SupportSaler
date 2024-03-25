using SupportSaler.Model;
using SupportSaler.Model.Abstractor;
using SupportSaler.Model.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SupportSaler.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand Run_CMD { get; set; }
        public MainViewModel()
        {
            Run_CMD = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                List<MyAccount> listaccount = new List<MyAccount>();
                listaccount.Add(new MyAccount() { UserID = "1", Password = "1", FACode = "1", Profile = "Profile1" });
                listaccount.Add(new MyAccount() { UserID = "2", Password = "2", FACode = "2", Profile = "Profile2" });
                listaccount.Add(new MyAccount() { UserID = "3", Password = "3", FACode = "3", Profile = "Profile3" });
                listaccount.Add(new MyAccount() { UserID = "4", Password = "4", FACode = "4", Profile = "Profile4" });
                listaccount.Add(new MyAccount() { UserID = "5", Password = "5", FACode = "5", Profile = "Profile5" });




                var director = new Director();


                foreach (var account in listaccount)
                {
                    var builder = new ConcreteBuilder(account);
                    director.Builder = builder;

                    Console.WriteLine("Standard basic product:");
                    director.BuildMinimalViableProduct();
                    string result = builder.GetProduct().ListParts(account.Profile);
                    Console.WriteLine(result);
                }
            });
        }
    }
}
