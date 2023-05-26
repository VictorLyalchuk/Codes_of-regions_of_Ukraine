using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Codes_of_regions_of_Ukraine
{
    //[AddINotifyPropertyChangedInterface]
    class ViewModel
    {
        private ObservableCollection<Oblast> _Oblast;
        private ObservableCollection<Show> _Show;
        public ViewModel()
        {
            _Oblast = new ObservableCollection<Oblast>();
            _Show = new ObservableCollection<Show>();
        }
        public IEnumerable<Oblast> Oblast => _Oblast;
        public IEnumerable<Show> Show => _Show;
        public void AddOblast(Oblast oblast)
        {
            _Oblast.Add(oblast);
        }
        public void AddShow(Show show)
        {
            _Show.Add(show);
        }
    }

}
