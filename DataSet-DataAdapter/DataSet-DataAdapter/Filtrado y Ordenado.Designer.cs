namespace DataSet_DataAdapter
{
    partial class FiltradoOrdenado
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
            this.txtOrdenar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOrdenar
            // 
            this.txtOrdenar.Location = new System.Drawing.Point(24, 23);
            this.txtOrdenar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOrdenar.Multiline = true;
            this.txtOrdenar.Name = "txtOrdenar";
            this.txtOrdenar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrdenar.Size = new System.Drawing.Size(764, 577);
            this.txtOrdenar.TabIndex = 0;
            // 
            // FiltradoOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 627);
            this.Controls.Add(this.txtOrdenar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FiltradoOrdenado";
            this.Text = "Filtrado y Ordenado de un Data Set";
            this.Load += new System.EventHandler(this.FiltradoOrdenado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrdenar;
    }
}