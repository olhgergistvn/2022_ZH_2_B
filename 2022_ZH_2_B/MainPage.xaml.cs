namespace _2022_ZH_2_B
{
    public partial class MainPage : ContentPage
    {

        private DataModel model;

        public DataModel Model { get; set; }

        public MainPage()
        {
            Model = new DataModel();
            this.BindingContext = Model;
            InitializeComponent();
        }
    }
}