namespace WarehousClosingClient.Views.SupplyView;

partial class SupplyAddController
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
        labelPrice = new Label();
        labelProvider = new Label();
        textBoxPrice = new TextBox();
        textBoxDate = new TextBox();
        textBoxProvider = new TextBox();
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
        label.Size = new Size(175, 42);
        label.TabIndex = 0;
        label.Text = "Add Supply";
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
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(17, 186);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(58, 25);
        labelPrice.TabIndex = 2;
        labelPrice.Text = "Price:";
        // 
        // labelProvider
        // 
        labelProvider.AutoSize = true;
        labelProvider.Font = new Font("Segoe UI", 12F);
        labelProvider.Location = new Point(17, 236);
        labelProvider.Name = "labelProvider";
        labelProvider.Size = new Size(87, 25);
        labelProvider.TabIndex = 3;
        labelProvider.Text = "Provider:";
        // 
        // textBoxPrice
        // 
        textBoxPrice.Font = new Font("Segoe UI", 12F);
        textBoxPrice.Location = new Point(120, 176);
        textBoxPrice.Margin = new Padding(3, 4, 3, 4);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.Size = new Size(322, 32);
        textBoxPrice.TabIndex = 6;
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
        // textBoxProvider
        // 
        textBoxProvider.Font = new Font("Segoe UI", 12F);
        textBoxProvider.Location = new Point(120, 229);
        textBoxProvider.Margin = new Padding(3, 4, 3, 4);
        textBoxProvider.Name = "textBoxProvider";
        textBoxProvider.Size = new Size(322, 32);
        textBoxProvider.TabIndex = 8;
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
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(labelProvider);
        groupBox1.Controls.Add(textBoxProvider);
        groupBox1.Controls.Add(textBoxDate);
        groupBox1.Controls.Add(textBoxPrice);
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
        // SupplyAddController
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SupplyAddController";
        Size = new Size(949, 741);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelDate;
    private Label labelPrice;
    private Label labelProvider;
    private TextBox textBoxPrice;
    private TextBox textBoxDate;
    private TextBox textBoxProvider;
    private Button buttonAdd;
    private Button buttonBack;
    private GroupBox groupBox1;
    private FlowLayoutPanel flowLayoutPanel1;
}
