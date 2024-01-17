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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeraApli
{
    /// <summary>
    /// Lógica de interacción para DialogPersona.xaml
    /// </summary>
    public partial class DialogPersona : Window
    {
        private int errores = 0;
        public Persona Persona { get; set; }

        public DialogPersona(Persona p)
        {
            InitializeComponent();
            this.Persona = p;
            this.DataContext = Persona;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;
            if (errores == 0)
                btnAceptar.IsEnabled = true;
            else
                btnAceptar.IsEnabled = false;

        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Persona.Id = -1;
            this.Close();
        }
    }
}
