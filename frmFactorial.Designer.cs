namespace FactorialParallel_Tasks
{
    partial class frmFactorial
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
            btnCalcular = new Button();
            txtNumero = new TextBox();
            lblResultados = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(505, 79);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(276, 110);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(62, 115);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(404, 39);
            txtNumero.TabIndex = 1;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(335, 336);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(19, 32);
            lblResultados.TabIndex = 2;
            lblResultados.Text = ".";
            // 
            // frmFactorial
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 589);
            Controls.Add(lblResultados);
            Controls.Add(txtNumero);
            Controls.Add(btnCalcular);
            Name = "frmFactorial";
            Text = "frmFactorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNumero;
        private Label lblResultados;
    }
}