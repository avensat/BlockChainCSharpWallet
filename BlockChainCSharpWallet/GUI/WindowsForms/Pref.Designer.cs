﻿namespace BlockChainCSharpWallet.GUI.WindowsForms
{
    partial class Pref
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
            this.UseRemoteDaemonCB = new System.Windows.Forms.CheckBox();
            this.remoteDaemonAddressLabel = new System.Windows.Forms.Label();
            this.RemoteDaemonAddress = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LocalDaemonAddressLabel = new System.Windows.Forms.Label();
            this.LocalDaemonAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UseRemoteDaemonCB
            // 
            this.UseRemoteDaemonCB.AutoSize = true;
            this.UseRemoteDaemonCB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseRemoteDaemonCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UseRemoteDaemonCB.Location = new System.Drawing.Point(202, 254);
            this.UseRemoteDaemonCB.Name = "UseRemoteDaemonCB";
            this.UseRemoteDaemonCB.Size = new System.Drawing.Size(397, 30);
            this.UseRemoteDaemonCB.TabIndex = 9;
            this.UseRemoteDaemonCB.Text = "Check if you want to use a remote daemon";
            this.UseRemoteDaemonCB.UseVisualStyleBackColor = true;
            // 
            // remoteDaemonAddressLabel
            // 
            this.remoteDaemonAddressLabel.AutoSize = true;
            this.remoteDaemonAddressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remoteDaemonAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.remoteDaemonAddressLabel.Location = new System.Drawing.Point(198, 156);
            this.remoteDaemonAddressLabel.Name = "remoteDaemonAddressLabel";
            this.remoteDaemonAddressLabel.Size = new System.Drawing.Size(201, 23);
            this.remoteDaemonAddressLabel.TabIndex = 8;
            this.remoteDaemonAddressLabel.Text = "Remote daemon address";
            // 
            // RemoteDaemonAddress
            // 
            this.RemoteDaemonAddress.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoteDaemonAddress.ForeColor = System.Drawing.Color.Gray;
            this.RemoteDaemonAddress.Location = new System.Drawing.Point(202, 199);
            this.RemoteDaemonAddress.Name = "RemoteDaemonAddress";
            this.RemoteDaemonAddress.Size = new System.Drawing.Size(384, 33);
            this.RemoteDaemonAddress.TabIndex = 7;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(202, 300);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(384, 41);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Save and close";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LocalDaemonAddressLabel
            // 
            this.LocalDaemonAddressLabel.AutoSize = true;
            this.LocalDaemonAddressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalDaemonAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LocalDaemonAddressLabel.Location = new System.Drawing.Point(198, 66);
            this.LocalDaemonAddressLabel.Name = "LocalDaemonAddressLabel";
            this.LocalDaemonAddressLabel.Size = new System.Drawing.Size(181, 23);
            this.LocalDaemonAddressLabel.TabIndex = 11;
            this.LocalDaemonAddressLabel.Text = "Local daemon address";
            // 
            // LocalDaemonAddress
            // 
            this.LocalDaemonAddress.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalDaemonAddress.ForeColor = System.Drawing.Color.Gray;
            this.LocalDaemonAddress.Location = new System.Drawing.Point(202, 109);
            this.LocalDaemonAddress.Name = "LocalDaemonAddress";
            this.LocalDaemonAddress.Size = new System.Drawing.Size(384, 33);
            this.LocalDaemonAddress.TabIndex = 10;
            // 
            // Pref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 449);
            this.Controls.Add(this.LocalDaemonAddressLabel);
            this.Controls.Add(this.LocalDaemonAddress);
            this.Controls.Add(this.UseRemoteDaemonCB);
            this.Controls.Add(this.remoteDaemonAddressLabel);
            this.Controls.Add(this.RemoteDaemonAddress);
            this.Controls.Add(this.ButtonSave);
            this.Name = "Pref";
            this.Text = "Pref";
            this.Load += new System.EventHandler(this.Pref_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UseRemoteDaemonCB;
        private System.Windows.Forms.Label remoteDaemonAddressLabel;
        private System.Windows.Forms.TextBox RemoteDaemonAddress;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LocalDaemonAddressLabel;
        private System.Windows.Forms.TextBox LocalDaemonAddress;
    }
}