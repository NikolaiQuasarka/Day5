using System.Runtime.CompilerServices;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            list1 = new SLList();

            list1.Changing +=UpdateL1;

            list2 = new SLList();
            list2.Changing += delegate (object sender, EventArgs e)
            {
                listBox2.Items.Clear();

                for (ListNode? i = list2.head; i != null; i = i.Next)
                {
                    listBox2.Items.Add(i.Value.ToString());
                }

            };
        }
        SLList list1;
        SLList list2;
        private void button_add_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_add.Text, out int i))
            {
                list1.AddItem(i);
            }
        }



        private void button_delete_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox_add.Text, out uint i))
            {
                list1.DeleteItem(i);
            }
        }

        private void button_listgen_Click(object sender, EventArgs e)
        {
            list2.head = null;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                list2.AddItem(rnd.Next(-10, 10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list1) button2.BackColor = Color.Green;
            else button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list1.head = list1 + list2;
            UpdateL1(button3,new EventArgs());
        }
        private void UpdateL1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
                for (ListNode i = list1.head; i != null; i = i.Next)
                {
                    listBox1.Items.Add(i.Value.ToString());
                }
                textBox_sum.Text = StaticOperation.Sum(list1).ToString();
                textBox_count.Text = StaticOperation.Count(list1).ToString();
                textBox_difference.Text = StaticOperation.Difference(list1).ToString();
        }

private void button4_Click(object sender, EventArgs e)
        {
            if (list1 == list2) button4.BackColor = Color.Green;
            else button4.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            --list1;
        }
    }
}
