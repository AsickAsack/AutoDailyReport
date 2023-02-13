
namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyPlan_TextBox = new System.Windows.Forms.RichTextBox();
            this.MyTask_TextBox = new System.Windows.Forms.RichTextBox();
            this.MyPlan = new System.Windows.Forms.Label();
            this.MyTask = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.Label();
            this.Create_Btn = new System.Windows.Forms.Button();
            this.FilePath_TextBox = new System.Windows.Forms.TextBox();
            this.FilePath_Btn = new System.Windows.Forms.Button();
            this.MyName_TextBox = new System.Windows.Forms.RichTextBox();
            this.grpFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.pictureBox1);
            this.grpFont.Controls.Add(this.MyPlan_TextBox);
            this.grpFont.Controls.Add(this.MyTask_TextBox);
            this.grpFont.Controls.Add(this.MyName_TextBox);
            this.grpFont.Controls.Add(this.MyPlan);
            this.grpFont.Controls.Add(this.MyTask);
            this.grpFont.Controls.Add(this.MyName);
            this.grpFont.Location = new System.Drawing.Point(22, 25);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(521, 412);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MyPlan_TextBox
            // 
            this.MyPlan_TextBox.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPlan_TextBox.Location = new System.Drawing.Point(54, 228);
            this.MyPlan_TextBox.Name = "MyPlan_TextBox";
            this.MyPlan_TextBox.Size = new System.Drawing.Size(395, 160);
            this.MyPlan_TextBox.TabIndex = 8;
            this.MyPlan_TextBox.Text = "";
            // 
            // MyTask_TextBox
            // 
            this.MyTask_TextBox.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyTask_TextBox.Location = new System.Drawing.Point(54, 135);
            this.MyTask_TextBox.Name = "MyTask_TextBox";
            this.MyTask_TextBox.Size = new System.Drawing.Size(336, 50);
            this.MyTask_TextBox.TabIndex = 7;
            this.MyTask_TextBox.Text = "";
            // 
            // MyPlan
            // 
            this.MyPlan.AutoSize = true;
            this.MyPlan.Font = new System.Drawing.Font("궁서", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPlan.Location = new System.Drawing.Point(49, 198);
            this.MyPlan.Name = "MyPlan";
            this.MyPlan.Size = new System.Drawing.Size(129, 27);
            this.MyPlan.TabIndex = 2;
            this.MyPlan.Text = "업무 계획";
            // 
            // MyTask
            // 
            this.MyTask.AutoSize = true;
            this.MyTask.Font = new System.Drawing.Font("궁서체", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyTask.Location = new System.Drawing.Point(49, 105);
            this.MyTask.Name = "MyTask";
            this.MyTask.Size = new System.Drawing.Size(96, 27);
            this.MyTask.TabIndex = 1;
            this.MyTask.Text = "업무명";
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.Font = new System.Drawing.Font("궁서체", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyName.Location = new System.Drawing.Point(49, 17);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(68, 27);
            this.MyName.TabIndex = 0;
            this.MyName.Text = "이름";
            // 
            // Create_Btn
            // 
            this.Create_Btn.Font = new System.Drawing.Font("궁서체", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Create_Btn.Location = new System.Drawing.Point(22, 497);
            this.Create_Btn.Name = "Create_Btn";
            this.Create_Btn.Size = new System.Drawing.Size(521, 43);
            this.Create_Btn.TabIndex = 2;
            this.Create_Btn.Text = "생성 하기!";
            this.Create_Btn.UseVisualStyleBackColor = true;
            this.Create_Btn.Click += new System.EventHandler(this.Create_Btn_Click);
            // 
            // FilePath_TextBox
            // 
            this.FilePath_TextBox.Location = new System.Drawing.Point(22, 455);
            this.FilePath_TextBox.Name = "FilePath_TextBox";
            this.FilePath_TextBox.Size = new System.Drawing.Size(424, 21);
            this.FilePath_TextBox.TabIndex = 3;
            // 
            // FilePath_Btn
            // 
            this.FilePath_Btn.Font = new System.Drawing.Font("궁서", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FilePath_Btn.Location = new System.Drawing.Point(469, 455);
            this.FilePath_Btn.Name = "FilePath_Btn";
            this.FilePath_Btn.Size = new System.Drawing.Size(75, 23);
            this.FilePath_Btn.TabIndex = 4;
            this.FilePath_Btn.Text = "저장 경로";
            this.FilePath_Btn.UseVisualStyleBackColor = true;
            this.FilePath_Btn.Click += new System.EventHandler(this.FilePath_Btn_Click);
            // 
            // MyName_TextBox
            // 
            this.MyName_TextBox.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyName_TextBox.Location = new System.Drawing.Point(54, 48);
            this.MyName_TextBox.Name = "MyName_TextBox";
            this.MyName_TextBox.Size = new System.Drawing.Size(336, 50);
            this.MyName_TextBox.TabIndex = 6;
            this.MyName_TextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 562);
            this.Controls.Add(this.FilePath_Btn);
            this.Controls.Add(this.FilePath_TextBox);
            this.Controls.Add(this.Create_Btn);
            this.Controls.Add(this.grpFont);
            this.Font = new System.Drawing.Font("궁서", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "일일 보고서 생성기";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.Button Create_Btn;
        private System.Windows.Forms.RichTextBox MyPlan_TextBox;
        private System.Windows.Forms.RichTextBox MyTask_TextBox;
        private System.Windows.Forms.Label MyPlan;
        private System.Windows.Forms.Label MyTask;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.TextBox FilePath_TextBox;
        private System.Windows.Forms.Button FilePath_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox MyName_TextBox;
    }
}

