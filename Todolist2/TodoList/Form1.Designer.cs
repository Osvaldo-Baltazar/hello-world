namespace TodoData1
{
    partial class FrmMain
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
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.LblOption = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.BtnEnter1 = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.cmd_Menu = new System.Windows.Forms.Button();
            this.Txt_Menu = new System.Windows.Forms.TextBox();
            this.lbl_CambiarEs = new System.Windows.Forms.Label();
            this.txt_CambiarEs = new System.Windows.Forms.TextBox();
            this.BrnUpdate = new System.Windows.Forms.Button();
            this.Cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuser,
            this.Cfecha,
            this.Cname,
            this.Cdescripcion,
            this.Chour,
            this.Cstatus});
            this.DgvData.Location = new System.Drawing.Point(29, 85);
            this.DgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersWidth = 49;
            this.DgvData.RowTemplate.Height = 24;
            this.DgvData.Size = new System.Drawing.Size(772, 111);
            this.DgvData.TabIndex = 2;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick_1);
            // 
            // LblOption
            // 
            this.LblOption.AutoSize = true;
            this.LblOption.Location = new System.Drawing.Point(386, 224);
            this.LblOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOption.Name = "LblOption";
            this.LblOption.Size = new System.Drawing.Size(38, 13);
            this.LblOption.TabIndex = 1;
            this.LblOption.Text = "&Option";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(389, 263);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 20);
            this.textBox11.TabIndex = 0;
            // 
            // BtnEnter1
            // 
            this.BtnEnter1.Location = new System.Drawing.Point(237, 26);
            this.BtnEnter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEnter1.Name = "BtnEnter1";
            this.BtnEnter1.Size = new System.Drawing.Size(74, 32);
            this.BtnEnter1.TabIndex = 3;
            this.BtnEnter1.Text = "&Ingresar";
            this.BtnEnter1.UseVisualStyleBackColor = true;
            this.BtnEnter1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEnd.Location = new System.Drawing.Point(727, 377);
            this.BtnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(74, 32);
            this.BtnEnd.TabIndex = 4;
            this.BtnEnd.Text = "&Salir";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // cmd_Menu
            // 
            this.cmd_Menu.Location = new System.Drawing.Point(29, 26);
            this.cmd_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmd_Menu.Name = "cmd_Menu";
            this.cmd_Menu.Size = new System.Drawing.Size(74, 32);
            this.cmd_Menu.TabIndex = 5;
            this.cmd_Menu.Text = "&Menu";
            this.cmd_Menu.UseVisualStyleBackColor = true;
            this.cmd_Menu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // Txt_Menu
            // 
            this.Txt_Menu.Enabled = false;
            this.Txt_Menu.Location = new System.Drawing.Point(33, 221);
            this.Txt_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Menu.Multiline = true;
            this.Txt_Menu.Name = "Txt_Menu";
            this.Txt_Menu.Size = new System.Drawing.Size(70, 123);
            this.Txt_Menu.TabIndex = 6;
            // 
            // lbl_CambiarEs
            // 
            this.lbl_CambiarEs.AutoSize = true;
            this.lbl_CambiarEs.Location = new System.Drawing.Point(176, 224);
            this.lbl_CambiarEs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CambiarEs.Name = "lbl_CambiarEs";
            this.lbl_CambiarEs.Size = new System.Drawing.Size(82, 13);
            this.lbl_CambiarEs.TabIndex = 7;
            this.lbl_CambiarEs.Text = "&Cambiar estatus";
            // 
            // txt_CambiarEs
            // 
            this.txt_CambiarEs.Location = new System.Drawing.Point(179, 263);
            this.txt_CambiarEs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_CambiarEs.Name = "txt_CambiarEs";
            this.txt_CambiarEs.Size = new System.Drawing.Size(76, 20);
            this.txt_CambiarEs.TabIndex = 8;
            // 
            // BrnUpdate
            // 
            this.BrnUpdate.Location = new System.Drawing.Point(181, 312);
            this.BrnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrnUpdate.Name = "BrnUpdate";
            this.BrnUpdate.Size = new System.Drawing.Size(74, 32);
            this.BrnUpdate.TabIndex = 9;
            this.BrnUpdate.Text = "&Update";
            this.BrnUpdate.UseVisualStyleBackColor = true;
            this.BrnUpdate.Click += new System.EventHandler(this.BrnUpdate_Click);
            // 
            // Cuser
            // 
            this.Cuser.HeaderText = "Nombre";
            this.Cuser.MinimumWidth = 6;
            this.Cuser.Name = "Cuser";
            this.Cuser.ReadOnly = true;
            this.Cuser.Width = 120;
            // 
            // Cfecha
            // 
            this.Cfecha.HeaderText = "Usuario";
            this.Cfecha.MinimumWidth = 6;
            this.Cfecha.Name = "Cfecha";
            this.Cfecha.ReadOnly = true;
            this.Cfecha.Width = 120;
            // 
            // Cname
            // 
            this.Cname.HeaderText = "Nombre de la tarea";
            this.Cname.MinimumWidth = 6;
            this.Cname.Name = "Cname";
            this.Cname.ReadOnly = true;
            this.Cname.Width = 120;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.HeaderText = "Detalle";
            this.Cdescripcion.MinimumWidth = 6;
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            this.Cdescripcion.Width = 120;
            // 
            // Chour
            // 
            this.Chour.HeaderText = "Hora";
            this.Chour.MinimumWidth = 6;
            this.Chour.Name = "Chour";
            this.Chour.ReadOnly = true;
            this.Chour.Width = 120;
            // 
            // Cstatus
            // 
            this.Cstatus.HeaderText = "Estatus";
            this.Cstatus.MinimumWidth = 6;
            this.Cstatus.Name = "Cstatus";
            this.Cstatus.ReadOnly = true;
            this.Cstatus.Width = 120;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnEnter1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnEnd;
            this.ClientSize = new System.Drawing.Size(830, 420);
            this.Controls.Add(this.BrnUpdate);
            this.Controls.Add(this.txt_CambiarEs);
            this.Controls.Add(this.lbl_CambiarEs);
            this.Controls.Add(this.Txt_Menu);
            this.Controls.Add(this.cmd_Menu);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnEnter1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.LblOption);
            this.Controls.Add(this.DgvData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label LblOption;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button BtnEnter1;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button cmd_Menu;
        private System.Windows.Forms.TextBox Txt_Menu;
        private System.Windows.Forms.Label lbl_CambiarEs;
        private System.Windows.Forms.TextBox txt_CambiarEs;
        private System.Windows.Forms.Button BrnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cstatus;
    }
}

