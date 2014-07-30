using System.Collections.Generic;

namespace HelloConverter.ViewModels
{
    public class CollectionsViewModel
    {
        public CollectionsViewModel()
        {
            NotEmptyCollection = new List<string> {"One", "Two", "Three"};
            EmptyCollection = new List<string>();
        }

        public List<string> NotEmptyCollection { get; set; }
        public List<string> EmptyCollection { get; set; }
    }
}