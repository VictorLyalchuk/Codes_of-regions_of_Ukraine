using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Environment;
using System.Xml;

namespace Codes_of_regions_of_Ukraine
{
    public partial class MainWindow : Window
    {
        ViewModel model = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = model;
            AddInfo();
        }
        public void AddInfo()
        {
            model.AddOblast(new Oblast
            {
                ID = 1,
                Name = "АР Крим",
                Image = $@"Images/1.png",
                Number1 = "АК",
                Number2 = "КК",
                Number3 = "ТК",
                Number4 = "МК",
            });
            model.AddOblast(new Oblast
            {
                ID = 2,
                Name = "місто Київ",
                Image = $@"Images/2.png",
                Number1 = "АА",
                Number2 = "КА",
                Number3 = "ТТ",
                Number4 = "ТА",
            }); 
            model.AddOblast(new Oblast
            {
                ID = 3,
                Name = "Вінницька область",
                Image = $@"Images/3.png",
                Number1 = "АВ",
                Number2 = "КВ",
                Number3 = "ММ",
                Number4 = "ОК",
            });
            model.AddOblast(new Oblast
            {
                ID = 4,
                Name = "Волинська область",
                Image = $@"Images/4.png",
                Number1 = "АС",
                Number2 = "КС",
                Number3 = "СМ",
                Number4 = "ТС",
            });
            model.AddOblast(new Oblast
            {
                ID = 5,
                Name = "Дніпропетровська",
                Image = $@"Images/5.png",
                Number1 = "АЕ",
                Number2 = "КЕ",
                Number3 = "РР",
                Number4 = "МІ",
            });
            model.AddOblast(new Oblast
            {
                ID = 6,
                Name = "Донецька область",
                Image = $@"Images/6.png",
                Number1 = "АН",
                Number2 = "КН",
                Number3 = "ТН",
                Number4 = "МН",
            });
            model.AddOblast(new Oblast
            {
                ID = 7,
                Name = "Київська область",
                Image = $@"Images/7.png",
                Number1 = "АІ",
                Number2 = "КІ",
                Number3 = "ТІ",
                Number4 = "МЕ",
            });
            model.AddOblast(new Oblast
            {
                ID = 8,
                Name = "Житомирська",
                Image = $@"Images/8.png",
                Number1 = "АМ",
                Number2 = "КМ",
                Number3 = "ТМ",
                Number4 = "МВ",
            });
            model.AddOblast(new Oblast
            {
                ID = 9,
                Name = "Закарпатська",
                Image = $@"Images/9.png",
                Number1 = "АО",
                Number2 = "КО",
                Number3 = "МТ",
                Number4 = "МО",
            });
            model.AddOblast(new Oblast
            {
                ID = 10,
                Name = "Запорізька область",
                Image = $@"Images/10.png",
                Number1 = "АР",
                Number2 = "КР",
                Number3 = "ТР",
                Number4 = "МР",
            });
            model.AddOblast(new Oblast
            {
                ID = 11,
                Name = "Івано-Франківська",
                Image = $@"Images/11.png",
                Number1 = "АТ",
                Number2 = "КТ",
                Number3 = "ТО",
                Number4 = "ХС",
            }); 
            model.AddOblast(new Oblast
            {
                ID = 12,
                Name = "Кіровоградська",
                Image = $@"Images/12.png",
                Number1 = "ВА",
                Number2 = "НА",
                Number3 = "ХА",
                Number4 = "ЕА",
            });
            model.AddOblast(new Oblast
            {
                ID = 13,
                Name = "Луганська область",
                Image = $@"Images/13.png",
                Number1 = "ВВ",
                Number2 = "НВ",
                Number3 = "ЕЕ",
                Number4 = "ЕВ",
            });
            model.AddOblast(new Oblast
            {
                ID = 14,
                Name = "Львівська область",
                Image = $@"Images/14.png",
                Number1 = "ВС",
                Number2 = "НС",
                Number3 = "СС",
                Number4 = "ЕС",
            });
            model.AddOblast(new Oblast
            {
                ID = 15,
                Name = "Миколаївська",
                Image = $@"Images/15.png",
                Number1 = "ВЕ",
                Number2 = "НЕ",
                Number3 = "ХЕ",
                Number4 = "ХН",
            });
            model.AddOblast(new Oblast
            {
                ID = 16,
                Name = "Одеська область",
                Image = $@"Images/16.png",
                Number1 = "ВН",
                Number2 = "НН",
                Number3 = "ОО",
                Number4 = "ЕН",
            });
            model.AddOblast(new Oblast
            {
                ID = 17,
                Name = "Полтавська область",
                Image = $@"Images/17.png",
                Number1 = "ВІ",
                Number2 = "НІ",
                Number3 = "ХІ",
                Number4 = "ЕІ",
            });
            model.AddOblast(new Oblast
            {
                ID = 18,
                Name = "Рівненська область",
                Image = $@"Images/18.png",
                Number1 = "ВК",
                Number2 = "НК",
                Number3 = "ХК",
                Number4 = "ЕК",
            });
            model.AddOblast(new Oblast
            {
                ID = 19,
                Name = "Сумська область",
                Image = $@"Images/19.png",
                Number1 = "ВМ",
                Number2 = "НМ",
                Number3 = "ХМ",
                Number4 = "ЕМ",
            });
            model.AddOblast(new Oblast
            {
                ID = 20,
                Name = "Тернопільська",
                Image = $@"Images/20.png",
                Number1 = "ВО",
                Number2 = "НО",
                Number3 = "ХО",
                Number4 = "ЕО",
            });
            model.AddOblast(new Oblast
            {
                ID = 21,
                Name = "Харківська область",
                Image = $@"Images/21.png",
                Number1 = "АХ",
                Number2 = "КХ",
                Number3 = "ХХ",
                Number4 = "ЕХ",
            });
            model.AddOblast(new Oblast
            {
                ID = 22,
                Name = "Херсонська область",
                Image = $@"Images/22.png",
                Number1 = "ВТ",
                Number2 = "НТ",
                Number3 = "ХТ",
                Number4 = "ЕТ",
            });
            model.AddOblast(new Oblast
            {
                ID = 23,
                Name = "Хмельницька",
                Image = $@"Images/23.png",
                Number1 = "ВХ",
                Number2 = "НХ",
                Number3 = "ОХ",
                Number4 = "РХ",
            });
            model.AddOblast(new Oblast
            {
                ID = 24,
                Name = "Черкаська область",
                Image = $@"Images/24.png",
                Number1 = "СА",
                Number2 = "ІА",
                Number3 = "ОА",
                Number4 = "РА",
            });
            model.AddOblast(new Oblast
            {
                ID = 25,
                Name = "Чернігівська",
                Image = $@"Images/25.png",
                Number1 = "СВ",
                Number2 = "ІВ",
                Number3 = "ОВ",
                Number4 = "РВ",
            });
            model.AddOblast(new Oblast
            {
                ID = 26,
                Name = "Чернівецька",
                Image = $@"Images/26.png",
                Number1 = "СЕ",
                Number2 = "ІЕ",
                Number3 = "ОЕ",
                Number4 = "РЕ",
            });
            model.AddOblast(new Oblast
            {
                ID = 27,
                Name = "місто Севастополь",
                Image = $@"Images/27.png",
                Number1 = "СН",
                Number2 = "ІН",
                Number3 = "ОН",
                Number4 = "РН",
            });
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ListFlipper.ItemsSource = model.Oblast.Where(a => a.Number1.Contains(SearchBox.Text) || a.Number2.Contains(SearchBox.Text) 
                || a.Number3.Contains(SearchBox.Text) || a.Number4.Contains(SearchBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}
