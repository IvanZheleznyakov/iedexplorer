﻿/*
 *  Copyright (C) 2013 Pavel Charvat
 * 
 *  This file is part of IEDExplorer.
 *
 *  IEDExplorer is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  IEDExplorer is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with IEDExplorer.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace IEDExplorer
{
    partial class CommandDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFlow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAddr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTest = new System.Windows.Forms.CheckBox();
            this.checkBoxSynchroCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxInterlockCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.groupBoxOrig = new System.Windows.Forms.GroupBox();
            this.textBoxIdent = new System.Windows.Forms.TextBox();
            this.numericUpDownCat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxOrig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attention!!! Command will be sent to the IED!";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(70, 298);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(79, 33);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "Send";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(276, 298);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 33);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelFlow
            // 
            this.labelFlow.AutoSize = true;
            this.labelFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFlow.Location = new System.Drawing.Point(66, 20);
            this.labelFlow.Name = "labelFlow";
            this.labelFlow.Size = new System.Drawing.Size(29, 13);
            this.labelFlow.TabIndex = 4;
            this.labelFlow.Text = "Flow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address: ";
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddr.Location = new System.Drawing.Point(66, 41);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(29, 13);
            this.labelAddr.TabIndex = 7;
            this.labelAddr.Text = "Addr";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerTime);
            this.groupBox1.Controls.Add(this.checkBoxTest);
            this.groupBox1.Controls.Add(this.checkBoxSynchroCheck);
            this.groupBox1.Controls.Add(this.checkBoxInterlockCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command Options";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(271, 25);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerTime.TabIndex = 3;
            // 
            // checkBoxTest
            // 
            this.checkBoxTest.AutoSize = true;
            this.checkBoxTest.Location = new System.Drawing.Point(218, 28);
            this.checkBoxTest.Name = "checkBoxTest";
            this.checkBoxTest.Size = new System.Drawing.Size(47, 17);
            this.checkBoxTest.TabIndex = 2;
            this.checkBoxTest.Tag = "Test";
            this.checkBoxTest.Text = "Test";
            this.checkBoxTest.UseVisualStyleBackColor = true;
            // 
            // checkBoxSynchroCheck
            // 
            this.checkBoxSynchroCheck.AutoSize = true;
            this.checkBoxSynchroCheck.Location = new System.Drawing.Point(113, 28);
            this.checkBoxSynchroCheck.Name = "checkBoxSynchroCheck";
            this.checkBoxSynchroCheck.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSynchroCheck.TabIndex = 1;
            this.checkBoxSynchroCheck.Tag = "synchroCheck";
            this.checkBoxSynchroCheck.Text = "Synchro Check";
            this.checkBoxSynchroCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxInterlockCheck
            // 
            this.checkBoxInterlockCheck.AutoSize = true;
            this.checkBoxInterlockCheck.Location = new System.Drawing.Point(6, 28);
            this.checkBoxInterlockCheck.Name = "checkBoxInterlockCheck";
            this.checkBoxInterlockCheck.Size = new System.Drawing.Size(101, 17);
            this.checkBoxInterlockCheck.TabIndex = 0;
            this.checkBoxInterlockCheck.Tag = "interlockCheck";
            this.checkBoxInterlockCheck.Text = "Interlock Check";
            this.checkBoxInterlockCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Value: ";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(69, 68);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(314, 21);
            this.comboBoxValue.TabIndex = 10;
            // 
            // groupBoxOrig
            // 
            this.groupBoxOrig.Controls.Add(this.textBoxIdent);
            this.groupBoxOrig.Controls.Add(this.numericUpDownCat);
            this.groupBoxOrig.Controls.Add(this.label6);
            this.groupBoxOrig.Controls.Add(this.label5);
            this.groupBoxOrig.Location = new System.Drawing.Point(12, 211);
            this.groupBoxOrig.Name = "groupBoxOrig";
            this.groupBoxOrig.Size = new System.Drawing.Size(389, 79);
            this.groupBoxOrig.TabIndex = 11;
            this.groupBoxOrig.TabStop = false;
            this.groupBoxOrig.Text = "Originator";
            // 
            // textBoxIdent
            // 
            this.textBoxIdent.Location = new System.Drawing.Point(86, 48);
            this.textBoxIdent.Name = "textBoxIdent";
            this.textBoxIdent.Size = new System.Drawing.Size(297, 20);
            this.textBoxIdent.TabIndex = 3;
            // 
            // numericUpDownCat
            // 
            this.numericUpDownCat.Location = new System.Drawing.Point(86, 19);
            this.numericUpDownCat.Name = "numericUpDownCat";
            this.numericUpDownCat.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownCat.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Identifier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxValue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelAddr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelFlow);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 107);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            // 
            // CommandDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxOrig);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Name = "CommandDialog";
            this.Text = "Sending a Command";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxOrig.ResumeLayout(false);
            this.groupBoxOrig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFlow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxInterlockCheck;
        private System.Windows.Forms.CheckBox checkBoxSynchroCheck;
        private System.Windows.Forms.CheckBox checkBoxTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.GroupBox groupBoxOrig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCat;
        private System.Windows.Forms.TextBox textBoxIdent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
    }
}