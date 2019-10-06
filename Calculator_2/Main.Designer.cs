namespace Calculator_2
{
    partial class Main_form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.Screen = new System.Windows.Forms.Label();
            this.Button_function_mr = new System.Windows.Forms.Button();
            this.Button_function_ms = new System.Windows.Forms.Button();
            this.Button_function_m_add = new System.Windows.Forms.Button();
            this.Button_function_m_sub = new System.Windows.Forms.Button();
            this.Button_function_c = new System.Windows.Forms.Button();
            this.Button_function_mc = new System.Windows.Forms.Button();
            this.Button_function_pos_or_neg = new System.Windows.Forms.Button();
            this.Button_oprt_add = new System.Windows.Forms.Button();
            this.Button_number_1 = new System.Windows.Forms.Button();
            this.Button_number_2 = new System.Windows.Forms.Button();
            this.Button_number_3 = new System.Windows.Forms.Button();
            this.Button_oprt_sub = new System.Windows.Forms.Button();
            this.Button_number_4 = new System.Windows.Forms.Button();
            this.Button_number_5 = new System.Windows.Forms.Button();
            this.Button_number_6 = new System.Windows.Forms.Button();
            this.Button_oprt_mul = new System.Windows.Forms.Button();
            this.Button_number_7 = new System.Windows.Forms.Button();
            this.Button_number_8 = new System.Windows.Forms.Button();
            this.Button_number_9 = new System.Windows.Forms.Button();
            this.Button_oprt_div = new System.Windows.Forms.Button();
            this.Button_number_0 = new System.Windows.Forms.Button();
            this.Button_function_dot = new System.Windows.Forms.Button();
            this.Button_function_equ = new System.Windows.Forms.Button();
            this.TrackBar_uos = new System.Windows.Forms.TrackBar();
            this.TrackBar_dds = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_oprt_pow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_uos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_dds)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.Olive;
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Screen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Screen.Location = new System.Drawing.Point(12, 12);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(258, 50);
            this.Screen.TabIndex = 1;
            this.Screen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button_function_mr
            // 
            this.Button_function_mr.BackColor = System.Drawing.Color.Gray;
            this.Button_function_mr.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_mr.Location = new System.Drawing.Point(12, 119);
            this.Button_function_mr.Name = "Button_function_mr";
            this.Button_function_mr.Size = new System.Drawing.Size(60, 50);
            this.Button_function_mr.TabIndex = 2;
            this.Button_function_mr.TabStop = false;
            this.Button_function_mr.Tag = "1";
            this.Button_function_mr.Text = "MR";
            this.Button_function_mr.UseVisualStyleBackColor = false;
            this.Button_function_mr.Click += new System.EventHandler(this.Button_function_clck);
            // 
            // Button_function_ms
            // 
            this.Button_function_ms.BackColor = System.Drawing.Color.Gray;
            this.Button_function_ms.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_ms.Location = new System.Drawing.Point(78, 119);
            this.Button_function_ms.Name = "Button_function_ms";
            this.Button_function_ms.Size = new System.Drawing.Size(60, 50);
            this.Button_function_ms.TabIndex = 3;
            this.Button_function_ms.TabStop = false;
            this.Button_function_ms.Tag = "2";
            this.Button_function_ms.Text = "MS";
            this.Button_function_ms.UseVisualStyleBackColor = false;
            this.Button_function_ms.Click += new System.EventHandler(this.Button_function_clck);
            // 
            // Button_function_m_add
            // 
            this.Button_function_m_add.BackColor = System.Drawing.Color.Gray;
            this.Button_function_m_add.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_m_add.Location = new System.Drawing.Point(144, 119);
            this.Button_function_m_add.Name = "Button_function_m_add";
            this.Button_function_m_add.Size = new System.Drawing.Size(60, 50);
            this.Button_function_m_add.TabIndex = 4;
            this.Button_function_m_add.TabStop = false;
            this.Button_function_m_add.Tag = "3";
            this.Button_function_m_add.Text = "M+";
            this.Button_function_m_add.UseVisualStyleBackColor = false;
            this.Button_function_m_add.Click += new System.EventHandler(this.Button_function_clck);
            // 
            // Button_function_m_sub
            // 
            this.Button_function_m_sub.BackColor = System.Drawing.Color.Gray;
            this.Button_function_m_sub.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_m_sub.Location = new System.Drawing.Point(210, 119);
            this.Button_function_m_sub.Name = "Button_function_m_sub";
            this.Button_function_m_sub.Size = new System.Drawing.Size(60, 50);
            this.Button_function_m_sub.TabIndex = 5;
            this.Button_function_m_sub.TabStop = false;
            this.Button_function_m_sub.Tag = "4";
            this.Button_function_m_sub.Text = "M-";
            this.Button_function_m_sub.UseVisualStyleBackColor = false;
            this.Button_function_m_sub.Click += new System.EventHandler(this.Button_function_clck);
            // 
            // Button_function_c
            // 
            this.Button_function_c.BackColor = System.Drawing.Color.Gray;
            this.Button_function_c.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_c.Location = new System.Drawing.Point(12, 175);
            this.Button_function_c.Name = "Button_function_c";
            this.Button_function_c.Size = new System.Drawing.Size(60, 50);
            this.Button_function_c.TabIndex = 6;
            this.Button_function_c.TabStop = false;
            this.Button_function_c.Tag = "1";
            this.Button_function_c.Text = "C";
            this.Button_function_c.UseVisualStyleBackColor = false;
            this.Button_function_c.Click += new System.EventHandler(this.Button_clear_clck);
            // 
            // Button_function_mc
            // 
            this.Button_function_mc.BackColor = System.Drawing.Color.Gray;
            this.Button_function_mc.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_mc.Location = new System.Drawing.Point(78, 175);
            this.Button_function_mc.Name = "Button_function_mc";
            this.Button_function_mc.Size = new System.Drawing.Size(60, 50);
            this.Button_function_mc.TabIndex = 7;
            this.Button_function_mc.TabStop = false;
            this.Button_function_mc.Tag = "2";
            this.Button_function_mc.Text = "MC";
            this.Button_function_mc.UseVisualStyleBackColor = false;
            this.Button_function_mc.Click += new System.EventHandler(this.Button_clear_clck);
            // 
            // Button_function_pos_or_neg
            // 
            this.Button_function_pos_or_neg.BackColor = System.Drawing.Color.Gray;
            this.Button_function_pos_or_neg.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_pos_or_neg.Location = new System.Drawing.Point(144, 175);
            this.Button_function_pos_or_neg.Name = "Button_function_pos_or_neg";
            this.Button_function_pos_or_neg.Size = new System.Drawing.Size(60, 50);
            this.Button_function_pos_or_neg.TabIndex = 8;
            this.Button_function_pos_or_neg.TabStop = false;
            this.Button_function_pos_or_neg.Tag = "5";
            this.Button_function_pos_or_neg.Text = "+/-";
            this.Button_function_pos_or_neg.UseVisualStyleBackColor = false;
            this.Button_function_pos_or_neg.Click += new System.EventHandler(this.Button_function_clck);
            // 
            // Button_oprt_add
            // 
            this.Button_oprt_add.BackColor = System.Drawing.Color.Gray;
            this.Button_oprt_add.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_oprt_add.Location = new System.Drawing.Point(210, 175);
            this.Button_oprt_add.Name = "Button_oprt_add";
            this.Button_oprt_add.Size = new System.Drawing.Size(60, 50);
            this.Button_oprt_add.TabIndex = 9;
            this.Button_oprt_add.TabStop = false;
            this.Button_oprt_add.Tag = "1";
            this.Button_oprt_add.Text = "+";
            this.Button_oprt_add.UseVisualStyleBackColor = false;
            this.Button_oprt_add.Click += new System.EventHandler(this.Button_oprt_clck);
            // 
            // Button_number_1
            // 
            this.Button_number_1.BackColor = System.Drawing.Color.Gray;
            this.Button_number_1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_1.Location = new System.Drawing.Point(12, 231);
            this.Button_number_1.Name = "Button_number_1";
            this.Button_number_1.Size = new System.Drawing.Size(60, 50);
            this.Button_number_1.TabIndex = 10;
            this.Button_number_1.TabStop = false;
            this.Button_number_1.Tag = "1";
            this.Button_number_1.Text = "1";
            this.Button_number_1.UseVisualStyleBackColor = false;
            this.Button_number_1.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_number_2
            // 
            this.Button_number_2.BackColor = System.Drawing.Color.Gray;
            this.Button_number_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_2.Location = new System.Drawing.Point(78, 231);
            this.Button_number_2.Name = "Button_number_2";
            this.Button_number_2.Size = new System.Drawing.Size(60, 50);
            this.Button_number_2.TabIndex = 11;
            this.Button_number_2.TabStop = false;
            this.Button_number_2.Tag = "2";
            this.Button_number_2.Text = "2";
            this.Button_number_2.UseVisualStyleBackColor = false;
            this.Button_number_2.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_number_3
            // 
            this.Button_number_3.BackColor = System.Drawing.Color.Gray;
            this.Button_number_3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_3.Location = new System.Drawing.Point(144, 231);
            this.Button_number_3.Name = "Button_number_3";
            this.Button_number_3.Size = new System.Drawing.Size(60, 50);
            this.Button_number_3.TabIndex = 12;
            this.Button_number_3.TabStop = false;
            this.Button_number_3.Tag = "3";
            this.Button_number_3.Text = "3";
            this.Button_number_3.UseVisualStyleBackColor = false;
            this.Button_number_3.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_oprt_sub
            // 
            this.Button_oprt_sub.BackColor = System.Drawing.Color.Gray;
            this.Button_oprt_sub.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_oprt_sub.Location = new System.Drawing.Point(210, 231);
            this.Button_oprt_sub.Name = "Button_oprt_sub";
            this.Button_oprt_sub.Size = new System.Drawing.Size(60, 50);
            this.Button_oprt_sub.TabIndex = 13;
            this.Button_oprt_sub.TabStop = false;
            this.Button_oprt_sub.Tag = "2";
            this.Button_oprt_sub.Text = "-";
            this.Button_oprt_sub.UseVisualStyleBackColor = false;
            this.Button_oprt_sub.Click += new System.EventHandler(this.Button_oprt_clck);
            // 
            // Button_number_4
            // 
            this.Button_number_4.BackColor = System.Drawing.Color.Gray;
            this.Button_number_4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_4.Location = new System.Drawing.Point(12, 287);
            this.Button_number_4.Name = "Button_number_4";
            this.Button_number_4.Size = new System.Drawing.Size(60, 50);
            this.Button_number_4.TabIndex = 14;
            this.Button_number_4.TabStop = false;
            this.Button_number_4.Tag = "4";
            this.Button_number_4.Text = "4";
            this.Button_number_4.UseVisualStyleBackColor = false;
            this.Button_number_4.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_number_5
            // 
            this.Button_number_5.BackColor = System.Drawing.Color.Gray;
            this.Button_number_5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_5.Location = new System.Drawing.Point(78, 287);
            this.Button_number_5.Name = "Button_number_5";
            this.Button_number_5.Size = new System.Drawing.Size(60, 50);
            this.Button_number_5.TabIndex = 15;
            this.Button_number_5.TabStop = false;
            this.Button_number_5.Tag = "5";
            this.Button_number_5.Text = "5";
            this.Button_number_5.UseVisualStyleBackColor = false;
            this.Button_number_5.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_number_6
            // 
            this.Button_number_6.BackColor = System.Drawing.Color.Gray;
            this.Button_number_6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_6.Location = new System.Drawing.Point(144, 287);
            this.Button_number_6.Name = "Button_number_6";
            this.Button_number_6.Size = new System.Drawing.Size(60, 50);
            this.Button_number_6.TabIndex = 16;
            this.Button_number_6.TabStop = false;
            this.Button_number_6.Tag = "6";
            this.Button_number_6.Text = "6";
            this.Button_number_6.UseVisualStyleBackColor = false;
            this.Button_number_6.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_oprt_mul
            // 
            this.Button_oprt_mul.BackColor = System.Drawing.Color.Gray;
            this.Button_oprt_mul.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_oprt_mul.Location = new System.Drawing.Point(210, 287);
            this.Button_oprt_mul.Name = "Button_oprt_mul";
            this.Button_oprt_mul.Size = new System.Drawing.Size(60, 50);
            this.Button_oprt_mul.TabIndex = 17;
            this.Button_oprt_mul.TabStop = false;
            this.Button_oprt_mul.Tag = "3";
            this.Button_oprt_mul.Text = "*";
            this.Button_oprt_mul.UseVisualStyleBackColor = false;
            this.Button_oprt_mul.Click += new System.EventHandler(this.Button_oprt_clck);
            // 
            // Button_number_7
            // 
            this.Button_number_7.BackColor = System.Drawing.Color.Gray;
            this.Button_number_7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_7.Location = new System.Drawing.Point(12, 343);
            this.Button_number_7.Name = "Button_number_7";
            this.Button_number_7.Size = new System.Drawing.Size(60, 50);
            this.Button_number_7.TabIndex = 18;
            this.Button_number_7.TabStop = false;
            this.Button_number_7.Tag = "7";
            this.Button_number_7.Text = "7";
            this.Button_number_7.UseVisualStyleBackColor = false;
            this.Button_number_7.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_number_8
            // 
            this.Button_number_8.BackColor = System.Drawing.Color.Gray;
            this.Button_number_8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_8.Location = new System.Drawing.Point(78, 343);
            this.Button_number_8.Name = "Button_number_8";
            this.Button_number_8.Size = new System.Drawing.Size(60, 50);
            this.Button_number_8.TabIndex = 19;
            this.Button_number_8.TabStop = false;
            this.Button_number_8.Tag = "8";
            this.Button_number_8.Text = "8";
            this.Button_number_8.UseVisualStyleBackColor = false;
            this.Button_number_8.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_number_9
            // 
            this.Button_number_9.BackColor = System.Drawing.Color.Gray;
            this.Button_number_9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_9.Location = new System.Drawing.Point(144, 343);
            this.Button_number_9.Name = "Button_number_9";
            this.Button_number_9.Size = new System.Drawing.Size(60, 50);
            this.Button_number_9.TabIndex = 20;
            this.Button_number_9.TabStop = false;
            this.Button_number_9.Tag = "9";
            this.Button_number_9.Text = "9";
            this.Button_number_9.UseVisualStyleBackColor = false;
            this.Button_number_9.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_oprt_div
            // 
            this.Button_oprt_div.BackColor = System.Drawing.Color.Gray;
            this.Button_oprt_div.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_oprt_div.Location = new System.Drawing.Point(210, 343);
            this.Button_oprt_div.Name = "Button_oprt_div";
            this.Button_oprt_div.Size = new System.Drawing.Size(60, 50);
            this.Button_oprt_div.TabIndex = 21;
            this.Button_oprt_div.TabStop = false;
            this.Button_oprt_div.Tag = "4";
            this.Button_oprt_div.Text = "/";
            this.Button_oprt_div.UseVisualStyleBackColor = false;
            this.Button_oprt_div.Click += new System.EventHandler(this.Button_oprt_clck);
            // 
            // Button_number_0
            // 
            this.Button_number_0.BackColor = System.Drawing.Color.Gray;
            this.Button_number_0.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_number_0.Location = new System.Drawing.Point(12, 399);
            this.Button_number_0.Name = "Button_number_0";
            this.Button_number_0.Size = new System.Drawing.Size(60, 50);
            this.Button_number_0.TabIndex = 22;
            this.Button_number_0.TabStop = false;
            this.Button_number_0.Tag = "0";
            this.Button_number_0.Text = "0";
            this.Button_number_0.UseVisualStyleBackColor = false;
            this.Button_number_0.Click += new System.EventHandler(this.Button_number_clck);
            // 
            // Button_function_dot
            // 
            this.Button_function_dot.BackColor = System.Drawing.Color.Gray;
            this.Button_function_dot.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_dot.Location = new System.Drawing.Point(78, 399);
            this.Button_function_dot.Name = "Button_function_dot";
            this.Button_function_dot.Size = new System.Drawing.Size(60, 50);
            this.Button_function_dot.TabIndex = 23;
            this.Button_function_dot.TabStop = false;
            this.Button_function_dot.Tag = "6";
            this.Button_function_dot.Text = ".";
            this.Button_function_dot.UseVisualStyleBackColor = false;
            this.Button_function_dot.Click += new System.EventHandler(this.Button_function_clck);
            // 
            // Button_function_equ
            // 
            this.Button_function_equ.BackColor = System.Drawing.Color.Gray;
            this.Button_function_equ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_function_equ.Location = new System.Drawing.Point(144, 399);
            this.Button_function_equ.Name = "Button_function_equ";
            this.Button_function_equ.Size = new System.Drawing.Size(60, 50);
            this.Button_function_equ.TabIndex = 24;
            this.Button_function_equ.TabStop = false;
            this.Button_function_equ.Tag = "7";
            this.Button_function_equ.Text = "=";
            this.Button_function_equ.UseVisualStyleBackColor = false;
            this.Button_function_equ.Click += new System.EventHandler(this.Button_function_clck);
            // 
            // TrackBar_uos
            // 
            this.TrackBar_uos.LargeChange = 0;
            this.TrackBar_uos.Location = new System.Drawing.Point(12, 68);
            this.TrackBar_uos.Maximum = 2;
            this.TrackBar_uos.Name = "TrackBar_uos";
            this.TrackBar_uos.Size = new System.Drawing.Size(126, 45);
            this.TrackBar_uos.SmallChange = 0;
            this.TrackBar_uos.TabIndex = 26;
            this.TrackBar_uos.TabStop = false;
            this.TrackBar_uos.Tag = "1";
            this.TrackBar_uos.Value = 1;
            this.TrackBar_uos.ValueChanged += new System.EventHandler(this.TrackBar_value_change);
            // 
            // TrackBar_dds
            // 
            this.TrackBar_dds.LargeChange = 0;
            this.TrackBar_dds.Location = new System.Drawing.Point(144, 68);
            this.TrackBar_dds.Maximum = 3;
            this.TrackBar_dds.Name = "TrackBar_dds";
            this.TrackBar_dds.Size = new System.Drawing.Size(126, 45);
            this.TrackBar_dds.SmallChange = 0;
            this.TrackBar_dds.TabIndex = 27;
            this.TrackBar_dds.TabStop = false;
            this.TrackBar_dds.Tag = "2";
            this.TrackBar_dds.Value = 2;
            this.TrackBar_dds.ValueChanged += new System.EventHandler(this.TrackBar_value_change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "U";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "5/4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "O";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(151, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(184, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(217, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(250, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "3";
            // 
            // Button_oprt_pow
            // 
            this.Button_oprt_pow.BackColor = System.Drawing.Color.Gray;
            this.Button_oprt_pow.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_oprt_pow.Location = new System.Drawing.Point(210, 399);
            this.Button_oprt_pow.Name = "Button_oprt_pow";
            this.Button_oprt_pow.Size = new System.Drawing.Size(60, 50);
            this.Button_oprt_pow.TabIndex = 35;
            this.Button_oprt_pow.Tag = "5";
            this.Button_oprt_pow.Text = "^";
            this.Button_oprt_pow.UseVisualStyleBackColor = false;
            this.Button_oprt_pow.Click += new System.EventHandler(this.Button_oprt_clck);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(282, 462);
            this.Controls.Add(this.Button_oprt_pow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackBar_dds);
            this.Controls.Add(this.TrackBar_uos);
            this.Controls.Add(this.Button_function_equ);
            this.Controls.Add(this.Button_function_dot);
            this.Controls.Add(this.Button_number_0);
            this.Controls.Add(this.Button_oprt_div);
            this.Controls.Add(this.Button_number_9);
            this.Controls.Add(this.Button_number_8);
            this.Controls.Add(this.Button_number_7);
            this.Controls.Add(this.Button_oprt_mul);
            this.Controls.Add(this.Button_number_6);
            this.Controls.Add(this.Button_number_5);
            this.Controls.Add(this.Button_number_4);
            this.Controls.Add(this.Button_oprt_sub);
            this.Controls.Add(this.Button_number_3);
            this.Controls.Add(this.Button_number_2);
            this.Controls.Add(this.Button_number_1);
            this.Controls.Add(this.Button_oprt_add);
            this.Controls.Add(this.Button_function_pos_or_neg);
            this.Controls.Add(this.Button_function_mc);
            this.Controls.Add(this.Button_function_c);
            this.Controls.Add(this.Button_function_m_sub);
            this.Controls.Add(this.Button_function_m_add);
            this.Controls.Add(this.Button_function_ms);
            this.Controls.Add(this.Button_function_mr);
            this.Controls.Add(this.Screen);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 501);
            this.MinimumSize = new System.Drawing.Size(298, 501);
            this.Name = "Main_form";
            this.Text = "Calculator 2 (v3.1, FU)";
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_uos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_dds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Screen;
        private System.Windows.Forms.Button Button_function_mr;
        private System.Windows.Forms.Button Button_function_ms;
        private System.Windows.Forms.Button Button_function_m_add;
        private System.Windows.Forms.Button Button_function_m_sub;
        private System.Windows.Forms.Button Button_function_c;
        private System.Windows.Forms.Button Button_function_mc;
        private System.Windows.Forms.Button Button_function_pos_or_neg;
        private System.Windows.Forms.Button Button_oprt_add;
        private System.Windows.Forms.Button Button_number_1;
        private System.Windows.Forms.Button Button_number_2;
        private System.Windows.Forms.Button Button_number_3;
        private System.Windows.Forms.Button Button_oprt_sub;
        private System.Windows.Forms.Button Button_number_4;
        private System.Windows.Forms.Button Button_number_5;
        private System.Windows.Forms.Button Button_number_6;
        private System.Windows.Forms.Button Button_oprt_mul;
        private System.Windows.Forms.Button Button_number_7;
        private System.Windows.Forms.Button Button_number_8;
        private System.Windows.Forms.Button Button_number_9;
        private System.Windows.Forms.Button Button_oprt_div;
        private System.Windows.Forms.Button Button_number_0;
        private System.Windows.Forms.Button Button_function_dot;
        private System.Windows.Forms.Button Button_function_equ;
        private System.Windows.Forms.TrackBar TrackBar_uos;
        private System.Windows.Forms.TrackBar TrackBar_dds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_oprt_pow;
    }
}

