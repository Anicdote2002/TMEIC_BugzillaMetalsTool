//Name: Metals Tool.Designer.cs
//Author:
//Date:
//Modified:
/*----
 * Alexander Summerton - 11/14/2022 - Added token extraction to project creation function, depreciated XML Edit and Test Cookies event functions
 */




using System;
using System.Windows.Forms;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Web;
using System.Xml;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Security.Policy;
using HtmlAgilityPack;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApplication1
{


    public partial class Metals_tool : Form
    {
        List<object> comboBox_ItemsCopy = new List<object>();
        public Metals_tool()
        {
            InitializeComponent();
            checkedListBox_DriveComp.Enabled = false;
            checkedListBox_RequistComp.Enabled = false;
            checkBox_RequistComp.Enabled = false;
            checkBox_DriveComp.Enabled = false;
            

        }


        private void button4_Click(object sender, EventArgs e)
        {

            this.progressBar1.Value = 0;


            if (CreateProject())
            {
                if (MessageBox.Show("A new project has been created.\r\n\r\n Select yes to open a the new project in your browser and no to close this message", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@"https://tools.tmeic.com/metals/editproducts.cgi?action=edit&product=" + Encoder(textBox3.Text));
                }
            }
            else this.progressBar1.Value = 0;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (get_users_email())
            {
                MessageBox.Show("Email List has been updated successfully! Proceed?", "Succes!");
            }
        }

        private void comboBox_ProjMain_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {// Handle printable characters (letters, numbers, symbols, punctuation).             
                comboBox_get_emails(comboBox_ProjMan);
            }
            else if (string.IsNullOrEmpty(comboBox_ProjMan.Text))
            {//Hide the dropdown when there's no input.
                comboBox_clear_emails(comboBox_ProjMan);
            }
        }

        private void comboBox_System_Engineer_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {// Handle printable characters (letters, numbers, symbols, punctuation).             
                comboBox_get_emails(comboBox_SystemEngineer);
            }
            else if (string.IsNullOrEmpty(comboBox_SystemEngineer.Text))
            {//Hide the dropdown when there's no input.
                comboBox_clear_emails(comboBox_SystemEngineer);
            }
        }



        private void comboBox_Hardware_Engineer_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {// Handle printable characters (letters, numbers, symbols, punctuation).             
                comboBox_get_emails(comboBox_HardwareEngineer);
            }
            else if (string.IsNullOrEmpty(comboBox_HardwareEngineer.Text))
            {//Hide the dropdown when there's no input.
                comboBox_clear_emails(comboBox_HardwareEngineer);
            }
        }

        private void comboBox_ContEng_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {// Handle printable characters (letters, numbers, symbols, punctuation).             
                comboBox_get_emails(comboBox_ContEng);
            }
            else if (string.IsNullOrEmpty(comboBox_ContEng.Text))
            {//Hide the dropdown when there's no input.
                comboBox_clear_emails(comboBox_ContEng);
            }
        }

        private void comboBox_HMIEng_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {// Handle printable characters (letters, numbers, symbols, punctuation).             
                comboBox_get_emails(comboBox_HMIEng);
            }
            else if (string.IsNullOrEmpty(comboBox_HMIEng.Text))
            {//Hide the dropdown when there's no input.
                comboBox_clear_emails(comboBox_HMIEng);
            }
        }


        private void comboBox_AppEng_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {// Handle printable characters (letters, numbers, symbols, punctuation).             
                comboBox_get_emails(comboBox_AppEng);
            }
            else if (string.IsNullOrEmpty(comboBox_AppEng.Text))
            {//Hide the dropdown when there's no input.
                comboBox_clear_emails(comboBox_AppEng);
            }
        }

        private void comboBox_CompTech_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {// Handle printable characters (letters, numbers, symbols, punctuation).             
                comboBox_get_emails(comboBox_CompTech);
            }
            else if (string.IsNullOrEmpty(comboBox_CompTech.Text))
            {//Hide the dropdown when there's no input.
                comboBox_clear_emails(comboBox_CompTech);
            }
        }

        private void comboBox_DriveEng_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {// Handle printable characters (letters, numbers, symbols, punctuation).             
                comboBox_get_emails(comboBox_DriveEng);
            }
            else if (string.IsNullOrEmpty(comboBox_DriveEng.Text))
            {//Hide the dropdown when there's no input.
                comboBox_clear_emails(comboBox_DriveEng);
            }
        }


        private void comboBox_get_emails(System.Windows.Forms.ComboBox combobox)
        {

            List<object> autoComplete_suggestions = new List<object>();
            foreach (object item in comboBox_ItemsCopy)
            {// Filter items that start with the user's input (case-insensitive).               
                if (item.ToString().Contains(combobox.Text, StringComparison.OrdinalIgnoreCase))
                {
                    autoComplete_suggestions.Add(item);
                }
            }
            combobox.Items.Clear();
            combobox.Items.AddRange(autoComplete_suggestions.ToArray());
            combobox.SelectionStart = combobox.Text.Length; // Keep the user's input selected.
            combobox.DroppedDown = true; // Show the dropdown with autoComplete_suggestions

        }
        private void comboBox_clear_emails(System.Windows.Forms.ComboBox combobox)
        {
            combobox.Items.Clear();
            combobox.Items.AddRange(comboBox_ItemsCopy.ToArray());
        }


        private bool get_users_email()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string url = "https://tools.tmeic.com/metals/editusers.cgi?action=list&matchvalue=login_name&matchstr=&matchtype=substr&groupid=1&is_enabled=1";
            string loginToken;
            string email_cookies;
            string response;
            try
            {
                if (!username.Contains("@"))
                {
                    _ = MessageBox.Show("Make sure that the entered usernames and those in the ProjectEmail.xml file are of the form 'first.last@tmeic.com' or are correct", "Friendly reminder!");
                    return false;
                }
                username = username.Replace("@", "%40").ToLower();  // Replace @ with %40 and make sure it is lower case
                if (username == "" || password == "")
                {
                    _ = MessageBox.Show("Please fill out all the fields", "Friendly reminder!");
                    return false;
                }
                using (WebClient web = new WebClient())
                {
                    if (password == "")
                    {
                        _ = MessageBox.Show("You must enter your Bugzilla credentials to test the cookies.", "Error!");
                        return false;
                    }
                    try
                    {
                        try   //Load XML Document
                        {
                            System.Xml.XmlDocument DocTest = new System.Xml.XmlDocument();
                            DocTest.Load(@"ProjectEmail.xml");
                        }
                        catch
                        {
                            _ = MessageBox.Show("Please make sure that the ProjectEmail.xml file is located in the same file as this tool when it is run.", "Error");
                            return false;
                        }
                        System.Xml.XmlDocument Doc = new System.Xml.XmlDocument();
                        Doc.Load(@"ProjectEmail.xml");
                        XmlNode curNode = Doc.SelectSingleNode("Configuration/FieldEngineerManager");
                        curNode = Doc.SelectSingleNode("Configuration/Cookies");
                        if (curNode == null)
                        {
                            _ = MessageBox.Show("Problem with ProjectEmail.xml/Configuration/Cookies");
                            return false;
                        }
                        email_cookies = curNode.InnerText;
                        curNode = Doc.SelectSingleNode("Configuration/LoginToken");
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show("An exception was thrown while reading the ProjectEmail.xml. Please insure that it is in the same folder as the project creation utility. ", "Error!");
                        return false;
                    }
                    try
                    {
                        web.Headers.Add(HttpRequestHeader.Cookie, email_cookies);
                        CredentialCache credentialCache = new CredentialCache();
                        credentialCache.Add(new System.Uri(url), "Basic", new NetworkCredential(username, password, "tools.tmeic.com"));
                        try
                        {
                            web.Credentials = credentialCache;
                            web.BaseAddress = url;
                            string token_page = web.DownloadString(url);  //retrieve a login webpage as a string                          
                            string _buggzilla_login = "Bugzilla_login_token";
                            int position = 0;
                            for (int i = 0; i < token_page.Length; i++)//iterate through the string until finding the login token
                            {
                                bool done_flag = false; //flag to track if the vlaue is found and terminate the for loop
                                for (int j = 0; j < _buggzilla_login.Length; j++)
                                {//for every character, begin a substring search
                                    if (_buggzilla_login[j] != token_page[i + j])
                                    {//sequentially check each character against the phrase "Bugzilla_login_token", if there is a mis-match, break and start over from next character
                                        break;
                                    }
                                    else if (j == _buggzilla_login.Length - 1)
                                    {//if all cards match, position becomes i;
                                        position = i;
                                        done_flag = true; //set the finish flag to false
                                        break;
                                    }
                                }
                                if (done_flag) { break; }//if the token position was found, break and end the position finding loop.
                            }
                            string _value = "value"; //jump position to first instance of value after the token is found.
                            for (int i = position; i < token_page.Length; i++)//iterate through the string until finding the login token
                            {
                                bool done_flag = false; //flag to track if the value is found and terminate the for loop
                                for (int j = 0; j < _value.Length; j++)
                                {//for every character, begin a substring search
                                    if (_value[j] != token_page[i + j])
                                    {//sequentially check each character against the phrase "Bugzilla_login_token", if there is a mis-match, break and start from next character
                                        break;
                                    }
                                    else if (j == _value.Length - 1)
                                    {//if all cards match, position becomes i;
                                        position = i + j + 3; //set the position to four characters pasts the "e" in value, the first character of the login token
                                        done_flag = true;
                                        break;
                                    }
                                }
                                if (done_flag) { break; }//if the token position was found, break and end the position finding loop.
                            }
                            StringBuilder loginToken_temp = new StringBuilder();
                            while (token_page[position] != 34)
                            {
                                _ = loginToken_temp.Append(token_page[position]);
                                position++;
                            }
                            loginToken = loginToken_temp.ToString();
                            response = web.UploadString(url, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            if (response.Contains("<title>Untrusted Authentication Request</title>"))
                            {
                                _ = MessageBox.Show("Bugzilla returned the Untrusted Authentication Request page. The Cookies or Login Tokens are invalid", "Failed!");
                                return false;
                            }
                            else if (response.Contains("<title>Invalid Username Or Password</title>"))
                            {
                                _ = MessageBox.Show("Invalid Username Or Password.");
                                return false;
                            }
                            else if (response.Contains("<title>Authorization Required</title>"))
                            {
                                _ = MessageBox.Show("Authorization Required. You are not an Admin!");
                                return false;
                            }
                            else if (response.Contains("<title>Select user</title>"))
                            {
                                _ = MessageBox.Show("Select User Emails");
                                HtmlAgilityPack.HtmlDocument html_doc = new HtmlAgilityPack.HtmlDocument();
                                html_doc.LoadHtml(response);
                                HtmlAgilityPack.HtmlNodeCollection thNode = html_doc.DocumentNode.SelectNodes("//table[@id='admin_table']//td//a");
                                if (thNode != null)
                                {// Iterate through all child nodes of the <th> element
                                    foreach (HtmlNode childNode in thNode)
                                    { // Extract the content of child nodes (text or HTML)
                                        string elementContent = childNode.InnerHtml; // or .InnerText for plain text                                       
                                        if (elementContent.Contains("&#64;"))
                                        {
                                            elementContent = elementContent.Replace("&#64;", "@");
                                            comboBox_ItemsCopy.Add(elementContent);
                                           // email_list.Items.Add(elementContent);
                                        }
                                    }
                                }
                                return true;
                            }
                            else
                            {
                                _ = MessageBox.Show("Unexpected response");
                                return false;
                            }
                        }
                        catch
                        {
                            _ = MessageBox.Show("Exception thrown. Operation failed");
                            return false;
                        }
                    }
                    catch (Exception e)
                    {
                        _ = MessageBox.Show("Failed to complete!" + e, "Error");
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                _ = MessageBox.Show("Failed to complete! Check Bugzilla to see if any part of the project was created. \r\n\r\n Exception thrown: " + e, "Error!");
                return false;
            }
        }


        private bool CreateProject()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string projectname = textBox3.Text;
            string projectDescription = textBox7.Text;
         
            string projectManager = comboBox_ProjMan.Text;
            string System_Engineer = comboBox_SystemEngineer.Text;
            string Hardware_Engineer = comboBox_HardwareEngineer.Text;
            string Control_Engineer = comboBox_ContEng.Text;
            string HMI_Engineer = comboBox_HMIEng.Text;
            string AppEngineer = comboBox_AppEng.Text;
            string CompTech = comboBox_CompTech.Text;
            string DrvEngineer = comboBox_DriveEng.Text;


            string FE_Manager;
            string HW_Manager;
            string SW_Manager;
            string Crane_Dir_Owner;
            string Warranty_User;
            string MPR_Owner;
            string MaxviewRT_Owner;
            string VOIP_Owner;
            string SPLC_Owner;
            string Maxview_QC_Owner;

            string loginToken;
            string cookies;
            string urlAddProject = @"https://tools.tmeic.com/metals/editproducts.cgi?action=add&classification=Metals%20Projects";
            string urlAddProduct = @"https://tools.tmeic.com/metals/editcomponents.cgi?action=add&product=";
            string urlEditGroupControl = @"https://tools.tmeic.com/metals/editproducts.cgi?action=editgroupcontrols&product=";

            //Local Variables added by Alexander Summerotn 11-7-11
            //Mergiing of button2_click
            string response;
            string url = "https://tools.tmeic.com/metals/editproducts.cgi?action=add&classification=Metals%20Projects";

            
            
            //string xmlFilePath = "ProjectEmail.xml"; // Replace with your actual XML file path
            //// Get the full path of the XML file
            //string fullPath = Path.GetFullPath(xmlFilePath);

            //Console.WriteLine("Full path of the XML file: " + fullPath);

            //// Load the XML document
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(fullPath);

            //// Now you can perform operations on the XML document as needed
            //// ...

            //// Example: Print the XML content
            //Console.WriteLine("XML Content:");
            //Console.WriteLine(xmlDoc.OuterXml);



            if (password == "")
            {
                MessageBox.Show("You must enter your Bugzilla credentials to test the cookies.", "Error!");
                return false;
            }

            try
            {
                //Load XML Document
                try
                {
                    System.Xml.XmlDocument DocTest = new System.Xml.XmlDocument();
                    DocTest.Load(@"ProjectEmail.xml");
                }
                catch
                {
                    MessageBox.Show("Please make sure that the ProjectEmail.xml file is located in the same file as this tool when it is run.", "Error");
                    return false;
                }
                System.Xml.XmlDocument Doc = new System.Xml.XmlDocument();
                Doc.Load(@"ProjectEmail.xml");

                XmlNode curNode = Doc.SelectSingleNode("Configuration/FieldEngineerManager");
              
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/FieldEngineerManager");
                    return false;
                }
                FE_Manager = curNode.InnerText;
                Console.WriteLine(FE_Manager);

                curNode = Doc.SelectSingleNode("Configuration/HardwareManager");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/HardwareManager");
                    return false;
                }
                HW_Manager = curNode.InnerText;
                Console.WriteLine(HW_Manager);

                curNode = Doc.SelectSingleNode("Configuration/SoftwareManager");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/SoftwareManager");
                    return false;
                }
                SW_Manager = curNode.InnerText;
                Console.WriteLine(SW_Manager);

                curNode = Doc.SelectSingleNode("Configuration/CrainDirectorOwner");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/CrainDirectorOwner");
                    return false;
                }
                Crane_Dir_Owner = curNode.InnerText;
                Console.WriteLine(Crane_Dir_Owner);

                curNode = Doc.SelectSingleNode("Configuration/WarrantyUser");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/WarrantyUser");
                    return false;
                }
                Warranty_User = curNode.InnerText;
                Console.WriteLine(Warranty_User);

                curNode = Doc.SelectSingleNode("Configuration/MPROwner");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/MPROwner");
                    return false;
                }
                MPR_Owner = curNode.InnerText;
                Console.WriteLine(MPR_Owner);

                curNode = Doc.SelectSingleNode("Configuration/MaxViewRT");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/MaxViewRT");
                    return false;
                }
                MaxviewRT_Owner = curNode.InnerText;
                Console.WriteLine(MaxviewRT_Owner);

                curNode = Doc.SelectSingleNode("Configuration/VOIPOwner");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/VOIPOwner");
                    return false;
                }
                VOIP_Owner = curNode.InnerText;
                Console.WriteLine(VOIP_Owner);

                curNode = Doc.SelectSingleNode("Configuration/SPLCOwner");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/SPLCOwner");
                    return false;
                }
                SPLC_Owner = curNode.InnerText;
                Console.WriteLine(SPLC_Owner);

                curNode = Doc.SelectSingleNode("Configuration/MaxviewQCOwner");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/MaxviewQCOwner");
                    return false;
                }
                Maxview_QC_Owner = curNode.InnerText;
                Console.WriteLine(Maxview_QC_Owner);

                curNode = Doc.SelectSingleNode("Configuration/Cookies");
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/Cookies");
                    return false;
                }
                cookies = curNode.InnerText;
                Console.WriteLine(cookies);

                curNode = Doc.SelectSingleNode("Configuration/LoginToken");
                /*
                if (curNode == null)
                {
                    MessageBox.Show("Problem with ProjectEmail.xml/Configuration/LoginToken");
                    return false;
                }
                loginToken = curNode.InnerText;               
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception was thrown while reading the ProjectEmail.xml. Please ensure that it is in the same folder as the project creation utility. ", "Error!");
                return false;
            }

            try
            {

                // Encoding Project Name and Description
                projectname = Encoder(projectname);
                projectDescription = Encoder(projectDescription);

                // Checking username formate
                if (!username.Contains("@") || !projectManager.Contains("@") || !Hardware_Engineer.Contains("@") || !System_Engineer.Contains("@") || !AppEngineer.Contains("@") || !HMI_Engineer.Contains("@") || !FE_Manager.Contains("@") || !HW_Manager.Contains("@") || !SW_Manager.Contains("@") || !Crane_Dir_Owner.Contains("@") || !Warranty_User.Contains("@") || !MPR_Owner.Contains("@") || !MaxviewRT_Owner.Contains("@") || !VOIP_Owner.Contains("@") || !SPLC_Owner.Contains("@") || !Maxview_QC_Owner.Contains("@"))
                {
                    MessageBox.Show("Make sure that the entered usernames and those in the ProjectEmail.xml file are of the form 'first.last@tmeic.com' or are correct", "Friendly reminder!");
                    return false;
                }
                // Replace @ with %40 and make sure it is lower case
                username = username.Replace("@", "%40").ToLower();
                projectManager = projectManager.Replace("@", "%40").ToLower();
                Hardware_Engineer = Hardware_Engineer.Replace("@", "%40").ToLower();
                System_Engineer = System_Engineer.Replace("@", "%40").ToLower();
                AppEngineer = AppEngineer.Replace("@", "%40").ToLower();
                HMI_Engineer = HMI_Engineer.Replace("@", "%40").ToLower();
                Control_Engineer = Control_Engineer.Replace("@", "%40").ToLower();
                CompTech = CompTech.Replace("@", "%40").ToLower();
                DrvEngineer = DrvEngineer.Replace("@", "%40").ToLower();

                FE_Manager = FE_Manager.Replace("@", "%40").ToLower();
                HW_Manager = HW_Manager.Replace("@", "%40").ToLower();
                SW_Manager = SW_Manager.Replace("@", "%40").ToLower();
                Crane_Dir_Owner = Crane_Dir_Owner.Replace("@", "%40").ToLower();
                Warranty_User = Warranty_User.Replace("@", "%40").ToLower();
                MPR_Owner = MPR_Owner.Replace("@", "%40").ToLower();
                MaxviewRT_Owner = MaxviewRT_Owner.Replace("@", "%40").ToLower();
                VOIP_Owner = VOIP_Owner.Replace("@", "%40").ToLower();
                SPLC_Owner = SPLC_Owner.Replace("@", "%40").ToLower();
                Maxview_QC_Owner = Maxview_QC_Owner.Replace("@", "%40").ToLower();



                if (HMI_Engineer == "" || AppEngineer == "" || username == "" || password == "" || projectname == "" || projectManager == "" || DrvEngineer == "" || Hardware_Engineer == "" || System_Engineer == "" || Control_Engineer == "" || CompTech == "" || projectDescription == "")
                {  // do something
                    MessageBox.Show("Please fill out all the fields", "Friendly reminder!");
                    return false;
                }

                this.progressBar1.Increment(10);

                using (WebClient wb = new WebClient())
                {
                    string token;
                    string component;
                    string componentComment;
                    //string response;
                    string getToken;

                    try
                    {
                        // Create New project and Add first component:
                        // First component is General/Systems because every project type has it.


                        wb.Headers.Add(HttpRequestHeader.Cookie, cookies);
                        /*-----------------Coded Added by Alexander Summerton
                         * adapted from  button2_click to present function
                         * This code pulls a Bugzilla login page, extracts the login token from the login page, then uses it as the login for project creation
                         */
                        CredentialCache credentialCache = new CredentialCache();
                        credentialCache.Add(new System.Uri(url), "Basic", new NetworkCredential(username, password, "tools.tmeic.com"));

                        try
                        {
                            wb.Credentials = credentialCache;
                            wb.BaseAddress = url;

                            //retrieve a login webpage as a string
                            string token_page = wb.DownloadString(url);
                            string _buggzilla_login = "Bugzilla_login_token";
                            int position = 0;
                            for (int i = 0; i < token_page.Length; i++)//iterate through the string until finding the login token
                            {
                                bool done_flag = false; //flag to track if the vlaue is found and terminate the for loop
                                for (int j = 0; j < _buggzilla_login.Length; j++)
                                {//for every character, begin a substring search
                                    if (_buggzilla_login[j] != token_page[i + j])
                                    {//sequentially check each character against the phrase "Bugzilla_login_token", if there is a mis-match, break and start over from next character
                                        break;
                                    }
                                    else if (j == _buggzilla_login.Length - 1)
                                    {//if all cards match, position becomes i;
                                        position = i;
                                        done_flag = true; //set the finish flag to false
                                        break;
                                    }
                                }
                                if (done_flag) { break; }//if the token position was found, break and end the position finding loop.
                            }
                            //jump position to first instance of value after the token is found.
                            string _value = "value";
                            for (int i = position; i < token_page.Length; i++)//iterate through the string until finding the login token
                            {
                                bool done_flag = false; //flag to track if the vlaue is found and terminate the for loop
                                for (int j = 0; j < _value.Length; j++)
                                {//for every character, begin a substring search
                                    if (_value[j] != token_page[i + j])
                                    {//sequentially check each character against the phrase "Bugzilla_login_token", if there is a mis-match, break and start from next character
                                        break;
                                    }
                                    else if (j == _value.Length - 1)
                                    {//if all cards match, position becomes i;
                                        position = i + j + 3; //set the position to four cahracters pasts the "e" in value, the first character of the login token
                                        done_flag = true;
                                        break;
                                    }
                                }
                                if (done_flag) { break; }//if the token position was found, break and end the position finding loop.
                            }

                            StringBuilder loginToken_temp = new StringBuilder();

                            while (token_page[position] != 34)
                            {  //the page is returned with the token ending with " (quotation marks).  34 is ASCII code.  while that character is not hit, keep appending the login token to loginToken_temp
                                //a temp String_builder is used since strings are "immutable" in C#, that is, once set their value cannot be changed.
                                loginToken_temp.Append(token_page[position]);
                                position++;
                            }
                            loginToken = loginToken_temp.ToString(); // once the terminal character is found, set the login token to the extracted string

                            //attempt a Login-push.  If there is a mismatch, Dialogue box will appear and indicate failure and abort project creation.
                            //otherwise, login is successful and 
                            response = wb.UploadString(url, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");

                            if (response.Contains("<title>Add Product</title>")) { }
                            //    MessageBox.Show("Successfully sent command. Cookies and Tokens are still valid.", "Success! ");
                            else if (response.Contains("<title>Confirm Match</title>"))
                            {
                                MessageBox.Show("Failed to match entered engineer email. Please make sure each entry is correct. Check the ProjectEmail.xml as well.", "Error");
                                Console.WriteLine("Hey you failed at line 690");
                                return false;
                            }
                            else if (response.Contains("<title>Untrusted Authentication Request</title>"))
                            {
                                MessageBox.Show("Bugzilla returned the Untrusted Authentication Request page. The Cookies or Login Tokens are invalid", "Failed!");
                                return false;
                            }
                            else if (response.Contains("<title>Invalid Username Or Password</title>"))
                            {
                                MessageBox.Show("Invalid Username Or Password.");
                                return false;
                            }
                            else if (response.Contains("<title>Match Failed</title>"))
                            {
                                MessageBox.Show("Failed to match one or more of the input engineer emails. Please make sure each entry is correct. Check the ProjectEmail.xml as well.", "Error!");
                                Console.WriteLine("Hey you failed at line 706");
                                return false;
                            }
                            else if (response.Contains("<title>Authorization Required</title>"))
                            {
                                MessageBox.Show("Authorization Required. You are not an Admin!");
                                return false;
                            }
                            else
                            {
                                MessageBox.Show("Unexpected response. Unsure of success.  Ending Project Creation");
                                return false;
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Exception thrown. Operation failed");
                            return false;

                        }
                        /*----- End code added by Alexander Summerton-----*/

                        getToken = wb.UploadString(urlAddProject, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");


                       // Console.WriteLine(getToken);
                        if (getToken.Contains("<title>Invalid Username Or Password</title>"))
                        {
                            MessageBox.Show("Invalid Username Or Password.", "Warning!");
                            return false;
                        }
                        if (getToken.Contains("<title>Authorization Required</title>"))
                        {
                            MessageBox.Show("This utility requires Administrative rights.", "Authorization Required");
                            return false;
                        }
                        if (getToken.Contains("<title>Untrusted Authentication Request</title>"))
                        {
                            MessageBox.Show("Bugzilla returned the Untrusted Authentication Request page. Failed to create project.");
                            return false;
                        }
                        // Including all emails in the CC list to validate them before the project is created in Bugzilla
                        token = FindToken(getToken);
                        component = "General%2FSystems";
                        componentComment = "Other+System+or+multicomponent+issues";
                        response = wb.UploadString(urlAddProject, "POST", "Bugzilla_login="
                                                    + username + "&Bugzilla_password="
                                                    + password + "&Bugzilla_login_token="
                                                    + loginToken + "&product="
                                                    + projectname + "&description="
                                                    + projectDescription + "&is_active=1&allows_unconfirmed=on&version=unspecified&createseries=1&component="
                                                    + component + "&comp_desc="
                                                    + componentComment + "&initialowner="
                                                    + Control_Engineer + "&initialcc="
                                                    + CompTech + "%2C+"
                                                    + DrvEngineer + "%2C+"
                                                    + System_Engineer + "%2C+"
                                                    + Hardware_Engineer + "%2C+"
                                                    + projectManager + "%2C+"
                                                    + AppEngineer + "%2C+"
                                                    + HMI_Engineer + "%2C+"
                                                    + FE_Manager + "%2C+"
                                                    + HW_Manager + "%2C+"
                                                    + SW_Manager + "%2C+"
                                                    + Crane_Dir_Owner + "%2C+"
                                                    + Warranty_User + "%2C+"
                                                    + MPR_Owner + "%2C+"
                                                    + MaxviewRT_Owner + "%2C+"
                                                    + SPLC_Owner + "%2C+"
                                                    + Maxview_QC_Owner + "%2C+" + "&action=new&token="
                                                    + token + "&classification=Metals+Projects");

                        if (response.Contains("<title>Match Failed</title>"))
                        {
                            Console.WriteLine(response);
                            MessageBox.Show("Failed to match one or more of the input engineer emails. Please make sure each entry is correct. Check the ProjectEmail.xml as well.", "Error!");
                            Console.WriteLine("Match Failed");
                            return false;
                        }
                        if (response.Contains("<title>Confirm Match</title>"))
                        {
                            MessageBox.Show("Failed to match entered engineer email. Please make sure each entry is correct. Check the ProjectEmail.xml as well.", "Error");
                            Console.WriteLine("Confirm Match");
                            return false;
                        }
                        if (response.Contains("<title>Untrusted Authentication Request</title>"))
                        {
                            MessageBox.Show("Bugzilla returned the Untrusted Authentication Request page. Failed to create project.");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception thrown while creating project", "Error");
                        return false;
                    }
                    try
                    {
                        // Editing CC list for first component to remove some of the people added.  
                        component = "General%2FSystems";
                        componentComment = "Other+System+or+multicomponent+issues";
                        getToken = wb.UploadString("https://tools.tmeic.com/metals/editcomponents.cgi?action=edit&product=" + projectname + "&component=General%2FSystems", "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                        token = FindToken(getToken);
                        response = wb.UploadString("https://tools.tmeic.com/metals/editcomponents.cgi?action=edit&product=" + projectname + "&component=General%2FSystems", "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=General%2FSystems&description=Other+System+or+multicomponent+issues&initialowner=" + DrvEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + CompTech + "%2C+" + Hardware_Engineer + "%2C+" + AppEngineer + "%2C+" + HW_Manager + "%2C+" + SW_Manager + "%2C+" + projectManager + "%2C+" + FE_Manager + "&isactive=1&action=update&componentold=General%2FSystems&product=" + projectname + "&token=" + token);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception thrown while creating project", "Error");
                    }

                    // Begins the creation of all components common to any Metals project if this is not a Requisition Project
                    if ((radioButton_Yes.Checked == false) && (radio_No.Checked == true))
                    {

                       if (checkBox_DriveComp.Checked == true)
                        {
                            this.progressBar1.Increment(10);
                            // Add component: Hardware  ------------ Every project gets Hardware 
                            component = "General+Hardware";
                            componentComment = "General+hardware+related+issues+including+elementary+drawings,+panels,+Circuits,+etc.";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            if (getToken.Contains("<title>Product Access Denied</title>"))
                            {
                                MessageBox.Show("Something went wrong");
                                return false;
                            }
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + AppEngineer + "%2C+" + Hardware_Engineer + "%2C+" + HW_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Application Engineering 
                            component = "Application+Engineering";
                            componentComment = "General+Application+Related+Issues";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + AppEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);

                            // Add component: General Software 
                            component = "General+Software";
                            componentComment = "Anything+software+related+not+dealing+with+the+PLC+or+HMI+project";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: L1 Software 
                            component = "L1+Software";
                            componentComment = "General+L1+Software+Issues";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);

                            // Add component: L2 Software 
                            component = "L2+Software";
                            componentComment = "General+L2+Software+Issues";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Drive Hardware 
                            component = "Drive+Hardware";
                            componentComment = "Issues+related+to+Drive+Hardware";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + SW_Manager + "%2C+" + AppEngineer + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Drive Software 
                            component = "Drive+Software";
                            componentComment = "Issues+related+to+Drive+Software+files";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + DrvEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + HW_Manager + "%2C+" + SW_Manager + "%2C+" + AppEngineer + "%2C+" + projectManager + "&action=new&token=" + token);

                            // Add component: L1 HMI Project 
                            component = "L1+HMI+Project";
                            componentComment = "General+L1+HMI+project+related+issues+including+points,+alarms,+events,+scripts,+devices,+ports,+users,+roles,+resources,+database+logger,+documentation,+drawings+index,+and+HMI+config+files";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + HMI_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: L1 HMI Screens 
                            component = "L1+HMI+Screens";
                            componentComment = "General+L1+HMI+screens+related+issues";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + HMI_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: L2 HMI Project 
                            component = "L2+HMI+Project";
                            componentComment = "General+L2+HMI+project+related+issues+including+points,+alarms,+events,+scripts,+devices,+ports,+users,+roles,+resources,+database+logger,+documentation,+drawings+index,+and+HMI+config+files";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + HMI_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: L2 HMI Screens 
                            component = "L2+HMI+Screens";
                            componentComment = "General+L2+HMI+screens+related+issues";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + HMI_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Models 
                            component = "General+Models+Issues";
                            componentComment = "General+Mathematical+Models+related+issues";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + CompTech + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Elementaries 
                            component = "Elementaries";
                            componentComment = "General+issues+involving+elementary+drawings";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + AppEngineer + "%2C+" + HW_Manager + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);
                        }
                        else if (checkBox_DriveComp.Checked == false)
                        {
                            if(checkedListBox_DriveComp.GetItemChecked(0))
                            {
                                this.progressBar1.Increment(10);
                                // Add component: Hardware  ------------ Every project gets Hardware 
                                component = "General+Hardware";
                                componentComment = "General+hardware+related+issues+including+elementary+drawings,+panels,+Circuits,+etc.";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                if (getToken.Contains("<title>Product Access Denied</title>"))
                                {
                                    MessageBox.Show("Something went wrong");
                                    return false;
                                }
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + AppEngineer + "%2C+" + Hardware_Engineer + "%2C+" + HW_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                            if (checkedListBox_DriveComp.GetItemChecked(1))
                            {
                                // Add component: Application Engineering 
                                component = "Application+Engineering";
                                componentComment = "General+Application+Related+Issues";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + AppEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);

                            }
                            if (checkedListBox_DriveComp.GetItemChecked(2))
                            {
                                // Add component: General Software 
                                component = "General+Software";
                                componentComment = "Anything+software+related+not+dealing+with+the+PLC+or+HMI+project";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);

                            }
                            if (checkedListBox_DriveComp.GetItemChecked(3))
                            {
                                // Add component: L1 Software 
                                component = "L1+Software";
                                componentComment = "General+L1+Software+Issues";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);


                            }
                            if (checkedListBox_DriveComp.GetItemChecked(4))
                            {
                                // Add component: L2 Software 
                                component = "L2+Software";
                                componentComment = "General+L2+Software+Issues";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                            if (checkedListBox_DriveComp.GetItemChecked(5))
                            {

                                // Add component: Drive Hardware 
                                component = "Drive+Hardware";
                                componentComment = "Issues+related+to+Drive+Hardware";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + SW_Manager + "%2C+" + AppEngineer + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                            if (checkedListBox_DriveComp.GetItemChecked(6))
                            {
                                // Add component: Drive Software 
                                component = "Drive+Software";
                                componentComment = "Issues+related+to+Drive+Software+files";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + DrvEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + HW_Manager + "%2C+" + SW_Manager + "%2C+" + AppEngineer + "%2C+" + projectManager + "&action=new&token=" + token);

                            }
                            if (checkedListBox_DriveComp.GetItemChecked(7))
                            {
                                // Add component: L1 HMI Project 
                                component = "L1+HMI+Project";
                                componentComment = "General+L1+HMI+project+related+issues+including+points,+alarms,+events,+scripts,+devices,+ports,+users,+roles,+resources,+database+logger,+documentation,+drawings+index,+and+HMI+config+files";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + HMI_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);


                            }
                            if (checkedListBox_DriveComp.GetItemChecked(8))
                            {
                                // Add component: L1 HMI Screens 
                                component = "L1+HMI+Screens";
                                componentComment = "General+L1+HMI+screens+related+issues";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + HMI_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);

                            }
                            if (checkedListBox_DriveComp.GetItemChecked(9))
                            {

                                // Add component: L2 HMI Project 
                                component = "L2+HMI+Project";
                                componentComment = "General+L2+HMI+project+related+issues+including+points,+alarms,+events,+scripts,+devices,+ports,+users,+roles,+resources,+database+logger,+documentation,+drawings+index,+and+HMI+config+files";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + HMI_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);

                            }
                            if (checkedListBox_DriveComp.GetItemChecked(10))
                            {

                                // Add component: L2 HMI Screens 
                                component = "L2+HMI+Screens";
                                componentComment = "General+L2+HMI+screens+related+issues";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + HMI_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);

                            }
                            if (checkedListBox_DriveComp.GetItemChecked(11))
                            {

                                // Add component: Models 
                                component = "General+Models+Issues";
                                componentComment = "General+Mathematical+Models+related+issues";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + CompTech + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                            if (checkedListBox_DriveComp.GetItemChecked(12))
                            {
                                // Add component: Elementaries 
                                component = "Elementaries";
                                componentComment = "General+issues+involving+elementary+drawings";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + AppEngineer + "%2C+" + HW_Manager + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                        }
                                                                                            
                    }

                    // Components created if the Project is created as "Drive Only" first.
                    else if ((radioButton_Yes.Checked == true) && (radio_No.Checked == false))
                    {
                        if(checkBox_RequistComp.Checked == true)
                        {
                            // Add component: Drive Software 
                            component = "Drive+Software";
                            componentComment = "Issues+related+to+Drive+Software+files";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + DrvEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Drive Hardware 
                            component = "Drive+Hardware";
                            componentComment = "Issues+related+to+Drive+Hardware";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + SW_Manager + "%2C+" + AppEngineer + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Elementaries 
                            component = "Elementaries";
                            componentComment = "General+issues+involving+elementary+drawings";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + AppEngineer + "%2C+" + HW_Manager + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Hardware  ------------ Every project gets Hardware 
                            component = "General+Hardware";
                            componentComment = "General+hardware+related+issues+including+elementary+drawings,+panels,+Circuits,+etc.";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + AppEngineer + "%2C+" + Hardware_Engineer + "%2C+" + HW_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: Application Engineering 
                            component = "Application+Engineering";
                            componentComment = "General+Application+Related+Issues";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + AppEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);

                            // Add component: General Software 
                            component = "General+Software";
                            componentComment = "Anything+software+related+not+dealing+with+the+PLC+or+HMI+project";
                            getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                            token = FindToken(getToken);
                            response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                            this.progressBar1.Increment(10);
                        }
                        else if(checkBox_RequistComp.Checked == false)
                        {
                            if(checkedListBox_RequistComp.GetItemChecked(0))
                            {
                                // Add component: Drive Software 
                                component = "Drive+Software";
                                componentComment = "Issues+related+to+Drive+Software+files";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + DrvEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);

                            }
                            if (checkedListBox_RequistComp.GetItemChecked(1))
                            {
                                // Add component: Drive Hardware 
                                component = "Drive+Hardware";
                                componentComment = "Issues+related+to+Drive+Hardware";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + SW_Manager + "%2C+" + AppEngineer + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);

                            }
                            if (checkedListBox_RequistComp.GetItemChecked(2))
                            {
                                // Add component: Elementaries 
                                component = "Elementaries";
                                componentComment = "General+issues+involving+elementary+drawings";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + AppEngineer + "%2C+" + HW_Manager + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                            if (checkedListBox_RequistComp.GetItemChecked(3))
                            {
                                // Add component: Hardware  ------------ Every project gets Hardware 
                                component = "General+Hardware";
                                componentComment = "General+hardware+related+issues+including+elementary+drawings,+panels,+Circuits,+etc.";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Hardware_Engineer + "&initialcc=" + Control_Engineer + "%2C+" + AppEngineer + "%2C+" + Hardware_Engineer + "%2C+" + HW_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                            if (checkedListBox_RequistComp.GetItemChecked(4))
                            {
                                // Add component: Application Engineering 
                                component = "Application+Engineering";
                                componentComment = "General+Application+Related+Issues";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + AppEngineer + "&initialcc=" + Control_Engineer + "%2C+" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                            if (checkedListBox_RequistComp.GetItemChecked(5))
                            {
                                // Add component: General Software 
                                component = "General+Software";
                                componentComment = "Anything+software+related+not+dealing+with+the+PLC+or+HMI+project";
                                getToken = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                                token = FindToken(getToken);
                                response = wb.UploadString(urlAddProduct + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&component=" + component + "&description=" + componentComment + "&initialowner=" + Control_Engineer + "&initialcc=" + System_Engineer + "%2C+" + FE_Manager + "%2C+" + projectManager + "&action=new&token=" + token);
                                this.progressBar1.Increment(10);
                            }
                        }
                        

                    }

                    getToken = wb.UploadString(urlEditGroupControl + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");
                    token = FindToken(getToken);
                    response = wb.UploadString(urlEditGroupControl + projectname, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&action=updategroupcontrols&product=" + projectname + "&token=" + token + "&membercontrol_21=0&othercontrol_21=0&membercontrol_17=0&othercontrol_17=0&membercontrol_15=0&othercontrol_15=0&entry_16=1&membercontrol_16=3&othercontrol_16=3&membercontrol_22=0&othercontrol_22=0&submit=submit");
                }

                this.progressBar1.Increment(10);
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to complete! Check Bugzilla to see if any part of the project was created. \r\n\r\n Exception thrown: " + e, "Error!");
                return false;
            }

        }

        private string FindToken(string PageHTML)
        {
            // This function retrieves the unique token which is created every time a page is opened so that it can be submitted with the new component.
            int first = PageHTML.IndexOf("name=\"token\" value=\"") + "name=\"token\" value=\"".Length;
            return PageHTML.Substring(first, 10);
        }
        private string Encoder(string projectDescription)
        {
            // The encoding needed is not exactly ASCII encoding so this does it for us.
            // -   == -
            // _   == _
            // .   == . 
            // *   == * 

            // Must be the first one.
            projectDescription = projectDescription.Replace("%", "%25");// %25 == %
            projectDescription = projectDescription.Replace(">", "%3E"); // %3E == >
            projectDescription = projectDescription.Replace("<", "%3C"); // %3C == <
            projectDescription = projectDescription.Replace("(", "%28");// %28 == (
            projectDescription = projectDescription.Replace(")", "%29");// %29 == )
            projectDescription = projectDescription.Replace("[", "%5B");// %5B == [
            projectDescription = projectDescription.Replace("]", "%5D");// %5D == ]
            projectDescription = projectDescription.Replace("{", "%7B");// %7B == { 
            projectDescription = projectDescription.Replace("}", "%7D");// %7D == }
            projectDescription = projectDescription.Replace(",", "%2C");// %2C == ,
            projectDescription = projectDescription.Replace(":", "%3A");// %3A == :
            projectDescription = projectDescription.Replace(";", "%3B");// %3B == ;
            projectDescription = projectDescription.Replace("\"", "%22");// %22 == "
            projectDescription = projectDescription.Replace("`", "%60");// %60 == `
            projectDescription = projectDescription.Replace("~", "%7E");// %7E == ~
            projectDescription = projectDescription.Replace("\\", "%5C");// %5C == \
            projectDescription = projectDescription.Replace("/", "%2F");// %2F == /
            projectDescription = projectDescription.Replace("|", "%7C");// %7C == |
            projectDescription = projectDescription.Replace("@", "%40");// %40 == @
            projectDescription = projectDescription.Replace("#", "%23");// %23 == # 
            projectDescription = projectDescription.Replace("?", "%3F"); // %3F == ?
            projectDescription = projectDescription.Replace("+", "%2B");// %2B == +  
            projectDescription = projectDescription.Replace("!", "%21");// %21 == ! 
            projectDescription = projectDescription.Replace("$", "%24");// %24 == $            
            projectDescription = projectDescription.Replace("^", "%5E");// %5E == ^
            projectDescription = projectDescription.Replace("&", "%26");// %26 == &
            projectDescription = projectDescription.Replace("=", "%3D");// %3D == = 
            // Must be at the end 
            projectDescription = projectDescription.Replace(" ", "+");// +   == (space)

            return projectDescription;
        }

        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetGetCookieEx(
            string url,
            string cookieName,
            StringBuilder cookieData,
            ref int size,
            Int32 dwFlags,
            IntPtr lpReserved);

        private const Int32 InternetCookieHttponly = 0x2000;

        /// <summary>
        /// Gets the URI cookie container.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns></returns>
        public static CookieContainer GetUriCookieContainer(Uri uri)
        {
            CookieContainer cookies = null;
            // Determine the size of the cookie
            int datasize = 8192 * 16;
            StringBuilder cookieData = new StringBuilder(datasize);
            if (!InternetGetCookieEx(uri.ToString(), null, cookieData, ref datasize, InternetCookieHttponly, IntPtr.Zero))
            {
                if (datasize < 0)
                    return null;
                // Allocate stringbuilder large enough to hold the cookie
                cookieData = new StringBuilder(datasize);
                if (!InternetGetCookieEx(
                    uri.ToString(),
                    null, cookieData,
                    ref datasize,
                    InternetCookieHttponly,
                    IntPtr.Zero))
                    return null;
            }
            if (cookieData.Length > 0)
            {
                cookies = new CookieContainer();
                cookies.SetCookies(uri, cookieData.ToString().Replace(';', ','));
            }
            return cookies;
        }
   
        private void radioButton_Yes_CheckChanged(object sender, EventArgs e)
        {

            checkBox_RequistComp.Enabled = true;
            checkBox_DriveComp.Enabled = false;
        
            checkedListBox_DriveComp.Enabled = false;
            checkedListBox_RequistComp.Enabled = true;
           
            for (int i = 0; i < checkedListBox_DriveComp.Items.Count; i++)
            {
                checkedListBox_DriveComp.SetItemChecked(i, false);
            }

        }
        private void radio_No_CheckChanged(object sender, EventArgs e)
        {
            checkBox_RequistComp.Enabled = false;
            checkBox_DriveComp.Enabled = true;
         
            checkedListBox_DriveComp.Enabled = true;
            checkedListBox_RequistComp.Enabled = false;

            for (int i = 0; i < checkedListBox_RequistComp.Items.Count; i++)
            {
                checkedListBox_RequistComp.SetItemChecked(i, false);
            }

        }
        private void checkBox_DriveComp_CheckedChanged(object sender, EventArgs e)
        {          
            for( int i = 0; i < checkedListBox_DriveComp.Items.Count; i++)
            {
                checkedListBox_DriveComp.SetItemChecked(i, true);
            }
        }
        private void checkBox_RequistComp_CheckedChange(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox_RequistComp.Items.Count; i++)
            {
                checkedListBox_RequistComp.SetItemChecked(i, true);
            }
        }
        private void DriveComp_itemClick(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBox_DriveComp.Items.Count; i++)
            {
                if (e.NewValue == CheckState.Unchecked)
                {
                    checkBox_DriveComp.Checked = false;
                    checkBox_DriveComp.Refresh();
                    break;
                }
            }
        }
        private void RequistComp_itemClick(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBox_DriveComp.Items.Count; i++)
            {
                if (e.NewValue == CheckState.Unchecked)
                {
                    checkBox_RequistComp.Checked = false;
                    checkBox_RequistComp.Refresh();
                    break;
                }
            }
        }
    }
    public static class StringExtensions //Add the Contains function to the Strings OOP
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            if (source == null) return false;
            return source.IndexOf(toCheck, comp) >= 0;
        }
    }
}


