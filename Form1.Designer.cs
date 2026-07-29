namespace CalculadoraCientificaPOO104
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbpDatos = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.gbpBasicas = new System.Windows.Forms.GroupBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.gbpCientificas = new System.Windows.Forms.GroupBox();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnCoseno = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnLog10 = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnAbsoluto = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRaizCubica = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbpDatos.SuspendLayout();
            this.gbpBasicas.SuspendLayout();
            this.gbpCientificas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(278, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(230, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora Cientifica";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // gbpDatos
            // 
            this.gbpDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbpDatos.Controls.Add(this.txtResultado);
            this.gbpDatos.Controls.Add(this.lblResultado);
            this.gbpDatos.Controls.Add(this.txtNum2);
            this.gbpDatos.Controls.Add(this.lblNum2);
            this.gbpDatos.Controls.Add(this.txtNum1);
            this.gbpDatos.Controls.Add(this.lblNum1);
            this.gbpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpDatos.Location = new System.Drawing.Point(227, 52);
            this.gbpDatos.Name = "gbpDatos";
            this.gbpDatos.Size = new System.Drawing.Size(353, 139);
            this.gbpDatos.TabIndex = 1;
            this.gbpDatos.TabStop = false;
            this.gbpDatos.Text = "Datos de Entrada";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResultado.Location = new System.Drawing.Point(226, 47);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(235, 28);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.SystemColors.Info;
            this.txtNum2.Location = new System.Drawing.Point(86, 66);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(7, 66);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(77, 16);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Numero 2:";
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.SystemColors.Info;
            this.txtNum1.Location = new System.Drawing.Point(86, 28);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 1;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(7, 31);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(77, 16);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Numero 1:";
            // 
            // gbpBasicas
            // 
            this.gbpBasicas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbpBasicas.Controls.Add(this.lblDivision);
            this.gbpBasicas.Controls.Add(this.lblMulti);
            this.gbpBasicas.Controls.Add(this.lblResta);
            this.gbpBasicas.Controls.Add(this.lblSuma);
            this.gbpBasicas.Controls.Add(this.btnDiv);
            this.gbpBasicas.Controls.Add(this.btnMulti);
            this.gbpBasicas.Controls.Add(this.btnResta);
            this.gbpBasicas.Controls.Add(this.btnSuma);
            this.gbpBasicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpBasicas.Location = new System.Drawing.Point(39, 233);
            this.gbpBasicas.Name = "gbpBasicas";
            this.gbpBasicas.Size = new System.Drawing.Size(261, 207);
            this.gbpBasicas.TabIndex = 2;
            this.gbpBasicas.TabStop = false;
            this.gbpBasicas.Text = "Operaciones Basicas";
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(156, 131);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(156, 100);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(156, 65);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(156, 34);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // gbpCientificas
            // 
            this.gbpCientificas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbpCientificas.Controls.Add(this.btnRaizCubica);
            this.gbpCientificas.Controls.Add(this.btnModulo);
            this.gbpCientificas.Controls.Add(this.btnFactorial);
            this.gbpCientificas.Controls.Add(this.btnExp);
            this.gbpCientificas.Controls.Add(this.btnTangente);
            this.gbpCientificas.Controls.Add(this.btnCoseno);
            this.gbpCientificas.Controls.Add(this.btnSeno);
            this.gbpCientificas.Controls.Add(this.btnLog10);
            this.gbpCientificas.Controls.Add(this.btnLn);
            this.gbpCientificas.Controls.Add(this.btnAbsoluto);
            this.gbpCientificas.Controls.Add(this.btnRaizCuadrada);
            this.gbpCientificas.Controls.Add(this.btnPotencia);
            this.gbpCientificas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpCientificas.Location = new System.Drawing.Point(374, 233);
            this.gbpCientificas.Name = "gbpCientificas";
            this.gbpCientificas.Size = new System.Drawing.Size(326, 207);
            this.gbpCientificas.TabIndex = 3;
            this.gbpCientificas.TabStop = false;
            this.gbpCientificas.Text = "Operaciones Cientificas";
            this.gbpCientificas.Enter += new System.EventHandler(this.gbpCientificas_Enter);
            // 
            // btnModulo
            // 
            this.btnModulo.Location = new System.Drawing.Point(238, 67);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(75, 23);
            this.btnModulo.TabIndex = 10;
            this.btnModulo.Text = "Módulo (%)";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(238, 35);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(75, 23);
            this.btnFactorial.TabIndex = 9;
            this.btnFactorial.Text = "x!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(141, 163);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(75, 23);
            this.btnExp.TabIndex = 8;
            this.btnExp.Text = "e^x";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.Location = new System.Drawing.Point(141, 133);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(75, 23);
            this.btnTangente.TabIndex = 7;
            this.btnTangente.Text = "Tangente";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // btnCoseno
            // 
            this.btnCoseno.Location = new System.Drawing.Point(141, 96);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(75, 23);
            this.btnCoseno.TabIndex = 6;
            this.btnCoseno.Text = "Coseno";
            this.btnCoseno.UseVisualStyleBackColor = true;
            this.btnCoseno.Click += new System.EventHandler(this.btnCoseno_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Location = new System.Drawing.Point(141, 66);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(75, 23);
            this.btnSeno.TabIndex = 5;
            this.btnSeno.Text = "Seno";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnLog10
            // 
            this.btnLog10.Location = new System.Drawing.Point(141, 34);
            this.btnLog10.Name = "btnLog10";
            this.btnLog10.Size = new System.Drawing.Size(75, 26);
            this.btnLog10.TabIndex = 4;
            this.btnLog10.Text = "Log10";
            this.btnLog10.UseVisualStyleBackColor = true;
            this.btnLog10.Click += new System.EventHandler(this.btnLog10_Click);
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(18, 162);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(75, 23);
            this.btnLn.TabIndex = 3;
            this.btnLn.Text = "Ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnAbsoluto
            // 
            this.btnAbsoluto.Location = new System.Drawing.Point(18, 132);
            this.btnAbsoluto.Name = "btnAbsoluto";
            this.btnAbsoluto.Size = new System.Drawing.Size(87, 23);
            this.btnAbsoluto.TabIndex = 2;
            this.btnAbsoluto.Text = "Absoluto |x|";
            this.btnAbsoluto.UseVisualStyleBackColor = true;
            this.btnAbsoluto.Click += new System.EventHandler(this.btnAbsoluto_Click);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Location = new System.Drawing.Point(18, 67);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(75, 23);
            this.btnRaizCuadrada.TabIndex = 1;
            this.btnRaizCuadrada.Text = "Raíz Cuadrada";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.btnRaizCuadrada_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(18, 35);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 23);
            this.btnPotencia.TabIndex = 0;
            this.btnPotencia.Text = "Potencia (x^y)";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Location = new System.Drawing.Point(718, 337);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Brown;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(718, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRaizCubica
            // 
            this.btnRaizCubica.Location = new System.Drawing.Point(18, 95);
            this.btnRaizCubica.Name = "btnRaizCubica";
            this.btnRaizCubica.Size = new System.Drawing.Size(87, 23);
            this.btnRaizCubica.TabIndex = 11;
            this.btnRaizCubica.Text = "Raiz Cubica";
            this.btnRaizCubica.UseVisualStyleBackColor = true;
            this.btnRaizCubica.Click += new System.EventHandler(this.btnRaizCubica_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(103, 35);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(42, 16);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "Suma";
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(102, 67);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(43, 16);
            this.lblResta.TabIndex = 5;
            this.lblResta.Text = "Resta";
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(62, 107);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(88, 16);
            this.lblMulti.TabIndex = 6;
            this.lblMulti.Text = "Multiplicacion";
            this.lblMulti.Click += new System.EventHandler(this.lblMulti_Click);
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(93, 138);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(55, 16);
            this.lblDivision.TabIndex = 7;
            this.lblDivision.Text = "Division";
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(191, 207);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(467, 23);
            this.lblIndicacion.TabIndex = 6;
            this.lblIndicacion.Text = "Para realizar la operacion presione el boton blanco con la operacion deseada";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadoraCientificaPOO104.Properties.Resources.adorable_calculator_companions_cute_cartoon_calculator_characters_vector;
            this.pictureBox1.Location = new System.Drawing.Point(53, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbpCientificas);
            this.Controls.Add(this.gbpBasicas);
            this.Controls.Add(this.gbpDatos);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.Text = "Calculadora Cientifica POO104";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbpDatos.ResumeLayout(false);
            this.gbpDatos.PerformLayout();
            this.gbpBasicas.ResumeLayout(false);
            this.gbpBasicas.PerformLayout();
            this.gbpCientificas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbpDatos;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.GroupBox gbpBasicas;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.GroupBox gbpCientificas;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnAbsoluto;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnLog10;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnCoseno;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRaizCubica;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

