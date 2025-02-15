namespace SS.ViewLayer
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersMenu = new FontAwesome.Sharp.IconMenuItem();
            this.managerMenu = new FontAwesome.Sharp.IconMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSaleRegister = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGetSaleDetail = new FontAwesome.Sharp.IconMenuItem();
            this.purchasesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPurchaseRegister = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGetPurchaseDetail = new FontAwesome.Sharp.IconMenuItem();
            this.clientsMenu = new FontAwesome.Sharp.IconMenuItem();
            this.suppliersMenu = new FontAwesome.Sharp.IconMenuItem();
            this.reportsMenu = new FontAwesome.Sharp.IconMenuItem();
            this.aboutMenu = new FontAwesome.Sharp.IconMenuItem();
            this.titleMenu = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.loguedUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersMenu,
            this.managerMenu,
            this.salesMenu,
            this.purchasesMenu,
            this.clientsMenu,
            this.suppliersMenu,
            this.reportsMenu,
            this.aboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 59);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersMenu
            // 
            this.usersMenu.AutoSize = false;
            this.usersMenu.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.usersMenu.IconColor = System.Drawing.Color.Black;
            this.usersMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usersMenu.IconSize = 50;
            this.usersMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersMenu.Name = "usersMenu";
            this.usersMenu.Size = new System.Drawing.Size(80, 69);
            this.usersMenu.Text = "Usuarios";
            this.usersMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usersMenu.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // managerMenu
            // 
            this.managerMenu.AutoSize = false;
            this.managerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.managerMenu.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.managerMenu.IconColor = System.Drawing.Color.Black;
            this.managerMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.managerMenu.IconSize = 50;
            this.managerMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.managerMenu.Name = "managerMenu";
            this.managerMenu.Size = new System.Drawing.Size(80, 69);
            this.managerMenu.Text = "Mantenedor";
            this.managerMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.managerMenu.Click += new System.EventHandler(this.menuMantenedor_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // salesMenu
            // 
            this.salesMenu.AutoSize = false;
            this.salesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuSaleRegister,
            this.subMenuGetSaleDetail});
            this.salesMenu.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.salesMenu.IconColor = System.Drawing.Color.Black;
            this.salesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salesMenu.IconSize = 50;
            this.salesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salesMenu.Name = "salesMenu";
            this.salesMenu.Size = new System.Drawing.Size(80, 69);
            this.salesMenu.Text = "Ventas";
            this.salesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salesMenu.Click += new System.EventHandler(this.menuVentas_Click);
            // 
            // subMenuSaleRegister
            // 
            this.subMenuSaleRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSaleRegister.IconColor = System.Drawing.Color.Black;
            this.subMenuSaleRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSaleRegister.Name = "subMenuSaleRegister";
            this.subMenuSaleRegister.Size = new System.Drawing.Size(129, 22);
            this.subMenuSaleRegister.Text = "Registrar";
            this.subMenuSaleRegister.Click += new System.EventHandler(this.subMenuSaleRegister_Click);
            // 
            // subMenuGetSaleDetail
            // 
            this.subMenuGetSaleDetail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuGetSaleDetail.IconColor = System.Drawing.Color.Black;
            this.subMenuGetSaleDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuGetSaleDetail.Name = "subMenuGetSaleDetail";
            this.subMenuGetSaleDetail.Size = new System.Drawing.Size(129, 22);
            this.subMenuGetSaleDetail.Text = "Ver Detalle";
            this.subMenuGetSaleDetail.Click += new System.EventHandler(this.subMenuGetSaleDetail_Click);
            // 
            // purchasesMenu
            // 
            this.purchasesMenu.AutoSize = false;
            this.purchasesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuPurchaseRegister,
            this.subMenuGetPurchaseDetail});
            this.purchasesMenu.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.purchasesMenu.IconColor = System.Drawing.Color.Black;
            this.purchasesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.purchasesMenu.IconSize = 50;
            this.purchasesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.purchasesMenu.Name = "purchasesMenu";
            this.purchasesMenu.Size = new System.Drawing.Size(80, 69);
            this.purchasesMenu.Text = "Compras";
            this.purchasesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.purchasesMenu.Click += new System.EventHandler(this.menuCompras_Click);
            // 
            // subMenuPurchaseRegister
            // 
            this.subMenuPurchaseRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPurchaseRegister.IconColor = System.Drawing.Color.Black;
            this.subMenuPurchaseRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPurchaseRegister.Name = "subMenuPurchaseRegister";
            this.subMenuPurchaseRegister.Size = new System.Drawing.Size(180, 22);
            this.subMenuPurchaseRegister.Text = "Registrar";
            this.subMenuPurchaseRegister.Click += new System.EventHandler(this.subMenuPurchaseRegister_Click);
            // 
            // subMenuGetPurchaseDetail
            // 
            this.subMenuGetPurchaseDetail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuGetPurchaseDetail.IconColor = System.Drawing.Color.Black;
            this.subMenuGetPurchaseDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuGetPurchaseDetail.Name = "subMenuGetPurchaseDetail";
            this.subMenuGetPurchaseDetail.Size = new System.Drawing.Size(180, 22);
            this.subMenuGetPurchaseDetail.Text = "Ver Detalle";
            this.subMenuGetPurchaseDetail.Click += new System.EventHandler(this.subMenuGetPurchaseDetail_Click);
            // 
            // clientsMenu
            // 
            this.clientsMenu.AutoSize = false;
            this.clientsMenu.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.clientsMenu.IconColor = System.Drawing.Color.Black;
            this.clientsMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clientsMenu.IconSize = 50;
            this.clientsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientsMenu.Name = "clientsMenu";
            this.clientsMenu.Size = new System.Drawing.Size(80, 69);
            this.clientsMenu.Text = "Clientes";
            this.clientsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clientsMenu.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // suppliersMenu
            // 
            this.suppliersMenu.AutoSize = false;
            this.suppliersMenu.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.suppliersMenu.IconColor = System.Drawing.Color.Black;
            this.suppliersMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.suppliersMenu.IconSize = 50;
            this.suppliersMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.suppliersMenu.Name = "suppliersMenu";
            this.suppliersMenu.Size = new System.Drawing.Size(80, 69);
            this.suppliersMenu.Text = "Proveedores";
            this.suppliersMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.suppliersMenu.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // reportsMenu
            // 
            this.reportsMenu.AutoSize = false;
            this.reportsMenu.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.reportsMenu.IconColor = System.Drawing.Color.Black;
            this.reportsMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportsMenu.IconSize = 50;
            this.reportsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportsMenu.Name = "reportsMenu";
            this.reportsMenu.Size = new System.Drawing.Size(80, 69);
            this.reportsMenu.Text = "Reportes";
            this.reportsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportsMenu.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.AutoSize = false;
            this.aboutMenu.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.aboutMenu.IconColor = System.Drawing.Color.Black;
            this.aboutMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aboutMenu.IconSize = 50;
            this.aboutMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(80, 69);
            this.aboutMenu.Text = "Acerca de";
            this.aboutMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aboutMenu.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // titleMenu
            // 
            this.titleMenu.AutoSize = false;
            this.titleMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.titleMenu.Location = new System.Drawing.Point(0, 0);
            this.titleMenu.Name = "titleMenu";
            this.titleMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleMenu.Size = new System.Drawing.Size(955, 59);
            this.titleMenu.TabIndex = 1;
            this.titleMenu.Text = "menuStrip2";
            this.titleMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 132);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(955, 415);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(760, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hola de nuevo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loguedUser
            // 
            this.loguedUser.AutoSize = true;
            this.loguedUser.BackColor = System.Drawing.Color.SteelBlue;
            this.loguedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loguedUser.ForeColor = System.Drawing.Color.White;
            this.loguedUser.Location = new System.Drawing.Point(843, 18);
            this.loguedUser.Name = "loguedUser";
            this.loguedUser.Size = new System.Drawing.Size(56, 15);
            this.loguedUser.TabIndex = 5;
            this.loguedUser.Text = "Usuario: ";
            this.loguedUser.Click += new System.EventHandler(this.loguedUser_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(955, 547);
            this.Controls.Add(this.loguedUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.titleMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip titleMenu;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem aboutMenu;
        private FontAwesome.Sharp.IconMenuItem usersMenu;
        private FontAwesome.Sharp.IconMenuItem managerMenu;
        private FontAwesome.Sharp.IconMenuItem salesMenu;
        private FontAwesome.Sharp.IconMenuItem purchasesMenu;
        private FontAwesome.Sharp.IconMenuItem clientsMenu;
        private FontAwesome.Sharp.IconMenuItem suppliersMenu;
        private FontAwesome.Sharp.IconMenuItem reportsMenu;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loguedUser;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem subMenuSaleRegister;
        private FontAwesome.Sharp.IconMenuItem subMenuGetSaleDetail;
        private FontAwesome.Sharp.IconMenuItem subMenuPurchaseRegister;
        private FontAwesome.Sharp.IconMenuItem subMenuGetPurchaseDetail;
    }
}

