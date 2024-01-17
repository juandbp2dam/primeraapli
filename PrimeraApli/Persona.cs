using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApli
{
    //public enum Genero { Hombre, Mujer}

    public class Persona : INotifyPropertyChanged, IDataErrorInfo
    {
        public Persona() { }
        
        //public Genero Genero { get; set; }
        private string nombre;
        private DateTime fechaNacimiento;
        public int Id { get; set; }
        public string Nombre { 
            get => nombre; 
            set 
            { 
                if (nombre != value) { 
                    nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            } 
        }

        public DateTime FechaNacimiento { get => fechaNacimiento;
            set {
                if (fechaNacimiento != value)
                {
                    fechaNacimiento = value;
                    OnPropertyChanged(nameof(fechaNacimiento));
                }
            } 
        }

        public string Error { get { return string.Empty; } }

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                if (columnName.Equals("Nombre") && string.IsNullOrEmpty(nombre))
                {
                    result = "Debe introducir un nombre";
                }
                if (columnName.Equals("FechaNacimiento") && fechaNacimiento >= new DateTime(2010, 1, 1))
                {
                    result = "La fecha de nacimiento debe ser anterior al 1/1/2010";
                }
                return result;
            }
        }


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
