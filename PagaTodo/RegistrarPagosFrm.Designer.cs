namespace PagaTodo
{
    partial class RegistrarPagosFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumeroReciboTxt = new System.Windows.Forms.TextBox();
            this.ValorPagadoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreEntidadCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeroReciboTxt
            // 
            this.NumeroReciboTxt.Location = new System.Drawing.Point(154, 53);
            this.NumeroReciboTxt.Name = "NumeroReciboTxt";
            this.NumeroReciboTxt.Size = new System.Drawing.Size(100, 20);
            this.NumeroReciboTxt.TabIndex = 0;
            // 
            // ValorPagadoTxt
            // 
            this.ValorPagadoTxt.Location = new System.Drawing.Point(154, 107);
            this.ValorPagadoTxt.Name = "ValorPagadoTxt";
            this.ValorPagadoTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorPagadoTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de Recibo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Pagado";
            // 
            // NombreEntidadCmb
            // 
            this.NombreEntidadCmb.FormattingEnabled = true;
            this.NombreEntidadCmb.Items.AddRange(new object[] {
            "Electricaribe",
            "GasCaribe",
            "Emdupar"});
            this.NombreEntidadCmb.Location = new System.Drawing.Point(154, 26);
            this.NombreEntidadCmb.Name = "NombreEntidadCmb";
            this.NombreEntidadCmb.Size = new System.Drawing.Size(121, 21);
            this.NombreEntidadCmb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre Entidad";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(80, 170);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(211, 170);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.LimpiarBtn.TabIndex = 12;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // RegistrarPagosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 251);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreEntidadCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorPagadoTxt);
            this.Controls.Add(this.NumeroReciboTxt);
            this.Name = "RegistrarPagosFrm";
            this.Text = "Registrar Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeroReciboTxt;
        private System.Windows.Forms.TextBox ValorPagadoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox NombreEntidadCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button LimpiarBtn;
    }
}