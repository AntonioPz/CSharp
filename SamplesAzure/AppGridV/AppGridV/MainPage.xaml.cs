using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using AppGridV.Classes;
using System.Threading.Tasks;
using Windows.UI.Core;
using System.Collections.ObjectModel;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace AppGridV
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public List<Bills> Bill;
        private readonly IMobileServiceTable<Bills> _billsTableObject = App.MobileService.GetTable<Bills>();
        public MainPage()
        {
            try
            {
                this.InitializeComponent();
                Bill = new List<Bills>();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }
        
        public List<Bills> bill;
        public ObservableCollection<Bills> objBills = new ObservableCollection<Bills>();
        private async void GetAzureDataBinding()
        {
            try
            {
                Bill = await _billsTableObject.Where(billsTableObject => billsTableObject.IdC == 19).ToListAsync();

                foreach (var item in Bill)
                    objBills.Add(item);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
    }


}
