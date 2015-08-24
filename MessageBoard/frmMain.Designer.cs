namespace MessageBoard
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.gbOne = new System.Windows.Forms.GroupBox();
            this.btn1DeltMesInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labMesId = new System.Windows.Forms.Label();
            this.labFloor = new System.Windows.Forms.Label();
            this.lab1Reply = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.labContent = new System.Windows.Forms.Label();
            this.labGuestName = new System.Windows.Forms.Label();
            this.gbTwo = new System.Windows.Forms.GroupBox();
            this.btn2DeltMesInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lab2MesId = new System.Windows.Forms.Label();
            this.lab2Floor = new System.Windows.Forms.Label();
            this.lab2Reply = new System.Windows.Forms.Label();
            this.lab2Time = new System.Windows.Forms.Label();
            this.lab2Content = new System.Windows.Forms.Label();
            this.lab2GuestName = new System.Windows.Forms.Label();
            this.gbThree = new System.Windows.Forms.GroupBox();
            this.btn3DeltMesInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lab3MesId = new System.Windows.Forms.Label();
            this.lab3Floor = new System.Windows.Forms.Label();
            this.lab3Reply = new System.Windows.Forms.Label();
            this.lab3Time = new System.Windows.Forms.Label();
            this.lab3Content = new System.Windows.Forms.Label();
            this.lab3GuestName = new System.Windows.Forms.Label();
            this.labLastPage = new System.Windows.Forms.Label();
            this.labNextPage = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.labMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labMesCount = new System.Windows.Forms.Label();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.gbOne.SuspendLayout();
            this.gbTwo.SuspendLayout();
            this.gbThree.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(42, 38);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(385, 96);
            this.txtContent.TabIndex = 0;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(42, 140);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "发表";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(42, 12);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(98, 20);
            this.cmbUser.TabIndex = 2;
            // 
            // gbOne
            // 
            this.gbOne.Controls.Add(this.btn1DeltMesInfo);
            this.gbOne.Controls.Add(this.label1);
            this.gbOne.Controls.Add(this.labMesId);
            this.gbOne.Controls.Add(this.labFloor);
            this.gbOne.Controls.Add(this.lab1Reply);
            this.gbOne.Controls.Add(this.labTime);
            this.gbOne.Controls.Add(this.labContent);
            this.gbOne.Controls.Add(this.labGuestName);
            this.gbOne.Location = new System.Drawing.Point(42, 168);
            this.gbOne.Name = "gbOne";
            this.gbOne.Size = new System.Drawing.Size(385, 117);
            this.gbOne.TabIndex = 3;
            this.gbOne.TabStop = false;
            // 
            // btn1DeltMesInfo
            // 
            this.btn1DeltMesInfo.Location = new System.Drawing.Point(316, 16);
            this.btn1DeltMesInfo.Name = "btn1DeltMesInfo";
            this.btn1DeltMesInfo.Size = new System.Drawing.Size(63, 23);
            this.btn1DeltMesInfo.TabIndex = 2;
            this.btn1DeltMesInfo.Text = "删除留言";
            this.btn1DeltMesInfo.UseVisualStyleBackColor = true;
            this.btn1DeltMesInfo.Click += new System.EventHandler(this.btn1DeltMesInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "留言人:";
            // 
            // labMesId
            // 
            this.labMesId.AutoSize = true;
            this.labMesId.Location = new System.Drawing.Point(257, 21);
            this.labMesId.Name = "labMesId";
            this.labMesId.Size = new System.Drawing.Size(0, 12);
            this.labMesId.TabIndex = 0;
            this.labMesId.Visible = false;
            // 
            // labFloor
            // 
            this.labFloor.AutoSize = true;
            this.labFloor.Location = new System.Drawing.Point(111, 21);
            this.labFloor.Name = "labFloor";
            this.labFloor.Size = new System.Drawing.Size(41, 12);
            this.labFloor.TabIndex = 0;
            this.labFloor.Text = "label1";
            // 
            // lab1Reply
            // 
            this.lab1Reply.AutoSize = true;
            this.lab1Reply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab1Reply.ForeColor = System.Drawing.Color.Blue;
            this.lab1Reply.Location = new System.Drawing.Point(185, 84);
            this.lab1Reply.Name = "lab1Reply";
            this.lab1Reply.Size = new System.Drawing.Size(29, 12);
            this.lab1Reply.TabIndex = 0;
            this.lab1Reply.Text = "回复";
            this.lab1Reply.Click += new System.EventHandler(this.lab1Reply_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(28, 84);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(41, 12);
            this.labTime.TabIndex = 0;
            this.labTime.Text = "label1";
            // 
            // labContent
            // 
            this.labContent.AutoSize = true;
            this.labContent.Location = new System.Drawing.Point(28, 50);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(41, 12);
            this.labContent.TabIndex = 0;
            this.labContent.Text = "label1";
            // 
            // labGuestName
            // 
            this.labGuestName.AutoSize = true;
            this.labGuestName.Location = new System.Drawing.Point(53, 21);
            this.labGuestName.Name = "labGuestName";
            this.labGuestName.Size = new System.Drawing.Size(41, 12);
            this.labGuestName.TabIndex = 0;
            this.labGuestName.Text = "label1";
            // 
            // gbTwo
            // 
            this.gbTwo.Controls.Add(this.btn2DeltMesInfo);
            this.gbTwo.Controls.Add(this.label3);
            this.gbTwo.Controls.Add(this.lab2MesId);
            this.gbTwo.Controls.Add(this.lab2Floor);
            this.gbTwo.Controls.Add(this.lab2Reply);
            this.gbTwo.Controls.Add(this.lab2Time);
            this.gbTwo.Controls.Add(this.lab2Content);
            this.gbTwo.Controls.Add(this.lab2GuestName);
            this.gbTwo.Location = new System.Drawing.Point(42, 285);
            this.gbTwo.Name = "gbTwo";
            this.gbTwo.Size = new System.Drawing.Size(385, 117);
            this.gbTwo.TabIndex = 3;
            this.gbTwo.TabStop = false;
            // 
            // btn2DeltMesInfo
            // 
            this.btn2DeltMesInfo.Location = new System.Drawing.Point(316, 16);
            this.btn2DeltMesInfo.Name = "btn2DeltMesInfo";
            this.btn2DeltMesInfo.Size = new System.Drawing.Size(63, 23);
            this.btn2DeltMesInfo.TabIndex = 2;
            this.btn2DeltMesInfo.Text = "删除留言";
            this.btn2DeltMesInfo.UseVisualStyleBackColor = true;
            this.btn2DeltMesInfo.Click += new System.EventHandler(this.btn2DeltMesInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "留言人:";
            // 
            // lab2MesId
            // 
            this.lab2MesId.AutoSize = true;
            this.lab2MesId.Location = new System.Drawing.Point(325, 21);
            this.lab2MesId.Name = "lab2MesId";
            this.lab2MesId.Size = new System.Drawing.Size(0, 12);
            this.lab2MesId.TabIndex = 0;
            this.lab2MesId.Visible = false;
            // 
            // lab2Floor
            // 
            this.lab2Floor.AutoSize = true;
            this.lab2Floor.Location = new System.Drawing.Point(111, 21);
            this.lab2Floor.Name = "lab2Floor";
            this.lab2Floor.Size = new System.Drawing.Size(41, 12);
            this.lab2Floor.TabIndex = 0;
            this.lab2Floor.Text = "label1";
            // 
            // lab2Reply
            // 
            this.lab2Reply.AutoSize = true;
            this.lab2Reply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab2Reply.ForeColor = System.Drawing.Color.Blue;
            this.lab2Reply.Location = new System.Drawing.Point(185, 84);
            this.lab2Reply.Name = "lab2Reply";
            this.lab2Reply.Size = new System.Drawing.Size(29, 12);
            this.lab2Reply.TabIndex = 0;
            this.lab2Reply.Text = "回复";
            this.lab2Reply.Click += new System.EventHandler(this.lab2Reply_Click);
            // 
            // lab2Time
            // 
            this.lab2Time.AutoSize = true;
            this.lab2Time.Location = new System.Drawing.Point(28, 84);
            this.lab2Time.Name = "lab2Time";
            this.lab2Time.Size = new System.Drawing.Size(41, 12);
            this.lab2Time.TabIndex = 0;
            this.lab2Time.Text = "label1";
            // 
            // lab2Content
            // 
            this.lab2Content.AutoSize = true;
            this.lab2Content.Location = new System.Drawing.Point(28, 50);
            this.lab2Content.Name = "lab2Content";
            this.lab2Content.Size = new System.Drawing.Size(41, 12);
            this.lab2Content.TabIndex = 0;
            this.lab2Content.Text = "label1";
            // 
            // lab2GuestName
            // 
            this.lab2GuestName.AutoSize = true;
            this.lab2GuestName.Location = new System.Drawing.Point(53, 21);
            this.lab2GuestName.Name = "lab2GuestName";
            this.lab2GuestName.Size = new System.Drawing.Size(41, 12);
            this.lab2GuestName.TabIndex = 0;
            this.lab2GuestName.Text = "label1";
            // 
            // gbThree
            // 
            this.gbThree.Controls.Add(this.btn3DeltMesInfo);
            this.gbThree.Controls.Add(this.label4);
            this.gbThree.Controls.Add(this.lab3MesId);
            this.gbThree.Controls.Add(this.lab3Floor);
            this.gbThree.Controls.Add(this.lab3Reply);
            this.gbThree.Controls.Add(this.lab3Time);
            this.gbThree.Controls.Add(this.lab3Content);
            this.gbThree.Controls.Add(this.lab3GuestName);
            this.gbThree.Location = new System.Drawing.Point(42, 402);
            this.gbThree.Name = "gbThree";
            this.gbThree.Size = new System.Drawing.Size(385, 117);
            this.gbThree.TabIndex = 3;
            this.gbThree.TabStop = false;
            // 
            // btn3DeltMesInfo
            // 
            this.btn3DeltMesInfo.Location = new System.Drawing.Point(316, 16);
            this.btn3DeltMesInfo.Name = "btn3DeltMesInfo";
            this.btn3DeltMesInfo.Size = new System.Drawing.Size(63, 23);
            this.btn3DeltMesInfo.TabIndex = 2;
            this.btn3DeltMesInfo.Text = "删除留言";
            this.btn3DeltMesInfo.UseVisualStyleBackColor = true;
            this.btn3DeltMesInfo.Click += new System.EventHandler(this.btn3DeltMesInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "留言人:";
            // 
            // lab3MesId
            // 
            this.lab3MesId.AutoSize = true;
            this.lab3MesId.Location = new System.Drawing.Point(325, 21);
            this.lab3MesId.Name = "lab3MesId";
            this.lab3MesId.Size = new System.Drawing.Size(0, 12);
            this.lab3MesId.TabIndex = 0;
            this.lab3MesId.Visible = false;
            // 
            // lab3Floor
            // 
            this.lab3Floor.AutoSize = true;
            this.lab3Floor.Location = new System.Drawing.Point(111, 21);
            this.lab3Floor.Name = "lab3Floor";
            this.lab3Floor.Size = new System.Drawing.Size(41, 12);
            this.lab3Floor.TabIndex = 0;
            this.lab3Floor.Text = "label1";
            // 
            // lab3Reply
            // 
            this.lab3Reply.AutoSize = true;
            this.lab3Reply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab3Reply.ForeColor = System.Drawing.Color.Blue;
            this.lab3Reply.Location = new System.Drawing.Point(185, 84);
            this.lab3Reply.Name = "lab3Reply";
            this.lab3Reply.Size = new System.Drawing.Size(29, 12);
            this.lab3Reply.TabIndex = 0;
            this.lab3Reply.Text = "回复";
            this.lab3Reply.Click += new System.EventHandler(this.lab3Reply_Click);
            // 
            // lab3Time
            // 
            this.lab3Time.AutoSize = true;
            this.lab3Time.Location = new System.Drawing.Point(28, 84);
            this.lab3Time.Name = "lab3Time";
            this.lab3Time.Size = new System.Drawing.Size(41, 12);
            this.lab3Time.TabIndex = 0;
            this.lab3Time.Text = "label1";
            // 
            // lab3Content
            // 
            this.lab3Content.AutoSize = true;
            this.lab3Content.Location = new System.Drawing.Point(28, 50);
            this.lab3Content.Name = "lab3Content";
            this.lab3Content.Size = new System.Drawing.Size(41, 12);
            this.lab3Content.TabIndex = 0;
            this.lab3Content.Text = "label1";
            // 
            // lab3GuestName
            // 
            this.lab3GuestName.AutoSize = true;
            this.lab3GuestName.Location = new System.Drawing.Point(53, 21);
            this.lab3GuestName.Name = "lab3GuestName";
            this.lab3GuestName.Size = new System.Drawing.Size(41, 12);
            this.lab3GuestName.TabIndex = 0;
            this.lab3GuestName.Text = "label1";
            // 
            // labLastPage
            // 
            this.labLastPage.AutoSize = true;
            this.labLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labLastPage.ForeColor = System.Drawing.Color.Blue;
            this.labLastPage.Location = new System.Drawing.Point(339, 534);
            this.labLastPage.Name = "labLastPage";
            this.labLastPage.Size = new System.Drawing.Size(41, 12);
            this.labLastPage.TabIndex = 4;
            this.labLastPage.Text = "上一页";
            this.labLastPage.Click += new System.EventHandler(this.labLastPage_Click);
            // 
            // labNextPage
            // 
            this.labNextPage.AutoSize = true;
            this.labNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labNextPage.ForeColor = System.Drawing.Color.Blue;
            this.labNextPage.Location = new System.Drawing.Point(386, 534);
            this.labNextPage.Name = "labNextPage";
            this.labNextPage.Size = new System.Drawing.Size(41, 12);
            this.labNextPage.TabIndex = 4;
            this.labNextPage.Text = "下一页";
            this.labNextPage.Click += new System.EventHandler(this.labNextPage_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.SystemColors.Control;
            this.labName.Location = new System.Drawing.Point(166, 16);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 12);
            this.labName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "欢迎回来";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(316, 16);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 12);
            this.labId.TabIndex = 7;
            this.labId.Visible = false;
            // 
            // labMsg
            // 
            this.labMsg.AutoSize = true;
            this.labMsg.ForeColor = System.Drawing.Color.Red;
            this.labMsg.Location = new System.Drawing.Point(194, 145);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(0, 12);
            this.labMsg.TabIndex = 8;
            this.labMsg.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labMesCount
            // 
            this.labMesCount.AutoSize = true;
            this.labMesCount.Location = new System.Drawing.Point(12, 206);
            this.labMesCount.Name = "labMesCount";
            this.labMesCount.Size = new System.Drawing.Size(0, 12);
            this.labMesCount.TabIndex = 9;
            this.labMesCount.Visible = false;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Location = new System.Drawing.Point(386, 7);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(75, 23);
            this.btnChangeUser.TabIndex = 10;
            this.btnChangeUser.Text = "切换用户";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 561);
            this.Controls.Add(this.btnChangeUser);
            this.Controls.Add(this.labMesCount);
            this.Controls.Add(this.labMsg);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labNextPage);
            this.Controls.Add(this.labLastPage);
            this.Controls.Add(this.gbThree);
            this.Controls.Add(this.gbTwo);
            this.Controls.Add(this.gbOne);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtContent);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "留言板";
            this.gbOne.ResumeLayout(false);
            this.gbOne.PerformLayout();
            this.gbTwo.ResumeLayout(false);
            this.gbTwo.PerformLayout();
            this.gbThree.ResumeLayout(false);
            this.gbThree.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.GroupBox gbOne;
        private System.Windows.Forms.Label labFloor;
        private System.Windows.Forms.Label lab1Reply;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labContent;
        private System.Windows.Forms.Label labGuestName;
        private System.Windows.Forms.GroupBox gbTwo;
        private System.Windows.Forms.Label lab2Floor;
        private System.Windows.Forms.Label lab2Reply;
        private System.Windows.Forms.Label lab2Time;
        private System.Windows.Forms.Label lab2Content;
        private System.Windows.Forms.Label lab2GuestName;
        private System.Windows.Forms.GroupBox gbThree;
        private System.Windows.Forms.Label lab3Floor;
        private System.Windows.Forms.Label lab3Reply;
        private System.Windows.Forms.Label lab3Time;
        private System.Windows.Forms.Label lab3Content;
        private System.Windows.Forms.Label lab3GuestName;
        private System.Windows.Forms.Label labLastPage;
        private System.Windows.Forms.Label labNextPage;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labMsg;
        private System.Windows.Forms.Label labMesId;
        private System.Windows.Forms.Label lab2MesId;
        private System.Windows.Forms.Label lab3MesId;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labMesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn1DeltMesInfo;
        private System.Windows.Forms.Button btn2DeltMesInfo;
        private System.Windows.Forms.Button btn3DeltMesInfo;
        private System.Windows.Forms.Button btnChangeUser;
    }
}