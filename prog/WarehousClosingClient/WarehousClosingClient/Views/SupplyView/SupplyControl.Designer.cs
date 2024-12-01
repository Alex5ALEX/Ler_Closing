namespace WarehousClosingClient.Views.SupplyView;

partial class SupplyControl
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
        labelMenuName.Location = new Point(424, 35);
        labelMenuName.Name = "labelMenuName";
        labelMenuName.Size = new Size(169, 50);
        labelMenuName.TabIndex = 8;
        labelMenuName.Text = "Supplyes";
        // 
        // buttonAddNew
        // 
        buttonAddNew.Location = new Point(366, 28);
        buttonAddNew.Margin = new Padding(3, 4, 3, 4);
        buttonAddNew.Name = "buttonAddNew";
        buttonAddNew.Size = new Size(99, 65);
        buttonAddNew.TabIndex = 7;
        buttonAddNew.Text = "Add New";
        buttonAddNew.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel
        // 
        flowLayoutPanel.AutoScroll = true;
        flowLayoutPanel.Location = new Point(8, 100);
        flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
        flowLayoutPanel.Name = "flowLayoutPanel";
        flowLayoutPanel.Size = new Size(457, 722);
        flowLayoutPanel.TabIndex = 6;
        // 
        // buttonEdit
        // 
        buttonEdit.Location = new Point(251, 28);
        buttonEdit.Margin = new Padding(3, 4, 3, 4);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(99, 65);
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
        groupBox.Margin = new Padding(3, 4, 3, 4);
        groupBox.Name = "groupBox";
        groupBox.Padding = new Padding(3, 4, 3, 4);
        groupBox.Size = new Size(1440, 861);
        groupBox.TabIndex = 12;
        groupBox.TabStop = false;
        // 
        // groupBoxList
        // 
        groupBoxList.Controls.Add(buttonEdit);
        groupBoxList.Controls.Add(flowLayoutPanel);
        groupBoxList.Controls.Add(buttonAddNew);
        groupBoxList.Location = new Point(961, 19);
        groupBoxList.Margin = new Padding(3, 4, 3, 4);
        groupBoxList.Name = "groupBoxList";
        groupBoxList.Padding = new Padding(3, 4, 3, 4);
        groupBoxList.Size = new Size(475, 830);
        groupBoxList.TabIndex = 11;
        groupBoxList.TabStop = false;
        // 
        // groupBoxAction
        // 
        groupBoxAction.Location = new Point(6, 108);
        groupBoxAction.Margin = new Padding(3, 4, 3, 4);
        groupBoxAction.Name = "groupBoxAction";
        groupBoxAction.Padding = new Padding(3, 4, 3, 4);
        groupBoxAction.Size = new Size(949, 741);
        groupBoxAction.TabIndex = 10;
        groupBoxAction.TabStop = false;
        // 
        // buttonMenu
        // 
        buttonMenu.BackColor = Color.FromArgb(240, 240, 240);
        buttonMenu.Font = new Font("Segoe UI", 12F);
        buttonMenu.Location = new Point(6, 19);
        buttonMenu.Margin = new Padding(3, 4, 3, 4);
        buttonMenu.Name = "buttonMenu";
        buttonMenu.Size = new Size(91, 76);
        buttonMenu.TabIndex = 0;
        buttonMenu.Text = "Menu";
        buttonMenu.UseVisualStyleBackColor = false;
        // 
        // SupplyControl
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SupplyControl";
        Size = new Size(1440, 861);
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
