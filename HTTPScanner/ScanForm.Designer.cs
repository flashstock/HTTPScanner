﻿namespace HTTPScanner
{
    partial class ScanForm
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
            this.startScanButton = new System.Windows.Forms.Button();
            this.resultList = new System.Windows.Forms.ListView();
            this.ipAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.responseCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stopScanButton = new System.Windows.Forms.Button();
            this.okHttpStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.badRequestHttpStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.unauthorizedHttpStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.anyHttpStatusCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startScanButton
            // 
            this.startScanButton.Location = new System.Drawing.Point(254, 226);
            this.startScanButton.Name = "startScanButton";
            this.startScanButton.Size = new System.Drawing.Size(75, 23);
            this.startScanButton.TabIndex = 0;
            this.startScanButton.Text = "Start";
            this.startScanButton.UseVisualStyleBackColor = true;
            this.startScanButton.Click += new System.EventHandler(this.startScanButton_Click);
            // 
            // resultList
            // 
            this.resultList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.resultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ipAddressHeader,
            this.responseCodeHeader});
            this.resultList.Location = new System.Drawing.Point(13, 13);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(235, 236);
            this.resultList.TabIndex = 1;
            this.resultList.UseCompatibleStateImageBehavior = false;
            this.resultList.View = System.Windows.Forms.View.Details;
            this.resultList.DoubleClick += new System.EventHandler(this.resultList_DoubleClick);
            // 
            // ipAddressHeader
            // 
            this.ipAddressHeader.Text = "IP Address";
            this.ipAddressHeader.Width = 104;
            // 
            // responseCodeHeader
            // 
            this.responseCodeHeader.Text = "HTTP Response";
            this.responseCodeHeader.Width = 95;
            // 
            // stopScanButton
            // 
            this.stopScanButton.Location = new System.Drawing.Point(254, 197);
            this.stopScanButton.Name = "stopScanButton";
            this.stopScanButton.Size = new System.Drawing.Size(75, 23);
            this.stopScanButton.TabIndex = 2;
            this.stopScanButton.Text = "Stop";
            this.stopScanButton.UseVisualStyleBackColor = true;
            this.stopScanButton.Click += new System.EventHandler(this.stopScanButton_Click);
            // 
            // okHttpStatusCheckbox
            // 
            this.okHttpStatusCheckbox.AutoSize = true;
            this.okHttpStatusCheckbox.Checked = true;
            this.okHttpStatusCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.okHttpStatusCheckbox.Location = new System.Drawing.Point(255, 13);
            this.okHttpStatusCheckbox.Name = "okHttpStatusCheckbox";
            this.okHttpStatusCheckbox.Size = new System.Drawing.Size(41, 17);
            this.okHttpStatusCheckbox.TabIndex = 3;
            this.okHttpStatusCheckbox.Text = "OK";
            this.okHttpStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // badRequestHttpStatusCheckbox
            // 
            this.badRequestHttpStatusCheckbox.AutoSize = true;
            this.badRequestHttpStatusCheckbox.Location = new System.Drawing.Point(255, 37);
            this.badRequestHttpStatusCheckbox.Name = "badRequestHttpStatusCheckbox";
            this.badRequestHttpStatusCheckbox.Size = new System.Drawing.Size(85, 17);
            this.badRequestHttpStatusCheckbox.TabIndex = 4;
            this.badRequestHttpStatusCheckbox.Text = "BadRequest";
            this.badRequestHttpStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // unauthorizedHttpStatusCheckbox
            // 
            this.unauthorizedHttpStatusCheckbox.AutoSize = true;
            this.unauthorizedHttpStatusCheckbox.Location = new System.Drawing.Point(255, 61);
            this.unauthorizedHttpStatusCheckbox.Name = "unauthorizedHttpStatusCheckbox";
            this.unauthorizedHttpStatusCheckbox.Size = new System.Drawing.Size(89, 17);
            this.unauthorizedHttpStatusCheckbox.TabIndex = 5;
            this.unauthorizedHttpStatusCheckbox.Text = "Unauthorized";
            this.unauthorizedHttpStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // anyHttpStatusCheckbox
            // 
            this.anyHttpStatusCheckbox.AutoSize = true;
            this.anyHttpStatusCheckbox.Location = new System.Drawing.Point(255, 84);
            this.anyHttpStatusCheckbox.Name = "anyHttpStatusCheckbox";
            this.anyHttpStatusCheckbox.Size = new System.Drawing.Size(44, 17);
            this.anyHttpStatusCheckbox.TabIndex = 6;
            this.anyHttpStatusCheckbox.Text = "Any";
            this.anyHttpStatusCheckbox.UseVisualStyleBackColor = true;
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.anyHttpStatusCheckbox);
            this.Controls.Add(this.unauthorizedHttpStatusCheckbox);
            this.Controls.Add(this.badRequestHttpStatusCheckbox);
            this.Controls.Add(this.okHttpStatusCheckbox);
            this.Controls.Add(this.stopScanButton);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.startScanButton);
            this.Name = "ScanForm";
            this.Text = "HTTP Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startScanButton;
        private System.Windows.Forms.ListView resultList;
        private System.Windows.Forms.ColumnHeader ipAddressHeader;
        private System.Windows.Forms.ColumnHeader responseCodeHeader;
        private System.Windows.Forms.Button stopScanButton;
        private System.Windows.Forms.CheckBox okHttpStatusCheckbox;
        private System.Windows.Forms.CheckBox badRequestHttpStatusCheckbox;
        private System.Windows.Forms.CheckBox unauthorizedHttpStatusCheckbox;
        private System.Windows.Forms.CheckBox anyHttpStatusCheckbox;
    }
}
