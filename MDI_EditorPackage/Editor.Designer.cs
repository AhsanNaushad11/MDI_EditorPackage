namespace MDI_EditorPackage
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.EditTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // EditTextBox
            // 
            this.EditTextBox.AcceptsTab = true;
            this.EditTextBox.AllowDrop = true;
            resources.ApplyResources(this.EditTextBox, "EditTextBox");
            this.EditTextBox.Name = "EditTextBox";
            this.EditTextBox.TextChanged += new System.EventHandler(this.EditTextBox_TextChanged);
            this.EditTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTextBox_KeyDown);
            // 
            // Editor
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditTextBox);
            this.Name = "Editor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TextBox EditTextBox;
    }
}