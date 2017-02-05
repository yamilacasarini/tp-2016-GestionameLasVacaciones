using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Alta_Agenda_Profesional
{
    public partial class Principal : Form
    {

        static DateTime horaDelSistema;

        private string diaDelSistema;
        private string mesDelSistema;
        private string anioDelSistema;

        public Principal()
        {
            InitializeComponent();
            cargarDias(diaSemanaInicio);
            cargarDias(diaSemanaFinal);
            horaDelSistema = DateTime.ParseExact(Program.horarioSistema, "yyyy-dd-MM HH:mm:ss.fff",
                                      System.Globalization.CultureInfo.InvariantCulture);

            diaDelSistema = horaDelSistema.Day.ToString();
            mesDelSistema = horaDelSistema.Month.ToString();
            anioDelSistema = horaDelSistema.Year.ToString();
            if (Sesion.getInstance().rol == "Profesional")
            {
                btBuscar.Hide();
                prof = Sesion.getInstance().profesional;
                setearLabelProf(prof);
            }

        }
        private bool fallarPor(String error) {
            MessageBox.Show(error);
            return false;
        }

        Pedir_Turno.Profesional prof = new Pedir_Turno.Profesional();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void cargarDias(ComboBox combito)
        {
            combito.Items.Add("Lunes");
            combito.Items.Add("Martes");
            combito.Items.Add("Miercoles");
            combito.Items.Add("Jueves");
            combito.Items.Add("Viernes");
            combito.Items.Add("Sabado");
        }
        private bool validarDatos()
        {
            return
               validarDia(DiaInicio.Value, mesInicio.Value, anioInicio.Value)
                && validarDia(anioFinal.Value, mesFinal.Value, anioFinal.Value)
                && validacion48Horas()
                && validarQueSeaFechaFutura(anioInicio.Value, anioFinal.Value,
                mesInicio.Value, mesFinal.Value, DiaInicio.Value, anioFinal.Value)
                && validarQueSeaFechaFutura(Convert.ToDecimal(anioDelSistema), anioInicio.Value,
                Convert.ToDecimal(mesDelSistema), mesInicio.Value, Convert.ToDecimal(diaDelSistema), DiaInicio.Value)
                && validarQueSeaFechaFutura(Convert.ToDecimal(anioDelSistema), anioFinal.Value,
                Convert.ToDecimal(mesDelSistema), mesFinal.Value, Convert.ToDecimal(diaDelSistema), anioFinal.Value)
                && validarHorarioSabados(diaSemanaInicio.Text, listaHorasInicio.Value)
                && validarHorarioSabados(diaSemanaFinal.Text, listaHorasInicio.Value)
                && validarHorarioSabados(diaSemanaInicio.Text, listaHorasFinal.Value)
                && validarHorarioSabados(diaSemanaFinal.Text, listaHorasFinal.Value)
                ;
        }

        private bool validarHorarioSabados(string dia, decimal hora)
        {
            if ((diaNumericoDeLaSemana(dia) == 6 && (aInt(hora) >= 15 || aInt(hora) < 10)))
                 return fallarPor("Los sabados el hospital solamente esta abierto de 10 a 15 hs");
             return true;
        }

        
        private bool validarQueSeaFechaFutura(decimal anioInicio,
            decimal anioFinal, decimal mesInicio, decimal mesFinal,
            decimal diaInicio, decimal diaFinal)
        {
            if (aInt(anioInicio) > aInt(anioFinal))
                return fallarPor("La fecha inicial es posterior a la final");
            if (aInt(anioInicio) == aInt(anioFinal) &&
                aInt(mesInicio) > aInt(mesFinal))
                return fallarPor("La fecha inicial es posterior a la final");
            if (aInt(mesInicio) == aInt(mesFinal) &&
                aInt(diaInicio) > aInt(diaFinal))
                return fallarPor("La fecha inicial es posterior a la final");
            return true;
        }

        private bool validarDia(decimal dia, decimal mes, decimal anio)
        {
            int mesInicial = aInt(mes);
            if (mesInicial == 1 || mesInicial == 3 || mesInicial == 5 || mesInicial == 7 || mesInicial == 8 || mesInicial == 10 || mesInicial == 12)
                return aInt(dia) <= 31;
            else if (mesInicial == 4 || mesInicial == 6 || mesInicial == 9 || mesInicial == 11)
                return aInt(dia) <= 30;
            else if (mesInicial == 2 && DateTime.IsLeapYear(Convert.ToInt32(anio)))
                return aInt(dia) <= 29;
            else if (mesInicial == 2 && !(DateTime.IsLeapYear(Convert.ToInt32(anio))))
                return aInt(dia) <= 28;

            return fallarPor("Has ingresado una fecha invalida");
        }

        private int diaNumericoDeLaSemana(String dia)
        {
            switch (dia)
            {
                case "Lunes": 
                    return 1; 
                case "Martes":
                    return 2;
                case "Miercoles":
                    return 3;
                case "Jueves":
                    return 4;
                case "Viernes":
                    return 5;
                case "Sabado":
                    return 6;
                default: 
                    return 0;
            }
        
        }

        private bool validacion48Horas()
        {
            int horarioInicio = aInt(listaHorasInicio.Value) * 100 + aInt(listaMinutosInicio.Value);
            int horarioFin = aInt(listaHorasFinal.Value) * 100 + aInt(listaMinutosFinal.Value);
            int suma = (horarioFin - horarioInicio) * (diaNumericoDeLaSemana(diaSemanaFinal.Text) - diaNumericoDeLaSemana(diaSemanaInicio.Text) + 1);
            if (suma > 4800)
                fallarPor("El profesional supera las 48 horas de trabajo");
           return suma <= 4800;
        }

        int matr = 0;
        string esp;

        private int aInt(decimal algo)
        {
            return Convert.ToInt32(algo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!validarVacio() || validarDatos())
            {
                try
                {
                    Server server = Server.getInstance();
                    DateTime fechaA = new DateTime(aInt(anioInicio.Value), aInt(mesInicio.Value), aInt(DiaInicio.Value), aInt(listaHorasInicio.Value), aInt(listaMinutosInicio.Value), 0);
                    DateTime fechaB = new DateTime(aInt(anioFinal.Value), aInt(mesFinal.Value), aInt(diaFinal.Value), aInt(listaHorasFinal.Value), aInt(listaMinutosFinal.Value), 0);
                    server.query("exec GESTIONAME_LAS_VACACIONES.altaAgendaProfesional " + matr + "," + "'" + esp + "','" + fechaA.ToString() + "','" + fechaB.ToString() + "'," + diaNumericoDeLaSemana(diaSemanaInicio.Text) + "," + diaNumericoDeLaSemana(diaSemanaFinal.Text));
                    MessageBox.Show("Agenda dada de alta exitosamente");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                   
            }
            else
            {
                MessageBox.Show("Faltan datos por completar");
            }
        }

        private bool validarVacio()
        {
            return  Validacion.estaVacioSinNotificar(DiaInicio)
                    || Validacion.estaVacioSinNotificar(anioFinal)
                    || Validacion.estaVacioSinNotificar(mesInicio)
                    || Validacion.estaVacioSinNotificar(mesFinal)
                    || Validacion.estaVacioSinNotificar(anioInicio)
                    || Validacion.estaVacioSinNotificar(anioFinal)
                    || Validacion.estaVacioSinNotificar(listaHorasInicio)
                    || Validacion.estaVacioSinNotificar(listaHorasFinal)
                    || Validacion.estaVacioSinNotificar(listaMinutosInicio)
                    || Validacion.estaVacioSinNotificar(listaMinutosFinal)
                    || Validacion.estaVacioSinNotificar(diaSemanaInicio)
                    || Validacion.estaVacioSinNotificar(diaSemanaFinal)
                    || Validacion.estaVacioSinNotificar(profesional);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedir_Turno.BuscarProfesional buscador = new Pedir_Turno.BuscarProfesional();
            buscador.ShowDialog();
            prof = buscador.profesional;
            if(prof != null)
            setearLabelProf(prof);
        }
        

        public void setearLabelProf(Pedir_Turno.Profesional prof )
        {
            matr = prof.matricula;
            esp = prof.especialidad;
            profesional.Text = prof.apellido + "," + prof.nombre + ". Matricula: " + prof.matricula;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
