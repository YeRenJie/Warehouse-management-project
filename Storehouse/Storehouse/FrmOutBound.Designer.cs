namespace Storehouse
{
    partial class FrmOutBound
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnoutBound = new System.Windows.Forms.Button();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.txtGoodsColor = new System.Windows.Forms.TextBox();
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnoutBound
            // 
            this.btnoutBound.Location = new System.Drawing.Point(43, 253);
            this.btnoutBound.Name = "btnoutBound";
            this.btnoutBound.Size = new System.Drawing.Size(85, 35);
            this.btnoutBound.TabIndex = 5;
            this.btnoutBound.Text = "出 库";
            this.btnoutBound.UseVisualStyleBackColor = true;
            this.btnoutBound.Click += new System.EventHandler(this.btnoutBound_Click);
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Location = new System.Drawing.Point(92, 168);
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(169, 21);
            this.txtGoodsNum.TabIndex = 3;
            this.txtGoodsNum.TextChanged += new System.EventHandler(this.txtGoodsNum_TextChanged);
            // 
            // txtGoodsColor
            // 
            this.txtGoodsColor.Location = new System.Drawing.Point(92, 117);
            this.txtGoodsColor.Name = "txtGoodsColor";
            this.txtGoodsColor.Size = new System.Drawing.Size(169, 21);
            this.txtGoodsColor.TabIndex = 2;
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(92, 67);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.Size = new System.Drawing.Size(169, 21);
            this.txtGoodsID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数 量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "颜 色";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "编 号";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // FrmOutBound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 352);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnoutBound);
            this.Controls.Add(this.txtGoodsNum);
            this.Controls.Add(this.txtGoodsColor);
            this.Controls.Add(this.txtGoodsID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(335, 390);
            this.MinimumSize = new System.Drawing.Size(335, 390);
            this.Name = "FrmOutBound";
            this.Text = "货物出库";
            this.Load += new System.EventHandler(this.FrmOutBound_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnoutBound;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.TextBox txtGoodsColor;
        private System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
    }
}