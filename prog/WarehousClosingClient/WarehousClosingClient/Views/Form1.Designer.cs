namespace WarehousClosingClient;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        splitContainer1 = new SplitContainer();
        groupBox_Menu = new GroupBox();
        providerMenu = new Button();
        supplyMenu = new Button();
        productMenu = new Button();
        orderMenu = new Button();
        employeeMenu = new Button();
        customerMenu = new Button();
        pictureBox2 = new PictureBox();
        label1 = new Label();
        groupBox_View = new GroupBox();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        groupBox_Menu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(groupBox_Menu);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(groupBox_View);
        splitContainer1.Size = new Size(800, 500);
        splitContainer1.SplitterDistance = 179;
        splitContainer1.TabIndex = 0;
        // 
        // groupBox_Menu
        // 
        groupBox_Menu.Controls.Add(providerMenu);
        groupBox_Menu.Controls.Add(supplyMenu);
        groupBox_Menu.Controls.Add(productMenu);
        groupBox_Menu.Controls.Add(orderMenu);
        groupBox_Menu.Controls.Add(employeeMenu);
        groupBox_Menu.Controls.Add(customerMenu);
        groupBox_Menu.Controls.Add(pictureBox2);
        groupBox_Menu.Controls.Add(label1);
        groupBox_Menu.Location = new Point(2, 3);
        groupBox_Menu.Name = "groupBox_Menu";
        groupBox_Menu.Size = new Size(177, 497);
        groupBox_Menu.TabIndex = 9;
        groupBox_Menu.TabStop = false;
        // 
        // providerMenu
        // 
        providerMenu.BackColor = Color.White;
        providerMenu.Location = new Point(5, 315);
        providerMenu.Name = "providerMenu";
        providerMenu.Size = new Size(169, 45);
        providerMenu.TabIndex = 16;
        providerMenu.Text = "Providers";
        providerMenu.UseVisualStyleBackColor = false;
        // 
        // supplyMenu
        // 
        supplyMenu.BackColor = Color.White;
        supplyMenu.Location = new Point(5, 270);
        supplyMenu.Name = "supplyMenu";
        supplyMenu.Size = new Size(169, 45);
        supplyMenu.TabIndex = 15;
        supplyMenu.Text = "Supplyes";
        supplyMenu.UseVisualStyleBackColor = false;
        // 
        // productMenu
        // 
        productMenu.BackColor = Color.White;
        productMenu.Location = new Point(5, 225);
        productMenu.Name = "productMenu";
        productMenu.Size = new Size(169, 45);
        productMenu.TabIndex = 14;
        productMenu.Text = "Products";
        productMenu.UseVisualStyleBackColor = false;
        // 
        // orderMenu
        // 
        orderMenu.BackColor = Color.White;
        orderMenu.Location = new Point(5, 180);
        orderMenu.Name = "orderMenu";
        orderMenu.Size = new Size(169, 45);
        orderMenu.TabIndex = 13;
        orderMenu.Text = "Orders";
        orderMenu.UseVisualStyleBackColor = false;
        // 
        // employeeMenu
        // 
        employeeMenu.BackColor = Color.White;
        employeeMenu.Location = new Point(5, 135);
        employeeMenu.Name = "employeeMenu";
        employeeMenu.Size = new Size(169, 45);
        employeeMenu.TabIndex = 12;
        employeeMenu.Text = "Employers";
        employeeMenu.UseVisualStyleBackColor = false;
        // 
        // customerMenu
        // 
        customerMenu.BackColor = Color.White;
        customerMenu.Location = new Point(5, 90);
        customerMenu.Name = "customerMenu";
        customerMenu.Size = new Size(169, 45);
        customerMenu.TabIndex = 11;
        customerMenu.Text = "Customers";
        customerMenu.UseVisualStyleBackColor = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(5, 14);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(82, 70);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 10;
        pictureBox2.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 18F);
        label1.Location = new Point(87, 19);
        label1.Name = "label1";
        label1.Size = new Size(87, 54);
        label1.TabIndex = 9;
        label1.Text = "Admin \nPanel";
        // 
        // groupBox_View
        // 
        groupBox_View.Location = new Point(2, 3);
        groupBox_View.Name = "groupBox_View";
        groupBox_View.Size = new Size(615, 497);
        groupBox_View.TabIndex = 0;
        groupBox_View.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(800, 500);
        Controls.Add(splitContainer1);
        Name = "Form1";
        Text = "Warehouse";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        groupBox_Menu.ResumeLayout(false);
        groupBox_Menu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private GroupBox groupBox_Menu;
    private Button providerMenu;
    private Button supplyMenu;
    private Button productMenu;
    private Button orderMenu;
    private Button employeeMenu;
    private Button customerMenu;
    private PictureBox pictureBox2;
    private Label label1;
    private GroupBox groupBox_View;
}
