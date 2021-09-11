
namespace FactioBuilder
{
    partial class FactioBuilder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AndroidBuild = new System.Windows.Forms.Button();
            this.WindowsBuild = new System.Windows.Forms.Button();
            this.BuildProgressBar = new System.Windows.Forms.ProgressBar();
            this.Quit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FactioBuilderText = new System.Windows.Forms.Label();
            this.MessagesListBox = new System.Windows.Forms.ListBox();
            this.AndroidDowloadCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AndroidBuild
            // 
            this.AndroidBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(220)))), ((int)(((byte)(132)))));
            this.AndroidBuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AndroidBuild.Location = new System.Drawing.Point(12, 202);
            this.AndroidBuild.Name = "AndroidBuild";
            this.AndroidBuild.Size = new System.Drawing.Size(150, 50);
            this.AndroidBuild.TabIndex = 0;
            this.AndroidBuild.Text = "Android Build";
            this.AndroidBuild.UseVisualStyleBackColor = false;
            // 
            // WindowsBuild
            // 
            this.WindowsBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.WindowsBuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindowsBuild.Location = new System.Drawing.Point(338, 202);
            this.WindowsBuild.Name = "WindowsBuild";
            this.WindowsBuild.Size = new System.Drawing.Size(150, 50);
            this.WindowsBuild.TabIndex = 1;
            this.WindowsBuild.Text = "Windows Build";
            this.WindowsBuild.UseVisualStyleBackColor = false;
            // 
            // BuildProgressBar
            // 
            this.BuildProgressBar.Location = new System.Drawing.Point(12, 283);
            this.BuildProgressBar.Name = "BuildProgressBar";
            this.BuildProgressBar.Size = new System.Drawing.Size(476, 25);
            this.BuildProgressBar.TabIndex = 2;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quit.Location = new System.Drawing.Point(433, 12);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(55, 30);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FactioBuilderText
            // 
            this.FactioBuilderText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FactioBuilderText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.FactioBuilderText.Location = new System.Drawing.Point(187, 9);
            this.FactioBuilderText.Name = "FactioBuilderText";
            this.FactioBuilderText.Size = new System.Drawing.Size(115, 30);
            this.FactioBuilderText.TabIndex = 6;
            this.FactioBuilderText.Text = "Factio Builder";
            // 
            // MessagesListBox
            // 
            this.MessagesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.MessagesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessagesListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessagesListBox.FormattingEnabled = true;
            this.MessagesListBox.ItemHeight = 15;
            this.MessagesListBox.Location = new System.Drawing.Point(12, 48);
            this.MessagesListBox.Name = "MessagesListBox";
            this.MessagesListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MessagesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.MessagesListBox.Size = new System.Drawing.Size(476, 150);
            this.MessagesListBox.TabIndex = 7;
            // 
            // AndroidDowloadCheckBox
            // 
            this.AndroidDowloadCheckBox.AutoSize = true;
            this.AndroidDowloadCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AndroidDowloadCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.AndroidDowloadCheckBox.Location = new System.Drawing.Point(12, 258);
            this.AndroidDowloadCheckBox.Name = "AndroidDowloadCheckBox";
            this.AndroidDowloadCheckBox.Size = new System.Drawing.Size(129, 19);
            this.AndroidDowloadCheckBox.TabIndex = 8;
            this.AndroidDowloadCheckBox.Text = "Android Download";
            this.AndroidDowloadCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.checkBox1.Location = new System.Drawing.Point(338, 258);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Windows Download";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FactioBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(500, 321);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AndroidDowloadCheckBox);
            this.Controls.Add(this.MessagesListBox);
            this.Controls.Add(this.FactioBuilderText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.BuildProgressBar);
            this.Controls.Add(this.WindowsBuild);
            this.Controls.Add(this.AndroidBuild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FactioBuilder";
            this.Text = "Factio Builder";
            this.Load += new System.EventHandler(this.FactioBuilder_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FactioBuilder_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AndroidBuild;
        private System.Windows.Forms.Button WindowsBuild;
        private System.Windows.Forms.ProgressBar BuildProgressBar;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FactioBuilderText;
        private System.Windows.Forms.ListBox MessagesListBox;
        private System.Windows.Forms.CheckBox AndroidDowloadCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

