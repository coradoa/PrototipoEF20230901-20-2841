
namespace Vista_PrototipoMenu
{
    partial class Mantenimiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codpuesto = new System.Windows.Forms.TextBox();
            this.txt_nompuesto = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código puesto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(22, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 1;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estatus";
            // 
            // txt_codpuesto
            // 
            this.txt_codpuesto.Location = new System.Drawing.Point(184, 230);
            this.txt_codpuesto.Name = "txt_codpuesto";
            this.txt_codpuesto.Size = new System.Drawing.Size(144, 23);
            this.txt_codpuesto.TabIndex = 4;
            this.txt_codpuesto.Tag = "codigo_puesto";
            // 
            // txt_nompuesto
            // 
            this.txt_nompuesto.Location = new System.Drawing.Point(184, 272);
            this.txt_nompuesto.Name = "txt_nompuesto";
            this.txt_nompuesto.Size = new System.Drawing.Size(144, 23);
            this.txt_nompuesto.TabIndex = 5;
            this.txt_nompuesto.Tag = "nombre_puesto";
            // 
            // txt_status
            // 
            this.txt_status.Enabled = false;
            this.txt_status.Location = new System.Drawing.Point(184, 316);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(19, 23);
            this.txt_status.TabIndex = 6;
            this.txt_status.Tag = "estatus_puesto";
            this.txt_status.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 121);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Location = new System.Drawing.Point(363, 123);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(91, 77);
            this.btn_reportes.TabIndex = 9;
            this.btn_reportes.Text = "Reporte";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_nompuesto);
            this.Controls.Add(this.txt_codpuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codpuesto;
        private System.Windows.Forms.TextBox txt_nompuesto;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_reportes;
    }
}