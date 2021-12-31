
namespace MathApp
{
    partial class Form1
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
            this.displaytask = new System.Windows.Forms.Label();
            this.putanswer = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.displaysc = new System.Windows.Forms.Label();
            this.displayhelp = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displaytask
            // 
            this.displaytask.AutoSize = true;
            this.displaytask.Location = new System.Drawing.Point(100, 235);
            this.displaytask.Name = "displaytask";
            this.displaytask.Size = new System.Drawing.Size(20, 17);
            this.displaytask.TabIndex = 0;
            this.displaytask.Text = "dt";
            // 
            // putanswer
            // 
            this.putanswer.Location = new System.Drawing.Point(162, 235);
            this.putanswer.Name = "putanswer";
            this.putanswer.Size = new System.Drawing.Size(47, 22);
            this.putanswer.TabIndex = 1;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(233, 235);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(97, 23);
            this.check.TabIndex = 2;
            this.check.Text = "SPRAWDŹ";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(346, 235);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 3;
            this.next.Text = "DALEJ";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // displaysc
            // 
            this.displaysc.AutoSize = true;
            this.displaysc.Location = new System.Drawing.Point(696, 19);
            this.displaysc.Name = "displaysc";
            this.displaysc.Size = new System.Drawing.Size(43, 17);
            this.displaysc.TabIndex = 4;
            this.displaysc.Text = "score";
            // 
            // displayhelp
            // 
            this.displayhelp.AutoSize = true;
            this.displayhelp.Location = new System.Drawing.Point(711, 238);
            this.displayhelp.Name = "displayhelp";
            this.displayhelp.Size = new System.Drawing.Size(79, 17);
            this.displayhelp.TabIndex = 5;
            this.displayhelp.Text = "displayhelp";
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(630, 235);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 6;
            this.help.Text = "POMOC";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.help);
            this.Controls.Add(this.displayhelp);
            this.Controls.Add(this.displaysc);
            this.Controls.Add(this.next);
            this.Controls.Add(this.check);
            this.Controls.Add(this.putanswer);
            this.Controls.Add(this.displaytask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displaytask;
        private System.Windows.Forms.TextBox putanswer;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label displaysc;
        private System.Windows.Forms.Label displayhelp;
        private System.Windows.Forms.Button help;
    }
}

