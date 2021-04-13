using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;

namespace AniToolsCC
{
    public partial class Form1 : Form
    {
        private string folderPath;
        private string[] files;
        private string[] OnlyFileNames;
        public Form1()
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            folderPath = null;
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            //OpenFileDialog folderBrowser = new OpenFileDialog();
            //// Set validate names and check file exists to false otherwise windows will
            //// not let you select "Folder Selection."
            //folderBrowser.ValidateNames = false;
            //folderBrowser.CheckFileExists = false;
            //folderBrowser.CheckPathExists = true;
            //// Always default to Folder Selection.
            //folderBrowser.FileName = "CARPETA";
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderDlg.SelectedPath;
                txtCarpeta.Text = folderPath.ToString();
                files = Directory.GetFiles(folderPath);
                OnlyFileNames = files;

                for (int i = 0; i < files.Count(); i++)
                {
                    OnlyFileNames[i] = Path.GetFileName(files[i]);
                }
                lbArchivos.DataSource = OnlyFileNames;
            }
        }

        private void btnTaN_Click(object sender, EventArgs e)
        {
            try
            {
                if(folderPath != null)
                {
                    if(files.Length != 0)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            string[] file = files[i].Split('.');
                            File.Move(folderPath + "/" + files[i], folderPath + "/" + (i + 1) + "." + file[1]);
                        }
                        lbResultado.Text = "Trabajo realizado";
                    }
                    else
                    {
                        lbResultado.Text = "La carpeta no contiene archivos";
                    }
                }
                else
                {
                    lbResultado.Text = "Selecciona una carpeta para comenzar";
                }
            }
            catch (Exception)
            {
                lbResultado.Text = "Ha ocurrido un error [CODE:B01]";
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string value = @"\D+";
            //String[] test = Regex.Split(OnlyFileNames[0], value);
            //MessageBox.Show(test[0].ToString());
            try
            {
                if (folderPath != null)
                {
                    if (files.Length != 0)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            string[] file = files[i].Split('.');
                            string value = @"\D+";
                            String[] test = Regex.Split(OnlyFileNames[i], value);
                            File.Move(folderPath + "/" + files[i], folderPath + "/" + (test[1]) + "." + file[1]);
                        }
                        lbResultado.Text = "Trabajo realizado";
                    }
                    else
                    {
                        lbResultado.Text = "La carpeta no contiene archivos";
                    }
                }
                else
                {
                    lbResultado.Text = "Selecciona una carpeta para comenzar";
                }
            }
            catch (Exception)
            {
                lbResultado.Text = "Ha ocurrido un error [CODE:B02]";
                throw;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "";
            lbArchivos.DataSource = null;
            folderPath = null;
            txtCarpeta.Text = "";
            files = new string[0];
        }
    }
}
