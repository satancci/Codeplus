namespace Gerador_de_senha
{
    partial class Code
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.texto = new Guna.UI2.WinForms.Guna2TextBox();
            this.senhaR = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button = new Guna.UI2.WinForms.Guna2Button();
            this.borda = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.salvar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.local = new Guna.UI2.WinForms.Guna2TextBox();
            this.Check = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quanta = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(503, 0);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(30, 29);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.texto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.texto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.texto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texto.Location = new System.Drawing.Point(54, 149);
            this.texto.Margin = new System.Windows.Forms.Padding(2);
            this.texto.Name = "texto";
            this.texto.PasswordChar = '\0';
            this.texto.PlaceholderText = "";
            this.texto.ReadOnly = true;
            this.texto.SelectedText = "";
            this.texto.Size = new System.Drawing.Size(426, 23);
            this.texto.TabIndex = 1;
            this.texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // senhaR
            // 
            this.senhaR.AutoSize = true;
            this.senhaR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaR.ForeColor = System.Drawing.Color.White;
            this.senhaR.Location = new System.Drawing.Point(220, 121);
            this.senhaR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.senhaR.Name = "senhaR";
            this.senhaR.Size = new System.Drawing.Size(96, 17);
            this.senhaR.TabIndex = 2;
            this.senhaR.Text = "Your password:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.Location = new System.Drawing.Point(217, 7);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 23);
            this.name.TabIndex = 3;
            this.name.Text = "Code Plus";
            // 
            // button
            // 
            this.button.BorderRadius = 9;
            this.button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(53, 202);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.PressedColor = System.Drawing.Color.White;
            this.button.Size = new System.Drawing.Size(120, 30);
            this.button.TabIndex = 4;
            this.button.Text = "Create";
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // borda
            // 
            this.borda.AnimateWindow = true;
            this.borda.BorderRadius = 20;
            this.borda.ContainerControl = this;
            this.borda.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.borda.DockIndicatorTransparencyValue = 0.6D;
            this.borda.ResizeForm = false;
            this.borda.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.borda.TransparentWhileDrag = true;
            // 
            // salvar
            // 
            this.salvar.BorderRadius = 9;
            this.salvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salvar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar.ForeColor = System.Drawing.Color.White;
            this.salvar.Location = new System.Drawing.Point(207, 202);
            this.salvar.Margin = new System.Windows.Forms.Padding(2);
            this.salvar.Name = "salvar";
            this.salvar.PressedColor = System.Drawing.Color.White;
            this.salvar.Size = new System.Drawing.Size(120, 30);
            this.salvar.TabIndex = 5;
            this.salvar.Text = "Save";
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Local/Dono:";
            // 
            // local
            // 
            this.local.BorderRadius = 10;
            this.local.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.local.DefaultText = "";
            this.local.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.local.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.local.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.local.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.local.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.local.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.local.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.local.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.local.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.local.Location = new System.Drawing.Point(53, 73);
            this.local.Margin = new System.Windows.Forms.Padding(2);
            this.local.Name = "local";
            this.local.PasswordChar = '\0';
            this.local.PlaceholderText = "";
            this.local.SelectedText = "";
            this.local.Size = new System.Drawing.Size(426, 23);
            this.local.TabIndex = 8;
            this.local.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Check
            // 
            this.Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Check.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Check.CheckedState.BorderRadius = 2;
            this.Check.CheckedState.BorderThickness = 0;
            this.Check.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Check.Location = new System.Drawing.Point(364, 209);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(15, 15);
            this.Check.TabIndex = 10;
            this.Check.Text = "Check";
            this.Check.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Check.UncheckedState.BorderRadius = 2;
            this.Check.UncheckedState.BorderThickness = 0;
            this.Check.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(384, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Special Char";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantidade de caracteres:";
            // 
            // quanta
            // 
            this.quanta.BorderRadius = 10;
            this.quanta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quanta.DefaultText = "12";
            this.quanta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quanta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quanta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quanta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quanta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.quanta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quanta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quanta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quanta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quanta.Location = new System.Drawing.Point(239, 259);
            this.quanta.Margin = new System.Windows.Forms.Padding(2);
            this.quanta.Name = "quanta";
            this.quanta.PasswordChar = '\0';
            this.quanta.PlaceholderText = "";
            this.quanta.SelectedText = "";
            this.quanta.Size = new System.Drawing.Size(58, 23);
            this.quanta.TabIndex = 13;
            this.quanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Code
            // 
            this.AcceptButton = this.salvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(533, 306);
            this.Controls.Add(this.quanta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.local);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.button);
            this.Controls.Add(this.name);
            this.Controls.Add(this.senhaR);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.Code_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button button;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label senhaR;
        private Guna.UI2.WinForms.Guna2TextBox texto;
        private Guna.UI2.WinForms.Guna2Button salvar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox local;
        private Guna.UI2.WinForms.Guna2CustomCheckBox Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox quanta;
        public Guna.UI2.WinForms.Guna2BorderlessForm borda;
    }
}

