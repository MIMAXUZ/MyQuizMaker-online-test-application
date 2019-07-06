using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//MQuizDBEntities
namespace MyQuizMaker
{
    class TestGenerator
    {
        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string ConnectionString = @"Data Source=.;Initial Catalog=MQuizDB;Integrated Security=True;Connect Timeout=30";
        string Query;

        private string[,] questions = new string[20, 5];

        public TestGenerator()
        {
            sqlconnection = new SqlConnection(ConnectionString);
            Query =
                // "; ";
                "SELECT questions.id as qid, questions.question as qq FROM dbo.questions; ";
            sqlcommand = new SqlCommand(Query, sqlconnection);
            sqlconnection.Open();
            SqlDataReader sdr = sqlcommand.ExecuteReader();

            while (sdr.Read())
            {
                int quiz_id;
                bool quiz_id1 = Int32.TryParse(sdr["qid"].ToString(), out quiz_id);

                sqlconnection = new SqlConnection(ConnectionString);
                Query =
                "SELECT id, question_id, answer, is_correct FROM dbo.question_answers WHERE question_id = " + quiz_id + "  ; ";
                sqlcommand = new SqlCommand(Query, sqlconnection);
                sqlconnection.Open();
                SqlDataReader answr = sqlcommand.ExecuteReader();
                var ii = 1;
                while (answr.Read())
                {
                    questions[quiz_id, 0] = sdr["qq"].ToString();
                    string st = answr["is_correct"].ToString();
                    if (st == "1")
                        questions[quiz_id, ii] = "*" + answr["answer"].ToString();
                    else
                        questions[quiz_id, ii] = answr["answer"].ToString();

                    ii++;
                }
            }
        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }

        public string getAnswer(int i, int j)
        {
            return questions[i, j];
        }
    }
}
