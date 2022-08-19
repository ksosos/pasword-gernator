namespace pasword_gernator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w = new List<string>();
            if (checkBox1.Checked)
            {
                w.Add(@"@#$%^&*(-/.\`");

            }
            if (checkBox3.Checked)
            {
                w.Add("1234567890");
            }
            if (checkBox2.Checked)
            {
                w.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            }
            w.Add("abcdefghijklmnopqrstuvwxyz");
            if (textBox1.Text.Length == 0)
            {
                var len = 13;
                
                var r = new Random();
                var ut = "";
                for (int i = 0; i < len; i++)
                {
                    try
                    {
                        var chosen = w.ToArray()[r.Next(0, w.Count)];
                        ut += chosen[r.Next(0, chosen.Length)];
                    }
                    catch(Exception) { };
                }
                textBox2.Text = ut;
            }
            else
            {

                var b = int.TryParse(textBox1.Text, out int len);
                if (!b)
                {
                    textBox1.Text = "Error text";
                    return;
                }
                
                var r = new Random();
                var ut = "";
                for(int i= 0;i<len; i++)
                {
                    var chosen = w.ToArray()[r.Next(0, w.Count - 1)];
                    ut += chosen[r.Next(0,chosen.Length)];
                }
                textBox2.Text = ut;
            }
        }
    }
}