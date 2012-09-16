using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace LineCodeCounter
{
	/// <summary>
	/// Summary description for UC_BrowseFile.
	/// </summary>
	public class UC_BrowseFile : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Button Btn_Search;
		private System.Windows.Forms.ToolTip toolTip_info;
		private System.Windows.Forms.FolderBrowserDialog folderBrowser_DialogMain;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label Lbl_RepName;
		private System.Windows.Forms.TextBox Txt_Value;

		private string m_FolderPath = "";
		/// <summary>
		/// Repertoire a chercher
		/// </summary>
		public string FolderPath
		{
			get
			{
				return m_FolderPath;
			}
			set
			{
				if(m_FolderPath != value)
				{
					m_FolderPath = value;
					Txt_Value.Text = m_FolderPath;
					this.toolTip_info.SetToolTip(this.Txt_Value, m_FolderPath);
				}
			}
		}


		private string m_Intitule = "";
		public string Intitule
		{
			get
			{
				return m_Intitule;
			}
			set
			{
				if(m_Intitule != value)
				{
					m_Intitule = value;
					Lbl_RepName.Text = m_Intitule;
				}
			}
		}


		public UC_BrowseFile()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Btn_Search = new System.Windows.Forms.Button();
			this.toolTip_info = new System.Windows.Forms.ToolTip(this.components);
			this.Txt_Value = new System.Windows.Forms.TextBox();
			this.folderBrowser_DialogMain = new System.Windows.Forms.FolderBrowserDialog();
			this.Lbl_RepName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Search
			// 
			this.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
			this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Btn_Search.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Btn_Search.Location = new System.Drawing.Point(328, 0);
			this.Btn_Search.Name = "Btn_Search";
			this.Btn_Search.Size = new System.Drawing.Size(24, 20);
			this.Btn_Search.TabIndex = 1;
			this.Btn_Search.Text = "...";
			this.toolTip_info.SetToolTip(this.Btn_Search, "Parcourir...");
			this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
			// 
			// Txt_Value
			// 
			this.Txt_Value.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Txt_Value.Location = new System.Drawing.Point(66, 0);
			this.Txt_Value.Name = "Txt_Value";
			this.Txt_Value.Size = new System.Drawing.Size(262, 20);
			this.Txt_Value.TabIndex = 0;
			this.Txt_Value.Text = "";
			this.toolTip_info.SetToolTip(this.Txt_Value, "repertoire choisit");
			this.Txt_Value.TextChanged += new System.EventHandler(this.Txt_Value_TextChanged);
			// 
			// Lbl_RepName
			// 
			this.Lbl_RepName.AutoSize = true;
			this.Lbl_RepName.Dock = System.Windows.Forms.DockStyle.Left;
			this.Lbl_RepName.Location = new System.Drawing.Point(0, 0);
			this.Lbl_RepName.Name = "Lbl_RepName";
			this.Lbl_RepName.Size = new System.Drawing.Size(66, 16);
			this.Lbl_RepName.TabIndex = 2;
			this.Lbl_RepName.Text = "Repertoire : ";
			this.Lbl_RepName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UC_BrowseFile
			// 
			this.Controls.Add(this.Txt_Value);
			this.Controls.Add(this.Lbl_RepName);
			this.Controls.Add(this.Btn_Search);
			this.Name = "UC_BrowseFile";
			this.Size = new System.Drawing.Size(352, 20);
			this.Load += new System.EventHandler(this.UC_BrowseFile_Load);
			this.SizeChanged += new System.EventHandler(this.UC_BrowseFile_SizeChanged);
			this.ResumeLayout(false);

		}
		#endregion

		private void Btn_Search_Click(object sender, System.EventArgs e)
		{
				MyFunc_BrowseDirectory();
		}
		public void MyFunc_BrowseDirectory()
		{
			folderBrowser_DialogMain.SelectedPath = FolderPath;
			if(DialogResult.OK == folderBrowser_DialogMain.ShowDialog(this))
				FolderPath = folderBrowser_DialogMain.SelectedPath;

		}

		private void Txt_Value_TextChanged(object sender, System.EventArgs e)
		{
			FolderPath = Txt_Value.Text;
		}

		private void UC_BrowseFile_Load(object sender, System.EventArgs e)
		{
			this.Height = 20;
		}

		private void UC_BrowseFile_SizeChanged(object sender, System.EventArgs e)
		{
			this.Height = 20;
		}


	}
}
