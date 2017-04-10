namespace Flyweight
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("12");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("20");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Black");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Yellow");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Red");
            this.pctPaint = new System.Windows.Forms.PictureBox();
            this.lstWeights = new System.Windows.Forms.ListView();
            this.lstColors = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPaint
            // 
            this.pctPaint.Location = new System.Drawing.Point(121, 4);
            this.pctPaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctPaint.Name = "pctPaint";
            this.pctPaint.Size = new System.Drawing.Size(697, 375);
            this.pctPaint.TabIndex = 0;
            this.pctPaint.TabStop = false;
            this.pctPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pctPaint_Paint);
            this.pctPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseDown);
            this.pctPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseMove);
            this.pctPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseUp);
            // 
            // lstWeights
            // 
            this.lstWeights.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstWeights.Location = new System.Drawing.Point(16, 229);
            this.lstWeights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstWeights.Name = "lstWeights";
            this.lstWeights.Size = new System.Drawing.Size(96, 149);
            this.lstWeights.TabIndex = 6;
            this.lstWeights.UseCompatibleStateImageBehavior = false;
            this.lstWeights.SelectedIndexChanged += new System.EventHandler(this.lstWeights_SelectedIndexChanged);
            // 
            // lstColors
            // 
            this.lstColors.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstColors.Location = new System.Drawing.Point(16, 39);
            this.lstColors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(96, 146);
            this.lstColors.TabIndex = 7;
            this.lstColors.UseCompatibleStateImageBehavior = false;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.lstWeights);
            this.Controls.Add(this.pctPaint);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pctPaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPaint;
        private System.Windows.Forms.ListView lstWeights;
        private System.Windows.Forms.ListView lstColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

