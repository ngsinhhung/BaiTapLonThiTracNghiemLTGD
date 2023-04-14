using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_ThiTracNghiem
{
    public class Question
    {
        private int _id = dem++;
        private string _ask;
        private string answerA;
        private string answerB;
        private string answerC;
        private string answerD;
        private char key;
        private static int dem = 0;

        public Question(string ask, string answerA, string answerB, string answerC, string answerD, char key)
        {
            this.Ask = ask;
            this.AnswerA = answerA;
            this.AnswerB = answerB;
            this.AnswerC = answerC;
            this.AnswerD = answerD;
            this.key = key;
        }
        
        public string Ask { get => _ask; set => _ask = value; }
        public string AnswerA { get => answerA; set => answerA = value; }
        public string AnswerB { get => answerB; set => answerB = value; }
        public string AnswerC { get => answerC; set => answerC = value; }
        public string AnswerD { get => answerD; set => answerD = value; }
        public char Key { get => key; set => key = value; }
    }
}
