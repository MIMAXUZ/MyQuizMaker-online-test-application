using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQuizMaker
{
    public partial class GetTests : Form
    {
        //We will make some variable methods
        private TestGenerator q = new TestGenerator();
        private List<int> lst = new List<int>();
        private string ans;
        private int score = 0;
        private int number = 1;

        public GetTests()
        {
            InitializeComponent();
        }

        private void GetTests_Load(object sender, EventArgs e)
        {
            int i = getRandom();
            q_text.Text = q.getQuestion(i);
            AnswerA.ButtonText = q.getAnswer(i, 1);
            AnswerB.ButtonText = q.getAnswer(i, 2);
            AnswerC.ButtonText = q.getAnswer(i, 3);
            AnswerD.ButtonText = q.getAnswer(i, 4);
            final.Visible = false;
            restart.Visible = false;

            if (Convert.ToString(AnswerA.ButtonText).StartsWith("*"))
            {
                this.ans = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                AnswerA.ButtonText = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
            }
            else
            {
                if (Convert.ToString(AnswerB.ButtonText).StartsWith("*"))
                {
                    this.ans = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                    AnswerB.ButtonText = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                }
                else
                {
                    if (Convert.ToString(AnswerC.ButtonText).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                        AnswerC.ButtonText = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                    }
                    else
                    {
                        this.ans = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                        AnswerD.ButtonText = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                    }
                }
            }
            lst.Add(i);
        }
        public int getRandom()
        {
            Random rnd = new Random();
            int i = rnd.Next(11);
            if (lst.Contains(i) && lst.Count() < 10)
                while (lst.Contains(i))
                    i = rnd.Next(1, 10);
            return i;
        }

        private void AnswerA_Click(object sender, EventArgs e)
        {
            if (this.number < 11)
            {
                this.number++;
                if (Convert.ToString(AnswerA.ButtonText) == this.ans)
                    this.score++;
                int i = this.getRandom();
                q_text.Text = q.getQuestion(i);
                //
                AnswerA.ButtonText = q.getAnswer(i, 1);
                AnswerB.ButtonText = q.getAnswer(i, 2);
                AnswerC.ButtonText = q.getAnswer(i, 3);
                AnswerD.ButtonText = q.getAnswer(i, 4);
                if (Convert.ToString(AnswerA.ButtonText).StartsWith("*"))
                {
                    this.ans = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                    AnswerA.ButtonText = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                }
                else
                {
                    if (Convert.ToString(AnswerB.ButtonText).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                        AnswerB.ButtonText = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(AnswerC.ButtonText).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                            AnswerC.ButtonText = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                            AnswerD.ButtonText = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Text = "Score : " + this.score;
                final.Visible = false;
                restart.Visible = false;
            }
            else
            {
                q_text.Visible = false;
                AnswerA.Visible = false;
                AnswerB.Visible = false;
                AnswerC.Visible = false;
                AnswerD.Visible = false;
                final.Visible = true;
                final.Text = "         Congratulations" + "\n          Your score is " + this.score;
                restart.Visible = true;
            }
        }

        private void AnswerB_Click(object sender, EventArgs e)
        {
            if (this.number < 11)
            {
                this.number++;
                if (Convert.ToString(AnswerB.ButtonText) == this.ans)
                    this.score++;
                int i = this.getRandom();
                q_text.Text = q.getQuestion(i);
                //
                AnswerA.ButtonText = q.getAnswer(i, 1);
                AnswerB.ButtonText = q.getAnswer(i, 2);
                AnswerC.ButtonText = q.getAnswer(i, 3);
                AnswerD.ButtonText = q.getAnswer(i, 4);
                if (Convert.ToString(AnswerA.ButtonText).StartsWith("*"))
                {
                    this.ans = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                    AnswerA.ButtonText = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                }
                else
                {
                    if (Convert.ToString(AnswerB.ButtonText).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                        AnswerB.ButtonText = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(AnswerC.ButtonText).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                            AnswerC.ButtonText = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                            AnswerD.ButtonText = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Text = "Score : " + this.score;
                final.Visible = false;
                restart.Visible = false;
            }
            else
            {
                q_text.Visible = false;
                AnswerA.Visible = false;
                AnswerB.Visible = false;
                AnswerC.Visible = false;
                AnswerD.Visible = false;
                final.Visible = true;
                final.Text = "         Congratulations" + "\n          Your score is " + this.score;
                restart.Visible = true;
            }
        }

        private void AnswerC_Click(object sender, EventArgs e)
        {
            if (this.number < 11)
            {
                this.number++;
                if (Convert.ToString(AnswerC.ButtonText) == this.ans)
                    this.score++;
                int i = this.getRandom();
                q_text.Text = q.getQuestion(i);
                //
                AnswerA.ButtonText = q.getAnswer(i, 1);
                AnswerB.ButtonText = q.getAnswer(i, 2);
                AnswerC.ButtonText = q.getAnswer(i, 3);
                AnswerD.ButtonText = q.getAnswer(i, 4);
                if (Convert.ToString(AnswerA.ButtonText).StartsWith("*"))
                {
                    this.ans = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                    AnswerA.ButtonText = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                }
                else
                {
                    if (Convert.ToString(AnswerB.ButtonText).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                        AnswerB.ButtonText = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(AnswerC.ButtonText).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                            AnswerC.ButtonText = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                            AnswerD.ButtonText = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Text = "Score : " + this.score;
                final.Visible = false;
                restart.Visible = false;
            }
            else
            {
                q_text.Visible = false;
                AnswerA.Visible = false;
                AnswerB.Visible = false;
                AnswerC.Visible = false;
                AnswerD.Visible = false;
                final.Visible = true;
                final.Text = "         Congratulations" + "\n          Your score is " + this.score;
                restart.Visible = true;
            }
        }

        private void AnswerD_Click(object sender, EventArgs e)
        {
            if (this.number < 11)
            {
                this.number++;
                if (Convert.ToString(AnswerD.ButtonText) == this.ans)
                    this.score++;
                int i = this.getRandom();
                q_text.Text = q.getQuestion(i);
                //
                AnswerA.ButtonText = q.getAnswer(i, 1);
                AnswerB.ButtonText = q.getAnswer(i, 2);
                AnswerC.ButtonText = q.getAnswer(i, 3);
                AnswerD.ButtonText = q.getAnswer(i, 4);
                if (Convert.ToString(AnswerA.ButtonText).StartsWith("*"))
                {
                    this.ans = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                    AnswerA.ButtonText = Convert.ToString(AnswerA.ButtonText).Substring(1, Convert.ToString(AnswerA.ButtonText).Length - 1);
                }
                else
                {
                    if (Convert.ToString(AnswerB.ButtonText).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                        AnswerB.ButtonText = Convert.ToString(AnswerB.ButtonText).Substring(1, Convert.ToString(AnswerB.ButtonText).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(AnswerC.ButtonText).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                            AnswerC.ButtonText = Convert.ToString(AnswerC.ButtonText).Substring(1, Convert.ToString(AnswerC.ButtonText).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                            AnswerD.ButtonText = Convert.ToString(AnswerD.ButtonText).Substring(1, Convert.ToString(AnswerD.ButtonText).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Text = "Score : " + this.score;
                final.Visible = false;
                restart.Visible = false;
            }
            else
            {
                q_text.Visible = false;
                AnswerA.Visible = false;
                AnswerB.Visible = false;
                AnswerC.Visible = false;
                AnswerD.Visible = false;
                final.Visible = true;
                final.Text = "         Congratulations" + "\n          Your score is " + this.score;
                restart.Visible = true;
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            //Reload this page after finish test
            GetTests gt = new GetTests();
            this.Visible = false;
            gt.Show(this);
        }
    }
}