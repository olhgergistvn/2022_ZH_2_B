using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2022_ZH_2_B
{
    public class DataModel : INotifyPropertyChanged
    {
        private List<Car> cars = new List<Car>();

        public List<Car> Cars { get { return cars; } set { cars = value; } }

        private string brand;

        public string Brand
        { get { return brand; } set { brand = value; Notify(); Notify(nameof(Summary)); } }

        private int maxPrice;

        public int MaxPrice { get { return maxPrice; } set { maxPrice = value; Notify(); Notify(nameof(Summary)); } }

        private string selectedType;

        public string SelectedType { get { return selectedType; } set { selectedType = value; Notify(); Notify(nameof(Summary)); } }

        private int days;

        public int Days { get { return days; } set { days = value; Notify(); Notify(nameof(Summary)); } }

        private string summary;

        public string Summary => $"Az ön keresési feltételei: {Brand} típusú {SelectedType} autó, összesen {Days} napra, napi maximum {MaxPrice} Ft";

        public event PropertyChangedEventHandler PropertyChanged;
        public DataModel()
        {
            Cars.Add(new Car("Toyota Yaris", 3532, "kicsi"));
            Cars.Add(new Car("Toyota Yaris", 3532, "nagy"));
            Cars.Add(new Car("Toyota Yaris", 3532, "kombi"));
        }

        protected void Notify([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
