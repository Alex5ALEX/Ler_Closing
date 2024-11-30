namespace WarehousClosingClient.Views.OrderView;

partial class OrderControl
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
        labelMenuName = new Label();
        buttonAddNew = new Button();
        flowLayoutPanel = new FlowLayoutPanel();
        buttonEdit = new Button();
        groupBox = new GroupBox();
        groupBoxList = new GroupBox();
        groupBoxAction = new GroupBox();
        buttonMenu = new Button();
        groupBox.SuspendLayout();
        groupBoxList.SuspendLayout();
        SuspendLayout();
        // 
        // labelMenuName
        // 
        labelMenuName.AutoSize = true;
        labelMenuName.Font = new Font("Segoe UI", 24F);
        labelMenuName.Location = new Point(384, 31);
        labelMenuName.Name = "labelMenuName";
        labelMenuName.Size = new Size(116, 45);
        labelMenuName.TabIndex = 8;
        labelMenuName.Text = "Orders";
        // 
        // buttonAddNew
        // 
        buttonAddNew.Location = new Point(320, 22);
        buttonAddNew.Name = "buttonAddNew";
        buttonAddNew.Size = new Size(87, 51);
        buttonAddNew.TabIndex = 7;
        buttonAddNew.Text = "Add New";
        buttonAddNew.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel
        // 
        flowLayoutPanel.AutoScroll = true;
        flowLayoutPanel.Location = new Point(7, 79);
        flowLayoutPanel.Name = "flowLayoutPanel";
        flowLayoutPanel.Size = new Size(400, 570);
        flowLayoutPanel.TabIndex = 6;
        // 
        // buttonEdit
        // 
        buttonEdit.Location = new Point(220, 22);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(87, 51);
        buttonEdit.TabIndex = 9;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // groupBox
        // 
        groupBox.Controls.Add(groupBoxList);
        groupBox.Controls.Add(groupBoxAction);
        groupBox.Controls.Add(buttonMenu);
        groupBox.Controls.Add(labelMenuName);
        groupBox.Location = new Point(0, 0);
        groupBox.Name = "groupBox";
        groupBox.Size = new Size(1260, 680);
        groupBox.TabIndex = 12;
        groupBox.TabStop = false;
        // 
        // groupBoxList
        // 
        groupBoxList.Controls.Add(buttonEdit);
        groupBoxList.Controls.Add(flowLayoutPanel);
        groupBoxList.Controls.Add(buttonAddNew);
        groupBoxList.Location = new Point(841, 15);
        groupBoxList.Name = "groupBoxList";
        groupBoxList.Size = new Size(416, 655);
        groupBoxList.TabIndex = 11;
        groupBoxList.TabStop = false;
        // 
        // groupBoxAction
        // 
        groupBoxAction.Location = new Point(5, 85);
        groupBoxAction.Name = "groupBoxAction";
        groupBoxAction.Size = new Size(830, 585);
        groupBoxAction.TabIndex = 10;
        groupBoxAction.TabStop = false;
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
        // OrderControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox);
        Name = "OrderControl";
        Size = new Size(1260, 680);
        groupBox.ResumeLayout(false);
        groupBox.PerformLayout();
        groupBoxList.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label labelMenuName;
    private Button buttonAddNew;
    private FlowLayoutPanel flowLayoutPanel;
    private Button buttonEdit;
    private GroupBox groupBox;
    private Button buttonMenu;
    private GroupBox groupBoxList;
    private GroupBox groupBoxAction;
}
