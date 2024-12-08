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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            labelHello = new Label();
            buttonMenu = new Button();
            groupBoxMenu = new GroupBox();
            labelMenu = new Label();
            providerOption = new Button();
            supplyOption = new Button();
            productOption = new Button();
            orderOption = new Button();
            employeeOption = new Button();
            customerOption = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ReportOption = new Button();
            groupBoxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // labelHello
            // 
            labelHello.AutoSize = true;
            labelHello.Font = new Font("SWScrps", 28F);
            labelHello.Location = new Point(592, 333);
            labelHello.Name = "labelHello";
            labelHello.Size = new Size(95, 53);
            labelHello.TabIndex = 2;
            labelHello.Text = "Hello";
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = SystemColors.ControlLightLight;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Segoe UI", 12F);
            buttonMenu.Location = new Point(3, 3);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(80, 60);
            buttonMenu.TabIndex = 0;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.BackColor = SystemColors.ControlLightLight;
            groupBoxMenu.Controls.Add(ReportOption);
            groupBoxMenu.Controls.Add(labelMenu);
            groupBoxMenu.Controls.Add(providerOption);
            groupBoxMenu.Controls.Add(supplyOption);
            groupBoxMenu.Controls.Add(productOption);
            groupBoxMenu.Controls.Add(orderOption);
            groupBoxMenu.Controls.Add(employeeOption);
            groupBoxMenu.Controls.Add(customerOption);
            groupBoxMenu.FlatStyle = FlatStyle.Flat;
            groupBoxMenu.ForeColor = SystemColors.ControlText;
            groupBoxMenu.Location = new Point(0, 0);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(202, 681);
            groupBoxMenu.TabIndex = 1;
            groupBoxMenu.TabStop = false;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = SystemColors.ControlLightLight;
            labelMenu.FlatStyle = FlatStyle.Flat;
            labelMenu.Font = new Font("Segoe UI", 24F);
            labelMenu.ForeColor = SystemColors.ControlText;
            labelMenu.Location = new Point(6, 19);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(102, 45);
            labelMenu.TabIndex = 29;
            labelMenu.Text = "Menu";
            // 
            // providerOption
            // 
            providerOption.BackColor = SystemColors.ControlLightLight;
            providerOption.FlatStyle = FlatStyle.Flat;
            providerOption.Font = new Font("Segoe UI", 12F);
            providerOption.ForeColor = SystemColors.ControlText;
            providerOption.Location = new Point(6, 336);
            providerOption.Name = "providerOption";
            providerOption.Size = new Size(188, 45);
            providerOption.TabIndex = 28;
            providerOption.Text = "Providers";
            providerOption.UseVisualStyleBackColor = false;
            // 
            // supplyOption
            // 
            supplyOption.BackColor = SystemColors.ControlLightLight;
            supplyOption.FlatStyle = FlatStyle.Flat;
            supplyOption.Font = new Font("Segoe UI", 12F);
            supplyOption.ForeColor = SystemColors.ControlText;
            supplyOption.Location = new Point(6, 285);
            supplyOption.Name = "supplyOption";
            supplyOption.Size = new Size(188, 45);
            supplyOption.TabIndex = 27;
            supplyOption.Text = "Supplies";
            supplyOption.UseVisualStyleBackColor = false;
            // 
            // productOption
            // 
            productOption.BackColor = SystemColors.ControlLightLight;
            productOption.FlatStyle = FlatStyle.Flat;
            productOption.Font = new Font("Segoe UI", 12F);
            productOption.ForeColor = SystemColors.ControlText;
            productOption.Location = new Point(6, 234);
            productOption.Name = "productOption";
            productOption.Size = new Size(189, 45);
            productOption.TabIndex = 26;
            productOption.Text = "Products";
            productOption.UseVisualStyleBackColor = false;
            // 
            // orderOption
            // 
            orderOption.BackColor = SystemColors.ControlLightLight;
            orderOption.FlatStyle = FlatStyle.Flat;
            orderOption.Font = new Font("Segoe UI", 12F);
            orderOption.ForeColor = SystemColors.ControlText;
            orderOption.Location = new Point(6, 183);
            orderOption.Name = "orderOption";
            orderOption.Size = new Size(189, 45);
            orderOption.TabIndex = 25;
            orderOption.Text = "Orders";
            orderOption.UseVisualStyleBackColor = false;
            // 
            // employeeOption
            // 
            employeeOption.BackColor = SystemColors.ControlLightLight;
            employeeOption.FlatStyle = FlatStyle.Flat;
            employeeOption.Font = new Font("Segoe UI", 12F);
            employeeOption.ForeColor = SystemColors.ControlText;
            employeeOption.Location = new Point(6, 132);
            employeeOption.Name = "employeeOption";
            employeeOption.Size = new Size(188, 45);
            employeeOption.TabIndex = 24;
            employeeOption.Text = "Employers";
            employeeOption.UseVisualStyleBackColor = false;
            // 
            // customerOption
            // 
            customerOption.BackColor = SystemColors.ControlLightLight;
            customerOption.FlatStyle = FlatStyle.Flat;
            customerOption.Font = new Font("Segoe UI", 12F);
            customerOption.Location = new Point(6, 81);
            customerOption.Name = "customerOption";
            customerOption.Size = new Size(188, 45);
            customerOption.TabIndex = 23;
            customerOption.Text = "Customers";
            customerOption.UseVisualStyleBackColor = false;
            // 
            // ReportOption
            // 
            ReportOption.BackColor = SystemColors.ControlLightLight;
            ReportOption.FlatStyle = FlatStyle.Flat;
            ReportOption.Font = new Font("Segoe UI", 12F);
            ReportOption.ForeColor = SystemColors.ControlText;
            ReportOption.Location = new Point(6, 624);
            ReportOption.Name = "ReportOption";
            ReportOption.Size = new Size(188, 45);
            ReportOption.TabIndex = 30;
            ReportOption.Text = "Report";
            ReportOption.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1264, 681);
            Controls.Add(labelHello);
            Controls.Add(groupBoxMenu);
            Controls.Add(buttonMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Warehouse";
            groupBoxMenu.ResumeLayout(false);
            groupBoxMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ReportOption;
    }
}