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
        labelCustomer = new Label();
        labelEmployee = new Label();
        textBoxCustomer = new TextBox();
        textBoxDate = new TextBox();
        textBoxEmployee = new TextBox();
        buttonAdd = new Button();
        buttonBack = new Button();
        groupBox1 = new GroupBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        groupBox1.SuspendLayout();
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
        labelDate.Location = new Point(15, 105);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(45, 21);
        labelDate.TabIndex = 1;
        labelDate.Text = "Date:";
        // 
        // labelCustomer
        // 
        labelCustomer.AutoSize = true;
        labelCustomer.Font = new Font("Segoe UI", 12F);
        labelCustomer.Location = new Point(15, 147);
        labelCustomer.Name = "labelCustomer";
        labelCustomer.Size = new Size(81, 21);
        labelCustomer.TabIndex = 2;
        labelCustomer.Text = "Customer:";
        // 
        // labelEmployee
        // 
        labelEmployee.AutoSize = true;
        labelEmployee.Font = new Font("Segoe UI", 12F);
        labelEmployee.Location = new Point(15, 193);
        labelEmployee.Name = "labelEmployee";
        labelEmployee.Size = new Size(81, 21);
        labelEmployee.TabIndex = 3;
        labelEmployee.Text = "Employee:";
        // 
        // textBoxCustomer
        // 
        textBoxCustomer.Font = new Font("Segoe UI", 12F);
        textBoxCustomer.Location = new Point(96, 139);
        textBoxCustomer.Name = "textBoxCustomer";
        textBoxCustomer.Size = new Size(291, 29);
        textBoxCustomer.TabIndex = 6;
        // 
        // textBoxDate
        // 
        textBoxDate.Font = new Font("Segoe UI", 12F);
        textBoxDate.Location = new Point(96, 97);
        textBoxDate.Name = "textBoxDate";
        textBoxDate.Size = new Size(291, 29);
        textBoxDate.TabIndex = 7;
        // 
        // textBoxEmployee
        // 
        textBoxEmployee.Font = new Font("Segoe UI", 12F);
        textBoxEmployee.Location = new Point(96, 185);
        textBoxEmployee.Name = "textBoxEmployee";
        textBoxEmployee.Size = new Size(291, 29);
        textBoxEmployee.TabIndex = 8;
        // 
        // buttonAdd
        // 
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(265, 509);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(122, 70);
        buttonAdd.TabIndex = 11;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // buttonBack
        // 
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(6, 509);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(122, 70);
        buttonBack.TabIndex = 12;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(flowLayoutPanel1);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(labelCustomer);
        groupBox1.Controls.Add(labelEmployee);
        groupBox1.Controls.Add(textBoxEmployee);
        groupBox1.Controls.Add(textBoxDate);
        groupBox1.Controls.Add(textBoxCustomer);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(830, 585);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.Location = new Point(399, 22);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(425, 557);
        flowLayoutPanel1.TabIndex = 13;
        // 
        // OrderAddController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "OrderAddController";
        Size = new Size(830, 585);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelDate;
    private Label labelCustomer;
    private Label labelEmployee;
    private TextBox textBoxCustomer;
    private TextBox textBoxDate;
    private TextBox textBoxEmployee;
    private Button buttonAdd;
    private Button buttonBack;
    private GroupBox groupBox1;
    private FlowLayoutPanel flowLayoutPanel1;
}
