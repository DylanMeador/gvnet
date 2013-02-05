using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GVNET;

namespace SampleProject
{
	public partial class Form1 : Form
	{
		private SampleGraph myGraph = new SampleGraph("Test Graph");

		public Form1()
		{
			InitializeComponent();
		}

		private void btnAddNode_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtNode.Text.Trim()))
			{
				SampleNode newNode = new SampleNode(txtNode.Text); 
				myGraph.AddNode(newNode);
				listBox1.Items.Add(newNode);
				listBox2.Items.Add(newNode);
			}
		}

		private void btnEdge_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null || listBox2.SelectedItem == null)
				return;

			if (listBox1.SelectedItem != listBox2.SelectedItem && !string.IsNullOrEmpty(txtEdge.Text.Trim()))
			{
				SampleEdge newEdge = new SampleEdge(txtEdge.Text, (SampleNode)listBox1.SelectedItem, (SampleNode)listBox2.SelectedItem);
				myGraph.AddEdge(newEdge);
			}
		}

		private void btnGraph_Click(object sender, EventArgs e)
		{
			GraphManager.SaveGraph(myGraph, @".\");
		}
	}
}
