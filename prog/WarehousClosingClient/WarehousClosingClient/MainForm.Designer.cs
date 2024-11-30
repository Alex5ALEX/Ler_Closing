namespace WarehousClosingClient
{
    partial class MainForm
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
            groupBoxMain = new GroupBox();
            labelHello = new Label();
            groupBoxMenu = new GroupBox();
            buttonHideMenu = new Button();
            labelMenu = new Label();
            providerOption = new Button();
            supplyOption = new Button();
            productOption = new Button();
            orderOption = new Button();
            employeeOption = new Button();
            customerOption = new Button();
            buttonMenu = new Button();
            groupBoxMain.SuspendLayout();
            groupBoxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain
            // 
            groupBoxMain.Controls.Add(labelHello);
            groupBoxMain.Controls.Add(buttonMenu);
            groupBoxMain.Location = new Point(0, 0);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(1260, 680);
            groupBoxMain.TabIndex = 0;
            groupBoxMain.TabStop = false;
            // 
            // labelHello
            // 
            labelHello.AutoSize = true;
            labelHello.Font = new Font("SWScrps", 28F);
            labelHello.Location = new Point(590, 324);
            labelHello.Name = "labelHello";
            labelHello.Size = new Size(95, 53);
            labelHello.TabIndex = 2;
            labelHello.Text = "Hello";
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.Controls.Add(buttonHideMenu);
            groupBoxMenu.Controls.Add(labelMenu);
            groupBoxMenu.Controls.Add(providerOption);
            groupBoxMenu.Controls.Add(supplyOption);
            groupBoxMenu.Controls.Add(productOption);
            groupBoxMenu.Controls.Add(orderOption);
            groupBoxMenu.Controls.Add(employeeOption);
            groupBoxMenu.Controls.Add(customerOption);
            groupBoxMenu.Location = new Point(0, 0);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(200, 680);
            groupBoxMenu.TabIndex = 1;
            groupBoxMenu.TabStop = false;
            // 
            // buttonHideMenu
            // 
            buttonHideMenu.BackColor = Color.FromArgb(240, 240, 240);
            buttonHideMenu.Font = new Font("Segoe UI", 12F);
            buttonHideMenu.Location = new Point(6, 619);
            buttonHideMenu.Name = "buttonHideMenu";
            buttonHideMenu.Size = new Size(94, 55);
            buttonHideMenu.TabIndex = 30;
            buttonHideMenu.Text = "Hide\nMenu";
            buttonHideMenu.UseVisualStyleBackColor = false;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Segoe UI", 24F);
            labelMenu.Location = new Point(5, 19);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(102, 45);
            labelMenu.TabIndex = 29;
            labelMenu.Text = "Menu";
            // 
            // providerOption
            // 
            providerOption.BackColor = Color.FromArgb(240, 240, 240);
            providerOption.Font = new Font("Segoe UI", 12F);
            providerOption.Location = new Point(6, 336);
            providerOption.Name = "providerOption";
            providerOption.Size = new Size(188, 45);
            providerOption.TabIndex = 28;
            providerOption.Text = "Providers";
            providerOption.UseVisualStyleBackColor = false;
            // 
            // supplyOption
            // 
            supplyOption.BackColor = Color.FromArgb(240, 240, 240);
            supplyOption.Font = new Font("Segoe UI", 12F);
            supplyOption.Location = new Point(5, 285);
            supplyOption.Name = "supplyOption";
            supplyOption.Size = new Size(189, 45);
            supplyOption.TabIndex = 27;
            supplyOption.Text = "Supplyes";
            supplyOption.UseVisualStyleBackColor = false;
            // 
            // productOption
            // 
            productOption.BackColor = Color.FromArgb(240, 240, 240);
            productOption.Font = new Font("Segoe UI", 12F);
            productOption.Location = new Point(6, 234);
            productOption.Name = "productOption";
            productOption.Size = new Size(189, 45);
            productOption.TabIndex = 26;
            productOption.Text = "Products";
            productOption.UseVisualStyleBackColor = false;
            // 
            // orderOption
            // 
            orderOption.BackColor = Color.FromArgb(240, 240, 240);
            orderOption.Font = new Font("Segoe UI", 12F);
            orderOption.Location = new Point(6, 183);
            orderOption.Name = "orderOption";
            orderOption.Size = new Size(189, 45);
            orderOption.TabIndex = 25;
            orderOption.Text = "Orders";
            orderOption.UseVisualStyleBackColor = false;
            // 
            // employeeOption
            // 
            employeeOption.BackColor = Color.FromArgb(240, 240, 240);
            employeeOption.Font = new Font("Segoe UI", 12F);
            employeeOption.Location = new Point(6, 132);
            employeeOption.Name = "employeeOption";
            employeeOption.Size = new Size(188, 45);
            employeeOption.TabIndex = 24;
            employeeOption.Text = "Employers";
            employeeOption.UseVisualStyleBackColor = false;
            // 
            // customerOption
            // 
            customerOption.BackColor = Color.FromArgb(240, 240, 240);
            customerOption.Font = new Font("Segoe UI", 12F);
            customerOption.Location = new Point(6, 81);
            customerOption.Name = "customerOption";
            customerOption.Size = new Size(188, 45);
            customerOption.TabIndex = 23;
            customerOption.Text = "Customers";
            customerOption.UseVisualStyleBackColor = false;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.FromArgb(240, 240, 240);
            buttonMenu.Font = new Font("Segoe UI", 12F);
            buttonMenu.Location = new Point(5, 15);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(80, 60);
            buttonMenu.TabIndex = 0;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(groupBoxMain);
            Controls.Add(groupBoxMenu);
            Name = "MainForm";
            Text = "MainForm";
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            groupBoxMenu.ResumeLayout(false);
            groupBoxMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain;
        private Button buttonMenu;
        private GroupBox groupBoxMenu;
        private Label labelHello;
        private Button providerOption;
        private Button supplyOption;
        private Button productOption;
        private Button orderOption;
        private Button employeeOption;
        private Button customerOption;
        private Button buttonHideMenu;
        private Label labelMenu;
    }
}