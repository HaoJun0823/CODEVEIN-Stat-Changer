using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CODEVEINStatChanger
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private HexHelper helper;

        

        private void Button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open uasset:";
            ofd.Filter = "Unreal Assets (*.uasset)|*.uasset";

            ofd.RestoreDirectory = true;


            if (ofd.ShowDialog() == DialogResult.OK)
            {

                System.Console.WriteLine("Open File:{0}", ofd.FileName);



                try
                {
                    Config.LoadCurrentFileByte(ofd.FileName);
                    Config.OpenPath = Path.GetDirectoryName(ofd.FileName);
                    Label_Path.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                    MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    helper = new HexHelper(Config.FileByte);

                    CreateItem();
                    

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

            if (Config.OpenPath.Length <= 0)
            {

                MessageBox.Show("Open uasset firstly please!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;
            }


            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save uasset:";
            sfd.Filter = "Unreal Assets (*.uasset)|*.uasset";

            if (Config.OpenPath.Length > 0)
            {
                sfd.InitialDirectory = Config.OpenPath;
            }


            if (sfd.ShowDialog() == DialogResult.OK)
            {

                System.Console.WriteLine("Save File:{0}", sfd.FileName); 
                try
                {
                    Config.FileByte = helper.SaveIndex();
                    Config.SaveCurrentFileByte(sfd.FileName);
                    MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

                



                

            }


        }

        private void CreateItem()
        {


           for(int x = FlowLayoutPanel_Main.Controls.Count-1; x >=0; x--)
            {

                FlowLayoutPanel_Main.Controls.RemoveAt(x);


            }



            foreach (var d in helper.DataOffsets)
            {
                System.Console.WriteLine("Index:{0:x},Type:{1}", d.Index, d.Type);
            }

            int i = 0;
            foreach(var item in helper.DataOffsets)
            {

                Label label = new Label();
                label.Text = "ECharacterAttributeRank::" + item.Type;
                label.Width = 200;

                FlowLayoutPanel_Main.Controls.Add(label);

                ComboBox combo = new ComboBox();

                Dictionary<String, int> dictionary  = new Dictionary<string, int>();
                

                if (item.Type.Length == 1)
                {

                    dictionary.Add("S", i);
                    dictionary.Add("A", i);
                    dictionary.Add("B", i);
                    dictionary.Add("C", i);
                    dictionary.Add("D", i);
                    dictionary.Add("E", i);
                }
                else
                {
                    dictionary.Add("S_Plus", i);
                    dictionary.Add("A_Plus", i);
                    dictionary.Add("B_Plus", i);
                    dictionary.Add("C_Plus", i);
                    dictionary.Add("D_Plus", i);
                    dictionary.Add("E_Plus", i);
                }

                BindingSource bs = new BindingSource();

                bs.DataSource = dictionary;

                combo.DataSource = bs;

                combo.ValueMember = "Value";
                combo.DisplayMember = "Key";


                combo.Width = 200;

                FlowLayoutPanel_Main.Controls.Add(combo);

                for (int ii = 0; ii < dictionary.Count; ii++)
                {

                    combo.SelectedIndex = ii;

                    var kv = (KeyValuePair<String, int>)combo.SelectedItem;

                    //System.Console.WriteLine("Try Selected Index:{0:x},Item:{1}", combo.SelectedIndex, kv.Key);

                    if (kv.Key.Equals(item.Type))
                    {
                        break;
                    }


                }






                combo.SelectedIndexChanged += new EventHandler(delegate
                {

                    System.Console.WriteLine("Selected Index:{0:x},Item:{1}", combo.SelectedIndex, combo.SelectedItem.ToString());

                    var kv = (KeyValuePair<String, int>)combo.SelectedItem;

                    HexHelper.DataOffset doffset =  helper.DataOffsets[kv.Value];

                    doffset.Type = kv.Key;

                    helper.DataOffsets[kv.Value] = doffset;



                    foreach (var d in helper.DataOffsets)
                    {
                        System.Console.WriteLine("Index:{0:x},Type:{1}",d.Index,d.Type);
                    }

                });
                {

                }
                i++;

            }

        }


        private static readonly String ABOUT_TEXT = @"
Code By HaoJun0823
Mido Photo By Inanko

Follow MIT License

Github:https://github.com/HaoJun0823/CODEVEIN-Stat-Changer
Guide:https://github.com/HaoJun0823/CODEVEIN-Mod-Guide/wiki/Modify-Stat

Author's note: Love my son Okami Yuuki forever!

";


        private void Button_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ABOUT_TEXT,"About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
