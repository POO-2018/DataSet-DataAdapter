namespace DataSet_DataAdapter
{
    partial class DataViewForm
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
            this.gvContactos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvContactos
            // 
            this.gvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContactos.Location = new System.Drawing.Point(24, 23);
            this.gvContactos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gvContactos.Name = "gvContactos";
            this.gvContactos.Size = new System.Drawing.Size(1040, 598);
            this.gvContactos.TabIndex = 0;
            // 
            // DataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 644);
            this.Controls.Add(this.gvContactos);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DataViewForm";
            this.Text = "Data View";
            this.Load += new System.EventHandler(this.DataViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvContactos;
    }
}