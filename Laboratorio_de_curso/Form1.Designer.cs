namespace Laboratorio_de_curso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_Consola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre_de_Consola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_Consolas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Leer_registros_boton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Compania = new System.Windows.Forms.ComboBox();
            this.Ano_lanzamiento = new System.Windows.Forms.DateTimePicker();
            this.Generacion_numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consolas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Generacion_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "José Emmanuel de Jesús Rodrguez Ramirez 0905-23-1437";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenido a este pequeño CRUD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID de Consola";
            // 
            // ID_Consola
            // 
            this.ID_Consola.Location = new System.Drawing.Point(164, 86);
            this.ID_Consola.Name = "ID_Consola";
            this.ID_Consola.Size = new System.Drawing.Size(200, 20);
            this.ID_Consola.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre de Consola";
            // 
            // Nombre_de_Consola
            // 
            this.Nombre_de_Consola.Location = new System.Drawing.Point(164, 135);
            this.Nombre_de_Consola.Name = "Nombre_de_Consola";
            this.Nombre_de_Consola.Size = new System.Drawing.Size(200, 20);
            this.Nombre_de_Consola.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Compañia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Año de Lanzamiento ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Generacion";
            // 
            // dataGridView_Consolas
            // 
            this.dataGridView_Consolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consolas.Location = new System.Drawing.Point(412, 84);
            this.dataGridView_Consolas.Name = "dataGridView_Consolas";
            this.dataGridView_Consolas.Size = new System.Drawing.Size(553, 268);
            this.dataGridView_Consolas.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(10, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Registro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(195, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar Registro";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(10, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Actualizar registro ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Leer_registros_boton
            // 
            this.Leer_registros_boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Leer_registros_boton.Location = new System.Drawing.Point(195, 84);
            this.Leer_registros_boton.Name = "Leer_registros_boton";
            this.Leer_registros_boton.Size = new System.Drawing.Size(108, 38);
            this.Leer_registros_boton.TabIndex = 5;
            this.Leer_registros_boton.Text = "Leer Registros ";
            this.Leer_registros_boton.UseVisualStyleBackColor = false;
            this.Leer_registros_boton.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Leer_registros_boton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(25, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // Compania
            // 
            this.Compania.FormattingEnabled = true;
            this.Compania.Items.AddRange(new object[] {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc.",
            "Sega",
            "Sony"});
            this.Compania.Location = new System.Drawing.Point(164, 180);
            this.Compania.Name = "Compania";
            this.Compania.Size = new System.Drawing.Size(200, 21);
            this.Compania.TabIndex = 7;
            // 
            // Ano_lanzamiento
            // 
            this.Ano_lanzamiento.CustomFormat = "yyyy";
            this.Ano_lanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ano_lanzamiento.Location = new System.Drawing.Point(164, 228);
            this.Ano_lanzamiento.Name = "Ano_lanzamiento";
            this.Ano_lanzamiento.Size = new System.Drawing.Size(200, 20);
            this.Ano_lanzamiento.TabIndex = 8;
            // 
            // Generacion_numeric
            // 
            this.Generacion_numeric.Location = new System.Drawing.Point(164, 285);
            this.Generacion_numeric.Name = "Generacion_numeric";
            this.Generacion_numeric.Size = new System.Drawing.Size(200, 20);
            this.Generacion_numeric.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(986, 533);
            this.Controls.Add(this.Generacion_numeric);
            this.Controls.Add(this.Ano_lanzamiento);
            this.Controls.Add(this.Compania);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Consolas);
            this.Controls.Add(this.Nombre_de_Consola);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ID_Consola);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consolas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Generacion_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_Consola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre_de_Consola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_Consolas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Leer_registros_boton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Compania;
        private System.Windows.Forms.DateTimePicker Ano_lanzamiento;
        private System.Windows.Forms.NumericUpDown Generacion_numeric;
    }
}

