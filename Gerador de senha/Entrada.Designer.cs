namespace Gerador_de_senha
{
    partial class Entrada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.borda = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.link = new System.Windows.Forms.Label();
            this.locw = new Guna.UI2.WinForms.Guna2TextBox();
            this.senhaR = new System.Windows.Forms.Label();
            this.texto = new Guna.UI2.WinForms.Guna2TextBox();
            this.salvar = new Guna.UI2.WinForms.Guna2Button();
            this.name = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // borda
            // 
            this.borda.AnimateWindow = true;
            this.borda.BorderRadius = 20;
            this.borda.ContainerControl = this;
            this.borda.DockIndicatorTransparencyValue = 0.6D;
            this.borda.ResizeForm = false;
            this.borda.TransparentWhileDrag = true;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.ForeColor = System.Drawing.Color.White;
            this.link.Location = new System.Drawing.Point(219, 54);
            this.link.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(37, 16);
            this.link.TabIndex = 13;
            this.link.Text = "Link:";
            // 
            // locw
            // 
            this.locw.BorderRadius = 10;
            this.locw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locw.DefaultText = "";
            this.locw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.locw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.locw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.locw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.locw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.locw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locw.Location = new System.Drawing.Point(22, 82);
            this.locw.Margin = new System.Windows.Forms.Padding(2);
            this.locw.Name = "locw";
            this.locw.PasswordChar = '\0';
            this.locw.PlaceholderText = "";
            this.locw.SelectedText = "";
            this.locw.Size = new System.Drawing.Size(426, 23);
            this.locw.TabIndex = 12;
            this.locw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // senhaR
            // 
            this.senhaR.AutoSize = true;
            this.senhaR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaR.ForeColor = System.Drawing.Color.White;
            this.senhaR.Location = new System.Drawing.Point(196, 130);
            this.senhaR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.senhaR.Name = "senhaR";
            this.senhaR.Size = new System.Drawing.Size(81, 16);
            this.senhaR.TabIndex = 11;
            this.senhaR.Text = "AuthSecret:";
            // 
            // texto
            // 
            this.texto.BorderRadius = 10;
            this.texto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texto.DefaultText = "";
            this.texto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.texto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.texto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texto.Location = new System.Drawing.Point(23, 158);
            this.texto.Margin = new System.Windows.Forms.Padding(2);
            this.texto.Name = "texto";
            this.texto.PasswordChar = '\0';
            this.texto.PlaceholderText = "";
            this.texto.SelectedText = "";
            this.texto.Size = new System.Drawing.Size(426, 23);
            this.texto.TabIndex = 10;
            this.texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // salvar
            // 
            this.salvar.BorderRadius = 9;
            this.salvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar.ForeColor = System.Drawing.Color.White;
            this.salvar.Location = new System.Drawing.Point(175, 207);
            this.salvar.Margin = new System.Windows.Forms.Padding(2);
            this.salvar.Name = "salvar";
            this.salvar.PressedColor = System.Drawing.Color.White;
            this.salvar.Size = new System.Drawing.Size(120, 30);
            this.salvar.TabIndex = 14;
            this.salvar.Text = "Enter";
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.Location = new System.Drawing.Point(184, 9);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 23);
            this.name.TabIndex = 16;
            this.name.Text = "Code Plus";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(440, 2);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(30, 29);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "X";
            // 
            // Entrada
            // 
            this.AcceptButton = this.salvar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(471, 263);
            this.ControlBox = false;
            this.Controls.Add(this.name);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.link);
            this.Controls.Add(this.locw);
            this.Controls.Add(this.senhaR);
            this.Controls.Add(this.texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borda;
        private System.Windows.Forms.Label link;
        private Guna.UI2.WinForms.Guna2TextBox locw;
        private System.Windows.Forms.Label senhaR;
        private Guna.UI2.WinForms.Guna2TextBox texto;
        private Guna.UI2.WinForms.Guna2Button salvar;
        private System.Windows.Forms.Label name;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}