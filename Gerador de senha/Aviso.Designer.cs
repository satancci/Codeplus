namespace Gerador_de_senha
{
    partial class Aviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aviso));
            this.borda = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.texto = new Guna.UI2.WinForms.Guna2TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.avisoTexto = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // borda
            // 
            this.borda.BorderRadius = 20;
            this.borda.ContainerControl = this;
            this.borda.DockIndicatorTransparencyValue = 0.6D;
            this.borda.ResizeForm = false;
            this.borda.TransparentWhileDrag = true;
            // 
            // texto
            // 
            this.texto.BorderThickness = 0;
            this.texto.Cursor = System.Windows.Forms.Cursors.Default;
            this.texto.DefaultText = "Conecte-se à internet.";
            this.texto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.texto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.texto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.Color.White;
            this.texto.HideSelection = false;
            this.texto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.texto.Location = new System.Drawing.Point(9, 51);
            this.texto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texto.Name = "texto";
            this.texto.PasswordChar = '\0';
            this.texto.PlaceholderText = "";
            this.texto.ReadOnly = true;
            this.texto.SelectedText = "";
            this.texto.SelectionStart = 22;
            this.texto.Size = new System.Drawing.Size(287, 21);
            this.texto.TabIndex = 1;
            this.texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picture
            // 
            this.picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture.BackgroundImage")));
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Location = new System.Drawing.Point(237, 51);
            this.picture.Margin = new System.Windows.Forms.Padding(2);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(20, 20);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(107, 94);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Size = new System.Drawing.Size(120, 23);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "OK";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // avisoTexto
            // 
            this.avisoTexto.AutoSize = true;
            this.avisoTexto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoTexto.ForeColor = System.Drawing.Color.White;
            this.avisoTexto.Location = new System.Drawing.Point(141, 6);
            this.avisoTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avisoTexto.Name = "avisoTexto";
            this.avisoTexto.Size = new System.Drawing.Size(55, 17);
            this.avisoTexto.TabIndex = 4;
            this.avisoTexto.Text = "AVISO!";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 26);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(333, 6);
            this.guna2Separator1.TabIndex = 5;
            // 
            // Aviso
            // 
            this.AcceptButton = this.guna2Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(333, 125);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.avisoTexto);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Aviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviso!";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2TextBox texto;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label avisoTexto;
        public Guna.UI2.WinForms.Guna2BorderlessForm borda;
        public System.Windows.Forms.PictureBox picture;
    }
}