using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SS.Model;
using SS.Services;
using SS.Services.Interfaces;


namespace SS.ViewLayer
{
    public partial class Login : Form
    {
        private readonly IUsersService _usersService;
        public Login(IUsersService usersService)
        {
            InitializeComponent();
            _usersService = usersService;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            UserSession.Instance.Logout();
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDocumento.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            var user = _usersService.GetUsers().Where(x => x.Dni == txtDocumento.Text && x.Password == txtClave.Text)
                                               .FirstOrDefault();

            if (user != null)
            {
                UserSession.Instance.Login(user);

                Home form = new Home();
                form.Show();
                this.Hide();
                
                form.FormClosing += frm_closing;
            }
            else
            {
                var result = MessageBox.Show("No se encontró el usuario!", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel) 
                {
                    this.Close();
                }

            }

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtClave.Text = "";

            this.Show();
        }


    }
}
