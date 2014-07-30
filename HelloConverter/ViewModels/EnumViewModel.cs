using System.Collections.Generic;
using HelloConverter.Data;

namespace HelloConverter.ViewModels
{
    public class EnumViewModel
    {
        public EnumViewModel()
        {
            EnumValue = SimpleEnum.ValueThree;
        }

        public SimpleEnum EnumValue { get; set; }
    }
}