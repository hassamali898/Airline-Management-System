namespace Air_line_Managment_System
{
    partial class aeroplan_system
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aeroplan_system));
            this.Ticketclassbox = new System.Windows.Forms.ComboBox();
            this.Bookingbox = new System.Windows.Forms.ComboBox();
            this.Join = new System.Windows.Forms.Button();
            this.frombox = new System.Windows.Forms.ComboBox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.button1 = new System.Windows.Forms.Button();
            this.seats1 = new Air_line_Managment_System.Seats();
            this.SuspendLayout();
            // 
            // Ticketclassbox
            // 
            this.Ticketclassbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(93)))), ((int)(((byte)(32)))));
            this.Ticketclassbox.ForeColor = System.Drawing.Color.White;
            this.Ticketclassbox.FormattingEnabled = true;
            this.Ticketclassbox.Items.AddRange(new object[] {
            "Business",
            "Econemy"});
            this.Ticketclassbox.Location = new System.Drawing.Point(310, 74);
            this.Ticketclassbox.Name = "Ticketclassbox";
            this.Ticketclassbox.Size = new System.Drawing.Size(242, 29);
            this.Ticketclassbox.TabIndex = 6;
            this.Ticketclassbox.Text = "Ticket Class";
            // 
            // Bookingbox
            // 
            this.Bookingbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(93)))), ((int)(((byte)(32)))));
            this.Bookingbox.ForeColor = System.Drawing.Color.White;
            this.Bookingbox.FormattingEnabled = true;
            this.Bookingbox.Items.AddRange(new object[] {
            "Lahore",
            "Karachi",
            "Islamabad",
            "Kashmir",
            "Sindh"});
            this.Bookingbox.Location = new System.Drawing.Point(310, 124);
            this.Bookingbox.Name = "Bookingbox";
            this.Bookingbox.Size = new System.Drawing.Size(242, 29);
            this.Bookingbox.TabIndex = 7;
            this.Bookingbox.Text = "Booking";
            // 
            // Join
            // 
            this.Join.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.Join.FlatAppearance.BorderSize = 0;
            this.Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Join.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join.ForeColor = System.Drawing.Color.White;
            this.Join.Location = new System.Drawing.Point(349, 347);
            this.Join.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(166, 36);
            this.Join.TabIndex = 9;
            this.Join.Text = "Next";
            this.Join.UseVisualStyleBackColor = false;
            this.Join.Click += new System.EventHandler(this.Join_Click);
            // 
            // frombox
            // 
            this.frombox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(93)))), ((int)(((byte)(32)))));
            this.frombox.ForeColor = System.Drawing.Color.White;
            this.frombox.FormattingEnabled = true;
            this.frombox.Items.AddRange(new object[] {
            "Lahore",
            "Karachi",
            "Islamabad",
            "Kashmir",
            "Sindh"});
            this.frombox.Location = new System.Drawing.Point(310, 176);
            this.frombox.Name = "frombox";
            this.frombox.Size = new System.Drawing.Size(242, 29);
            this.frombox.TabIndex = 10;
            this.frombox.Text = "From";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(93)))), ((int)(((byte)(32)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(310, 232);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(242, 27);
            this.bunifuDatepicker1.TabIndex = 63;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 5, 5, 0, 3, 31, 743);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 64;
            this.button1.Text = "     Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seats1
            // 
            this.seats1.BackColor = System.Drawing.Color.White;
            this.seats1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seats1.Location = new System.Drawing.Point(0, 0);
            this.seats1.Margin = new System.Windows.Forms.Padding(5);
            this.seats1.Name = "seats1";
            this.seats1.Size = new System.Drawing.Size(854, 432);
            this.seats1.TabIndex = 65;
            // 
            // aeroplan_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.seats1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.frombox);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.Bookingbox);
            this.Controls.Add(this.Ticketclassbox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "aeroplan_system";
            this.Size = new System.Drawing.Size(854, 432);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Ticketclassbox;
        private System.Windows.Forms.ComboBox Bookingbox;
        private System.Windows.Forms.Button Join;
        private System.Windows.Forms.ComboBox frombox;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Button button1;
        private Seats seats1;

    }
}
