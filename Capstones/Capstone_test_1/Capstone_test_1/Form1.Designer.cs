﻿namespace Capstone_test_1
{
    partial class FCF
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
            this.Opne_Folder = new System.Windows.Forms.Button();
            this.Destination_Folder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Extension_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.endtimepicker = new System.Windows.Forms.DateTimePicker();
            this.TimeFiltering = new System.Windows.Forms.Button();
            this.starttimepicker = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Opne_Folder
            // 
            this.Opne_Folder.Location = new System.Drawing.Point(345, 12);
            this.Opne_Folder.Name = "Opne_Folder";
            this.Opne_Folder.Size = new System.Drawing.Size(116, 28);
            this.Opne_Folder.TabIndex = 1;
            this.Opne_Folder.Text = "Open Folder";
            this.Opne_Folder.UseVisualStyleBackColor = true;
            this.Opne_Folder.Click += new System.EventHandler(this.Open_file_click);
            // 
            // Destination_Folder
            // 
            this.Destination_Folder.Location = new System.Drawing.Point(345, 46);
            this.Destination_Folder.Name = "Destination_Folder";
            this.Destination_Folder.Size = new System.Drawing.Size(116, 28);
            this.Destination_Folder.TabIndex = 2;
            this.Destination_Folder.Text = "Destination Folder";
            this.Destination_Folder.UseVisualStyleBackColor = true;
            this.Destination_Folder.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(548, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Extension_button
            // 
            this.Extension_button.Location = new System.Drawing.Point(471, 201);
            this.Extension_button.Name = "Extension_button";
            this.Extension_button.Size = new System.Drawing.Size(233, 29);
            this.Extension_button.TabIndex = 6;
            this.Extension_button.Text = "Search Start";
            this.Extension_button.UseVisualStyleBackColor = true;
            this.Extension_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // endtimepicker
            // 
            this.endtimepicker.Location = new System.Drawing.Point(533, 160);
            this.endtimepicker.Name = "endtimepicker";
            this.endtimepicker.Size = new System.Drawing.Size(171, 21);
            this.endtimepicker.TabIndex = 9;
            this.endtimepicker.ValueChanged += new System.EventHandler(this.endtime_ValueChanged);
            // 
            // TimeFiltering
            // 
            this.TimeFiltering.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFiltering.Location = new System.Drawing.Point(471, 277);
            this.TimeFiltering.Name = "TimeFiltering";
            this.TimeFiltering.Size = new System.Drawing.Size(237, 123);
            this.TimeFiltering.TabIndex = 10;
            this.TimeFiltering.Text = "FCF ing";
            this.TimeFiltering.UseVisualStyleBackColor = true;
            this.TimeFiltering.Click += new System.EventHandler(this.TimeFiltering_Click);
            // 
            // starttimepicker
            // 
            this.starttimepicker.Location = new System.Drawing.Point(535, 118);
            this.starttimepicker.Name = "starttimepicker";
            this.starttimepicker.Size = new System.Drawing.Size(171, 21);
            this.starttimepicker.TabIndex = 11;
            this.starttimepicker.ValueChanged += new System.EventHandler(this.starttimepicker_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 110);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(449, 290);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(488, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(548, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 21);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Extension";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Regex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "End Time";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 412);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.starttimepicker);
            this.Controls.Add(this.TimeFiltering);
            this.Controls.Add(this.endtimepicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Extension_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Destination_Folder);
            this.Controls.Add(this.Opne_Folder);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Opne_Folder;
        private System.Windows.Forms.Button Destination_Folder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Extension_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker endtimepicker;
        private System.Windows.Forms.Button TimeFiltering;
        private System.Windows.Forms.DateTimePicker starttimepicker;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

