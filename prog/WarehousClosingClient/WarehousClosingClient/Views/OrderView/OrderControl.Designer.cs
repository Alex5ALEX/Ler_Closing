namespace WarehousClosingClient.Views.OrderView
{
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
            label1 = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 5;
            label1.Text = "Orders";
            // 
            // button1
            // 
            button1.Location = new Point(520, 9);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 4;
            button1.Text = "Add New";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 49);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(604, 439);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Name = "OrderControl";
            Size = new Size(610, 495);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
