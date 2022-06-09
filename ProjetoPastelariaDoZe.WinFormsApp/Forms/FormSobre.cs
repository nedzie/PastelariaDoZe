using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class FormSobre : Form
    {
        /// <summary>
        /// Construtor que inicializa o Form Sobre
        /// </summary>
        public FormSobre()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formSobre.Text");
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            MaximizeBox = false;
        }

        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
