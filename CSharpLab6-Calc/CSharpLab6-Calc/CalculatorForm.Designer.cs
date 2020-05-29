namespace CSharpLab6_Calc
{
    partial class Calculator
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butEqual = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butZero = new System.Windows.Forms.Button();
            this.butDot = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.butMultiply = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.butCE = new System.Windows.Forms.Button();
            this.flLayoutTop = new System.Windows.Forms.FlowLayoutPanel();
            this.labelResult = new System.Windows.Forms.Label();
            this.lblEquation = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flLayoutTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.butEqual, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flLayoutTop, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.70414F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.71506F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5808F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 424);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // butEqual
            // 
            this.butEqual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butEqual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.butEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butEqual.Location = new System.Drawing.Point(7, 357);
            this.butEqual.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.butEqual.MinimumSize = new System.Drawing.Size(145, 10);
            this.butEqual.Name = "butEqual";
            this.butEqual.Size = new System.Drawing.Size(287, 59);
            this.butEqual.TabIndex = 2;
            this.butEqual.Tag = "equal";
            this.butEqual.Text = "=";
            this.butEqual.UseVisualStyleBackColor = true;
            this.butEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.butZero, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.butDot, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.but1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.but2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.but3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.butMultiply, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.but4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.but5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.but6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.butMinus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.but7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.but9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.but8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.butDiv, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.butCE, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 90);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // butZero
            // 
            this.butZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butZero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butZero.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.butZero.Location = new System.Drawing.Point(77, 194);
            this.butZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butZero.Name = "butZero";
            this.butZero.Size = new System.Drawing.Size(67, 63);
            this.butZero.TabIndex = 0;
            this.butZero.TabStop = false;
            this.butZero.Tag = "numeric";
            this.butZero.Text = "0";
            this.butZero.UseVisualStyleBackColor = true;
            // 
            // butDot
            // 
            this.butDot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butDot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butDot.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.butDot.Location = new System.Drawing.Point(150, 194);
            this.butDot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDot.Name = "butDot";
            this.butDot.Size = new System.Drawing.Size(67, 63);
            this.butDot.TabIndex = 0;
            this.butDot.TabStop = false;
            this.butDot.Tag = "dot";
            this.butDot.Text = ".";
            this.butDot.UseVisualStyleBackColor = true;
            // 
            // but1
            // 
            this.but1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but1.Location = new System.Drawing.Point(3, 130);
            this.but1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(68, 60);
            this.but1.TabIndex = 0;
            this.but1.TabStop = false;
            this.but1.Tag = "numeric";
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            // 
            // but2
            // 
            this.but2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but2.Location = new System.Drawing.Point(77, 130);
            this.but2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(67, 60);
            this.but2.TabIndex = 0;
            this.but2.TabStop = false;
            this.but2.Tag = "numeric";
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            // 
            // but3
            // 
            this.but3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but3.Location = new System.Drawing.Point(150, 130);
            this.but3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(67, 60);
            this.but3.TabIndex = 0;
            this.but3.TabStop = false;
            this.but3.Tag = "numeric";
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            // 
            // butMultiply
            // 
            this.butMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butMultiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butMultiply.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.butMultiply.Location = new System.Drawing.Point(223, 130);
            this.butMultiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butMultiply.Name = "butMultiply";
            this.butMultiply.Size = new System.Drawing.Size(67, 60);
            this.butMultiply.TabIndex = 0;
            this.butMultiply.TabStop = false;
            this.butMultiply.Tag = "operation";
            this.butMultiply.Text = "*";
            this.butMultiply.UseVisualStyleBackColor = true;
            this.butMultiply.Click += new System.EventHandler(this.bOperator_Click);
            // 
            // but4
            // 
            this.but4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but4.Location = new System.Drawing.Point(3, 66);
            this.but4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(68, 60);
            this.but4.TabIndex = 0;
            this.but4.TabStop = false;
            this.but4.Tag = "numeric";
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            // 
            // but5
            // 
            this.but5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but5.Location = new System.Drawing.Point(77, 66);
            this.but5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(67, 60);
            this.but5.TabIndex = 0;
            this.but5.TabStop = false;
            this.but5.Tag = "numeric";
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            // 
            // but6
            // 
            this.but6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but6.Location = new System.Drawing.Point(150, 66);
            this.but6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(67, 60);
            this.but6.TabIndex = 0;
            this.but6.TabStop = false;
            this.but6.Tag = "numeric";
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            // 
            // butMinus
            // 
            this.butMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butMinus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.butMinus.Location = new System.Drawing.Point(223, 66);
            this.butMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(67, 60);
            this.butMinus.TabIndex = 0;
            this.butMinus.TabStop = false;
            this.butMinus.Tag = "operation";
            this.butMinus.Text = "-";
            this.butMinus.UseVisualStyleBackColor = true;
            this.butMinus.Click += new System.EventHandler(this.bOperator_Click);
            // 
            // but7
            // 
            this.but7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but7.Location = new System.Drawing.Point(3, 2);
            this.but7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(68, 60);
            this.but7.TabIndex = 0;
            this.but7.TabStop = false;
            this.but7.Tag = "numeric";
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            // 
            // but9
            // 
            this.but9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but9.Location = new System.Drawing.Point(77, 2);
            this.but9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(67, 60);
            this.but9.TabIndex = 0;
            this.but9.TabStop = false;
            this.but9.Tag = "numeric";
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            // 
            // but8
            // 
            this.but8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.but8.Location = new System.Drawing.Point(150, 2);
            this.but8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(67, 60);
            this.but8.TabIndex = 0;
            this.but8.TabStop = false;
            this.but8.Tag = "numeric";
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            this.butAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.butAdd.Location = new System.Drawing.Point(223, 2);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(67, 60);
            this.butAdd.TabIndex = 0;
            this.butAdd.TabStop = false;
            this.butAdd.Tag = "operation";
            this.butAdd.Text = "+";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.bOperator_Click);
            // 
            // butDiv
            // 
            this.butDiv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butDiv.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.butDiv.Location = new System.Drawing.Point(223, 194);
            this.butDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(67, 63);
            this.butDiv.TabIndex = 0;
            this.butDiv.TabStop = false;
            this.butDiv.Tag = "operation";
            this.butDiv.Text = "/";
            this.butDiv.UseVisualStyleBackColor = true;
            this.butDiv.Click += new System.EventHandler(this.bOperator_Click);
            // 
            // butCE
            // 
            this.butCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butCE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butCE.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.butCE.Location = new System.Drawing.Point(3, 194);
            this.butCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCE.Name = "butCE";
            this.butCE.Padding = new System.Windows.Forms.Padding(1);
            this.butCE.Size = new System.Drawing.Size(68, 63);
            this.butCE.TabIndex = 0;
            this.butCE.TabStop = false;
            this.butCE.Tag = "clear";
            this.butCE.Text = "CE";
            this.butCE.UseVisualStyleBackColor = true;
            this.butCE.Click += new System.EventHandler(this.bClear_Click);
            // 
            // flLayoutTop
            // 
            this.flLayoutTop.AutoSize = true;
            this.flLayoutTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flLayoutTop.Controls.Add(this.labelResult);
            this.flLayoutTop.Controls.Add(this.lblEquation);
            this.flLayoutTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flLayoutTop.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flLayoutTop.Location = new System.Drawing.Point(9, 2);
            this.flLayoutTop.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.flLayoutTop.Name = "flLayoutTop";
            this.flLayoutTop.Size = new System.Drawing.Size(283, 83);
            this.flLayoutTop.TabIndex = 1;
            this.flLayoutTop.WrapContents = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoEllipsis = true;
            this.labelResult.AutoSize = true;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flLayoutTop.SetFlowBreak(this.labelResult, true);
            this.labelResult.Font = new System.Drawing.Font("Calibri", 28.2F);
            this.labelResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResult.Location = new System.Drawing.Point(130, 22);
            this.labelResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelResult.MinimumSize = new System.Drawing.Size(150, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelResult.Size = new System.Drawing.Size(150, 59);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "0";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelResult.TextChanged += new System.EventHandler(this.labelResult_TextChanged);
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Dock = System.Windows.Forms.DockStyle.Top;
            this.flLayoutTop.SetFlowBreak(this.lblEquation, true);
            this.lblEquation.Location = new System.Drawing.Point(130, 3);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEquation.Size = new System.Drawing.Size(150, 17);
            this.lblEquation.TabIndex = 1;
            this.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(302, 424);
            this.Controls.Add(this.tableLayoutPanel2);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(642, 942);
            this.MinimumSize = new System.Drawing.Size(320, 355);
            this.Name = "Calculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Calculator_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Calculator_SizeChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flLayoutTop.ResumeLayout(false);
            this.flLayoutTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butZero;
        private System.Windows.Forms.Button butDot;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button butMultiply;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button butMinus;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDiv;
        private System.Windows.Forms.Button butCE;
        private System.Windows.Forms.FlowLayoutPanel flLayoutTop;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Button butEqual;
    }
}

