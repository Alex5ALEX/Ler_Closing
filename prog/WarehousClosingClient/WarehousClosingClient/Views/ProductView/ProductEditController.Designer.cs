namespace WarehousClosingClient.Views.ProductView;

partial class ProductEditController
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
        buttonBack = new Button();
        buttonEdit = new Button();
        textBoxName = new TextBox();
        labelPrice = new Label();
        labelName = new Label();
        label = new Label();
        labelId = new Label();
        buttonDelete = new Button();
        groupBox1 = new GroupBox();
        richTextBoxId = new RichTextBox();
        textBoxPrice = new TextBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // buttonBack
        // 
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(6, 508);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(87, 71);
        buttonBack.TabIndex = 25;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.Location = new Point(329, 508);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(87, 71);
        buttonEdit.TabIndex = 24;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(125, 173);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(291, 29);
        textBoxName.TabIndex = 20;
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(36, 229);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 15;
        labelPrice.Text = "Price:";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(36, 181);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 14;
        labelName.Text = "Name:";
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(162, 37);
        label.TabIndex = 13;
        label.Text = "Edit Product";
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("Segoe UI", 12F);
        labelId.Location = new Point(36, 120);
        labelId.Name = "labelId";
        labelId.Size = new Size(26, 21);
        labelId.TabIndex = 26;
        labelId.Text = "Id:";
        // 
        // buttonDelete
        // 
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.Location = new Point(167, 508);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(87, 71);
        buttonDelete.TabIndex = 28;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBoxPrice);
        groupBox1.Controls.Add(richTextBoxId);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(labelId);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(435, 585);
        groupBox1.TabIndex = 29;
        groupBox1.TabStop = false;
        // 
        // richTextBoxId
        // 
        richTextBoxId.Font = new Font("Segoe UI", 12F);
        richTextBoxId.Location = new Point(125, 70);
        richTextBoxId.Name = "richTextBoxId";
        richTextBoxId.Size = new Size(291, 71);
        richTextBoxId.TabIndex = 29;
        richTextBoxId.Text = "";
        // 
        // textBoxPrice
        // 
        textBoxPrice.Font = new Font("Segoe UI", 12F);
        textBoxPrice.Location = new Point(125, 221);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.Size = new Size(291, 29);
        textBoxPrice.TabIndex = 30;
        // 
        // ProductEditController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "ProductEditController";
        Size = new Size(435, 585);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonBack;
    private Button buttonEdit;
    private TextBox textBoxAddres;
    private TextBox textBoxEmail;
    private TextBox textBoxPhone;
    private TextBox textBoxName;
    private TextBox textBoxSurname;
    private Label labelAddres;
    private Label labelEmail;
    private Label labelPhone;
    private Label labelPrice;
    private Label labelName;
    private Label label;
    private Label labelId;
    private Button buttonDelete;
    private GroupBox groupBox1;
    private RichTextBox richTextBoxId;
    private Label labelJobtitle;
    private TextBox textBoxJobtitle;
    private TextBox textBoxPrice;
}
