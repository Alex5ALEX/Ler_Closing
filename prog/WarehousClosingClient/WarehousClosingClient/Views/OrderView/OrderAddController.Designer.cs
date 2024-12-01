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
        label.Location = new Point(7, 24);
        label.Name = "label";
        label.Size = new Size(161, 42);
        label.TabIndex = 0;
        label.Text = "Add Order";
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(17, 133);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(55, 25);
        labelDate.TabIndex = 1;
        labelDate.Text = "Date:";
        // 
        // labelCustomer
        // 
        labelCustomer.AutoSize = true;
        labelCustomer.Font = new Font("Segoe UI", 12F);
        labelCustomer.Location = new Point(17, 186);
        labelCustomer.Name = "labelCustomer";
        labelCustomer.Size = new Size(97, 25);
        labelCustomer.TabIndex = 2;
        labelCustomer.Text = "Customer:";
        // 
        // labelEmployee
        // 
        labelEmployee.AutoSize = true;
        labelEmployee.Font = new Font("Segoe UI", 12F);
        labelEmployee.Location = new Point(17, 244);
        labelEmployee.Name = "labelEmployee";
        labelEmployee.Size = new Size(98, 25);
        labelEmployee.TabIndex = 3;
        labelEmployee.Text = "Employee:";
        // 
        // textBoxCustomer
        // 
        textBoxCustomer.Font = new Font("Segoe UI", 12F);
        textBoxCustomer.Location = new Point(120, 176);
        textBoxCustomer.Margin = new Padding(3, 4, 3, 4);
        textBoxCustomer.Name = "textBoxCustomer";
        textBoxCustomer.Size = new Size(322, 32);
        textBoxCustomer.TabIndex = 6;
        // 
        // textBoxDate
        // 
        textBoxDate.Font = new Font("Segoe UI", 12F);
        textBoxDate.Location = new Point(120, 123);
        textBoxDate.Margin = new Padding(3, 4, 3, 4);
        textBoxDate.Name = "textBoxDate";
        textBoxDate.Size = new Size(322, 32);
        textBoxDate.TabIndex = 7;
        // 
        // textBoxEmployee
        // 
        textBoxEmployee.Font = new Font("Segoe UI", 12F);
        textBoxEmployee.Location = new Point(120, 234);
        textBoxEmployee.Margin = new Padding(3, 4, 3, 4);
        textBoxEmployee.Name = "textBoxEmployee";
        textBoxEmployee.Size = new Size(322, 32);
        textBoxEmployee.TabIndex = 8;
        // 
        // buttonAdd
        // 
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(303, 645);
        buttonAdd.Margin = new Padding(3, 4, 3, 4);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(139, 89);
        buttonAdd.TabIndex = 11;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // buttonBack
        // 
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(7, 645);
        buttonBack.Margin = new Padding(3, 4, 3, 4);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(139, 89);
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
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(949, 741);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.Location = new Point(456, 28);
        flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(486, 706);
        flowLayoutPanel1.TabIndex = 13;
        // 
        // OrderAddController
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "OrderAddController";
        Size = new Size(949, 741);
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
