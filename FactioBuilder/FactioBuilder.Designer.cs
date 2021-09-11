
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
            this.SuspendLayout();
            // 
            // AndroidBuild
            // 
            this.AndroidBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(220)))), ((int)(((byte)(132)))));
            this.AndroidBuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AndroidBuild.Location = new System.Drawing.Point(12, 168);
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
            this.WindowsBuild.Location = new System.Drawing.Point(322, 168);
            this.WindowsBuild.Name = "WindowsBuild";
            this.WindowsBuild.Size = new System.Drawing.Size(150, 50);
            this.WindowsBuild.TabIndex = 1;
            this.WindowsBuild.Text = "Windows Build";
            this.WindowsBuild.UseVisualStyleBackColor = false;
            // 
            // BuildProgressBar
            // 
            this.BuildProgressBar.Location = new System.Drawing.Point(12, 224);
            this.BuildProgressBar.Name = "BuildProgressBar";
            this.BuildProgressBar.Size = new System.Drawing.Size(460, 25);
            this.BuildProgressBar.TabIndex = 2;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quit.Location = new System.Drawing.Point(417, 12);
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
            this.MessagesListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessagesListBox.FormattingEnabled = true;
            this.MessagesListBox.ItemHeight = 15;
            this.MessagesListBox.Location = new System.Drawing.Point(12, 53);
            this.MessagesListBox.Name = "MessagesListBox";
            this.MessagesListBox.Size = new System.Drawing.Size(460, 109);
            this.MessagesListBox.TabIndex = 7;
            this.MessagesListBox.Enter += new System.EventHandler(this.MessagesListBox_Enter);
            // 
            // FactioBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
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

        }

        #endregion

        private System.Windows.Forms.Button AndroidBuild;
        private System.Windows.Forms.Button WindowsBuild;
        private System.Windows.Forms.ProgressBar BuildProgressBar;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FactioBuilderText;
        private System.Windows.Forms.ListBox MessagesListBox;
    }
}

