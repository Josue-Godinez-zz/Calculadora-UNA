namespace Calculadora
{
    partial class CalculadoraForm
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.principalTabControl = new System.Windows.Forms.TabControl();
            this.trianguloTabPage = new System.Windows.Forms.TabPage();
            this.cuadroTabPage = new System.Windows.Forms.TabPage();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.calcularPerimetroButton = new System.Windows.Forms.Button();
            this.calcularAreaButton = new System.Windows.Forms.Button();
            this.principalTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(248, 20);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(129, 13);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Calculadora De Poligonos";
            // 
            // principalTabControl
            // 
            this.principalTabControl.Controls.Add(this.trianguloTabPage);
            this.principalTabControl.Controls.Add(this.cuadroTabPage);
            this.principalTabControl.Controls.Add(this.circuloTabPage);
            this.principalTabControl.Controls.Add(this.rectanguloTabPage);
            this.principalTabControl.Controls.Add(this.pentagonoTabPage);
            this.principalTabControl.Location = new System.Drawing.Point(44, 54);
            this.principalTabControl.Name = "principalTabControl";
            this.principalTabControl.SelectedIndex = 0;
            this.principalTabControl.Size = new System.Drawing.Size(430, 282);
            this.principalTabControl.TabIndex = 1;
            // 
            // trianguloTabPage
            // 
            this.trianguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.trianguloTabPage.Name = "trianguloTabPage";
            this.trianguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trianguloTabPage.Size = new System.Drawing.Size(422, 256);
            this.trianguloTabPage.TabIndex = 0;
            this.trianguloTabPage.Text = "Triangulo";
            this.trianguloTabPage.UseVisualStyleBackColor = true;
            // 
            // cuadroTabPage
            // 
            this.cuadroTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadroTabPage.Name = "cuadroTabPage";
            this.cuadroTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadroTabPage.Size = new System.Drawing.Size(422, 256);
            this.cuadroTabPage.TabIndex = 1;
            this.cuadroTabPage.Text = "Cuadro";
            this.cuadroTabPage.UseVisualStyleBackColor = true;
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.circuloTabPage.Size = new System.Drawing.Size(422, 256);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanguloTabPage.Name = "rectanguloTabPage";
            this.rectanguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rectanguloTabPage.Size = new System.Drawing.Size(422, 256);
            this.rectanguloTabPage.TabIndex = 3;
            this.rectanguloTabPage.Text = "Rectangulo";
            this.rectanguloTabPage.UseVisualStyleBackColor = true;
            // 
            // pentagonoTabPage
            // 
            this.pentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTabPage.Name = "pentagonoTabPage";
            this.pentagonoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pentagonoTabPage.Size = new System.Drawing.Size(422, 256);
            this.pentagonoTabPage.TabIndex = 4;
            this.pentagonoTabPage.Text = "Pentagono";
            this.pentagonoTabPage.UseVisualStyleBackColor = true;
            // 
            // calcularPerimetroButton
            // 
            this.calcularPerimetroButton.Location = new System.Drawing.Point(494, 115);
            this.calcularPerimetroButton.Name = "calcularPerimetroButton";
            this.calcularPerimetroButton.Size = new System.Drawing.Size(111, 23);
            this.calcularPerimetroButton.TabIndex = 2;
            this.calcularPerimetroButton.Text = "Calcular Perimetro";
            this.calcularPerimetroButton.UseVisualStyleBackColor = true;
            this.calcularPerimetroButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // calcularAreaButton
            // 
            this.calcularAreaButton.Location = new System.Drawing.Point(494, 206);
            this.calcularAreaButton.Name = "calcularAreaButton";
            this.calcularAreaButton.Size = new System.Drawing.Size(111, 23);
            this.calcularAreaButton.TabIndex = 3;
            this.calcularAreaButton.Text = "Calcular Area";
            this.calcularAreaButton.UseVisualStyleBackColor = true;
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 385);
            this.Controls.Add(this.calcularAreaButton);
            this.Controls.Add(this.calcularPerimetroButton);
            this.Controls.Add(this.principalTabControl);
            this.Controls.Add(this.tituloLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora de Poligonos";
            this.principalTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TabControl principalTabControl;
        private System.Windows.Forms.TabPage trianguloTabPage;
        private System.Windows.Forms.TabPage cuadroTabPage;
        private System.Windows.Forms.TabPage circuloTabPage;
        private System.Windows.Forms.TabPage rectanguloTabPage;
        private System.Windows.Forms.TabPage pentagonoTabPage;
        private System.Windows.Forms.Button calcularPerimetroButton;
        private System.Windows.Forms.Button calcularAreaButton;
    }
}

