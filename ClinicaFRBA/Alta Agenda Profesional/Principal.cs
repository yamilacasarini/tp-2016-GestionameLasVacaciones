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
            cargarHoras(listaHorasInicio);
            cargarHoras(listaHorasFinal);
            cargarMinutos(listaMinutosInicio);
            cargarMinutos(listaMinutosFinal);
            cargarDias(diaSemanaInicio);
            cargarDias(diaSemanaFinal);
            horaDelSistema = DateTime.ParseExact(Program.horarioSistema, "yyyy-dd-MM HH:mm:ss.fff",
                                      System.Globalization.CultureInfo.InvariantCulture);

            diaDelSistema = horaDelSistema.Day.ToString();
            mesDelSistema = horaDelSistema.Month.ToString();
            anioDelSistema = horaDelSistema.Year.ToString();

        }

        Pedir_Turno.Profesional prof = new Pedir_Turno.Profesional();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarHoras(ComboBox combito)
        {
            for (int i = 7; i <= 20; i++) { combito.Items.Add(i); }
        }

        private void cargarMinutos(ComboBox combito)
        {
            for (int i = 0; i <= 59; i++) { combito.Items.Add(i); }
        }

        private void cargarDias(ComboBox combito)
        {
            combito.Items.Add("LUNES");
            combito.Items.Add("MARTES");
            combito.Items.Add("MIERCOLES");
            combito.Items.Add("JUEVES");
            combito.Items.Add("VIERNES");
            combito.Items.Add("SABADO");
        }
        private bool validarDatos()
        {
            return validarMes(mesInicio.Text)
                && validarMes(mesFinal.Text)
                && validarDia(DiaInicio.Text, mesInicio.Text, anioInicio.Text)
                && validarDia(diaFinal.Text, mesFinal.Text, anioFinal.Text)
                && validacion48Horas()
                && validarQueSeaFechaFutura(anioInicio.Text, anioFinal.Text, 
                mesInicio.Text, mesFinal.Text, DiaInicio.Text, diaFinal.Text)
                && validarQueSeaFechaFutura(anioDelSistema, anioInicio.Text,
                mesDelSistema, mesInicio.Text, diaDelSistema, DiaInicio.Text)
                && validarQueSeaFechaFutura(anioDelSistema, anioFinal.Text,
                mesDelSistema, mesFinal.Text, diaDelSistema, diaFinal.Text)
                && validarSabadoHastaLas15(diaSemanaInicio.Text, listaHorasInicio.Text)
                && validarSabadoHastaLas15(diaSemanaFinal.Text, listaHorasInicio.Text)
                && validarSabadoHastaLas15(diaSemanaInicio.Text, listaHorasFinal.Text)
                && validarSabadoHastaLas15(diaSemanaFinal.Text, listaHorasFinal.Text)
                ;
        }

        private bool validarSabadoHastaLas15(string dia, string hora)
        {
            if (diaNumericoDeLaSemana(dia) == 6 && aInt(hora) >= 15)
                return false;

            return true;
        }

        private bool validarMes(string mes)
        {
            return aInt(mes) >= 1 && aInt(mes) <= 12;
        }

        private bool validarQueSeaFechaFutura(string anioInicio,
            string anioFinal, string mesInicio, string mesFinal,
            string diaInicio, string diaFinal)
        {
            if (aInt(anioInicio) > aInt(anioFinal))
                return false;
            if (aInt(anioInicio) == aInt(anioFinal) &&
                aInt(mesInicio) > aInt(mesFinal))
                return false;
            if (aInt(mesInicio) == aInt(mesFinal) &&
                aInt(diaInicio) > aInt(diaFinal))
                return false;

            return true;
        }

        private bool validarDia(string dia, string mes, string anio)
        {
            int mesInicial = aInt(mes);
            bool diaNoNegativo = aInt(dia) >= 1;
            if (mesInicial == 1 || mesInicial == 3 || mesInicial == 5 || mesInicial == 7 || mesInicial == 8 || mesInicial == 10 || mesInicial == 12)
                return aInt(dia) <= 31 && diaNoNegativo;
            else if (mesInicial == 4 || mesInicial == 6 || mesInicial == 9 || mesInicial == 11)
                return aInt(dia) <= 30 && diaNoNegativo;
            else if (mesInicial == 2 && DateTime.IsLeapYear(Convert.ToInt32(anio)))
                return aInt(dia) <= 29 && diaNoNegativo;
            else if (mesInicial == 2 && !(DateTime.IsLeapYear(Convert.ToInt32(anio))))
                return aInt(dia) <= 28 && diaNoNegativo;

            return false;
        }

        private int diaNumericoDeLaSemana(String dia)
        {
            switch (dia)
            {
                case "LUNES": 
                    return 1; 
                case "MARTES":
                    return 2;
                case "MIERCOLES":
                    return 3;
                case "JUEVES":
                    return 4;
                case "VIERNES":
                    return 5;
                case "SABADO":
                    return 6;
                default: 
                    return 0;
            }
        
        }

        private bool validacion48Horas()
        {
            int horarioInicio = aInt(listaHorasInicio.Text) * 100 + aInt(listaMinutosInicio.Text);
            int horarioFin = aInt(listaHorasFinal.Text) * 100 + aInt(listaMinutosFinal.Text);
            int suma = (horarioFin - horarioInicio) * (diaNumericoDeLaSemana(diaSemanaFinal.Text) - diaNumericoDeLaSemana(diaSemanaInicio.Text) + 1);
           return suma <= 4800;
        }

        int matr = 0;
        string esp;

        private int aInt(string algo)
        {
            return Convert.ToInt32(algo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!validarVacio())
            {
                if (validarSoloNumeros())
                {
                    if (validarDatos())
                    {
                        Server server = Server.getInstance();
                        DateTime fechaA = new DateTime(aInt(anioInicio.Text), aInt(mesInicio.Text), aInt(DiaInicio.Text), aInt(listaHorasInicio.Text), aInt(listaMinutosInicio.Text), 0);
                        DateTime fechaB = new DateTime(aInt(anioFinal.Text), aInt(mesFinal.Text), aInt(diaFinal.Text), aInt(listaHorasFinal.Text), aInt(listaMinutosFinal.Text), 0);
                        server.query("exec GESTIONAME_LAS_VACACIONES.altaAgendaProfesional " + matr + "," + "'" + esp + "','" + fechaA.ToString() + "','" + fechaB.ToString() + "'," + diaNumericoDeLaSemana(diaSemanaInicio.Text) + "," + diaNumericoDeLaSemana(diaSemanaFinal.Text));

                        System.Windows.Forms.MessageBox.Show("Agenda dada de alta exitosamente");
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Faltan datos o los formatos no son correctos");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Faltan datos por completar");
            }
        }

        private bool validarVacio()
        {
            return  Validacion.estaVacioSinNotificar(DiaInicio)
                    || Validacion.estaVacioSinNotificar(diaFinal)
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


        private bool validarSoloNumeros()
        {
            return Validacion.soloNumeros(DiaInicio, "dia Inicio")
                    && Validacion.soloNumeros(diaFinal, "dia Final")
                    && Validacion.soloNumeros(mesInicio, "Mes Inicio")
                    && Validacion.soloNumeros(mesFinal, "Mes Final")
                    && Validacion.soloNumeros(anioInicio, "Año inicio")
                    && Validacion.soloNumeros(anioFinal, "Año final")
                    && Validacion.soloNumeros(listaHorasInicio, "Hora inicio")
                    && Validacion.soloNumeros(listaHorasFinal, "Horas Final")
                    && Validacion.soloNumeros(listaMinutosInicio, "Minutos Inicio")
                    && Validacion.soloNumeros(listaMinutosFinal, "Minutos Final");
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedir_Turno.BuscarProfesional buscador = new Pedir_Turno.BuscarProfesional();
            buscador.ShowDialog();
            prof = buscador.profesional;
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
