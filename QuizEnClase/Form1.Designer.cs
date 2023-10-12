namespace QuizEnClase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grbListaDatos = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtglistaDatos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbListaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de persona";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Estudiante";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Profesor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // grbListaDatos
            // 
            this.grbListaDatos.Controls.Add(this.textBox3);
            this.grbListaDatos.Controls.Add(this.txtSueldo);
            this.grbListaDatos.Controls.Add(this.textBox1);
            this.grbListaDatos.Controls.Add(this.label4);
            this.grbListaDatos.Controls.Add(this.label3);
            this.grbListaDatos.Controls.Add(this.label2);
            this.grbListaDatos.Location = new System.Drawing.Point(38, 244);
            this.grbListaDatos.Name = "grbListaDatos";
            this.grbListaDatos.Size = new System.Drawing.Size(349, 123);
            this.grbListaDatos.TabIndex = 1;
            this.grbListaDatos.TabStop = false;
            this.grbListaDatos.Text = "Datos de la persona";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 2;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(89, 60);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(84, 20);
            this.txtSueldo.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Calificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // dtglistaDatos
            // 
            this.dtglistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistaDatos.Location = new System.Drawing.Point(307, 26);
            this.dtglistaDatos.Name = "dtglistaDatos";
            this.dtglistaDatos.Size = new System.Drawing.Size(205, 105);
            this.dtglistaDatos.TabIndex = 2;
            this.dtglistaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnListaDatos_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(544, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtglistaDatos);
            this.Controls.Add(this.grbListaDatos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PERSONAS DE UNA ESCUELA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbListaDatos.ResumeLayout(false);
            this.grbListaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoPersona;
        private System.Windows.Forms.RadioButton radEstudiante;
        private System.Windows.Forms.RadioButton radProfesor;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txeSueldo;
        private System.Windows.Forms.DataGridView btnCapturarDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grbListaDatos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtglistaDatos;
        private System.Windows.Forms.Button button1;
    }
}

