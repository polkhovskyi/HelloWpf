using System.Windows.Controls;
using HelloConverter.Data;
using HelloConverter.ViewModels;

namespace HelloConverter
{
    public partial class HelloConverter
    {
        public HelloConverter()
        {
            InitializeComponent();
            DataContext = this;
            CollectionsViewModel = new CollectionsViewModel();
            EnumViewModel = new EnumViewModel();
        }

        public CollectionsViewModel CollectionsViewModel { get; set; }
        public EnumViewModel EnumViewModel { get; set; }
    }
}