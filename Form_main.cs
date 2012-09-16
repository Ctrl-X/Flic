using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace LineCodeCounter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form_main : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label Lbl_Titre;
		private System.Windows.Forms.StatusBar statusBar_main;
		private System.Windows.Forms.MainMenu mainMenu_main;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.GroupBox Grp_directory;
		private LineCodeCounter.UC_BrowseFile uC_Directory;
		private System.Windows.Forms.GroupBox Grp_Filter;
		private System.Windows.Forms.ListBox List_Filter;
		private System.Windows.Forms.Button BTn_AddFilter;
		private System.Windows.Forms.Button Btn_DeleteFilter;
		private System.Windows.Forms.TextBox Txt_Filter;
		private System.Windows.Forms.GroupBox Grp_Resultat;
		private System.Windows.Forms.ListBox List_Resultat;
		private System.Windows.Forms.Label Lbl_ListeFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Lbl_TotalLigne;
		private System.Windows.Forms.Label Lbl_NbrFichier;
		private System.Windows.Forms.Label Lbl_1;
		private System.Windows.Forms.Label Lbl_MoyenneFichier;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Btn_Start;
		private System.Windows.Forms.CheckBox Chk_AllFile;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Timer timer_comptage;

		private ArrayList m_FileList = null;
		private Int32 m_currentIndex = 0;
		private Double m_TotalLine = 0;
		private System.Windows.Forms.ProgressBar Progress_FileCount;
		private Int32 m_NbrFile =0;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Btn_Cancel;
		private Boolean isAlreadyCounting = false;


		public Form_main()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_main));
			this.Grp_directory = new System.Windows.Forms.GroupBox();
			this.uC_Directory = new LineCodeCounter.UC_BrowseFile();
			this.Lbl_Titre = new System.Windows.Forms.Label();
			this.statusBar_main = new System.Windows.Forms.StatusBar();
			this.mainMenu_main = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.Grp_Filter = new System.Windows.Forms.GroupBox();
			this.Chk_AllFile = new System.Windows.Forms.CheckBox();
			this.Txt_Filter = new System.Windows.Forms.TextBox();
			this.Btn_DeleteFilter = new System.Windows.Forms.Button();
			this.BTn_AddFilter = new System.Windows.Forms.Button();
			this.List_Filter = new System.Windows.Forms.ListBox();
			this.Grp_Resultat = new System.Windows.Forms.GroupBox();
			this.List_Resultat = new System.Windows.Forms.ListBox();
			this.Progress_FileCount = new System.Windows.Forms.ProgressBar();
			this.Btn_Start = new System.Windows.Forms.Button();
			this.Lbl_MoyenneFichier = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Lbl_NbrFichier = new System.Windows.Forms.Label();
			this.Lbl_1 = new System.Windows.Forms.Label();
			this.Lbl_TotalLigne = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Lbl_ListeFile = new System.Windows.Forms.Label();
			this.timer_comptage = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.Grp_directory.SuspendLayout();
			this.Grp_Filter.SuspendLayout();
			this.Grp_Resultat.SuspendLayout();
			this.SuspendLayout();
			// 
			// Grp_directory
			// 
			this.Grp_directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Grp_directory.Controls.Add(this.uC_Directory);
			this.Grp_directory.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Grp_directory.Location = new System.Drawing.Point(8, 24);
			this.Grp_directory.Name = "Grp_directory";
			this.Grp_directory.Size = new System.Drawing.Size(472, 48);
			this.Grp_directory.TabIndex = 0;
			this.Grp_directory.TabStop = false;
			this.Grp_directory.Text = "Repertoire à evaluer : ";
			// 
			// uC_Directory
			// 
			this.uC_Directory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uC_Directory.FolderPath = "";
			this.uC_Directory.Intitule = "";
			this.uC_Directory.Location = new System.Drawing.Point(3, 16);
			this.uC_Directory.Name = "uC_Directory";
			this.uC_Directory.Size = new System.Drawing.Size(466, 20);
			this.uC_Directory.TabIndex = 0;
			// 
			// Lbl_Titre
			// 
			this.Lbl_Titre.Cursor = System.Windows.Forms.Cursors.Default;
			this.Lbl_Titre.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Lbl_Titre.Location = new System.Drawing.Point(40, 0);
			this.Lbl_Titre.Name = "Lbl_Titre";
			this.Lbl_Titre.Size = new System.Drawing.Size(304, 24);
			this.Lbl_Titre.TabIndex = 1;
			this.Lbl_Titre.Text = "Utilitaire pour compter le nombre de lignes dans des fichiers.";
			this.Lbl_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// statusBar_main
			// 
			this.statusBar_main.Location = new System.Drawing.Point(0, 539);
			this.statusBar_main.Name = "statusBar_main";
			this.statusBar_main.Size = new System.Drawing.Size(488, 22);
			this.statusBar_main.TabIndex = 2;
			this.statusBar_main.Text = "Pret.";
			// 
			// mainMenu_main
			// 
			this.mainMenu_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "Fichier";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Quitter";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// Grp_Filter
			// 
			this.Grp_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Grp_Filter.Controls.Add(this.Chk_AllFile);
			this.Grp_Filter.Controls.Add(this.Txt_Filter);
			this.Grp_Filter.Controls.Add(this.Btn_DeleteFilter);
			this.Grp_Filter.Controls.Add(this.BTn_AddFilter);
			this.Grp_Filter.Controls.Add(this.List_Filter);
			this.Grp_Filter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Grp_Filter.Location = new System.Drawing.Point(8, 72);
			this.Grp_Filter.Name = "Grp_Filter";
			this.Grp_Filter.Size = new System.Drawing.Size(472, 112);
			this.Grp_Filter.TabIndex = 3;
			this.Grp_Filter.TabStop = false;
			this.Grp_Filter.Text = "Filtre des fichiers";
			// 
			// Chk_AllFile
			// 
			this.Chk_AllFile.Location = new System.Drawing.Point(8, 88);
			this.Chk_AllFile.Name = "Chk_AllFile";
			this.Chk_AllFile.TabIndex = 4;
			this.Chk_AllFile.Text = "Tout les fichiers";
			this.Chk_AllFile.CheckedChanged += new System.EventHandler(this.Chk_AllFile_CheckedChanged);
			// 
			// Txt_Filter
			// 
			this.Txt_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_Filter.Location = new System.Drawing.Point(232, 16);
			this.Txt_Filter.Name = "Txt_Filter";
			this.Txt_Filter.Size = new System.Drawing.Size(232, 20);
			this.Txt_Filter.TabIndex = 3;
			this.Txt_Filter.Text = "Tapez ici votre filtre ex :  .txt";
			this.Txt_Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Filter_KeyPress);
			this.Txt_Filter.Leave += new System.EventHandler(this.Txt_Filter_Leave);
			this.Txt_Filter.Enter += new System.EventHandler(this.Txt_Filter_Enter);
			// 
			// Btn_DeleteFilter
			// 
			this.Btn_DeleteFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_DeleteFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Btn_DeleteFilter.Location = new System.Drawing.Point(232, 80);
			this.Btn_DeleteFilter.Name = "Btn_DeleteFilter";
			this.Btn_DeleteFilter.Size = new System.Drawing.Size(232, 24);
			this.Btn_DeleteFilter.TabIndex = 2;
			this.Btn_DeleteFilter.Text = "Supprimer";
			this.Btn_DeleteFilter.Click += new System.EventHandler(this.Btn_DeleteFilter_Click);
			// 
			// BTn_AddFilter
			// 
			this.BTn_AddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.BTn_AddFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BTn_AddFilter.Location = new System.Drawing.Point(232, 48);
			this.BTn_AddFilter.Name = "BTn_AddFilter";
			this.BTn_AddFilter.Size = new System.Drawing.Size(232, 24);
			this.BTn_AddFilter.TabIndex = 1;
			this.BTn_AddFilter.Text = "Ajouter";
			this.BTn_AddFilter.Click += new System.EventHandler(this.BTn_AddFilter_Click);
			// 
			// List_Filter
			// 
			this.List_Filter.Location = new System.Drawing.Point(8, 16);
			this.List_Filter.Name = "List_Filter";
			this.List_Filter.Size = new System.Drawing.Size(208, 69);
			this.List_Filter.TabIndex = 0;
			// 
			// Grp_Resultat
			// 
			this.Grp_Resultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Grp_Resultat.Controls.Add(this.Btn_Cancel);
			this.Grp_Resultat.Controls.Add(this.List_Resultat);
			this.Grp_Resultat.Controls.Add(this.Progress_FileCount);
			this.Grp_Resultat.Controls.Add(this.Btn_Start);
			this.Grp_Resultat.Controls.Add(this.Lbl_MoyenneFichier);
			this.Grp_Resultat.Controls.Add(this.label3);
			this.Grp_Resultat.Controls.Add(this.Lbl_NbrFichier);
			this.Grp_Resultat.Controls.Add(this.Lbl_1);
			this.Grp_Resultat.Controls.Add(this.Lbl_TotalLigne);
			this.Grp_Resultat.Controls.Add(this.label1);
			this.Grp_Resultat.Controls.Add(this.Lbl_ListeFile);
			this.Grp_Resultat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Grp_Resultat.Location = new System.Drawing.Point(8, 184);
			this.Grp_Resultat.Name = "Grp_Resultat";
			this.Grp_Resultat.Size = new System.Drawing.Size(472, 352);
			this.Grp_Resultat.TabIndex = 4;
			this.Grp_Resultat.TabStop = false;
			this.Grp_Resultat.Text = "Résultat";
			// 
			// List_Resultat
			// 
			this.List_Resultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.List_Resultat.Location = new System.Drawing.Point(8, 32);
			this.List_Resultat.Name = "List_Resultat";
			this.List_Resultat.Size = new System.Drawing.Size(456, 186);
			this.List_Resultat.TabIndex = 0;
			// 
			// Progress_FileCount
			// 
			this.Progress_FileCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Progress_FileCount.Location = new System.Drawing.Point(16, 224);
			this.Progress_FileCount.Name = "Progress_FileCount";
			this.Progress_FileCount.Size = new System.Drawing.Size(448, 16);
			this.Progress_FileCount.Step = 1;
			this.Progress_FileCount.TabIndex = 9;
			// 
			// Btn_Start
			// 
			this.Btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Btn_Start.Location = new System.Drawing.Point(16, 240);
			this.Btn_Start.Name = "Btn_Start";
			this.Btn_Start.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Start.Size = new System.Drawing.Size(344, 32);
			this.Btn_Start.TabIndex = 8;
			this.Btn_Start.Text = "Compter !";
			this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
			// 
			// Lbl_MoyenneFichier
			// 
			this.Lbl_MoyenneFichier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_MoyenneFichier.AutoSize = true;
			this.Lbl_MoyenneFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Lbl_MoyenneFichier.Location = new System.Drawing.Point(272, 330);
			this.Lbl_MoyenneFichier.Name = "Lbl_MoyenneFichier";
			this.Lbl_MoyenneFichier.Size = new System.Drawing.Size(13, 18);
			this.Lbl_MoyenneFichier.TabIndex = 7;
			this.Lbl_MoyenneFichier.Text = "0";
			this.Lbl_MoyenneFichier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(56, 328);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Nombre de ligne moyen par fichier : ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Lbl_NbrFichier
			// 
			this.Lbl_NbrFichier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_NbrFichier.AutoSize = true;
			this.Lbl_NbrFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Lbl_NbrFichier.Location = new System.Drawing.Point(272, 306);
			this.Lbl_NbrFichier.Name = "Lbl_NbrFichier";
			this.Lbl_NbrFichier.Size = new System.Drawing.Size(13, 18);
			this.Lbl_NbrFichier.TabIndex = 5;
			this.Lbl_NbrFichier.Text = "0";
			this.Lbl_NbrFichier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Lbl_1
			// 
			this.Lbl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Lbl_1.Location = new System.Drawing.Point(56, 304);
			this.Lbl_1.Name = "Lbl_1";
			this.Lbl_1.Size = new System.Drawing.Size(216, 23);
			this.Lbl_1.TabIndex = 4;
			this.Lbl_1.Text = "Nombre de fichiers trouvés : ";
			this.Lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Lbl_TotalLigne
			// 
			this.Lbl_TotalLigne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_TotalLigne.AutoSize = true;
			this.Lbl_TotalLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Lbl_TotalLigne.Location = new System.Drawing.Point(272, 280);
			this.Lbl_TotalLigne.Name = "Lbl_TotalLigne";
			this.Lbl_TotalLigne.Size = new System.Drawing.Size(13, 18);
			this.Lbl_TotalLigne.TabIndex = 3;
			this.Lbl_TotalLigne.Text = "0";
			this.Lbl_TotalLigne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 277);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre total de lignes : ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Lbl_ListeFile
			// 
			this.Lbl_ListeFile.Location = new System.Drawing.Point(8, 16);
			this.Lbl_ListeFile.Name = "Lbl_ListeFile";
			this.Lbl_ListeFile.Size = new System.Drawing.Size(232, 23);
			this.Lbl_ListeFile.TabIndex = 1;
			this.Lbl_ListeFile.Text = "Liste des fichiers correspondant au critères :";
			// 
			// timer_comptage
			// 
			this.timer_comptage.Interval = 50;
			this.timer_comptage.Tick += new System.EventHandler(this.timer_comptage_Tick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(376, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Copyfree :)  by Lyju.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Btn_Cancel.Location = new System.Drawing.Point(368, 240);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Cancel.Size = new System.Drawing.Size(96, 32);
			this.Btn_Cancel.TabIndex = 10;
			this.Btn_Cancel.Text = "Annuler";
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// Form_main
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 561);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Grp_Resultat);
			this.Controls.Add(this.Grp_Filter);
			this.Controls.Add(this.statusBar_main);
			this.Controls.Add(this.Lbl_Titre);
			this.Controls.Add(this.Grp_directory);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu_main;
			this.Name = "Form_main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FLIC - File LIne Counter";
			this.Load += new System.EventHandler(this.Form_main_Load);
			this.Grp_directory.ResumeLayout(false);
			this.Grp_Filter.ResumeLayout(false);
			this.Grp_Resultat.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new Form_main());
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void BTn_AddFilter_Click(object sender, System.EventArgs e)
		{
			string theFilter = Txt_Filter.Text.Trim().Replace("*","").Replace(",","").Replace("?","").Replace("/","").Replace("\\","").Replace("%","").Replace("!","").Replace("#","");
			if(theFilter.Length == 0)
				MessageBox.Show("veuillez indiquer un filtre");
			else if(theFilter.Length > 4)
				if(DialogResult.Yes != MessageBox.Show("Votre filter ne semble pas etre une extension de fichier.\n Il doit ressembler à '.ext'.\n Voulez vous tout de meme l'ajouter ?","Attention", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning))
					return;

			//on ajoute l'extension
			if(!List_Filter.Items.Contains(theFilter))
				List_Filter.Items.Add(theFilter);

		}

		private void Btn_DeleteFilter_Click(object sender, System.EventArgs e)
		{
			if(List_Filter.SelectedIndex >=0)
				List_Filter.Items.RemoveAt(List_Filter.SelectedIndex);

			
		}

		private void Form_main_Load(object sender, System.EventArgs e)
		{
		
		}

		private void Txt_Filter_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Int32 theCode = (Int32) e.KeyChar;
			if(theCode == 13)
			{
				BTn_AddFilter_Click(null,null);
				Txt_Filter.Text = "";
			}
		}



		private void Chk_AllFile_CheckedChanged(object sender, System.EventArgs e)
		{
			if(Chk_AllFile.Checked)			
			{
				Txt_Filter.Enabled = false;
				BTn_AddFilter.Enabled = false;
				Btn_DeleteFilter.Enabled = false;
				List_Filter.Enabled = false;
			}
			else
			{
				Txt_Filter.Enabled = true;
				BTn_AddFilter.Enabled = true;
				Btn_DeleteFilter.Enabled = true;
				List_Filter.Enabled = true;
			}
		}

		private void Btn_Start_Click(object sender, System.EventArgs e)
		{

			//c'est bon, on y va !
			Myfunc_StartResearch();

		}

		public void Myfunc_StartResearch()
		{
			//on test voir si il y a ce qu'il faut pour rechercher
			if(!Directory.Exists(uC_Directory.FolderPath))
			{
				MessageBox.Show("veuillez choisir un repertoire qui existe");
				uC_Directory.MyFunc_BrowseDirectory();
				return;
			}
			if((!Chk_AllFile.Checked) && (List_Filter.Items.Count == 0))
			{
				MessageBox.Show("veuillez preciser des filtre a utiliser");
				Txt_Filter.Focus();
				return;
			}

			statusBar_main.Text = "Comptage en cours";

			#region on lance la recherche des fichiers
			if(m_FileList== null)
				m_FileList = new ArrayList();
			else
				m_FileList.Clear();

			List_Resultat.Items.Clear();
			MyFunc_GetFileInDirectory(uC_Directory.FolderPath, m_FileList);
			m_currentIndex = 0;
			m_TotalLine = 0;
			m_NbrFile = m_FileList.Count;
			Progress_FileCount.Maximum = m_NbrFile;
			#endregion

			Btn_Start.Enabled = false;
			isAlreadyCounting = false;
			timer_comptage.Start();


		}
		private void MyFunc_GetFileInDirectory(string theDirectory, ArrayList theFullList)
		{
			if(theFullList == null)
				theFullList = new ArrayList();

			string [] thefileNameList = null;
			if(Chk_AllFile.Checked)
			{
				thefileNameList = Directory.GetFiles(theDirectory);
				foreach(string thefile in thefileNameList)
					theFullList.Add(thefile);
			}
			else
			{
				foreach(string theFilter in List_Filter.Items)
				{
					thefileNameList = Directory.GetFiles(theDirectory,"*" + theFilter);
					foreach(string thefile in thefileNameList)
						theFullList.Add(thefile);
				}
			}

			//on parcourt tout les sous repertoire pour 
			string [] theSubDirectoryList = Directory.GetDirectories(theDirectory);
			foreach(string theDirectoryName in theSubDirectoryList)
				MyFunc_GetFileInDirectory(theDirectoryName,theFullList);


			
		}


		private Double Myfunc_CountLineOfFile(string theFileName)
		{
			Double theLineCount = 0;
			try
			{
				StreamReader sr = File.OpenText(theFileName);
				String input;
				while ((input=sr.ReadLine())!=null) 
				{
					if(input.Trim() != "")
						theLineCount++;
				}
				sr.Close();

			}
			catch(Exception ex)
			{
				Console.WriteLine("erreur : " + ex.Message);
			}

			return theLineCount;
		}

		private void timer_comptage_Tick(object sender, System.EventArgs e)
		{
			if(!isAlreadyCounting)
			{
				isAlreadyCounting = true;

				//on calcul chaque fichier dans la liste
				if(m_currentIndex >= m_FileList.Count)
				{
					timer_comptage.Stop();
					if(m_NbrFile == 0)
						List_Resultat.Items.Add("Aucun fichier ne correspond au critere");				

					statusBar_main.Text = "Fin du comptage !";
					Btn_Start.Enabled = true;
				}
				else
				{
					#region on traite le fichier en cours


					string theFilename = m_FileList[m_currentIndex].ToString();
					Double theFileLineCount = Myfunc_CountLineOfFile(theFilename); 
					m_TotalLine += theFileLineCount;

					try
					{
						m_currentIndex++;
						//on inscrit une ligne dans le log des fichiers
						theFilename = theFilename.Replace(uC_Directory.FolderPath,"..");
						List_Resultat.Items.Add(theFilename + " - ( " + theFileLineCount + " lignes )" );
						Progress_FileCount.Value = m_currentIndex;
					}
					catch{}
					#endregion
				}

				//on rafraichit
				Lbl_TotalLigne.Text = m_TotalLine.ToString();
				Lbl_NbrFichier.Text = m_NbrFile.ToString();
				if(m_NbrFile > 0)
					Lbl_MoyenneFichier.Text = (m_TotalLine / m_NbrFile).ToString();
				
				isAlreadyCounting = false;

			}

		}

		private void Txt_Filter_Enter(object sender, System.EventArgs e)
		{
			Txt_Filter.Text = "";
		}

		private void Txt_Filter_Leave(object sender, System.EventArgs e)
		{
			if(Txt_Filter.Text.Trim() =="")
				Txt_Filter.Text = "Tapez ici votre filtre ex : .txt";
		}

		private void Btn_Cancel_Click(object sender, System.EventArgs e)
		{
			if(timer_comptage.Enabled)
			{
				timer_comptage.Stop();
				statusBar_main.Text = "Comptage annulé !";
			}
		
		}
	}
}
