namespace TodoData1
{
    partial class FrmDataPrint
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
            this.TxtDataprint1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtDataprint1
            // 
            this.TxtDataprint1.Location = new System.Drawing.Point(3, -1);
            this.TxtDataprint1.Multiline = true;
            this.TxtDataprint1.Name = "TxtDataprint1";
            this.TxtDataprint1.Size = new System.Drawing.Size(563, 478);
            this.TxtDataprint1.TabIndex = 0;
            // 
            // FrmDataPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 478);
            this.Controls.Add(this.TxtDataprint1);
            this.Name = "FrmDataPrint";
            this.Text = "FrmDataPrint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtDataprint1;
    }
}