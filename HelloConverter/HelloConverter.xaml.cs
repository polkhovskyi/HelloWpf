using System.Windows.Controls;
using HelloConverter.Data;

namespace HelloConverter
{
    public partial class HelloConverter
    {
        public HelloConverter()
        {
            InitializeComponent();
            DataContext = this;
            EnumValue = SimpleEnum.ValueThree;
        }

        public SimpleEnum EnumValue { get; set; }
    }
}