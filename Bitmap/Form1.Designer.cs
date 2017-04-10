namespace Bitmap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGet = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pctOrigin = new System.Windows.Forms.PictureBox();
            this.pctExchange = new System.Windows.Forms.PictureBox();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.btnGetImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(13, 13);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(103, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get image";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(122, 13);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(115, 23);
            this.btnNegative.TabIndex = 1;
            this.btnNegative.Text = "Get negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(243, 13);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(108, 23);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Turn left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(357, 13);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(102, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "Turn right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(465, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pctOrigin
            // 
            this.pctOrigin.Image = ((System.Drawing.Image)(resources.GetObject("pctOrigin.Image")));
            this.pctOrigin.Location = new System.Drawing.Point(13, 62);
            this.pctOrigin.Name = "pctOrigin";
            this.pctOrigin.Size = new System.Drawing.Size(271, 256);
            this.pctOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctOrigin.TabIndex = 5;
            this.pctOrigin.TabStop = false;
            // 
            // pctExchange
            // 
            this.pctExchange.Location = new System.Drawing.Point(290, 62);
            this.pctExchange.Name = "pctExchange";
            this.pctExchange.Size = new System.Drawing.Size(279, 256);
            this.pctExchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExchange.TabIndex = 6;
            this.pctExchange.TabStop = false;
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Location = new System.Drawing.Point(13, 334);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(271, 23);
            this.btnUploadImg.TabIndex = 7;
            this.btnUploadImg.Text = "Upload images";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // btnGetImg
            // 
            this.btnGetImg.Location = new System.Drawing.Point(290, 334);
            this.btnGetImg.Name = "btnGetImg";
            this.btnGetImg.Size = new System.Drawing.Size(279, 23);
            this.btnGetImg.TabIndex = 8;
            this.btnGetImg.Text = "Get the images";
            this.btnGetImg.UseVisualStyleBackColor = true;
            this.btnGetImg.Click += new System.EventHandler(this.btnGetImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 369);
            this.Controls.Add(this.btnGetImg);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.pctExchange);
            this.Controls.Add(this.pctOrigin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "Adapter";
            ((System.ComponentModel.ISupportInitialize)(this.pctOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pctOrigin;
        private System.Windows.Forms.PictureBox pctExchange;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.Button btnGetImg;
    }
}

