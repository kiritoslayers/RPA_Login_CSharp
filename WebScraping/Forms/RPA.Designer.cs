namespace WebScraping.Forms
{
    partial class RPA
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
            this.tbUser = new Telerik.WinControls.UI.RadTextBox();
            this.tbPassword = new Telerik.WinControls.UI.RadTextBox();
            this.lbUsuario = new Telerik.WinControls.UI.RadLabel();
            this.lbSenha = new Telerik.WinControls.UI.RadLabel();
            this.btnLogar = new Telerik.WinControls.UI.RadButton();
            this.tbUrl = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(139, 133);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(238, 20);
            this.tbUser.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(139, 204);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(238, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Location = new System.Drawing.Point(139, 102);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(44, 18);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbSenha
            // 
            this.lbSenha.Location = new System.Drawing.Point(139, 180);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(37, 18);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha";
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(196, 289);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(110, 24);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Logar";
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(139, 64);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(238, 20);
            this.tbUrl.TabIndex = 5;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(139, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(26, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "URL";
            // 
            // RPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 356);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Name = "RPA";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RPA";
            ((System.ComponentModel.ISupportInitialize)(this.tbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox tbUser;
        private Telerik.WinControls.UI.RadTextBox tbPassword;
        private Telerik.WinControls.UI.RadLabel lbUsuario;
        private Telerik.WinControls.UI.RadLabel lbSenha;
        private Telerik.WinControls.UI.RadButton btnLogar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox tbUrl;
    }
}
