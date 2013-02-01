using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GVNET;

namespace TestProject
{
	public partial class Form1 : Form
	{
		private TestGraph myGraph = new TestGraph("Test Graph");

		public Form1()
		{
			InitializeComponent();
		}

		private void btnAddNode_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtNode.Text))
			{
				TestNode newNode = new TestNode(txtNode.Text); 
				myGraph.AddNode(newNode);
				listBox1.Items.Add(newNode);
				listBox2.Items.Add(newNode);
			}
		}

		private void btnEdge_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null || listBox2.SelectedItem == null)
				return;

			if (listBox1.SelectedItem != listBox2.SelectedItem && !string.IsNullOrWhiteSpace(txtEdge.Text))
			{
				TestEdge newEdge = new TestEdge(txtEdge.Text, (TestNode)listBox1.SelectedItem, (TestNode)listBox2.SelectedItem);
				myGraph.AddEdge(newEdge);
			}
		}

		private void btnGraph_Click(object sender, EventArgs e)
		{
			GraphManager.SaveGraph(myGraph, @".\");
		}
	}
}
