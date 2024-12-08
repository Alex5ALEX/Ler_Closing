namespace WarehousClosingClient.Views.OrderView;

partial class OrderAddController
{
    /// <summary> 
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
        label = new Label();
        labelDate = new Label();
        groupBox1 = new GroupBox();
        buttonBack = new Button();
        buttonAdd = new Button();
        tabControl = new TabControl();
        tabPageProducts = new TabPage();
        flowLayoutPanelProducts = new FlowLayoutPanel();
        tabPageCustomer = new TabPage();
        flowLayoutPanelCustomers = new FlowLayoutPanel();
        tabPageEmployee = new TabPage();
        flowLayoutPanelEmployers = new FlowLayoutPanel();
        dateTimePicker = new DateTimePicker();
        groupBox2 = new GroupBox();
        groupBox3 = new GroupBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        groupBox1.SuspendLayout();
        tabControl.SuspendLayout();
        tabPageProducts.SuspendLayout();
        tabPageCustomer.SuspendLayout();
        tabPageEmployee.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(141, 37);
        label.TabIndex = 0;
        label.Text = "Add Order";
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(15, 69);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(45, 21);
        labelDate.TabIndex = 1;
        labelDate.Text = "Date:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox3);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(tabControl);
        groupBox1.Controls.Add(dateTimePicker);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(680, 585);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(6, 528);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 17;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(197, 528);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 50);
        buttonAdd.TabIndex = 16;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabPageProducts);
        tabControl.Controls.Add(tabPageCustomer);
        tabControl.Controls.Add(tabPageEmployee);
        tabControl.Font = new Font("Segoe UI", 12F);
        tabControl.Location = new Point(312, 19);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(362, 563);
        tabControl.TabIndex = 15;
        // 
        // tabPageProducts
        // 
        tabPageProducts.Controls.Add(flowLayoutPanelProducts);
        tabPageProducts.Location = new Point(4, 30);
        tabPageProducts.Name = "tabPageProducts";
        tabPageProducts.Padding = new Padding(3);
        tabPageProducts.Size = new Size(354, 529);
        tabPageProducts.TabIndex = 0;
        tabPageProducts.Text = "Products";
        tabPageProducts.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelProducts
        // 
        flowLayoutPanelProducts.AutoScroll = true;
        flowLayoutPanelProducts.Location = new Point(0, 0);
        flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
        flowLayoutPanelProducts.Size = new Size(354, 529);
        flowLayoutPanelProducts.TabIndex = 0;
        // 
        // tabPageCustomer
        // 
        tabPageCustomer.Controls.Add(flowLayoutPanelCustomers);
        tabPageCustomer.Location = new Point(4, 30);
        tabPageCustomer.Name = "tabPageCustomer";
        tabPageCustomer.Padding = new Padding(3);
        tabPageCustomer.Size = new Size(354, 529);
        tabPageCustomer.TabIndex = 1;
        tabPageCustomer.Text = "Customer";
        tabPageCustomer.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelCustomers
        // 
        flowLayoutPanelCustomers.AutoScroll = true;
        flowLayoutPanelCustomers.Location = new Point(0, 0);
        flowLayoutPanelCustomers.Name = "flowLayoutPanelCustomers";
        flowLayoutPanelCustomers.Size = new Size(354, 529);
        flowLayoutPanelCustomers.TabIndex = 0;
        // 
        // tabPageEmployee
        // 
        tabPageEmployee.Controls.Add(flowLayoutPanelEmployers);
        tabPageEmployee.Location = new Point(4, 30);
        tabPageEmployee.Name = "tabPageEmployee";
        tabPageEmployee.Padding = new Padding(3);
        tabPageEmployee.Size = new Size(354, 529);
        tabPageEmployee.TabIndex = 2;
        tabPageEmployee.Text = "Employee";
        tabPageEmployee.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelEmployers
        // 
        flowLayoutPanelEmployers.AutoScroll = true;
        flowLayoutPanelEmployers.Location = new Point(0, 0);
        flowLayoutPanelEmployers.Name = "flowLayoutPanelEmployers";
        flowLayoutPanelEmployers.Size = new Size(354, 529);
        flowLayoutPanelEmployers.TabIndex = 0;
        // 
        // dateTimePicker
        // 
        dateTimePicker.CalendarFont = new Font("Segoe UI", 12F);
        dateTimePicker.Font = new Font("Segoe UI", 12F);
        dateTimePicker.Location = new Point(15, 93);
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new Size(282, 29);
        dateTimePicker.TabIndex = 14;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(15, 150);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(282, 130);
        groupBox2.TabIndex = 18;
        groupBox2.TabStop = false;
        groupBox2.Text = "Customer";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label5);
        groupBox3.Controls.Add(label6);
        groupBox3.Controls.Add(label7);
        groupBox3.Controls.Add(label8);
        groupBox3.Font = new Font("Segoe UI", 12F);
        groupBox3.Location = new Point(15, 311);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(282, 130);
        groupBox3.TabIndex = 19;
        groupBox3.TabStop = false;
        groupBox3.Text = "Employee";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(18, 25);
        label1.Name = "label1";
        label1.Size = new Size(0, 21);
        label1.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(148, 25);
        label2.Name = "label2";
        label2.Size = new Size(0, 21);
        label2.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(18, 57);
        label3.Name = "label3";
        label3.Size = new Size(0, 21);
        label3.TabIndex = 2;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(18, 91);
        label4.Name = "label4";
        label4.Size = new Size(0, 21);
        label4.TabIndex = 3;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(18, 100);
        label5.Name = "label5";
        label5.Size = new Size(0, 21);
        label5.TabIndex = 7;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(18, 68);
        label6.Name = "label6";
        label6.Size = new Size(0, 21);
        label6.TabIndex = 6;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(148, 34);
        label7.Name = "label7";
        label7.Size = new Size(0, 21);
        label7.TabIndex = 5;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(18, 34);
        label8.Name = "label8";
        label8.Size = new Size(0, 21);
        label8.TabIndex = 4;
        // 
        // OrderAddController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "OrderAddController";
        Size = new Size(680, 585);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tabControl.ResumeLayout(false);
        tabPageProducts.ResumeLayout(false);
        tabPageCustomer.ResumeLayout(false);
        tabPageEmployee.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelDate;
    private GroupBox groupBox1;
    private DateTimePicker dateTimePicker;
    private TabControl tabControl;
    private TabPage tabPageProducts;
    private TabPage tabPageCustomer;
    private TabPage tabPageEmployee;
    private Button buttonBack;
    private Button buttonAdd;
    private FlowLayoutPanel flowLayoutPanelProducts;
    private FlowLayoutPanel flowLayoutPanelCustomers;
    private FlowLayoutPanel flowLayoutPanelEmployers;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
}
