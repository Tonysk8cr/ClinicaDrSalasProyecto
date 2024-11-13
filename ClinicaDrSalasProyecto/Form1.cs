using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;

namespace ClinicaDrSalasProyecto
{
    //Esto es sintaxis viene ya con el codigo
    //Porfa cuando se crea la BLL hay que ir a Pryoyecto que contiene el frontend y agregar>referencia
    public partial class Form1 : Form
    {

        //Esto  es una instancia del metodo Operaciones de la clase BLL del proyecto BLL
        private Operaciones objOper = new Operaciones();
        public Form1()//Sintaxis
        {
            InitializeComponent();
        }

        //Esto nos ayuda a guardar los textos que vienen de los textboxes del front end
        //Se hace asi para poder usuarlos con mayor facilidad?
        public string nombrePasciente = "";
        public string apellidoPasciente = "";
        public string emailPasciente = "";
        public string fechaCita = "";
        public string hora = "";
        public string operacion = "";

        //Este evita que se puedan ingresar numeros en el textbox del nombre
        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra o si es un espacio o un backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Si no es una letra, se consume el evento y no se permite el ingreso
            }
        }

        //Este metodo sirve para evitar que se pongan numeros en el textbox del apellido, basicamente es lo mismo que el anterior
        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra o si es un espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Si no es una letra, se consume el evento y no se permite el ingreso
            }
        }

        //Guarda los datos del primer cuadro, estos incluyen nombre, apellido y email.
        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {
            this.nombrePasciente = this.TxtNombre.Text; //Guarda el nombre que proviene del textbox 
            this.apellidoPasciente = this.TxtApellido.Text; //Lo mismo pero para el apellido
            this.emailPasciente = this.TxtEmail.Text; //Lo mismo para el correo
        }

        //Este va a guardar los datos del segundo bloque como la fecha, hora y procedimiento
        private void BtnGuardarInfo_Click(object sender, EventArgs e)
        {
            this.fechaCita = this.FechaCita.Text; //Este guarda la fecha
            this.hora = this.Hora.Text; //Este guarda la hora
            this.operacion = this.Procedimiento.Text; //Este guarda la operacion que se selecciono del combo
        }

        //Este limpia la pantalla
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarPantalla(); //Llamamos a la funcion que limpia la pantalla
            //Se llamma la funcion, lo que se encuentra dentro de la funcion tambien se puede poner aqui
            //Y haria exactamente lo mismo.
        }

        //Metodo para limpiar la pantalla
        private void LimpiarPantalla() {

            //Aqui hacemos que todos los textboxes tengan su valor en blanco
            this.TxtNombre.Text = "";
            this.TxtApellido.Text = "";
            this.TxtEmail.Text = "";
            this.TxtImprimeAdelanto.Text = "";
            this.TxtImprimeFecha.Text = "";
            this.TxtImprimeHora.Text = "";
            this.TxtImprimeIva.Text = "";
            this.TxtImprimeNombre.Text = "";
            this.TxtImprimeProcedimiento.Text = "";
            this.TxtImprimeTotal.Text = "";
            this.txtImprimeCosto.Text = "";

            this.Procedimiento.SelectedIndex = 0; //Este devuelve el ComboBox o la lista a Limpiar que es el indice 0

            this.FechaCita.Value = DateTime.Today;//Este devuelve el time picker a la fecha actual
            //Se le pasa el nombre asignado al daytime, se le pasa el .value, y se le asigna el datetime today

            this.Hora.Text = "";//Este devuelve el textbox de la hora a nullo o limpio
            

        }

        //Metodo encargado de ejecutar la operacion dependiendo de lo seleccionado en la lista
        private void EjecutarOperacion()
        {
            // Obtener el índice del procedimiento seleccionado en el ComboBox
            int procedimientoSeleccionado = this.Procedimiento.SelectedIndex;

            // Calcular el costo total con IVA
            float totalConIva = objOper.CalcularCostoTotal(procedimientoSeleccionado);

            // Calcular el adelanto
            float adelanto = objOper.CalcularAdelanto(totalConIva);

            // Calcular el IVA
            float iva = totalConIva - (totalConIva / (1 + objOper.iva));

            // Imprimir el boucher con la información

            // Nombre y Apellido, imprime Nombre: y le agrega la varibale con el nombre de usuario + apellido
            this.TxtImprimeNombre.Text = "Nombre: " + this.TxtNombre.Text + " " + this.TxtApellido.Text;

            // Procedimiento
            this.TxtImprimeProcedimiento.Text = "Procedimiento: " + this.Procedimiento.SelectedItem.ToString();

            // Fecha y Hora
            this.TxtImprimeFecha.Text = "Fecha: " + this.FechaCita.Text;
            this.TxtImprimeHora.Text = "Hora: " + this.Hora.Text;

            // Adelanto
            this.TxtImprimeAdelanto.Text = "Adelanto: " + adelanto.ToString("N", new CultureInfo("es-CR")); // Mostrar en formato numérico

            // IVA
            this.TxtImprimeIva.Text = "IVA: " + iva.ToString("N", new CultureInfo("es-CR")); // Mostrar el IVA en formato numérico

            // Total
            this.TxtImprimeTotal.Text = "Total: " + totalConIva.ToString("N", new CultureInfo("es-CR")); // Mostrar total con IVA en formato numérico

            // Costo Total
            this.txtImprimeCosto.Text = "Costo: " + totalConIva.ToString("N", new CultureInfo("es-CR")); // Mostrar costo total en formato numérico
        }



        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            this.EjecutarOperacion();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Definir la fuente y las coordenadas
            Font fuente = new Font("Arial", 14); // Fuente para el tiquete
            int ancho = 500; // Ancho de la impresora
            int y = 20; // Posición inicial de la coordenada Y


            // Incrementa la posición en Y
            y += 40;

            // Imprimir los datos del paciente
            e.Graphics.DrawString("Nombre: " + this.TxtNombre.Text + " " + this.TxtApellido.Text, fuente, Brushes.Black, 10, y);
            y += 30;

            // Procedimiento
            e.Graphics.DrawString("Procedimiento: " + this.Procedimiento.SelectedItem.ToString(), fuente, Brushes.Black, 10, y);
            y += 30;

            // Fecha
            e.Graphics.DrawString("Fecha: " + this.FechaCita.Text, fuente, Brushes.Black, 10, y);
            y += 30;

            // Hora
            e.Graphics.DrawString("Hora: " + this.Hora.Text, fuente, Brushes.Black, 10, y);
            y += 30;

            // Adelanto
            e.Graphics.DrawString("Adelanto: " + this.TxtImprimeAdelanto.Text, fuente, Brushes.Black, 10, y);
            y += 30;

            // IVA
            e.Graphics.DrawString("IVA: " + this.TxtImprimeIva.Text, fuente, Brushes.Black, 10, y);
            y += 30;

            // Total
            e.Graphics.DrawString("Total: " + this.TxtImprimeTotal.Text, fuente, Brushes.Black, 10, y);
            y += 30;

            // Costo
            e.Graphics.DrawString("Costo: " + this.txtImprimeCosto.Text, fuente, Brushes.Black, 10, y);
            y += 30;

            // Si hay más información, puedes seguir añadiéndola aquí

            // Añadir mensaje final de agradecimiento
            e.Graphics.DrawString("Gracias por su compra", fuente, Brushes.Black, 10, y);
        }



        private void BtnImprime_Click(object sender, EventArgs e)
        {
            // Se crea una instancia del documento a imprimir
            this.printDocument1 = new PrintDocument();

            // Se usan los ajustes predeterminados de la impresora
            PrinterSettings settings = new PrinterSettings(); // Ajustes

            // Asignar la impresora predeterminada a la configuración
            this.printDocument1.PrinterSettings = settings;

            // Asignar el método de impresión al evento PrintPage
            this.printDocument1.PrintPage += this.printDocument1_PrintPage;

            // Imprimir el documento
            this.printDocument1.Print();
        }


    }
}
