using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Gerador_de_senha
{
    public partial class Code : Form
    {
        Aviso avisei = new Aviso();
        string senha;

  
        int caracter, quanto = 12;
        bool isSpecial, isNum, isCar, isTop, isBot;
        char[] especial = new char[] { 'α', 'β', 'ψ', 'ω', 'ç', 'Ç', 'ã', 'ê', 'ㄹ', 'ㄸ', 'ㅃ', 'ㅊ', 'ㅞ' };
        char[] num = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] car = new char[] { '!', '@', '#', '$', '%', '&', '*', '-', '+', '.', '_' };
        char[] top = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] bot = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        IFirebaseClient cliente;

        public Code()
        {
            InitializeComponent();
        }
        private void Code_Load(object sender, EventArgs e)
        {
            string vrc = Properties.Settings.Default.ValorLink;
            string vrw = Properties.Settings.Default.ValorSecret;
            IFirebaseConfig configuracoes = new FirebaseConfig()
            {
                AuthSecret = vrw,
                BasePath = vrc
            };

            try
            {
                cliente = new FireSharp.FirebaseClient(configuracoes);
                FirebaseResponse response = cliente.Get("/");
                if (response == null)
                {
                    msg("Conecte-se à internet.");
                }
            }
            catch (Exception)
            {
                msg("Conecte-se à internet.");
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            avisei.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(quanta.Text) <= 5)
            {
                quanta.Text = "6";
            }
            quanto = Convert.ToInt32(quanta.Text);
            senha = "";
            Random random = new Random();
            repeat: 
            for (int a = 0; a < quanto; a++)
            {
                caracter = random.Next(0, 5);
                switch (caracter)
                {
                    case 0:
                        if (Check.Checked)
                        {
                            senha += especial[random.Next(0, 13)]; isSpecial = true;
                        }
                        else
                        {
                            a--;
                        }
                        break; 
                    case 1:
                        senha += car[random.Next(0, 11)]; isCar = true;
                        break; 
                    case 2:
                        senha += num[random.Next(0, 10)]; isNum = true;
                        break;
                    case 3:
                        senha += top[random.Next(0, 26)]; isTop = true;
                        break;
                    case 4:
                        senha += bot[random.Next(0, 26)]; isBot = true;
                        break;
                }
            }
            if (isNum && isCar && isTop && isBot)
            {
                if((isSpecial && Check.Checked) || (!isSpecial && !Check.Checked))
                {
                    texto.Text = senha;
                    Clipboard.SetText(senha);
                    all(false);
                }
                else
                {
                    all(false);
                    senha = "";
                    goto repeat;
                }
            }
            else
            {
                all(false);
                senha = "";
                goto repeat;
            }
        }

        private async void salvar_Click(object sender, EventArgs e)
        {

            if (texto.TextLength <= 0 || local.TextLength <= 0)
            {
                msg("Preencha os campos.");
            }
            else { 
                Classe vip = new Classe()
            {
                Senha = senha
            };
            FirebaseResponse set =  cliente.Update<Classe>(
                local.Text + "/", vip);
            salvar.FillColor = Color.White;
            salvar.ForeColor = Color.FromArgb(94, 148, 255);
            await Task.Delay(1500);
            salvar.ForeColor = Color.White;
            salvar.FillColor = Color.FromArgb(94, 148, 255);}
        }

        private void all(bool state)
        {
            isNum = state;
            isSpecial = state;
            isCar = state;
            isBot = state;
            isTop = state;
        }
        public async void msg(string texto)
        {
            avisei.texto.Text = texto;
            avisei.picture.Visible = false;
            avisei.texto.SelectionStart = avisei.texto.Text.Length;
            avisei.texto.SelectionLength = 0;
            avisei.texto.TabStop = false;
            await Task.Delay(300);
            avisei.Show();
        }
    }
}


/*
           if (a == 8) {
               senha += especial[random.Next(0, 13)];
           }
           int b = random.Next(1, 11);
           if (b > 8)
           {
               senha += car[random.Next(0, 11)];
           }else if(b > 6)
           {
               senha += num[random.Next(0, 10)];
           }
           else if(b > 3)
           {
               senha += top[random.Next(0, 26)];
           }
           else
           {
               senha += bot[random.Next(0, 26)];
           }
*/