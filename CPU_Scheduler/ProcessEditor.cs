using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler
{
    public partial class ProcessEditor : Form
    {
        public Process P1 = Form1.P1;
        public Process P2 = Form1.P2;
        public Process P3 = Form1.P3;
        public Process P4 = Form1.P4;
        public Process P5 = Form1.P5;
        public Process P6 = Form1.P6;
        public Process P7 = Form1.P7;
        public Process P8 = Form1.P8;
        public Process P9 = Form1.P9;

        bool addCPU = true;
        string process;

        public ProcessEditor()
        {
            InitializeComponent();
            P1.name = "P1";
            P2.name = "P2";
            P3.name = "P3";
            P4.name = "P4";
            P5.name = "P5";
            P6.name = "P6";
            P7.name = "P7";
            P8.name = "P8";
            P9.name = "P9";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputTextbox.Text == "" || Convert.ToDouble(inputTextbox.Text) % 1 != 0)
            {
                MessageBox.Show("Please enter a whole number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                process = pickProcesscombobox.SelectedItem.ToString();
                if (addCPU == true)
                {
                    button1.Text = "Add IO";
                    addCPU = false;

                    if (process == "P1")
                    {
                        int n = P1.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P1.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P1.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);

                    }
                    else if (process == "P2")
                    {
                        int n = P2.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P2.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P2.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P3")
                    {
                        int n = P3.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P3.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P3.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P4")
                    {
                        int n = P4.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P4.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P4.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P5")
                    {
                        int n = P5.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P5.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P5.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P6")
                    {
                        int n = P6.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P6.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P6.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P7")
                    {
                        int n = P7.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P7.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P7.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P8")
                    {
                        int n = P8.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P8.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P8.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P9")
                    {
                        int n = P9.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P9.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P9.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }

                }

                else
                {
                    button1.Text = "Add CPU";
                    addCPU = true;

                    process = pickProcesscombobox.SelectedItem.ToString();

                    if (process == "P1")
                    {
                        int n = P1.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P1.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P1.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);

                    }
                    else if (process == "P2")
                    {
                        int n = P2.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P2.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P2.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P3")
                    {
                        int n = P3.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P3.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P3.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P4")
                    {
                        int n = P4.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P4.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P4.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P5")
                    {
                        int n = P5.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P5.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P5.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P6")
                    {
                        int n = P6.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P6.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P6.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P7")
                    {
                        int n = P7.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P7.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P7.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P8")
                    {
                        int n = P8.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P8.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P8.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                    else if (process == "P9")
                    {
                        int n = P9.cpuIoTime.Length + 1;
                        int[] newarray = new int[n];
                        for (int i = 0; i < n - 1; i++)
                        {
                            newarray[i] = P9.cpuIoTime[i];
                        }
                        newarray[n - 1] = Convert.ToInt32(inputTextbox.Text);
                        P9.cpuIoTime = newarray;
                        pickProcesscombobox_SelectedIndexChanged(sender, e);
                    }
                }
            }
            
        }

        private void ProcessEditor_Load(object sender, EventArgs e)
        {
            
        }

        private void processNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pickProcesscombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void processArraytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
             process = pickProcesscombobox.SelectedItem.ToString();
            inputTextbox.Clear();
            if (process == "P1")
            {
                int n = P1.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P1.cpuIoTime[i];
                }
                P1.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);

            }
            else if (process == "P2")
            {
                int n = P2.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P2.cpuIoTime[i];
                }
                P2.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);
            }
            else if (process == "P3")
            {
                int n = P3.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P3.cpuIoTime[i];
                }
                P3.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);
            }
            else if (process == "P4")
            {
                int n = P4.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P4.cpuIoTime[i];
                }
                P4.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);
            }
            else if (process == "P5")
            {
                int n = P5.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P5.cpuIoTime[i];
                }
                P5.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);
            }
            else if (process == "P6")
            {
                int n = P6.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P6.cpuIoTime[i];
                }
                P6.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);
            }
            else if (process == "P7")
            {
                int n = P7.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P7.cpuIoTime[i];
                }
                P7.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);
            }
            else if (process == "P8")
            {
                int n = P8.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P8.cpuIoTime[i];
                }
                P8.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);
            }
            else if (process == "P9")
            {
                int n = P9.cpuIoTime.Length - 1;
                int[] newarray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarray[i] = P9.cpuIoTime[i];
                }
                P9.cpuIoTime = newarray;
                pickProcesscombobox_SelectedIndexChanged(sender, e);
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Add CPU")
            {
                MessageBox.Show("You need to add a CPU burst", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Close();
        }

        private void inputTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pickProcesscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button1.Text == "Add CPU")
            {
                button1.Text = "Add IO";
            }
            else if (button1.Text == "Add IO")
            {
                button1.Text = "Add CPU";
            }
            process = pickProcesscombobox.SelectedItem.ToString();
            processArraytextBox.Clear();
            if (process == "P1")
            {
                for (int i = 0; i < P1.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P1.cpuIoTime[i].ToString() + ", ";
                }
            }
            else if (process == "P2")
            {
                for (int i = 0; i < P2.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P2.cpuIoTime[i].ToString() + ", ";
                }
            }
            else if (process == "P3")
            {
                for (int i = 0; i < P3.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P3.cpuIoTime[i].ToString() + ", ";
                }
            }
            else if (process == "P4")
            {
                for (int i = 0; i < P4.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P4.cpuIoTime[i].ToString() + ", ";
                }
            }
            else if (process == "P5")
            {
                for (int i = 0; i < P5.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P5.cpuIoTime[i].ToString() + ", ";
                }
            }
            else if (process == "P6")
            {
                for (int i = 0; i < P6.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P6.cpuIoTime[i].ToString() + ", ";
                }
            }
            else if (process == "P7")
            {
                for (int i = 0; i < P7.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P7.cpuIoTime[i].ToString() + ", ";
                }
            }
            else if (process == "P8")
            {
                for (int i = 0; i < P8.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P8.cpuIoTime[i].ToString() + ", ";
                }
            }
            else if (process == "P9")
            {
                for (int i = 0; i < P9.cpuIoTime.Length; i++)
                {
                    processArraytextBox.Text += P9.cpuIoTime[i].ToString() + ", ";
                }
            }
        }
    }
}
