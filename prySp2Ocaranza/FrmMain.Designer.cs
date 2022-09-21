namespace prySp2Ocaranza
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GbCabaña = new System.Windows.Forms.GroupBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.LblDias = new System.Windows.Forms.Label();
            this.CmbPersonas = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblPersonas = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.MrcAdcionales = new System.Windows.Forms.GroupBox();
            this.ChkTv = new System.Windows.Forms.CheckBox();
            this.ChkHeladera = new System.Windows.Forms.CheckBox();
            this.ChkCocina = new System.Windows.Forms.CheckBox();
            this.MrcPago = new System.Windows.Forms.GroupBox();
            this.CmbTarjeta = new System.Windows.Forms.ComboBox();
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.RbTarjeta = new System.Windows.Forms.RadioButton();
            this.RbEfectivo = new System.Windows.Forms.RadioButton();
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNonbre = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.GbCabaña.SuspendLayout();
            this.MrcAdcionales.SuspendLayout();
            this.MrcPago.SuspendLayout();
            this.GbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GbCabaña
            // 
            this.GbCabaña.Controls.Add(this.TxtDias);
            this.GbCabaña.Controls.Add(this.LblDias);
            this.GbCabaña.Controls.Add(this.CmbPersonas);
            this.GbCabaña.Controls.Add(this.LblTipo);
            this.GbCabaña.Controls.Add(this.LblPersonas);
            this.GbCabaña.Controls.Add(this.CmbTipo);
            this.GbCabaña.Location = new System.Drawing.Point(33, 36);
            this.GbCabaña.Name = "GbCabaña";
            this.GbCabaña.Size = new System.Drawing.Size(694, 119);
            this.GbCabaña.TabIndex = 10;
            this.GbCabaña.TabStop = false;
            this.GbCabaña.Text = "Tipo de Cabaña";
            // 
            // TxtDias
            // 
            this.TxtDias.Enabled = false;
            this.TxtDias.Location = new System.Drawing.Point(468, 48);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(100, 23);
            this.TxtDias.TabIndex = 16;
            this.TxtDias.TextChanged += new System.EventHandler(this.TxtDias_TextChanged);
            // 
            // LblDias
            // 
            this.LblDias.AutoSize = true;
            this.LblDias.Location = new System.Drawing.Point(426, 51);
            this.LblDias.Name = "LblDias";
            this.LblDias.Size = new System.Drawing.Size(36, 17);
            this.LblDias.TabIndex = 15;
            this.LblDias.Text = "Dias";
            // 
            // CmbPersonas
            // 
            this.CmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPersonas.Enabled = false;
            this.CmbPersonas.FormattingEnabled = true;
            this.CmbPersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "10+"});
            this.CmbPersonas.Location = new System.Drawing.Point(294, 48);
            this.CmbPersonas.Name = "CmbPersonas";
            this.CmbPersonas.Size = new System.Drawing.Size(110, 24);
            this.CmbPersonas.TabIndex = 14;
            this.CmbPersonas.SelectedIndexChanged += new System.EventHandler(this.CmbPersonas_SelectedIndexChanged);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(6, 48);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(36, 17);
            this.LblTipo.TabIndex = 11;
            this.LblTipo.Text = "Tipo";
            // 
            // LblPersonas
            // 
            this.LblPersonas.AutoSize = true;
            this.LblPersonas.Location = new System.Drawing.Point(205, 48);
            this.LblPersonas.Name = "LblPersonas";
            this.LblPersonas.Size = new System.Drawing.Size(68, 17);
            this.LblPersonas.TabIndex = 13;
            this.LblPersonas.Text = "Personas";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.CmbTipo.Location = new System.Drawing.Point(58, 47);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(110, 24);
            this.CmbTipo.TabIndex = 12;
            this.CmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipo_SelectedIndexChanged);
            // 
            // MrcAdcionales
            // 
            this.MrcAdcionales.Controls.Add(this.ChkTv);
            this.MrcAdcionales.Controls.Add(this.ChkHeladera);
            this.MrcAdcionales.Controls.Add(this.ChkCocina);
            this.MrcAdcionales.Enabled = false;
            this.MrcAdcionales.Location = new System.Drawing.Point(33, 196);
            this.MrcAdcionales.Name = "MrcAdcionales";
            this.MrcAdcionales.Size = new System.Drawing.Size(273, 169);
            this.MrcAdcionales.TabIndex = 11;
            this.MrcAdcionales.TabStop = false;
            this.MrcAdcionales.Text = "Adicionales";
            // 
            // ChkTv
            // 
            this.ChkTv.AutoSize = true;
            this.ChkTv.Enabled = false;
            this.ChkTv.Location = new System.Drawing.Point(20, 127);
            this.ChkTv.Name = "ChkTv";
            this.ChkTv.Size = new System.Drawing.Size(85, 21);
            this.ChkTv.TabIndex = 2;
            this.ChkTv.Text = "Televisor";
            this.ChkTv.UseVisualStyleBackColor = true;
            // 
            // ChkHeladera
            // 
            this.ChkHeladera.AutoSize = true;
            this.ChkHeladera.Enabled = false;
            this.ChkHeladera.Location = new System.Drawing.Point(20, 88);
            this.ChkHeladera.Name = "ChkHeladera";
            this.ChkHeladera.Size = new System.Drawing.Size(85, 21);
            this.ChkHeladera.TabIndex = 1;
            this.ChkHeladera.Text = "Heladera";
            this.ChkHeladera.UseVisualStyleBackColor = true;
            // 
            // ChkCocina
            // 
            this.ChkCocina.AutoSize = true;
            this.ChkCocina.Enabled = false;
            this.ChkCocina.Location = new System.Drawing.Point(20, 49);
            this.ChkCocina.Name = "ChkCocina";
            this.ChkCocina.Size = new System.Drawing.Size(70, 21);
            this.ChkCocina.TabIndex = 0;
            this.ChkCocina.Text = "Cocina";
            this.ChkCocina.UseVisualStyleBackColor = true;
            // 
            // MrcPago
            // 
            this.MrcPago.Controls.Add(this.CmbTarjeta);
            this.MrcPago.Controls.Add(this.LblTarjeta);
            this.MrcPago.Controls.Add(this.RbTarjeta);
            this.MrcPago.Controls.Add(this.RbEfectivo);
            this.MrcPago.Location = new System.Drawing.Point(327, 196);
            this.MrcPago.Name = "MrcPago";
            this.MrcPago.Size = new System.Drawing.Size(400, 169);
            this.MrcPago.TabIndex = 12;
            this.MrcPago.TabStop = false;
            this.MrcPago.Text = "Medios de pago";
            // 
            // CmbTarjeta
            // 
            this.CmbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTarjeta.FormattingEnabled = true;
            this.CmbTarjeta.Items.AddRange(new object[] {
            "Visa",
            "Master",
            "Naranja"});
            this.CmbTarjeta.Location = new System.Drawing.Point(154, 107);
            this.CmbTarjeta.Name = "CmbTarjeta";
            this.CmbTarjeta.Size = new System.Drawing.Size(231, 24);
            this.CmbTarjeta.TabIndex = 17;
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.Location = new System.Drawing.Point(151, 73);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(53, 17);
            this.LblTarjeta.TabIndex = 17;
            this.LblTarjeta.Text = "Tarjeta";
            // 
            // RbTarjeta
            // 
            this.RbTarjeta.AutoSize = true;
            this.RbTarjeta.Enabled = false;
            this.RbTarjeta.Location = new System.Drawing.Point(27, 107);
            this.RbTarjeta.Name = "RbTarjeta";
            this.RbTarjeta.Size = new System.Drawing.Size(71, 21);
            this.RbTarjeta.TabIndex = 22;
            this.RbTarjeta.TabStop = true;
            this.RbTarjeta.Text = "Tarjeta";
            this.RbTarjeta.UseVisualStyleBackColor = true;
            this.RbTarjeta.CheckedChanged += new System.EventHandler(this.RbTarjeta_CheckedChanged);
            // 
            // RbEfectivo
            // 
            this.RbEfectivo.AutoSize = true;
            this.RbEfectivo.Enabled = false;
            this.RbEfectivo.Location = new System.Drawing.Point(27, 49);
            this.RbEfectivo.Name = "RbEfectivo";
            this.RbEfectivo.Size = new System.Drawing.Size(76, 21);
            this.RbEfectivo.TabIndex = 21;
            this.RbEfectivo.TabStop = true;
            this.RbEfectivo.Text = "Efectivo";
            this.RbEfectivo.UseVisualStyleBackColor = true;
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.TxtNumero);
            this.GbDatos.Controls.Add(this.TxtNonbre);
            this.GbDatos.Controls.Add(this.LblNumero);
            this.GbDatos.Controls.Add(this.LblNombre);
            this.GbDatos.Location = new System.Drawing.Point(33, 386);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(694, 156);
            this.GbDatos.TabIndex = 13;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(92, 108);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(596, 23);
            this.TxtNumero.TabIndex = 19;
            // 
            // TxtNonbre
            // 
            this.TxtNonbre.Enabled = false;
            this.TxtNonbre.Location = new System.Drawing.Point(92, 47);
            this.TxtNonbre.Name = "TxtNonbre";
            this.TxtNonbre.Size = new System.Drawing.Size(596, 23);
            this.TxtNonbre.TabIndex = 17;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(17, 111);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(58, 17);
            this.LblNumero.TabIndex = 18;
            this.LblNumero.Text = "Numero";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(17, 47);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 17;
            this.LblNombre.Text = "Nombre";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Enabled = false;
            this.BtnAceptar.Location = new System.Drawing.Point(579, 563);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(148, 48);
            this.BtnAceptar.TabIndex = 14;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 637);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.GbDatos);
            this.Controls.Add(this.MrcPago);
            this.Controls.Add(this.MrcAdcionales);
            this.Controls.Add(this.GbCabaña);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Reserva de Cabañas";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GbCabaña.ResumeLayout(false);
            this.GbCabaña.PerformLayout();
            this.MrcAdcionales.ResumeLayout(false);
            this.MrcAdcionales.PerformLayout();
            this.MrcPago.ResumeLayout(false);
            this.MrcPago.PerformLayout();
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox GbCabaña;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label LblDias;
        private System.Windows.Forms.ComboBox CmbPersonas;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblPersonas;
        public System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.GroupBox MrcAdcionales;
        private System.Windows.Forms.CheckBox ChkTv;
        private System.Windows.Forms.CheckBox ChkHeladera;
        private System.Windows.Forms.CheckBox ChkCocina;
        private System.Windows.Forms.GroupBox MrcPago;
        private System.Windows.Forms.ComboBox CmbTarjeta;
        private System.Windows.Forms.Label LblTarjeta;
        private System.Windows.Forms.RadioButton RbTarjeta;
        private System.Windows.Forms.RadioButton RbEfectivo;
        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNonbre;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnAceptar;
    }
}

