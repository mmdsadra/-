namespace Mali_Khabgah_C.sh
{
    public partial class Form1 : Form
    {
        string[] names = { "sina", "sadra", "masood", "mehdi", "younes" };
        string pathsave = @"";//path to save
        struct Payment
        {

            int payerindex;
            List<int> users = new();
            float payedmoney;
            bool isfull;
            public Payment()
            {
                payerindex = 0;
                payedmoney = 0.0f;
                isfull = false;
                for (int i = 0; i < 5; i++)
                {
                    users[i] = 0;
                }
            }

            public void setpayer(int index)
            {
                payerindex = index;
            }

            public int getpayer()
            {
                return payerindex;
            }
            public void setmoney(float index)
            {
                payedmoney = index;
            }

            public float getmoney()
            {
                return payedmoney;
            }

            public void setusers(params int[] ar)
            {
                users = ar.ToList();
            }

            public List<int> getusersar()
            {
                return users;

            }

            public void setisfull(bool b)
            {
                isfull = b;
            }

            public bool getisfull()
            {
                return isfull;
            }
        }
        Payment[] payments = new Payment[1000];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(pathsave))
            {
                string[] readfile = File.ReadAllLines(pathsave);
                int i = 0;
                foreach (string line in readfile)
                {
                    string str = line;
                    payments[i].setpayer(int.Parse(str.Split(",")[0]));
                    payments[i].setmoney(int.Parse(str.Split(",")[1]));
                    int maxim = int.Parse(str.Split(",")[2]);
                    int[] inuse = new int[5];
                    for (int j = 1; j <= maxim; j++)
                    {
                        inuse[int.Parse(str.Split(",")[j + 2])] = 1;
                    }
                    //textBox2.Text = (str.Split(",")[1 + 2]);
                    payments[i].setusers(inuse);
                    payments[i].setisfull(true);
                    string making = names[payments[i].getpayer()] + ":" + payments[i].getmoney().ToString() + ":";

                    for (int j = 0; j < 5; j++)
                    {
                        if (inuse[j] == 1)
                        {
                            making += names[j] + ":";
                        }

                    }
                    making += str.Split(",")[2 + maxim + 1].ToString();
                    savebox.Items.Add(making);
                    i++;
                }
            }
            else
            {
                Close();
            }

        }

        public void loader()
        {

            for (int j = 0; j < 1000; j++)
            {
                payments[j].setisfull(false);
            }
            string[] readfile = File.ReadAllLines(pathsave);
            int i = 0;
            foreach (string line in readfile)
            {
                string str = line;
                payments[i].setpayer(int.Parse(str.Split(",")[0]));
                payments[i].setmoney(int.Parse(str.Split(",")[1]));
                int maxim = int.Parse(str.Split(",")[2]);
                int[] inuse = new int[5];
                for (int j = 1; j <= maxim; j++)
                {
                    inuse[int.Parse(str.Split(",")[j + 2])] = 1;
                }

                payments[i].setusers(inuse);
                payments[i].setisfull(true);
                i++;
            }

        }
        private void SaveData(object sender, EventArgs e)
        {
            //in:
            float money = float.Parse(textBox1.Text);
            bool[] checkedpeople = new bool[5];
            checkedpeople[0] = checkBox1.Checked;
            checkedpeople[1] = checkBox2.Checked;
            checkedpeople[2] = checkBox3.Checked;
            checkedpeople[3] = checkBox4.Checked;
            checkedpeople[4] = checkBox5.Checked;
            int numberofpayer = -1;
            int numberofusers = 0;
            int[] usersindex = new int[5];
            string users = "";
            string reasonsin = reasons.Text;
            for (int i = 0; i < 5; i++)
            {
                if (checkboxes.CheckedIndices.IndexOf(i) == 0)
                    numberofpayer = i;
                if (checkedpeople[i])
                {
                    numberofusers++;
                    users += ":" + names[i];
                    usersindex[i] = 1;
                }
            }
            users += ":" + reasonsin;
            //save:

            File.AppendAllText(pathsave, numberofpayer.ToString() + ",");
            File.AppendAllText(pathsave, money.ToString() + ",");
            File.AppendAllText(pathsave, numberofusers.ToString() + ",");
            for (int i = 0; i < 5; i++)
            {
                if (usersindex[i] == 1)
                {
                    File.AppendAllText(pathsave, i.ToString() + ",");
                }

            }
            File.AppendAllText(pathsave, reasonsin);
            File.AppendAllText(pathsave, "\n");
            savebox.Items.Add(names[numberofpayer] + ":" + money.ToString() + users);

            //reset:
            textBox1.Text = "0";
            reasons.Text = "";
            for (int i = 0; i < 5; i++)
            {
                checkboxes.SetItemChecked(i, false);
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            loader();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(pathsave, "");
            savebox.Items.Clear();
            loader();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float[] indade = new float[5];
            float[,] outdade = new float[5, 5];
            for (int i = 0; i < 1000; i++)
            {
                int dade = payments[i].getpayer();
                float pool = payments[i].getmoney();
                List<int> gerefte = payments[i].getusersar();
                int userscounter = 0;
                //sadrasadar
                if (!payments[i].getisfull())
                    break;


                for (int j = 0; j < 5; j++)
                {
                    if (gerefte[j] == 1)
                        userscounter++;
                }

                indade[dade] += pool;
                for (int j = 0; j < 5; j++)
                {
                    if (gerefte[j] == 1)
                    {
                        outdade[dade, j] += pool / userscounter;
                    }
                }
            }

            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    richTextBox1.Text += outdade[j, k].ToString() + "\t";
                }
                richTextBox1.Text += "\n";
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (outdade[j, i] - outdade[i, j] > 0)
                    {
                        richTextBox1.Text += names[i].ToString() + " bede be " + names[j].ToString() + " " + (outdade[j, i] - outdade[i, j]).ToString() + " tooman \t";
                    }
                }
                richTextBox1.Text += "\n";
            }

        }

        private void checkboxes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < checkboxes.Items.Count; i++)
            {
                checkboxes.SetItemChecked(i, sender.ToString() == checkboxes.Items[i].ToString());
                if (sender == checkboxes.Items[i])
                {
                    x = i;
                }
            }
            checkboxes.SetItemChecked(x, true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}