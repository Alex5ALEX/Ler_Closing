namespace WarehousClosingClient.Views.ProductView;

partial class ProductAddController
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
        labelName = new Label();
        labelPrice = new Label();
        textBoxPrice = new TextBox();
        textBoxName = new TextBox();
        buttonAdd = new Button();
        buttonBack = new Button();
        groupBox1 = new GroupBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(165, 37);
        label.TabIndex = 0;
        label.Text = "Add Product";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(27, 115);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 1;
        labelName.Text = "Name:";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(27, 157);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 2;
        labelPrice.Text = "Price:";
        // 
        // textBoxPrice
        // 
        textBoxPrice.Font = new Font("Segoe UI", 12F);
        textBoxPrice.Location = new Point(108, 149);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.Size = new Size(291, 29);
        textBoxPrice.TabIndex = 6;
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(108, 107);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(291, 29);
        textBoxName.TabIndex = 7;
        // 
        // buttonAdd
        // 
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(307, 509);
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
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(textBoxPrice);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(435, 585);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // ProductAddController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "ProductAddController";
        Size = new Size(435, 585);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelName;
    private Label labelPrice;
    private TextBox textBoxPrice;
    private TextBox textBoxName;
    private Button buttonAdd;
    private Button buttonBack;
    private GroupBox groupBox1;
}
