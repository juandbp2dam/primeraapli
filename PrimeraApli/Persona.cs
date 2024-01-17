using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApli
{
    public enum Genero { Hombre, Mujer}
    public class Persona : INotifyPropertyChanged
    { 
        public Genero Genero { get; set; }
        private string nombre;
        public int Id { get; set; }
        public string Nombre { 
            get => nombre; 
            set { 
                if (nombre != value) { 
                    nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            } }

        public Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
