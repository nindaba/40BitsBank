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
        //public static List<string> CUSTOMER_IDS = new List<string>();       
        //public static List<string> ACCOUNT_NUMBERS = new List<string>();


        public static void displayMenu()
        {
            display(new BankManagement());
            Database.loadCustomers();
            Database.loadSaff();
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
                string profileUpdateName = $"images/{Guid.NewGuid()}.jpeg";
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                FileStream resource = new FileStream(profileUpdateName, FileMode.OpenOrCreate);
                fileStream.CopyTo(resource);
                fileStream.Close();
                resource.Close();
                picture.ImageLocation = profileUpdateName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string fourRandom()
        {
            Random random = new Random();
            string value = "";
            for(int i = 0; i < 4; i++)
            {
                value += random.Next(0,9);
            }
            return value+" ";
        }
        public static bool contactValidator(string contact)
        {
            char start = contact.Length > 0 ? Char.Parse(contact.Substring(0,1)) : '\0';
            return
                contact.Equals("") ||
                contact.Trim('+').ToList().Find(chr => chr > '9' || chr < '0').Equals('\0') &&
                start == '+' || start <= '9' && start >= '0';
        }
        //public static string generateAccountNumber()
        //{
        //    string value = "";
        //    for (int i = 0; i < 4; i++)
        //    {
        //        value += Utils.fourRandom();
        //    }
        //    if (!ACCOUNT_NUMBERS.Contains(value))
        //    {
        //       ACCOUNT_NUMBERS.Add(value);
        //        return value;
        //    };
        //    return generateAccountNumber();
        //}

        //public static string generateId()
        //{
        //    string value =(char) new Random().Next(65, 70)+"-"+Utils.fourRandom();
        //    if (!CUSTOMER_IDS.Contains(value))
        //    {
        //        CUSTOMER_IDS.Add(value);
        //        return value;
        //    };
        //    return generateId();
        //}

    }
}
