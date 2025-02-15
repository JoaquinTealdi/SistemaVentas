using FontAwesome.Sharp;
using SS.Model;
using SS.Services;
using SS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SS.ViewLayer
{
    public partial class Home : Form
    {
        private readonly IPermissionsMenuManager permissionsManager;
        private static IconMenuItem activeMenu = null;
        private static Form activeForm = null;
        public Home(IPermissionsMenuManager pManager)
        {
            permissionsManager = pManager;
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            var user = UserSession.Instance.CurrentUser;
            var permissions = permissionsManager.GetPermissions(user.Id);

            foreach(IconMenuItem iconMenu in menuStrip1.Items)
            {
                var exists = permissions.Any(x=> x.MenuName == iconMenu.Name);

                if (!exists)
                {
                    iconMenu.Visible = false;
                }
            }

            loguedUser.Text = user.FullName + " :)";
        }

        private void OpenForm(IconMenuItem menu, Form form)
        {
            if(activeMenu != null)
            {
                activeMenu.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            activeMenu = menu;

            if(activeForm != null)
            {
                activeForm.Close();
            }

            //forms settings
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.SteelBlue;


            
            contenedor.Controls.Add(form);
            form.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loguedUser_Click(object sender, EventArgs e)
        {

        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new frmUsers());
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(managerMenu, new frmCategories());
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(managerMenu, new frmProducts());
        }

        private void menuVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void menuCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new frmClients());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new frmSuppliers());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new frmReports());
        }

        private void menuMantenedor_Click(object sender, EventArgs e)
        {

        }

        private void subMenuSaleRegister_Click(object sender, EventArgs e)
        {
            OpenForm(salesMenu, new frmSales());
        }

        private void subMenuGetSaleDetail_Click(object sender, EventArgs e)
        {
            OpenForm(salesMenu, new frmSaleDetails());
        }

        private void subMenuPurchaseRegister_Click(object sender, EventArgs e)
        {
            OpenForm(purchasesMenu, new frmPurchases());
        }

        private void subMenuGetPurchaseDetail_Click(object sender, EventArgs e)
        {
            OpenForm(purchasesMenu, new frmPurchaseDetails());
        }
    }
}
