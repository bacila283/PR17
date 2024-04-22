using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PPPR17
{
    /// <summary>
    /// Логика взаимодействия для CRUD.xaml
    /// </summary>
    public partial class CRUD : Window
    {
        public int x = 0;
        public CRUD(int x)
        {
            InitializeComponent();
            this.x = x;
            Contr();
        }
        public void Contr()
        {
            AddNewData addNewData = new AddNewData();
            switch (this.x)
            {
                
                case 1:// MainBTN.Content="Добавить новую запись"; 
                    
                    MainFrame.Content = addNewData;
                    
                    break;
                case 2:
                    //MainBTN.Content = "Удалить";
                    break;
                case 3:
                    //MainBTN.Content = "Изменить запись";
                    break;
            }
        }
    }
}
