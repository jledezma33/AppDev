namespace TimeSheetWinforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDay0 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtDay1 = new System.Windows.Forms.TextBox();
            this.txtDay2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDay0
            // 
            resources.ApplyResources(this.txtDay0, "txtDay0");
            this.txtDay0.Name = "txtDay0";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOutput
            // 
            resources.ApplyResources(this.lblOutput, "lblOutput");
            this.lblOutput.Name = "lblOutput";
            // 
            // txtDay1
            // 
            resources.ApplyResources(this.txtDay1, "txtDay1");
            this.txtDay1.Name = "txtDay1";
            // 
            // txtDay2
            // 
            resources.ApplyResources(this.txtDay2, "txtDay2");
            this.txtDay2.Name = "txtDay2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDay2);
            this.Controls.Add(this.txtDay1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDay0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDay0;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtDay1;
        private System.Windows.Forms.TextBox txtDay2;
    }
}

