using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_ThiTracNghiem
{
    public class QuanLyCauHoi
    {
        private List<Question> listDs = new List<Question>();

        public List<Question> ListDs { get => listDs; set => listDs = value; }

        public void addQuestion(Question ques)
        {
            this.ListDs.Add(ques);
        }
        
    }
}
