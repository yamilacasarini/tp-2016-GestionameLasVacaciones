using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClinicaFrba
{

    class Validacion
    {

        public static bool estaVacio(Control Box, string nombre)
        {
            if (Box.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("El campo " + nombre + " no puede estar vacio");
                return true;
            }
            return false;
        }

        public static bool estaVacioSinNotificar(Control Box)
        {
            if (Box.Text.Replace(" ", "") == "") return true;

            return false;
        }

        public static bool esMontoValido(Control Box, string nombre)
        {
            String monto = Box.Text;
            monto = monto.Replace(',', '.');

            if (Regex.IsMatch(monto, @"^([1-9]{1}[\d]{0,2}(\,[\d]{3})*(\.[\d]{0,2})?|[1-9]{1}[\d]{0,}(\.[\d]{0,2})?|0(\.[\d]{0,2})?|(\.[\d]{1,2})?)$")) return true;
            MessageBox.Show("El campo " + nombre + " no tiene un formato correcto, ej: 45,50 ó 45");
            return false;
        }

        public static bool esAlfanumerico(Control Box, string nombre)
        {
            if (Regex.IsMatch(Box.Text, "^[A-Za-z0-9 ]+$")) return true;
            MessageBox.Show("El campo " + nombre + " solo puede contener caracteres alfanuméricos");
            return false;
        }

        public static bool longitudDe(Control box, string nombre, int tamanio)
        {
            if (box.Text.Length != tamanio)
            {
                MessageBox.Show("La longitud de " + nombre + " debe ser de " + tamanio);
                return false;
            }
            return true;
        }

        public static bool longitudIncorrecta(Control Box, string nombre, int tamanio)
        {
            if (Box.Text.Length <= tamanio)
            {
                return false;
            }
            MessageBox.Show("El campo " + nombre + " debe tener longitud menor o igual a " + tamanio);
            return true;
        }

        public static bool soloNumeros(Control Box, string nombre)
        {
            string valor = (Box.Text.Count(c => c == '.') == 1) ? Box.Text.Replace(".", "") : Box.Text;
            if (Regex.IsMatch((valor.StartsWith("-")) ? valor.Substring(1) : valor, "\\D"))
            {
                MessageBox.Show("El campo " + nombre + " solo puede contener numeros");
                return false;
            }
            return true;
        }

        public static bool soloLetras(Control Box, string nombre)
        {
            if (Regex.IsMatch(Box.Text, "\\d") || Regex.IsMatch(Box.Text.Replace(" ", ""), "\\W"))
            {
                MessageBox.Show("El campo " + nombre + " solo puede contener letras");
                return false;
            }
            return true;
        }

        public static bool noTieneSeleccion(ComboBox Cbox, string nombre)
        {
            if (Cbox.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un item para " + nombre);
                return true;
            }
            return false;
        }

        public static bool noTieneSeleccionSinNotificar(ComboBox Cbox)
        {
            if (Cbox.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        public static bool fechaMenorAlDiaDeHoy(DateTimePicker fecha, String queFecha)
        {
           if (fecha.Value > ClinicaFrba.Sesion.getInstance.fecha)
            {
                MessageBox.Show("Usted ingreso mal la fecha de " + queFecha);
                return false;
            }
            return true;
        }

        public static bool fechaMenorAFecha(DateTimePicker fecha, DateTimePicker otraFecha, string fecha1, string fecha2)
        {
            if (fecha.Value > otraFecha.Value)
            {
                MessageBox.Show("La fecha de  " + fecha1 + " es mayor a la de " + fecha2);
                return false;
            }
            return true;
        }

        public static bool fechaMayorAlDiaDeHoy(DateTimePicker fecha, String queFecha)
        {
            if (fecha.Value < ClinicaFrba.Sesion.getInstance.fecha)
            {
                MessageBox.Show("Usted ingreso mal la fecha de " + queFecha);
                return false;
            }
            return true;
        }

        public static bool emailValido(Control emailBox)
        {
            string email = emailBox.Text;

            if (!email.Contains("@"))
            {
                MessageBox.Show("El mail no tiene @");
                return false;
            }
            else if (!email.Contains("."))
            {
                MessageBox.Show("El mail no tiene .");
                return false;
            }
            else
            {
                string strTest = "";
                foreach (var match in Regex.Matches(email, "\\W"))
                {
                    strTest = match.ToString();
                    if (strTest != "." && strTest != "-" && strTest != "_" && strTest != " " && strTest != "@")
                    {
                        MessageBox.Show("El mail posee caracteres no válidos");
                        return false;
                    }
                }
                if (email.Count(c => c == '@') > 1)
                {
                    MessageBox.Show("El mail posee caracteres no válidos");
                    return false;
                }

                int arroba = email.IndexOf('@'), punto = email.IndexOf('.');

                if (email.Substring(arroba).Count(c => c == '.') < 1)
                {
                    MessageBox.Show("No se encuentra un proveedor de mail");
                    return false;
                }
                else
                {
                    strTest = "";
                    for (int C = arroba + 1, len = email.Length; C < len; C++)
                    {
                        if (C == punto)
                        {
                            if (Regex.IsMatch(strTest, "\\W|\\d"))
                            {
                                MessageBox.Show("El nombre del proveedor de mail no es válido");
                                return false;
                            }
                            else
                            {
                                strTest = "";
                                for (int i = C; i < len; i++)
                                {
                                    strTest += email[i];
                                }
                                if (strTest != ".com" && strTest != ".gov" && strTest != ".net" && strTest != ".edu" && strTest != ".org" && strTest != ".com.ar")
                                {
                                    MessageBox.Show("No puede reconocerse dominio del mail");
                                    return false;
                                }
                                break;
                            }
                        }
                        else
                        {
                            strTest += email[C];
                        }
                    }
                }
            }

            return true;
        }
    }
}