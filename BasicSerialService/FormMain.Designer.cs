﻿namespace BasicSerialService
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addDeviceOKButton = new System.Windows.Forms.Button();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberComboBox = new System.Windows.Forms.ComboBox();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.lbParity = new System.Windows.Forms.Label();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.layoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(224, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addDeviceOKButton
            // 
            this.addDeviceOKButton.AutoSize = true;
            this.addDeviceOKButton.Location = new System.Drawing.Point(295, 62);
            this.addDeviceOKButton.Name = "addDeviceOKButton";
            this.addDeviceOKButton.Size = new System.Drawing.Size(120, 22);
            this.addDeviceOKButton.TabIndex = 0;
            this.addDeviceOKButton.Text = "OK";
            this.addDeviceOKButton.UseVisualStyleBackColor = true;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Location = new System.Drawing.Point(98, 36);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(120, 20);
            this.BaudRateComboBox.TabIndex = 4;
            // 
            // SerialNumberComboBox
            // 
            this.SerialNumberComboBox.FormattingEnabled = true;
            this.SerialNumberComboBox.Location = new System.Drawing.Point(98, 10);
            this.SerialNumberComboBox.Name = "SerialNumberComboBox";
            this.SerialNumberComboBox.Size = new System.Drawing.Size(120, 20);
            this.SerialNumberComboBox.TabIndex = 2;
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBaudRate.Location = new System.Drawing.Point(3, 33);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(89, 26);
            this.lbBaudRate.TabIndex = 5;
            this.lbBaudRate.Text = "Baud Rate:";
            this.lbBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.AutoSize = true;
            this.lbSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSerialNumber.Location = new System.Drawing.Point(3, 7);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(89, 26);
            this.lbSerialNumber.TabIndex = 3;
            this.lbSerialNumber.Text = "Serial number:";
            this.lbSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDataBits.Location = new System.Drawing.Point(224, 7);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(65, 26);
            this.lbDataBits.TabIndex = 6;
            this.lbDataBits.Text = "Data Bits:";
            this.lbDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStopBits.Location = new System.Drawing.Point(224, 33);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(65, 26);
            this.lbStopBits.TabIndex = 7;
            this.lbStopBits.Text = "Stop Bits:";
            this.lbStopBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbParity.Location = new System.Drawing.Point(3, 59);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(89, 28);
            this.lbParity.TabIndex = 8;
            this.lbParity.Text = "Parity:";
            this.lbParity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Location = new System.Drawing.Point(295, 10);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(120, 20);
            this.DataBitsComboBox.TabIndex = 9;
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Location = new System.Drawing.Point(295, 36);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(120, 20);
            this.StopBitsComboBox.TabIndex = 10;
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(98, 62);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(120, 20);
            this.ParityComboBox.TabIndex = 11;
            // 
            // layoutPane
            // 
            this.layoutPane.BackColor = System.Drawing.Color.Transparent;
            this.layoutPane.ColumnCount = 5;
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPane.Controls.Add(this.lbSerialNumber, 0, 1);
            this.layoutPane.Controls.Add(this.SerialNumberComboBox, 1, 1);
            this.layoutPane.Controls.Add(this.lbBaudRate, 0, 2);
            this.layoutPane.Controls.Add(this.BaudRateComboBox, 1, 2);
            this.layoutPane.Controls.Add(this.lbParity, 0, 3);
            this.layoutPane.Controls.Add(this.ParityComboBox, 1, 3);
            this.layoutPane.Controls.Add(this.lbDataBits, 2, 1);
            this.layoutPane.Controls.Add(this.DataBitsComboBox, 3, 1);
            this.layoutPane.Controls.Add(this.lbStopBits, 2, 2);
            this.layoutPane.Controls.Add(this.StopBitsComboBox, 3, 2);
            this.layoutPane.Controls.Add(this.label1, 2, 3);
            this.layoutPane.Controls.Add(this.addDeviceOKButton, 3, 3);
            this.layoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPane.Location = new System.Drawing.Point(0, 0);
            this.layoutPane.Name = "layoutPane";
            this.layoutPane.RowCount = 5;
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPane.Size = new System.Drawing.Size(770, 95);
            this.layoutPane.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 95);
            this.Controls.Add(this.layoutPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "串口设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.layoutPane.ResumeLayout(false);
            this.layoutPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addDeviceOKButton;
        private System.Windows.Forms.TableLayoutPanel layoutPane;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Label lbStopBits;
        private System.Windows.Forms.Label lbDataBits;
        private System.Windows.Forms.Label lbSerialNumber;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.ComboBox SerialNumberComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
    }
}