/*
 * private void button1_Click(object sender, EventArgs e)
{
    try
    {
        Process.Start("notepad.exe", "ProjectEmail.xml");
    }
    catch
    {
        MessageBox.Show("Unable to open the ProjectEmail.xml from here.  Please make sure it exists in the same directory as the tool.", "Error");
    }

}*/

/*
private void button2_Click(object sender, EventArgs e)
{
    string cookies;
    string loginToken;
    string username = textBox1.Text;
    string password = textBox2.Text;
    string response;
    string url = "https://tools.tmeic.com/metals/editproducts.cgi?action=add&classification=Metals%20Projects";
    username = username.Replace("@", "%40");

    if (password == "")
    {
        MessageBox.Show("You must enter your Bugzilla credentials to test the cookies.", "Error!");
        return;
    }


    try
    {
        //Load XML Document
        try
        {
            System.Xml.XmlDocument DocTest = new System.Xml.XmlDocument();
            DocTest.Load(@"ProjectEmail.xml");
        }
        catch
        {
            MessageBox.Show("Please make sure that the ProjectEmail.xml file is located in the same file as this tool when it is run.", "Error");
            return;
        }
        System.Xml.XmlDocument Doc = new System.Xml.XmlDocument();
        Doc.Load(@"ProjectEmail.xml");

        XmlNode curNode = Doc.SelectSingleNode("Configuration/Cookies");
        if (curNode == null)
        {
            MessageBox.Show("Problem with ProjectEmail.xml/Configuration/Cookies");
            return;
        }
        cookies = curNode.InnerText;

        curNode = Doc.SelectSingleNode("Configuration/LoginToken");
        if (curNode == null)
        {
            MessageBox.Show("Problem with ProjectEmail.xml/Configuration/LoginToken");
            return;
        }
        loginToken = curNode.InnerText;
    }
    catch (Exception ex)
    {
        MessageBox.Show("An exception was thrown while reading the ProjectEmail.xml. Please insure that it is in the same folder as the project creation utility. ", "Error!");
        return;
    }

    using (WebClient wb = new WebClient())
    {
        try
        {
            wb.Headers.Add(HttpRequestHeader.Cookie, cookies);

            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new System.Uri(url), "Basic", new NetworkCredential(username, password, "tools.tmeic.com"));


            wb.Credentials = credentialCache;
            wb.BaseAddress = url;

            response = wb.UploadString(url, "POST", "Bugzilla_login=" + username + "&Bugzilla_password=" + password + "&Bugzilla_login_token=" + loginToken + "&GoAheadAndLogIn=Log+in");

            if (response.Contains("<title>Match Failed</title>"))
                MessageBox.Show("Failed to match one or more of the input engineer emails. Please make sure each entry is correct. Check the ProjectEmail.xml as well.", "Error!");
            else if (response.Contains("<title>Confirm Match</title>"))
                MessageBox.Show("Failed to match entered engineer email. Please make sure each entry is correct. Check the ProjectEmail.xml as well.", "Error");
            else if (response.Contains("<title>Untrusted Authentication Request</title>"))
                MessageBox.Show("Bugzilla returned the Untrusted Authentication Request page. The Cookies or Login Tokens are invalid","Failed!");
            else if (response.Contains("<title>Invalid Username Or Password</title>"))
                MessageBox.Show("Invalid Username Or Password.");
            else if (response.Contains("<title>Add Product</title>"))
                MessageBox.Show("Successfully sent command. Cookies and Tokens are still valid.", "Success! ");                    
            else if (response.Contains("<title>Authorization Required</title>"))
                MessageBox.Show("Authorization Required. You are not an Admin!");
            else
                MessageBox.Show("Unexpected response. Unsure of success.");
        }
        catch
        {
            MessageBox.Show("Exception thrown. Operation failed");
        }
    }
}
*/