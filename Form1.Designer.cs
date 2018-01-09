namespace Prod_mod
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.facts_listbox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_label = new System.Windows.Forms.Label();
            this.forChainButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.true_facts_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.result_facts_listbox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.used_rules_listbox = new System.Windows.Forms.ListBox();
            this.knBaseButton = new System.Windows.Forms.Button();
            this.backChainButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rules_listbox = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.facts_listbox);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(277, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facts";
            // 
            // facts_listbox
            // 
            this.facts_listbox.FormattingEnabled = true;
            this.facts_listbox.ItemHeight = 16;
            this.facts_listbox.Location = new System.Drawing.Point(8, 20);
            this.facts_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.facts_listbox.Name = "facts_listbox";
            this.facts_listbox.Size = new System.Drawing.Size(261, 356);
            this.facts_listbox.TabIndex = 0;
            this.facts_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Choose_facts_click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.info_label);
            this.panel1.Controls.Add(this.forChainButton);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.knBaseButton);
            this.panel1.Controls.Add(this.backChainButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(16, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 234);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(871, 127);
            this.info_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info_label.Name = "label3";
            this.info_label.Size = new System.Drawing.Size(105, 17);
            this.info_label.TabIndex = 12;
            this.info_label.Text = "Select goal fact";
            // 
            // forChainButton
            // 
            this.forChainButton.Location = new System.Drawing.Point(871, 48);
            this.forChainButton.Margin = new System.Windows.Forms.Padding(4);
            this.forChainButton.Name = "forChainButton";
            this.forChainButton.Size = new System.Drawing.Size(161, 28);
            this.forChainButton.TabIndex = 3;
            this.forChainButton.Text = "Forward chaining";
            this.forChainButton.UseVisualStyleBackColor = true;
            this.forChainButton.Click += new System.EventHandler(this.forward_chaining_click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.true_facts_listbox);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(273, 218);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected facts";
            // 
            // true_facts_listbox
            // 
            this.true_facts_listbox.FormattingEnabled = true;
            this.true_facts_listbox.ItemHeight = 16;
            this.true_facts_listbox.Location = new System.Drawing.Point(8, 18);
            this.true_facts_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.true_facts_listbox.Name = "true_facts_listbox";
            this.true_facts_listbox.Size = new System.Drawing.Size(256, 196);
            this.true_facts_listbox.TabIndex = 1;
            this.true_facts_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.remove_fact_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(871, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fact id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.result_facts_listbox);
            this.groupBox4.Location = new System.Drawing.Point(590, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(273, 218);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resulting facts";
            // 
            // resFactsLB
            // 
            this.result_facts_listbox.FormattingEnabled = true;
            this.result_facts_listbox.ItemHeight = 16;
            this.result_facts_listbox.Location = new System.Drawing.Point(8, 20);
            this.result_facts_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.result_facts_listbox.Name = "resFactsLB";
            this.result_facts_listbox.Size = new System.Drawing.Size(257, 196);
            this.result_facts_listbox.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.used_rules_listbox);
            this.groupBox5.Location = new System.Drawing.Point(289, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(293, 218);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Used rules";
            // 
            // used_rules_listbox
            // 
            this.used_rules_listbox.FormattingEnabled = true;
            this.used_rules_listbox.HorizontalScrollbar = true;
            this.used_rules_listbox.ItemHeight = 16;
            this.used_rules_listbox.Location = new System.Drawing.Point(8, 20);
            this.used_rules_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.used_rules_listbox.Name = "used_rules_listbox";
            this.used_rules_listbox.Size = new System.Drawing.Size(277, 196);
            this.used_rules_listbox.TabIndex = 5;
            // 
            // knBaseButton
            // 
            this.knBaseButton.Location = new System.Drawing.Point(871, 11);
            this.knBaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.knBaseButton.Name = "knBaseButton";
            this.knBaseButton.Size = new System.Drawing.Size(161, 28);
            this.knBaseButton.TabIndex = 1;
            this.knBaseButton.Text = "Select knowledge base";
            this.knBaseButton.UseVisualStyleBackColor = true;
            this.knBaseButton.Click += new System.EventHandler(this.load_knowledge_base_click);
            // 
            // backChainButton
            // 
            this.backChainButton.Location = new System.Drawing.Point(871, 157);
            this.backChainButton.Margin = new System.Windows.Forms.Padding(4);
            this.backChainButton.Name = "backChainButton";
            this.backChainButton.Size = new System.Drawing.Size(158, 28);
            this.backChainButton.TabIndex = 4;
            this.backChainButton.Text = "Backward chaining";
            this.backChainButton.UseVisualStyleBackColor = true;
            this.backChainButton.Click += new System.EventHandler(this.backwards_chaining_click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(871, 194);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(158, 28);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Clear_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(930, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 22);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rules_listbox);
            this.groupBox2.Location = new System.Drawing.Point(305, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(755, 384);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rules";
            // 
            // rules_listbox
            // 
            this.rules_listbox.FormattingEnabled = true;
            this.rules_listbox.HorizontalScrollbar = true;
            this.rules_listbox.ItemHeight = 16;
            this.rules_listbox.Location = new System.Drawing.Point(8, 19);
            this.rules_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.rules_listbox.Name = "rules_listbox";
            this.rules_listbox.Size = new System.Drawing.Size(740, 356);
            this.rules_listbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1066, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production System";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox result_facts_listbox;
        private System.Windows.Forms.ListBox true_facts_listbox;
        private System.Windows.Forms.ListBox facts_listbox;
        private System.Windows.Forms.ListBox rules_listbox;
        private System.Windows.Forms.Button knBaseButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button forChainButton;
        private System.Windows.Forms.Button backChainButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox used_rules_listbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

