namespace Spotify
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            nameInput = new TextBox();
            durationInput = new TextBox();
            Add = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            getId = new Button();
            getById = new TextBox();
            deletebtn = new Button();
            deleteById = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            updateRadio3 = new RadioButton();
            updateRadio2 = new RadioButton();
            updateRadio1 = new RadioButton();
            update = new Button();
            updateDuration = new TextBox();
            updateName = new TextBox();
            idUpdate = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(502, 206);
            dataGridView1.TabIndex = 2;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(30, 77);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(138, 23);
            nameInput.TabIndex = 3;
            // 
            // durationInput
            // 
            durationInput.Location = new Point(30, 129);
            durationInput.Name = "durationInput";
            durationInput.Size = new Size(138, 23);
            durationInput.TabIndex = 9;
            // 
            // Add
            // 
            Add.Location = new Point(268, 88);
            Add.Name = "Add";
            Add.Size = new Size(122, 37);
            Add.TabIndex = 6;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // radioButton1
            // 
            radioButton1.Checked = true;
            radioButton1.Location = new Point(184, 71);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hip-Hop";
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(184, 101);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 10;
            radioButton2.Text = "Pop";
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(184, 127);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(78, 24);
            radioButton3.TabIndex = 11;
            radioButton3.Text = "Techno";
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // getId
            // 
            getId.Location = new Point(534, 291);
            getId.Name = "getId";
            getId.Size = new Size(122, 37);
            getId.TabIndex = 12;
            getId.Text = "Get By Id\r\n";
            getId.UseVisualStyleBackColor = true;
            getId.Click += getId_Click;
            // 
            // getById
            // 
            getById.Location = new Point(534, 262);
            getById.Name = "getById";
            getById.Size = new Size(138, 23);
            getById.TabIndex = 13;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(534, 393);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(122, 37);
            deletebtn.TabIndex = 14;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // deleteById
            // 
            deleteById.Location = new Point(534, 364);
            deleteById.Name = "deleteById";
            deleteById.Size = new Size(138, 23);
            deleteById.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(140, 393);
            button1.Name = "button1";
            button1.Size = new Size(122, 37);
            button1.TabIndex = 16;
            button1.Text = "Get All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(30, 51);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Location = new Point(30, 103);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 17;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.Location = new Point(534, 129);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 25;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.Location = new Point(534, 77);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 18;
            label4.Text = "Name";
            // 
            // updateRadio3
            // 
            updateRadio3.Location = new Point(678, 164);
            updateRadio3.Name = "updateRadio3";
            updateRadio3.Size = new Size(78, 24);
            updateRadio3.TabIndex = 24;
            updateRadio3.Text = "Techno";
            // 
            // updateRadio2
            // 
            updateRadio2.Location = new Point(678, 138);
            updateRadio2.Name = "updateRadio2";
            updateRadio2.Size = new Size(78, 24);
            updateRadio2.TabIndex = 23;
            updateRadio2.Text = "Pop";
            // 
            // updateRadio1
            // 
            updateRadio1.Checked = true;
            updateRadio1.Location = new Point(678, 108);
            updateRadio1.Name = "updateRadio1";
            updateRadio1.Size = new Size(78, 24);
            updateRadio1.TabIndex = 19;
            updateRadio1.TabStop = true;
            updateRadio1.Text = "Hip-Hop";
            // 
            // update
            // 
            update.Location = new Point(534, 188);
            update.Name = "update";
            update.Size = new Size(122, 37);
            update.TabIndex = 21;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // updateDuration
            // 
            updateDuration.Location = new Point(534, 155);
            updateDuration.Name = "updateDuration";
            updateDuration.Size = new Size(138, 23);
            updateDuration.TabIndex = 22;
            // 
            // updateName
            // 
            updateName.Location = new Point(534, 103);
            updateName.Name = "updateName";
            updateName.Size = new Size(138, 23);
            updateName.TabIndex = 20;
            // 
            // idUpdate
            // 
            idUpdate.Location = new Point(534, 48);
            idUpdate.Name = "idUpdate";
            idUpdate.Size = new Size(138, 23);
            idUpdate.TabIndex = 26;
            // 
            // label5
            // 
            label5.Location = new Point(534, 22);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 27;
            label5.Text = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 450);
            Controls.Add(label5);
            Controls.Add(idUpdate);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(updateRadio3);
            Controls.Add(updateRadio2);
            Controls.Add(updateRadio1);
            Controls.Add(update);
            Controls.Add(updateDuration);
            Controls.Add(updateName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(deleteById);
            Controls.Add(deletebtn);
            Controls.Add(getById);
            Controls.Add(getId);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(Add);
            Controls.Add(durationInput);
            Controls.Add(nameInput);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "wxwx";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox nameInput;
        private TextBox durationInput;
        private Button Add;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button getId;
        private TextBox getById;
        private Button deletebtn;
        private TextBox deleteById;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton updateRadio3;
        private RadioButton updateRadio2;
        private RadioButton updateRadio1;
        private Button update;
        private TextBox updateDuration;
        private TextBox updateName;
        private TextBox idUpdate;
        private Label label5;
    }
}
