namespace NetworkModel
{
    partial class MainForm
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
            this.buttonNewNode = new System.Windows.Forms.Button();
            this.panelNetworkModel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonNewNode
            // 
            this.buttonNewNode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNewNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewNode.Image = global::NetworkModel.Properties.Resources.computer_icon;
            this.buttonNewNode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewNode.Location = new System.Drawing.Point(12, 12);
            this.buttonNewNode.Name = "buttonNewNode";
            this.buttonNewNode.Size = new System.Drawing.Size(75, 27);
            this.buttonNewNode.TabIndex = 1;
            this.buttonNewNode.Text = "Node";
            this.buttonNewNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewNode.UseVisualStyleBackColor = false;
            this.buttonNewNode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonNewNode_MouseDown);
            this.buttonNewNode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonNewNode_MouseMove);
            this.buttonNewNode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonNewNode_MouseUp);
            // 
            // panelNetworkModel
            // 
            this.panelNetworkModel.AutoScroll = true;
            this.panelNetworkModel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNetworkModel.Location = new System.Drawing.Point(111, 80);
            this.panelNetworkModel.Name = "panelNetworkModel";
            this.panelNetworkModel.Size = new System.Drawing.Size(854, 471);
            this.panelNetworkModel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 563);
            this.Controls.Add(this.panelNetworkModel);
            this.Controls.Add(this.buttonNewNode);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewNode;
        private System.Windows.Forms.Panel panelNetworkModel;
    }
}