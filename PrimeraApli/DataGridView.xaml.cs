using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PrimeraApli
{
    /// <summary>
    /// Lógica de interacción para Ventana1.xaml
    /// </summary>
    public partial class Ventana1 : Window
    {
        public ObservableCollection<Persona> LstPersonas { get; set; }
        public Ventana1()
        {
            InitializeComponent();
            fillList();
            this.DataContext = this;
        }
        private void fillList()
        {
            LstPersonas =
            [
                new Persona(1, "Hans Landa"),
                new Persona(2, "Aldo Raine"),
                new Persona(3, "Shosanna Dreyfuss"),
                new Persona(4, "Bridget Von Hammersmark"),
                new Persona(5, "Donny Donowitz"),
            ];
        }
    }
}
