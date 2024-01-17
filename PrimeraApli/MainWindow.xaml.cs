using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrimeraApli
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IList<string> stringList = new List<string>();
        public ObservableCollection<Persona> LstPersonas { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            //stringList.Add("Hans Landa");
            //stringList.Add("Aldo Raine");
            //stringList.Add("Shosanna Dreyfuss");
            //stringList.Add("Bridget Von Hammersmark");
            //stringList.Add("Donny Donowitz");
            fillList();
            this.DataContext = this;
            cbPersonas.SelectedIndex = 0;
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

        private void btnSaludo_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                // Se obtiene el máximo Id de persona y se le suma 1
                int nuevoId = LstPersonas.Max(p => p.Id)+1;
                LstPersonas.Add(new Persona(nuevoId, txtNombre.Text));
            }

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Versión 1
            //if (cbPersonas.SelectedIndex != -1)
            //{
            //    LstPersonas.RemoveAt(cbPersonas.SelectedIndex);

            //}
            // Versión 2
            LstPersonas.Remove(cbPersonas.SelectedItem as Persona);
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Versión 1
            if (cbPersonas.SelectedIndex != -1) {
                LstPersonas[cbPersonas.SelectedIndex].Nombre = txtNombreAct.Text;
            }
            
            // Versión 2
            (cbPersonas.SelectedItem as Persona).Nombre = txtNombreAct.Text;
        }
    }
}