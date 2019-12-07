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
            this.valorLadoIzqTextBox = new System.Windows.Forms.TextBox();
            this.valorBaseTextBox = new System.Windows.Forms.TextBox();
            this.valorLadoDerTextBox = new System.Windows.Forms.TextBox();
            this.alturaLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.lado2Label = new System.Windows.Forms.Label();
            this.lado1Label = new System.Windows.Forms.Label();
            this.cuadroTabPage = new System.Windows.Forms.TabPage();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.ladoLabel = new System.Windows.Forms.Label();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.radioLabel = new System.Windows.Forms.Label();
            this.valorRadioTextBox = new System.Windows.Forms.TextBox();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.calcularPerimetroButton = new System.Windows.Forms.Button();
            this.calcularAreaButton = new System.Windows.Forms.Button();
            this.valorAlturaTextBox = new System.Windows.Forms.TextBox();
            this.valorLargoTextBox = new System.Windows.Forms.TextBox();
            this.valorAnchoTextBox = new System.Windows.Forms.TextBox();
            this.largoLabel = new System.Windows.Forms.Label();
            this.anchoLabel = new System.Windows.Forms.Label();
            this.valorLadoLabel = new System.Windows.Forms.Label();
            this.valorApotemaLabel = new System.Windows.Forms.Label();
            this.valorApotemaTextBox = new System.Windows.Forms.TextBox();
            this.valorLadoTextBox = new System.Windows.Forms.TextBox();
            this.principalTabControl.SuspendLayout();
            this.trianguloTabPage.SuspendLayout();
            this.cuadroTabPage.SuspendLayout();
            this.circuloTabPage.SuspendLayout();
            this.rectanguloTabPage.SuspendLayout();
            this.pentagonoTabPage.SuspendLayout();
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
            this.trianguloTabPage.Controls.Add(this.valorAlturaTextBox);
            this.trianguloTabPage.Controls.Add(this.valorLadoIzqTextBox);
            this.trianguloTabPage.Controls.Add(this.valorBaseTextBox);
            this.trianguloTabPage.Controls.Add(this.valorLadoDerTextBox);
            this.trianguloTabPage.Controls.Add(this.alturaLabel);
            this.trianguloTabPage.Controls.Add(this.baseLabel);
            this.trianguloTabPage.Controls.Add(this.lado2Label);
            this.trianguloTabPage.Controls.Add(this.lado1Label);
            this.trianguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.trianguloTabPage.Name = "trianguloTabPage";
            this.trianguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trianguloTabPage.Size = new System.Drawing.Size(422, 256);
            this.trianguloTabPage.TabIndex = 0;
            this.trianguloTabPage.Text = "Triangulo";
            this.trianguloTabPage.UseVisualStyleBackColor = true;
            // 
            // valorLadoIzqTextBox
            // 
            this.valorLadoIzqTextBox.Location = new System.Drawing.Point(118, 26);
            this.valorLadoIzqTextBox.Name = "valorLadoIzqTextBox";
            this.valorLadoIzqTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorLadoIzqTextBox.TabIndex = 6;
            // 
            // valorBaseTextBox
            // 
            this.valorBaseTextBox.Location = new System.Drawing.Point(118, 84);
            this.valorBaseTextBox.Name = "valorBaseTextBox";
            this.valorBaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorBaseTextBox.TabIndex = 5;
            // 
            // valorLadoDerTextBox
            // 
            this.valorLadoDerTextBox.Location = new System.Drawing.Point(118, 55);
            this.valorLadoDerTextBox.Name = "valorLadoDerTextBox";
            this.valorLadoDerTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorLadoDerTextBox.TabIndex = 4;
            // 
            // alturaLabel
            // 
            this.alturaLabel.AutoSize = true;
            this.alturaLabel.Location = new System.Drawing.Point(25, 119);
            this.alturaLabel.Name = "alturaLabel";
            this.alturaLabel.Size = new System.Drawing.Size(34, 13);
            this.alturaLabel.TabIndex = 3;
            this.alturaLabel.Text = "Altura";
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(25, 87);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(31, 13);
            this.baseLabel.TabIndex = 2;
            this.baseLabel.Text = "Base";
            // 
            // lado2Label
            // 
            this.lado2Label.AutoSize = true;
            this.lado2Label.Location = new System.Drawing.Point(25, 58);
            this.lado2Label.Name = "lado2Label";
            this.lado2Label.Size = new System.Drawing.Size(75, 13);
            this.lado2Label.TabIndex = 1;
            this.lado2Label.Text = "Lado Derecho";
            // 
            // lado1Label
            // 
            this.lado1Label.AutoSize = true;
            this.lado1Label.Location = new System.Drawing.Point(25, 29);
            this.lado1Label.Name = "lado1Label";
            this.lado1Label.Size = new System.Drawing.Size(77, 13);
            this.lado1Label.TabIndex = 0;
            this.lado1Label.Text = "Lado Izquierdo";
            // 
            // cuadroTabPage
            // 
            this.cuadroTabPage.Controls.Add(this.valorTextBox);
            this.cuadroTabPage.Controls.Add(this.ladoLabel);
            this.cuadroTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadroTabPage.Name = "cuadroTabPage";
            this.cuadroTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadroTabPage.Size = new System.Drawing.Size(422, 256);
            this.cuadroTabPage.TabIndex = 1;
            this.cuadroTabPage.Text = "Cuadro";
            this.cuadroTabPage.UseVisualStyleBackColor = true;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(54, 24);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(139, 20);
            this.valorTextBox.TabIndex = 1;
            // 
            // ladoLabel
            // 
            this.ladoLabel.AutoSize = true;
            this.ladoLabel.Location = new System.Drawing.Point(17, 27);
            this.ladoLabel.Name = "ladoLabel";
            this.ladoLabel.Size = new System.Drawing.Size(31, 13);
            this.ladoLabel.TabIndex = 0;
            this.ladoLabel.Text = "Lado";
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Controls.Add(this.radioLabel);
            this.circuloTabPage.Controls.Add(this.valorRadioTextBox);
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.circuloTabPage.Size = new System.Drawing.Size(422, 256);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // radioLabel
            // 
            this.radioLabel.AutoSize = true;
            this.radioLabel.Location = new System.Drawing.Point(26, 39);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(35, 13);
            this.radioLabel.TabIndex = 1;
            this.radioLabel.Text = "Radio";
            // 
            // valorRadioTextBox
            // 
            this.valorRadioTextBox.Location = new System.Drawing.Point(93, 36);
            this.valorRadioTextBox.Name = "valorRadioTextBox";
            this.valorRadioTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorRadioTextBox.TabIndex = 0;
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Controls.Add(this.anchoLabel);
            this.rectanguloTabPage.Controls.Add(this.largoLabel);
            this.rectanguloTabPage.Controls.Add(this.valorAnchoTextBox);
            this.rectanguloTabPage.Controls.Add(this.valorLargoTextBox);
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
            this.pentagonoTabPage.Controls.Add(this.valorLadoTextBox);
            this.pentagonoTabPage.Controls.Add(this.valorApotemaTextBox);
            this.pentagonoTabPage.Controls.Add(this.valorApotemaLabel);
            this.pentagonoTabPage.Controls.Add(this.valorLadoLabel);
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
            // valorAlturaTextBox
            // 
            this.valorAlturaTextBox.Location = new System.Drawing.Point(118, 116);
            this.valorAlturaTextBox.Name = "valorAlturaTextBox";
            this.valorAlturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorAlturaTextBox.TabIndex = 7;
            // 
            // valorLargoTextBox
            // 
            this.valorLargoTextBox.Location = new System.Drawing.Point(104, 29);
            this.valorLargoTextBox.Name = "valorLargoTextBox";
            this.valorLargoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorLargoTextBox.TabIndex = 0;
            // 
            // valorAnchoTextBox
            // 
            this.valorAnchoTextBox.Location = new System.Drawing.Point(104, 88);
            this.valorAnchoTextBox.Name = "valorAnchoTextBox";
            this.valorAnchoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorAnchoTextBox.TabIndex = 1;
            // 
            // largoLabel
            // 
            this.largoLabel.AutoSize = true;
            this.largoLabel.Location = new System.Drawing.Point(29, 32);
            this.largoLabel.Name = "largoLabel";
            this.largoLabel.Size = new System.Drawing.Size(34, 13);
            this.largoLabel.TabIndex = 2;
            this.largoLabel.Text = "Largo";
            // 
            // anchoLabel
            // 
            this.anchoLabel.AutoSize = true;
            this.anchoLabel.Location = new System.Drawing.Point(29, 91);
            this.anchoLabel.Name = "anchoLabel";
            this.anchoLabel.Size = new System.Drawing.Size(38, 13);
            this.anchoLabel.TabIndex = 3;
            this.anchoLabel.Text = "Ancho";
            // 
            // valorLadoLabel
            // 
            this.valorLadoLabel.AutoSize = true;
            this.valorLadoLabel.Location = new System.Drawing.Point(40, 27);
            this.valorLadoLabel.Name = "valorLadoLabel";
            this.valorLadoLabel.Size = new System.Drawing.Size(31, 13);
            this.valorLadoLabel.TabIndex = 0;
            this.valorLadoLabel.Text = "Lado";
            // 
            // valorApotemaLabel
            // 
            this.valorApotemaLabel.AutoSize = true;
            this.valorApotemaLabel.Location = new System.Drawing.Point(40, 92);
            this.valorApotemaLabel.Name = "valorApotemaLabel";
            this.valorApotemaLabel.Size = new System.Drawing.Size(49, 13);
            this.valorApotemaLabel.TabIndex = 1;
            this.valorApotemaLabel.Text = "Apotema";
            // 
            // valorApotemaTextBox
            // 
            this.valorApotemaTextBox.Location = new System.Drawing.Point(125, 89);
            this.valorApotemaTextBox.Name = "valorApotemaTextBox";
            this.valorApotemaTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorApotemaTextBox.TabIndex = 2;
            // 
            // valorLadoTextBox
            // 
            this.valorLadoTextBox.Location = new System.Drawing.Point(125, 24);
            this.valorLadoTextBox.Name = "valorLadoTextBox";
            this.valorLadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorLadoTextBox.TabIndex = 3;
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
            this.trianguloTabPage.ResumeLayout(false);
            this.trianguloTabPage.PerformLayout();
            this.cuadroTabPage.ResumeLayout(false);
            this.cuadroTabPage.PerformLayout();
            this.circuloTabPage.ResumeLayout(false);
            this.circuloTabPage.PerformLayout();
            this.rectanguloTabPage.ResumeLayout(false);
            this.rectanguloTabPage.PerformLayout();
            this.pentagonoTabPage.ResumeLayout(false);
            this.pentagonoTabPage.PerformLayout();
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
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label ladoLabel;
        private System.Windows.Forms.TextBox valorRadioTextBox;
        private System.Windows.Forms.Label radioLabel;
        private System.Windows.Forms.Label alturaLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label lado2Label;
        private System.Windows.Forms.Label lado1Label;
        private System.Windows.Forms.TextBox valorLadoIzqTextBox;
        private System.Windows.Forms.TextBox valorBaseTextBox;
        private System.Windows.Forms.TextBox valorLadoDerTextBox;
        private System.Windows.Forms.TextBox valorAlturaTextBox;
        private System.Windows.Forms.Label anchoLabel;
        private System.Windows.Forms.Label largoLabel;
        private System.Windows.Forms.TextBox valorAnchoTextBox;
        private System.Windows.Forms.TextBox valorLargoTextBox;
        private System.Windows.Forms.Label valorApotemaLabel;
        private System.Windows.Forms.Label valorLadoLabel;
        private System.Windows.Forms.TextBox valorLadoTextBox;
        private System.Windows.Forms.TextBox valorApotemaTextBox;
    }
}

