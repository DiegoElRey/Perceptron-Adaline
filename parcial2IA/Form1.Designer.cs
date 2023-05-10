namespace parcial2IA
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.labelAbrir = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelEntradas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSalidas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPatrones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxAlgoritmoEntrenaimento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbFuncionActivacion = new System.Windows.Forms.TextBox();
            this.textTipoRed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbErrorMax = new System.Windows.Forms.TextBox();
            this.tbNumeroIteracion = new System.Windows.Forms.TextBox();
            this.tbRtAprendizaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEntrenar = new System.Windows.Forms.Button();
            this.chartGraphicRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphicRed)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAbrir
            // 
            this.labelAbrir.AutoSize = true;
            this.labelAbrir.ForeColor = System.Drawing.Color.White;
            this.labelAbrir.Location = new System.Drawing.Point(93, 17);
            this.labelAbrir.Name = "labelAbrir";
            this.labelAbrir.Size = new System.Drawing.Size(0, 13);
            this.labelAbrir.TabIndex = 1;
            this.labelAbrir.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivo TXT(*.txt)|*.txt";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 562);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(414, 15);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // labelEntradas
            // 
            this.labelEntradas.AutoSize = true;
            this.labelEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEntradas.ForeColor = System.Drawing.Color.White;
            this.labelEntradas.Location = new System.Drawing.Point(63, 9);
            this.labelEntradas.Name = "labelEntradas";
            this.labelEntradas.Size = new System.Drawing.Size(15, 15);
            this.labelEntradas.TabIndex = 4;
            this.labelEntradas.Text = "0";
            this.labelEntradas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelEntradas.Click += new System.EventHandler(this.labelEntradas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salidas:";
            // 
            // labelSalidas
            // 
            this.labelSalidas.AutoSize = true;
            this.labelSalidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSalidas.ForeColor = System.Drawing.Color.White;
            this.labelSalidas.Location = new System.Drawing.Point(232, 9);
            this.labelSalidas.Name = "labelSalidas";
            this.labelSalidas.Size = new System.Drawing.Size(15, 15);
            this.labelSalidas.TabIndex = 6;
            this.labelSalidas.Text = "0";
            this.labelSalidas.Click += new System.EventHandler(this.labelSalidas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(338, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Patrones:";
            // 
            // labelPatrones
            // 
            this.labelPatrones.AutoSize = true;
            this.labelPatrones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPatrones.ForeColor = System.Drawing.Color.White;
            this.labelPatrones.Location = new System.Drawing.Point(388, 9);
            this.labelPatrones.Name = "labelPatrones";
            this.labelPatrones.Size = new System.Drawing.Size(15, 15);
            this.labelPatrones.TabIndex = 8;
            this.labelPatrones.Text = "0";
            this.labelPatrones.Click += new System.EventHandler(this.labelPatrones_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo de red:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Algoritmo de entrenamiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Función de activación:";
            // 
            // comboBoxAlgoritmoEntrenaimento
            // 
            this.comboBoxAlgoritmoEntrenaimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAlgoritmoEntrenaimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgoritmoEntrenaimento.FormattingEnabled = true;
            this.comboBoxAlgoritmoEntrenaimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxAlgoritmoEntrenaimento.Items.AddRange(new object[] {
            "Perceptron",
            "Adaline"});
            this.comboBoxAlgoritmoEntrenaimento.Location = new System.Drawing.Point(218, 51);
            this.comboBoxAlgoritmoEntrenaimento.Name = "comboBoxAlgoritmoEntrenaimento";
            this.comboBoxAlgoritmoEntrenaimento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlgoritmoEntrenaimento.TabIndex = 13;
            this.comboBoxAlgoritmoEntrenaimento.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgoritmoEntrenaimento_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Entradas:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labelEntradas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelSalidas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelPatrones);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 30);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbFuncionActivacion);
            this.panel2.Controls.Add(this.textTipoRed);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBoxAlgoritmoEntrenaimento);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 128);
            this.panel2.TabIndex = 17;
            // 
            // tbFuncionActivacion
            // 
            this.tbFuncionActivacion.Cursor = System.Windows.Forms.Cursors.No;
            this.tbFuncionActivacion.Enabled = false;
            this.tbFuncionActivacion.Location = new System.Drawing.Point(218, 83);
            this.tbFuncionActivacion.Name = "tbFuncionActivacion";
            this.tbFuncionActivacion.Size = new System.Drawing.Size(121, 20);
            this.tbFuncionActivacion.TabIndex = 17;
            // 
            // textTipoRed
            // 
            this.textTipoRed.Cursor = System.Windows.Forms.Cursors.No;
            this.textTipoRed.Enabled = false;
            this.textTipoRed.Location = new System.Drawing.Point(218, 22);
            this.textTipoRed.Name = "textTipoRed";
            this.textTipoRed.Size = new System.Drawing.Size(121, 20);
            this.textTipoRed.TabIndex = 16;
            this.textTipoRed.Text = "Monocapa";
            this.textTipoRed.TextChanged += new System.EventHandler(this.textTipoRed_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Error máximo permitido:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Número máximo de iteraciones:";
            // 
            // tbErrorMax
            // 
            this.tbErrorMax.Location = new System.Drawing.Point(174, 249);
            this.tbErrorMax.Name = "tbErrorMax";
            this.tbErrorMax.Size = new System.Drawing.Size(100, 20);
            this.tbErrorMax.TabIndex = 21;
            this.tbErrorMax.TextChanged += new System.EventHandler(this.tbErrorMax_TextChanged);
            // 
            // tbNumeroIteracion
            // 
            this.tbNumeroIteracion.Location = new System.Drawing.Point(174, 227);
            this.tbNumeroIteracion.Name = "tbNumeroIteracion";
            this.tbNumeroIteracion.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroIteracion.TabIndex = 22;
            this.tbNumeroIteracion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbRtAprendizaje
            // 
            this.tbRtAprendizaje.Location = new System.Drawing.Point(174, 271);
            this.tbRtAprendizaje.Name = "tbRtAprendizaje";
            this.tbRtAprendizaje.Size = new System.Drawing.Size(100, 20);
            this.tbRtAprendizaje.TabIndex = 25;
            this.tbRtAprendizaje.TextChanged += new System.EventHandler(this.tbRtAprendizaje_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rata aprendizaje:";
            // 
            // buttonEntrenar
            // 
            this.buttonEntrenar.BackColor = System.Drawing.Color.White;
            this.buttonEntrenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntrenar.Enabled = false;
            this.buttonEntrenar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrenar.Location = new System.Drawing.Point(302, 227);
            this.buttonEntrenar.Name = "buttonEntrenar";
            this.buttonEntrenar.Size = new System.Drawing.Size(126, 64);
            this.buttonEntrenar.TabIndex = 23;
            this.buttonEntrenar.Text = "Entrenar";
            this.buttonEntrenar.UseVisualStyleBackColor = false;
            this.buttonEntrenar.BackColorChanged += new System.EventHandler(this.green);
            this.buttonEntrenar.Click += new System.EventHandler(this.buttonEntrenar_Click);
            // 
            // chartGraphicRed
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraphicRed.ChartAreas.Add(chartArea1);
            this.chartGraphicRed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chartGraphicRed.Legends.Add(legend1);
            this.chartGraphicRed.Location = new System.Drawing.Point(12, 297);
            this.chartGraphicRed.Name = "chartGraphicRed";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series3";
            this.chartGraphicRed.Series.Add(series1);
            this.chartGraphicRed.Size = new System.Drawing.Size(414, 259);
            this.chartGraphicRed.TabIndex = 26;
            this.chartGraphicRed.Text = "chart1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(440, 589);
            this.Controls.Add(this.chartGraphicRed);
            this.Controls.Add(this.tbRtAprendizaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEntrenar);
            this.Controls.Add(this.tbNumeroIteracion);
            this.Controls.Add(this.tbErrorMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelAbrir);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Entrenamiento de la red";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphicRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelEntradas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSalidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPatrones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxAlgoritmoEntrenaimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbErrorMax;
        private System.Windows.Forms.TextBox tbNumeroIteracion;
        private System.Windows.Forms.TextBox textTipoRed;
        private System.Windows.Forms.TextBox tbFuncionActivacion;
        private System.Windows.Forms.TextBox tbRtAprendizaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEntrenar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphicRed;
    }
}

