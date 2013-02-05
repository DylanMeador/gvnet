namespace SampleProject
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
			this.txtNode = new System.Windows.Forms.TextBox();
			this.btnAddNode = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEdge = new System.Windows.Forms.Button();
			this.btnGraph = new System.Windows.Forms.Button();
			this.txtEdge = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtNode
			// 
			this.txtNode.Location = new System.Drawing.Point(13, 13);
			this.txtNode.Name = "txtNode";
			this.txtNode.Size = new System.Drawing.Size(170, 20);
			this.txtNode.TabIndex = 0;
			// 
			// btnAddNode
			// 
			this.btnAddNode.Location = new System.Drawing.Point(197, 10);
			this.btnAddNode.Name = "btnAddNode";
			this.btnAddNode.Size = new System.Drawing.Size(75, 23);
			this.btnAddNode.TabIndex = 1;
			this.btnAddNode.Text = "Add Node";
			this.btnAddNode.UseVisualStyleBackColor = true;
			this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 72);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(171, 199);
			this.listBox1.TabIndex = 2;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(12, 293);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(171, 199);
			this.listBox2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 274);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tail Node";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Head Node";
			// 
			// btnEdge
			// 
			this.btnEdge.Location = new System.Drawing.Point(287, 264);
			this.btnEdge.Name = "btnEdge";
			this.btnEdge.Size = new System.Drawing.Size(75, 23);
			this.btnEdge.TabIndex = 1;
			this.btnEdge.Text = "Add Edge";
			this.btnEdge.UseVisualStyleBackColor = true;
			this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
			// 
			// btnGraph
			// 
			this.btnGraph.Location = new System.Drawing.Point(287, 469);
			this.btnGraph.Name = "btnGraph";
			this.btnGraph.Size = new System.Drawing.Size(75, 23);
			this.btnGraph.TabIndex = 1;
			this.btnGraph.Text = "Build Graph";
			this.btnGraph.UseVisualStyleBackColor = true;
			this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
			// 
			// txtEdge
			// 
			this.txtEdge.Location = new System.Drawing.Point(197, 238);
			this.txtEdge.Name = "txtEdge";
			this.txtEdge.Size = new System.Drawing.Size(170, 20);
			this.txtEdge.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 504);
			this.Controls.Add(this.txtEdge);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnGraph);
			this.Controls.Add(this.btnEdge);
			this.Controls.Add(this.btnAddNode);
			this.Controls.Add(this.txtNode);
			this.Name = "Form1";
			this.Text = "Test Project";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNode;
		private System.Windows.Forms.Button btnAddNode;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEdge;
		private System.Windows.Forms.Button btnGraph;
		private System.Windows.Forms.TextBox txtEdge;
	}
}

