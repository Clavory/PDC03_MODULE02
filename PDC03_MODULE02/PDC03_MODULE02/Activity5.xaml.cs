using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity5 : ContentPage
    {
        ObservableCollection<employee> employees = new ObservableCollection<employee>();
        public ObservableCollection<employee> Employees { get { return employees; } }

        public Activity5()
        {
            InitializeComponent();

            {
                lst.ItemsSource = employees;

                employees.Add(new employee { DisplayName = "Nathaniel Allapitan", Position = "President" ,profileImage="image3.jpg" });
                employees.Add(new employee { DisplayName = "Clavory", Position = "Vice President", profileImage = "image2.jpg" });
                employees.Add(new employee { DisplayName = "Syncophantam", Position = "Secretary" , profileImage = "image1.jpg" });
             
            }
        }
    }
}