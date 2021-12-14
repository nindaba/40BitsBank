using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    internal static class Utils
    {
        public static MainForm mainForm = new MainForm();
        public static void displayMenu()
        {
            display(new BankManagement());
        }
        public static  void display(Form form)
        {
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            mainForm.Controls.Clear();
            mainForm.Controls.Add(form);
        }
        public static void selectPicture(PictureBox picture)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                picture.ImageLocation = openFileDialog.FileName;
                FileStream fileStream = new FileStream(picture.ImageLocation.ToString(), FileMode.Open, FileAccess.Read);
                FileStream resource = new FileStream($"images/{Guid.NewGuid()}.jpeg", FileMode.OpenOrCreate);
                fileStream.CopyTo(resource);
                fileStream.Close();
                resource.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
