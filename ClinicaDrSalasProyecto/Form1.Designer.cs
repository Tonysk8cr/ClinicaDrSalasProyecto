namespace ClinicaDrSalasProyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Datospaciente = new System.Windows.Forms.GroupBox();
            this.BtnGuardarDatos = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.EmailPaciente = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.ApellidoPac = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.NombrePac = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.GroupBox();
            this.Hora = new System.Windows.Forms.MaskedTextBox();
            this.Procedimiento = new System.Windows.Forms.ComboBox();
            this.FechaCita = new System.Windows.Forms.DateTimePicker();
            this.BtnGuardarInfo = new System.Windows.Forms.Button();
            this.Proce = new System.Windows.Forms.Label();
            this.HoraUsuario = new System.Windows.Forms.Label();
            this.FechaUsuario = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.GroupBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnImprime = new System.Windows.Forms.Button();
            this.TxtImprimeAdelanto = new System.Windows.Forms.TextBox();
            this.TxtImprimeIva = new System.Windows.Forms.TextBox();
            this.TxtImprimeProcedimiento = new System.Windows.Forms.TextBox();
            this.txtImprimeCosto = new System.Windows.Forms.TextBox();
            this.TxtImprimeTotal = new System.Windows.Forms.TextBox();
            this.TxtImprimeHora = new System.Windows.Forms.TextBox();
            this.TxtImprimeFecha = new System.Windows.Forms.TextBox();
            this.TxtImprimeNombre = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.GroupBox();
            this.Clinica = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Datospaciente.SuspendLayout();
            this.Info.SuspendLayout();
            this.Result.SuspendLayout();
            this.Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datospaciente
            // 
            this.Datospaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Datospaciente.Controls.Add(this.BtnGuardarDatos);
            this.Datospaciente.Controls.Add(this.TxtEmail);
            this.Datospaciente.Controls.Add(this.EmailPaciente);
            this.Datospaciente.Controls.Add(this.TxtApellido);
            this.Datospaciente.Controls.Add(this.ApellidoPac);
            this.Datospaciente.Controls.Add(this.TxtNombre);
            this.Datospaciente.Controls.Add(this.NombrePac);
            this.Datospaciente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datospaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Datospaciente.Location = new System.Drawing.Point(12, 107);
            this.Datospaciente.Name = "Datospaciente";
            this.Datospaciente.Size = new System.Drawing.Size(752, 286);
            this.Datospaciente.TabIndex = 0;
            this.Datospaciente.TabStop = false;
            this.Datospaciente.Text = "Datos del paciente: ";
            // 
            // BtnGuardarDatos
            // 
            this.BtnGuardarDatos.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnGuardarDatos.Location = new System.Drawing.Point(493, 107);
            this.BtnGuardarDatos.Name = "BtnGuardarDatos";
            this.BtnGuardarDatos.Size = new System.Drawing.Size(236, 59);
            this.BtnGuardarDatos.TabIndex = 6;
            this.BtnGuardarDatos.Text = "Guardar";
            this.BtnGuardarDatos.UseVisualStyleBackColor = false;
            this.BtnGuardarDatos.Click += new System.EventHandler(this.BtnGuardarDatos_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(127, 203);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(350, 34);
            this.TxtEmail.TabIndex = 5;
            // 
            // EmailPaciente
            // 
            this.EmailPaciente.AutoSize = true;
            this.EmailPaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailPaciente.Location = new System.Drawing.Point(6, 203);
            this.EmailPaciente.Name = "EmailPaciente";
            this.EmailPaciente.Size = new System.Drawing.Size(68, 28);
            this.EmailPaciente.TabIndex = 4;
            this.EmailPaciente.Text = "Email: ";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(127, 125);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(350, 34);
            this.TxtApellido.TabIndex = 3;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellido_KeyPress);
            // 
            // ApellidoPac
            // 
            this.ApellidoPac.AutoSize = true;
            this.ApellidoPac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoPac.Location = new System.Drawing.Point(6, 125);
            this.ApellidoPac.Name = "ApellidoPac";
            this.ApellidoPac.Size = new System.Drawing.Size(95, 28);
            this.ApellidoPac.TabIndex = 2;
            this.ApellidoPac.Text = "Apellido: ";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(127, 52);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(350, 34);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // NombrePac
            // 
            this.NombrePac.AutoSize = true;
            this.NombrePac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePac.Location = new System.Drawing.Point(6, 52);
            this.NombrePac.Name = "NombrePac";
            this.NombrePac.Size = new System.Drawing.Size(94, 28);
            this.NombrePac.TabIndex = 0;
            this.NombrePac.Text = "Nombre: ";
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Info.Controls.Add(this.Hora);
            this.Info.Controls.Add(this.Procedimiento);
            this.Info.Controls.Add(this.FechaCita);
            this.Info.Controls.Add(this.BtnGuardarInfo);
            this.Info.Controls.Add(this.Proce);
            this.Info.Controls.Add(this.HoraUsuario);
            this.Info.Controls.Add(this.FechaUsuario);
            this.Info.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Info.Location = new System.Drawing.Point(12, 429);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(752, 286);
            this.Info.TabIndex = 7;
            this.Info.TabStop = false;
            this.Info.Text = "Información de la cita: ";
            // 
            // Hora
            // 
            this.Hora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(127, 114);
            this.Hora.Mask = "00:00";
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(350, 34);
            this.Hora.TabIndex = 9;
            // 
            // Procedimiento
            // 
            this.Procedimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Procedimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procedimiento.FormattingEnabled = true;
            this.Procedimiento.Items.AddRange(new object[] {
            "Limpieza",
            "Calzas",
            "Extraciones",
            "Blanqueamiento",
            "Ortodoncia"});
            this.Procedimiento.Location = new System.Drawing.Point(162, 197);
            this.Procedimiento.Name = "Procedimiento";
            this.Procedimiento.Size = new System.Drawing.Size(315, 36);
            this.Procedimiento.TabIndex = 8;
            // 
            // FechaCita
            // 
            this.FechaCita.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaCita.Location = new System.Drawing.Point(127, 42);
            this.FechaCita.Name = "FechaCita";
            this.FechaCita.Size = new System.Drawing.Size(350, 34);
            this.FechaCita.TabIndex = 7;
            // 
            // BtnGuardarInfo
            // 
            this.BtnGuardarInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnGuardarInfo.Location = new System.Drawing.Point(493, 107);
            this.BtnGuardarInfo.Name = "BtnGuardarInfo";
            this.BtnGuardarInfo.Size = new System.Drawing.Size(236, 59);
            this.BtnGuardarInfo.TabIndex = 6;
            this.BtnGuardarInfo.Text = "Guardar";
            this.BtnGuardarInfo.UseVisualStyleBackColor = false;
            this.BtnGuardarInfo.Click += new System.EventHandler(this.BtnGuardarInfo_Click);
            // 
            // Proce
            // 
            this.Proce.AutoSize = true;
            this.Proce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proce.Location = new System.Drawing.Point(6, 203);
            this.Proce.Name = "Proce";
            this.Proce.Size = new System.Drawing.Size(149, 28);
            this.Proce.TabIndex = 4;
            this.Proce.Text = "Procedimiento: ";
            // 
            // HoraUsuario
            // 
            this.HoraUsuario.AutoSize = true;
            this.HoraUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraUsuario.Location = new System.Drawing.Point(6, 125);
            this.HoraUsuario.Name = "HoraUsuario";
            this.HoraUsuario.Size = new System.Drawing.Size(64, 28);
            this.HoraUsuario.TabIndex = 2;
            this.HoraUsuario.Text = "Hora: ";
            // 
            // FechaUsuario
            // 
            this.FechaUsuario.AutoSize = true;
            this.FechaUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaUsuario.Location = new System.Drawing.Point(6, 52);
            this.FechaUsuario.Name = "FechaUsuario";
            this.FechaUsuario.Size = new System.Drawing.Size(66, 28);
            this.FechaUsuario.TabIndex = 0;
            this.FechaUsuario.Text = "Fecha:";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Result.Controls.Add(this.BtnCalcular);
            this.Result.Controls.Add(this.BtnLimpiar);
            this.Result.Controls.Add(this.BtnImprime);
            this.Result.Controls.Add(this.TxtImprimeAdelanto);
            this.Result.Controls.Add(this.TxtImprimeIva);
            this.Result.Controls.Add(this.TxtImprimeProcedimiento);
            this.Result.Controls.Add(this.txtImprimeCosto);
            this.Result.Controls.Add(this.TxtImprimeTotal);
            this.Result.Controls.Add(this.TxtImprimeHora);
            this.Result.Controls.Add(this.TxtImprimeFecha);
            this.Result.Controls.Add(this.TxtImprimeNombre);
            this.Result.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(786, 15);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(440, 700);
            this.Result.TabIndex = 8;
            this.Result.TabStop = false;
            this.Result.Text = "Tiquete";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BtnCalcular.Location = new System.Drawing.Point(149, 615);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(143, 70);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BtnLimpiar.Location = new System.Drawing.Point(7, 615);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(143, 70);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnImprime
            // 
            this.BtnImprime.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnImprime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BtnImprime.Location = new System.Drawing.Point(292, 615);
            this.BtnImprime.Name = "BtnImprime";
            this.BtnImprime.Size = new System.Drawing.Size(142, 70);
            this.BtnImprime.TabIndex = 8;
            this.BtnImprime.Text = "Imprimir";
            this.BtnImprime.UseVisualStyleBackColor = false;
            this.BtnImprime.Click += new System.EventHandler(this.BtnImprime_Click);
            // 
            // TxtImprimeAdelanto
            // 
            this.TxtImprimeAdelanto.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.TxtImprimeAdelanto.Location = new System.Drawing.Point(7, 553);
            this.TxtImprimeAdelanto.Name = "TxtImprimeAdelanto";
            this.TxtImprimeAdelanto.ReadOnly = true;
            this.TxtImprimeAdelanto.Size = new System.Drawing.Size(427, 35);
            this.TxtImprimeAdelanto.TabIndex = 7;
            this.TxtImprimeAdelanto.Text = "Adelanto";
            // 
            // TxtImprimeIva
            // 
            this.TxtImprimeIva.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.TxtImprimeIva.Location = new System.Drawing.Point(7, 402);
            this.TxtImprimeIva.Name = "TxtImprimeIva";
            this.TxtImprimeIva.ReadOnly = true;
            this.TxtImprimeIva.Size = new System.Drawing.Size(427, 35);
            this.TxtImprimeIva.TabIndex = 5;
            this.TxtImprimeIva.Text = "IVA: ";
            // 
            // TxtImprimeProcedimiento
            // 
            this.TxtImprimeProcedimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImprimeProcedimiento.Location = new System.Drawing.Point(7, 259);
            this.TxtImprimeProcedimiento.Name = "TxtImprimeProcedimiento";
            this.TxtImprimeProcedimiento.ReadOnly = true;
            this.TxtImprimeProcedimiento.Size = new System.Drawing.Size(427, 34);
            this.TxtImprimeProcedimiento.TabIndex = 3;
            this.TxtImprimeProcedimiento.Text = "Procedimiento: ";
            // 
            // txtImprimeCosto
            // 
            this.txtImprimeCosto.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.txtImprimeCosto.Location = new System.Drawing.Point(7, 476);
            this.txtImprimeCosto.Name = "txtImprimeCosto";
            this.txtImprimeCosto.ReadOnly = true;
            this.txtImprimeCosto.Size = new System.Drawing.Size(427, 35);
            this.txtImprimeCosto.TabIndex = 4;
            this.txtImprimeCosto.Text = "Costo: ";
            // 
            // TxtImprimeTotal
            // 
            this.TxtImprimeTotal.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.TxtImprimeTotal.Location = new System.Drawing.Point(7, 329);
            this.TxtImprimeTotal.Name = "TxtImprimeTotal";
            this.TxtImprimeTotal.ReadOnly = true;
            this.TxtImprimeTotal.Size = new System.Drawing.Size(427, 35);
            this.TxtImprimeTotal.TabIndex = 6;
            this.TxtImprimeTotal.Text = "Total: ";
            // 
            // TxtImprimeHora
            // 
            this.TxtImprimeHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImprimeHora.Location = new System.Drawing.Point(7, 190);
            this.TxtImprimeHora.Name = "TxtImprimeHora";
            this.TxtImprimeHora.ReadOnly = true;
            this.TxtImprimeHora.Size = new System.Drawing.Size(427, 34);
            this.TxtImprimeHora.TabIndex = 2;
            this.TxtImprimeHora.Text = "Hora: ";
            // 
            // TxtImprimeFecha
            // 
            this.TxtImprimeFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImprimeFecha.Location = new System.Drawing.Point(7, 120);
            this.TxtImprimeFecha.Name = "TxtImprimeFecha";
            this.TxtImprimeFecha.ReadOnly = true;
            this.TxtImprimeFecha.Size = new System.Drawing.Size(427, 34);
            this.TxtImprimeFecha.TabIndex = 1;
            this.TxtImprimeFecha.Text = "Fecha: ";
            // 
            // TxtImprimeNombre
            // 
            this.TxtImprimeNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImprimeNombre.Location = new System.Drawing.Point(7, 52);
            this.TxtImprimeNombre.Name = "TxtImprimeNombre";
            this.TxtImprimeNombre.ReadOnly = true;
            this.TxtImprimeNombre.Size = new System.Drawing.Size(427, 34);
            this.TxtImprimeNombre.TabIndex = 0;
            this.TxtImprimeNombre.Text = "Paciente: ";
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Titulo.Controls.Add(this.Clinica);
            this.Titulo.Location = new System.Drawing.Point(12, 12);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(752, 89);
            this.Titulo.TabIndex = 9;
            this.Titulo.TabStop = false;
            // 
            // Clinica
            // 
            this.Clinica.AutoSize = true;
            this.Clinica.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Clinica.Location = new System.Drawing.Point(6, 17);
            this.Clinica.Name = "Clinica";
            this.Clinica.Size = new System.Drawing.Size(456, 59);
            this.Clinica.TabIndex = 0;
            this.Clinica.Text = "Clínica Dental Dr. Salas";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 730);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Datospaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppClinicaDrSalas";
            this.Datospaciente.ResumeLayout(false);
            this.Datospaciente.PerformLayout();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.Titulo.ResumeLayout(false);
            this.Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Datospaciente;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label EmailPaciente;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label ApellidoPac;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label NombrePac;
        private System.Windows.Forms.Button BtnGuardarDatos;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.DateTimePicker FechaCita;
        private System.Windows.Forms.Button BtnGuardarInfo;
        private System.Windows.Forms.Label Proce;
        private System.Windows.Forms.Label HoraUsuario;
        private System.Windows.Forms.Label FechaUsuario;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.TextBox TxtImprimeFecha;
        private System.Windows.Forms.TextBox TxtImprimeNombre;
        private System.Windows.Forms.TextBox TxtImprimeProcedimiento;
        private System.Windows.Forms.TextBox TxtImprimeHora;
        private System.Windows.Forms.TextBox txtImprimeCosto;
        private System.Windows.Forms.TextBox TxtImprimeIva;
        private System.Windows.Forms.TextBox TxtImprimeAdelanto;
        private System.Windows.Forms.TextBox TxtImprimeTotal;
        private System.Windows.Forms.MaskedTextBox Hora;
        private System.Windows.Forms.ComboBox Procedimiento;
        private System.Windows.Forms.Button BtnImprime;
        private System.Windows.Forms.GroupBox Titulo;
        private System.Windows.Forms.Label Clinica;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

