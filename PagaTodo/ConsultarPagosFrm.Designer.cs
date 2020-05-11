namespace PagaTodo
{
    partial class ConsultarPagosFrm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultaEntidadesCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PagosRealizadosTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalRecaudosTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha De Pago";
            // 
            // ConsultaEntidadesCmb
            // 
            this.ConsultaEntidadesCmb.FormattingEnabled = true;
            this.ConsultaEntidadesCmb.Location = new System.Drawing.Point(33, 28);
            this.ConsultaEntidadesCmb.Name = "ConsultaEntidadesCmb";
            this.ConsultaEntidadesCmb.Size = new System.Drawing.Size(121, 21);
            this.ConsultaEntidadesCmb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entidades";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // PagosRealizadosTxt
            // 
            this.PagosRealizadosTxt.Location = new System.Drawing.Point(128, 336);
            this.PagosRealizadosTxt.Name = "PagosRealizadosTxt";
            this.PagosRealizadosTxt.Size = new System.Drawing.Size(100, 20);
            this.PagosRealizadosTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PagosRealizados";
            // 
            // TotalRecaudosTxt
            // 
            this.TotalRecaudosTxt.Location = new System.Drawing.Point(327, 335);
            this.TotalRecaudosTxt.Name = "TotalRecaudosTxt";
            this.TotalRecaudosTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalRecaudosTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Recaudado";
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Location = new System.Drawing.Point(391, 26);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBtn.TabIndex = 9;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(472, 26);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportarBtn.TabIndex = 10;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            // 
            // ConsultarPagosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 389);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.ConsultarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalRecaudosTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PagosRealizadosTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsultaEntidadesCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ConsultarPagosFrm";
            this.Text = "ConsultarPagosFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ConsultaEntidadesCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PagosRealizadosTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalRecaudosTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.Button ExportarBtn;
    }
}