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
using FireSharp;

namespace Gerador_de_senha
{
    public partial class Entrada : Form
    {
        Aviso avisei = new Aviso();
        Code dalk = new Code();
        public Entrada()
        {
            InitializeComponent();
        }
        

        private void salvar_Click(object sender, EventArgs e)
        {
            IFirebaseConfig configuracoes = new FirebaseConfig()
            {
                AuthSecret = texto.Text,
                BasePath = locw.Text
            };
            IFirebaseClient cliente;
            if (!string.IsNullOrEmpty(texto.Text) && !string.IsNullOrEmpty(locw.Text))
            {
   
                try
                {

                    cliente = new FireSharp.FirebaseClient(configuracoes);
                    FirebaseResponse response = cliente.Get("/");
                  
                    if (response != null)
                    {
                        Properties.Settings.Default.ValorLink = locw.Text;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.ValorSecret = texto.Text;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.Valido = "OK";
                        Properties.Settings.Default.Save();
                        this.Hide();
                        dalk.Show();
                    }
                    else
                    {
                        msg("Banco de dados inexistente.");
                    }
                  
                }
                catch (Exception)
                {
                    msg("Conecte-se à internet.");
                }
   
            }
            else
            {
                msg("Preencha as informações.");
            }
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
