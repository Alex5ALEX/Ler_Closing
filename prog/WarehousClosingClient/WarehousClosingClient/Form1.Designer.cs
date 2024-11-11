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
        groupBox1 = new GroupBox();
        button1 = new Button();
        providerMenu = new Button();
        supplyMenu = new Button();
        productMenu = new Button();
        orderMenu = new Button();
        employeeMenu = new Button();
        customerMenu = new Button();
        pictureBox2 = new PictureBox();
        label1 = new Label();
        customerGroupBox = new GroupBox();
        customerLabel = new Label();
        customertFlowLayoutPanel = new FlowLayoutPanel();
        customerAddButton = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        customerGroupBox.SuspendLayout();
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
        splitContainer1.Panel1.Controls.Add(groupBox1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(customerGroupBox);
        splitContainer1.Size = new Size(800, 450);
        splitContainer1.SplitterDistance = 213;
        splitContainer1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(button1);
        groupBox1.Controls.Add(providerMenu);
        groupBox1.Controls.Add(supplyMenu);
        groupBox1.Controls.Add(productMenu);
        groupBox1.Controls.Add(orderMenu);
        groupBox1.Controls.Add(employeeMenu);
        groupBox1.Controls.Add(customerMenu);
        groupBox1.Controls.Add(pictureBox2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(2, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(209, 447);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        // 
        // button1
        // 
        button1.BackColor = Color.White;
        button1.Location = new Point(10, 410);
        button1.Name = "button1";
        button1.Size = new Size(80, 30);
        button1.TabIndex = 17;
        button1.Text = "Exit";
        button1.UseVisualStyleBackColor = false;
        // 
        // providerMenu
        // 
        providerMenu.BackColor = Color.White;
        providerMenu.Location = new Point(5, 315);
        providerMenu.Name = "providerMenu";
        providerMenu.Size = new Size(200, 45);
        providerMenu.TabIndex = 16;
        providerMenu.Text = "Providers";
        providerMenu.UseVisualStyleBackColor = false;
        // 
        // supplyMenu
        // 
        supplyMenu.BackColor = Color.White;
        supplyMenu.Location = new Point(5, 270);
        supplyMenu.Name = "supplyMenu";
        supplyMenu.Size = new Size(200, 45);
        supplyMenu.TabIndex = 15;
        supplyMenu.Text = "Supplyes";
        supplyMenu.UseVisualStyleBackColor = false;
        // 
        // productMenu
        // 
        productMenu.BackColor = Color.White;
        productMenu.Location = new Point(5, 225);
        productMenu.Name = "productMenu";
        productMenu.Size = new Size(200, 45);
        productMenu.TabIndex = 14;
        productMenu.Text = "Products";
        productMenu.UseVisualStyleBackColor = false;
        // 
        // orderMenu
        // 
        orderMenu.BackColor = Color.White;
        orderMenu.Location = new Point(5, 180);
        orderMenu.Name = "orderMenu";
        orderMenu.Size = new Size(200, 45);
        orderMenu.TabIndex = 13;
        orderMenu.Text = "Orders";
        orderMenu.UseVisualStyleBackColor = false;
        // 
        // employeeMenu
        // 
        employeeMenu.BackColor = Color.White;
        employeeMenu.Location = new Point(5, 135);
        employeeMenu.Name = "employeeMenu";
        employeeMenu.Size = new Size(200, 45);
        employeeMenu.TabIndex = 12;
        employeeMenu.Text = "Employers";
        employeeMenu.UseVisualStyleBackColor = false;
        // 
        // customerMenu
        // 
        customerMenu.BackColor = Color.White;
        customerMenu.Location = new Point(5, 90);
        customerMenu.Name = "customerMenu";
        customerMenu.Size = new Size(200, 45);
        customerMenu.TabIndex = 11;
        customerMenu.Text = "Customers";
        customerMenu.UseVisualStyleBackColor = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(10, 14);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(89, 67);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 10;
        pictureBox2.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 18F);
        label1.Location = new Point(116, 19);
        label1.Name = "label1";
        label1.Size = new Size(87, 54);
        label1.TabIndex = 9;
        label1.Text = "Admin \nPanel";
        // 
        // customerGroupBox
        // 
        customerGroupBox.Controls.Add(customerLabel);
        customerGroupBox.Controls.Add(customertFlowLayoutPanel);
        customerGroupBox.Controls.Add(customerAddButton);
        customerGroupBox.Location = new Point(2, 3);
        customerGroupBox.Name = "customerGroupBox";
        customerGroupBox.Size = new Size(580, 447);
        customerGroupBox.TabIndex = 0;
        customerGroupBox.TabStop = false;
        // 
        // customerLabel
        // 
        customerLabel.AutoSize = true;
        customerLabel.Font = new Font("Arial", 18F);
        customerLabel.Location = new Point(8, 14);
        customerLabel.Name = "customerLabel";
        customerLabel.Size = new Size(128, 27);
        customerLabel.TabIndex = 2;
        customerLabel.Text = "Customers";
        // 
        // customertFlowLayoutPanel
        // 
        customertFlowLayoutPanel.AutoScroll = true;
        customertFlowLayoutPanel.Location = new Point(5, 65);
        customertFlowLayoutPanel.Name = "customertFlowLayoutPanel";
        customertFlowLayoutPanel.Size = new Size(566, 375);
        customertFlowLayoutPanel.TabIndex = 1;
        // 
        // customerAddButton
        // 
        customerAddButton.BackColor = Color.White;
        customerAddButton.Location = new Point(474, 14);
        customerAddButton.Name = "customerAddButton";
        customerAddButton.Size = new Size(100, 45);
        customerAddButton.TabIndex = 0;
        customerAddButton.Text = "Add Customer";
        customerAddButton.UseVisualStyleBackColor = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(800, 450);
        Controls.Add(splitContainer1);
        Name = "Form1";
        Text = "Warehouse";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        customerGroupBox.ResumeLayout(false);
        customerGroupBox.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private GroupBox groupBox1;
    private Button button1;
    private Button providerMenu;
    private Button supplyMenu;
    private Button productMenu;
    private Button orderMenu;
    private Button employeeMenu;
    private Button customerMenu;
    private PictureBox pictureBox2;
    private Label label1;
    private GroupBox customerGroupBox;
    private Button customerAddButton;
    private FlowLayoutPanel customertFlowLayoutPanel;
    private Label customerLabel;
}
