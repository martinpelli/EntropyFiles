
namespace Practico1_Ejercicio3_TDI
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
            this.loadFile1Button = new System.Windows.Forms.Button();
            this.loadFile2Button = new System.Windows.Forms.Button();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // loadFile1Button
            // 
            this.loadFile1Button.Location = new System.Drawing.Point(52, 113);
            this.loadFile1Button.Name = "loadFile1Button";
            this.loadFile1Button.Size = new System.Drawing.Size(142, 51);
            this.loadFile1Button.TabIndex = 0;
            this.loadFile1Button.Text = "Cargar Primer Archivo";
            this.loadFile1Button.UseVisualStyleBackColor = true;
            this.loadFile1Button.Click += new System.EventHandler(this.loadFile1Button_Click);
            // 
            // loadFile2Button
            // 
            this.loadFile2Button.Location = new System.Drawing.Point(276, 113);
            this.loadFile2Button.Name = "loadFile2Button";
            this.loadFile2Button.Size = new System.Drawing.Size(156, 51);
            this.loadFile2Button.TabIndex = 1;
            this.loadFile2Button.Text = "Cargar Segundo Archivo";
            this.loadFile2Button.UseVisualStyleBackColor = true;
            this.loadFile2Button.Click += new System.EventHandler(this.loadFile2Button_Click);
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.Location = new System.Drawing.Point(81, 38);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(328, 31);
            this.tittleLabel.TabIndex = 2;
            this.tittleLabel.Text = "Comparador De Entropías";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 218);
            this.Controls.Add(this.tittleLabel);
            this.Controls.Add(this.loadFile2Button);
            this.Controls.Add(this.loadFile1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFile1Button;
        private System.Windows.Forms.Button loadFile2Button;
        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

