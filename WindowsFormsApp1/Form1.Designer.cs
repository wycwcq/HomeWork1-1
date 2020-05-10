namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.num1txt = new System.Windows.Forms.TextBox();
            this.CbFunc = new System.Windows.Forms.ComboBox();
            this.num2txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resulttxt = new System.Windows.Forms.TextBox();
            this.btnCaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1txt
            // 
            this.num1txt.Location = new System.Drawing.Point(119, 139);
            this.num1txt.Name = "num1txt";
            this.num1txt.Size = new System.Drawing.Size(100, 21);
            this.num1txt.TabIndex = 0;
            this.num1txt.TextChanged += new System.EventHandler(this.num1txt_TextChanged);
            // 
            // CbFunc
            // 
            this.CbFunc.FormattingEnabled = true;
            this.CbFunc.Location = new System.Drawing.Point(235, 139);
            this.CbFunc.Name = "CbFunc";
            this.CbFunc.Size = new System.Drawing.Size(58, 20);
            this.CbFunc.TabIndex = 1;
            // 
            // num2txt
            // 
            this.num2txt.Location = new System.Drawing.Point(311, 139);
            this.num2txt.Name = "num2txt";
            this.num2txt.Size = new System.Drawing.Size(100, 21);
            this.num2txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(417, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // resulttxt
            // 
            this.resulttxt.Location = new System.Drawing.Point(454, 139);
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.Size = new System.Drawing.Size(100, 21);
            this.resulttxt.TabIndex = 4;
            // 
            // btnCaluate
            // 
            this.btnCaluate.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCaluate.Location = new System.Drawing.Point(235, 249);
            this.btnCaluate.Name = "btnCaluate";
            this.btnCaluate.Size = new System.Drawing.Size(176, 105);
            this.btnCaluate.TabIndex = 5;
            this.btnCaluate.Text = "计算";
            this.btnCaluate.UseVisualStyleBackColor = true;
            this.btnCaluate.Click += new System.EventHandler(this.btnCaluate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaluate);
            this.Controls.Add(this.resulttxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2txt);
            this.Controls.Add(this.CbFunc);
            this.Controls.Add(this.num1txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1txt;
        private System.Windows.Forms.ComboBox CbFunc;
        private System.Windows.Forms.TextBox num2txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resulttxt;
        private System.Windows.Forms.Button btnCaluate;
    }
}

