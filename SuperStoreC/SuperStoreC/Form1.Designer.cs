using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperStoreC
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridView1 = new DataGridView();
            cboEstado = new ComboBox();
            cboEstado.SelectedIndexChanged += new EventHandler(cboEstado_SelectedIndexChanged);
            CbCiudad = new ComboBox();
            CbCiudad.SelectedIndexChanged += new EventHandler(CbCiudad_SelectedIndexChanged);
            Label1 = new Label();
            Label2 = new Label();
            Panel1 = new Panel();
            Panel2 = new Panel();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PictureBox1.DoubleClick += new EventHandler(PictureBox1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(98, 71);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(593, 359);
            DataGridView1.TabIndex = 0;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(111, 33);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(179, 21);
            cboEstado.TabIndex = 1;
            // 
            // CbCiudad
            // 
            CbCiudad.FormattingEnabled = true;
            CbCiudad.Location = new Point(329, 33);
            CbCiudad.Name = "CbCiudad";
            CbCiudad.Size = new Size(155, 21);
            CbCiudad.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(108, 17);
            Label1.Name = "Label1";
            Label1.Size = new Size(75, 13);
            Label1.TabIndex = 3;
            Label1.Text = "Estado Cliente";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(326, 17);
            Label2.Name = "Label2";
            Label2.Size = new Size(40, 13);
            Label2.TabIndex = 4;
            Label2.Text = "Ciudad";
            // 
            // Panel1
            // 
            Panel1.BackColor = SystemColors.ActiveCaption;
            Panel1.Controls.Add(PictureBox1);
            Panel1.Controls.Add(CbCiudad);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(cboEstado);
            Panel1.Controls.Add(Label1);
            Panel1.Location = new Point(-3, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(694, 73);
            Panel1.TabIndex = 5;
            // 
            // Panel2
            // 
            Panel2.BackColor = SystemColors.ActiveCaption;
            Panel2.Location = new Point(-1, 71);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(103, 359);
            Panel2.TabIndex = 6;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(3, 11);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(100, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 5;
            PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 431);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(DataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);

        }

        internal DataGridView DataGridView1;
        internal ComboBox cboEstado;
        internal ComboBox CbCiudad;
        internal Label Label1;
        internal Label Label2;
        internal Panel Panel1;
        internal PictureBox PictureBox1;
        internal Panel Panel2;
    }
}