using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BaiTapLon_ThiTracNghiem
{
    public partial class Form_Question : Form
    {
        public static string name = null;
        public static String tenThiSinh;
        public static String runTime;
        public static int thoiGianThi;
        public static string filePath;
        private int h, m, s;
        List<Question> list = new List<Question>();
        private int dem = 0; // biến đếm để kiểm tra người dùng đang ở câu nào
        private static int[] ansArr; // mảng lưu câu trả lời của người dùng
        public static int soCauDung, soCauHoi;
        public Form_Question()
        {
            Form_Welcome f = new Form_Welcome();
            f.ShowDialog();
            InitializeComponent();
        }

        private void Form_Question_Load(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Text File (*.txt)|*.txt" + "|Excel File (*.xlsx)|*.xlsx";
            f.Title = "Open File";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Form_Question.filePath = f.FileName;
            }
            timerCountdown.Start();
            convertTime(thoiGianThi);
            runTime = String.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);
            lbTenThiSinh.Text = "Thí sinh: " + tenThiSinh;
            lbTime.Text = "Thời gian: " + runTime;

            readFile(filePath);
            //mảng lưu câu hỏi của người dùng nhập vào
            ansArr = new int[list.Count];
            //khởi tạo tất cả mảng là -1
            for (int i = 0; i < ansArr.Length; i++)
            {
                ansArr[i] = -1;
            }
        }
        private void convertTime(int min)
        {
            h = min / 60;
            m = min - (h * 60);
            s = 00;
        }
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            s--;
            if (s < 0)
            {
                s = 59;
                m--;
                if (m < 0)
                {
                    m = 59;
                    h--;
                }
            }
            
            if (h == 0 && m == 0 && s == 0)
            {
                timerCountdown.Stop();
                // hết thời gian làm bài
                finishedAndShowResult();
            }
            runTime = String.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);
            lbTime.Text = "Thời gian: " + runTime;
        }
        private void readFile(string filepath)
        {
            if(Path.GetExtension(filepath) == ".txt")
            {
                readFileTxt(filepath);
                loadQestion(0);
            }

        }
        private void readFileTxt(string filepath)
        {
            string content = File.ReadAllText(filepath);
            string[] question = content.Trim().Split(new string[] {"***"}  , StringSplitOptions.RemoveEmptyEntries);
            
            for(int i = 0; i <  question.Length; i++)
            {
                string[] partsQues = question[i].Trim().Split(new string[] { ":", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                Question quesItem = new Question(partsQues[0], partsQues[2], partsQues[3], partsQues[4], partsQues[5], (partsQues[7].Trim().ToCharArray())[0]);
                list.Add( quesItem );
                
            }
        }
        //nút câu hỏi tiếp theo
        private void btnNextQues_Click(object sender, EventArgs e)
        {
            int n = list.Count;
            n = n - 1;
            if (dem < n)
            {
                dem++;
            }
            checkedAns(ref ansArr);
            loadQestion(dem);
        }
        //nút lùi câu hỏi
        private void btnPreQues_Click(object sender, EventArgs e)
        {
            if (dem > 0)
            {
                dem--;
            }
            checkedAns(ref ansArr);
            loadQestion(dem);
        }

        private void loadQestion(int vitri)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(i == vitri)
                {
                    showQuestion(list[i]);
                }
            }
            boxQuestion.Text = "Câu " + (vitri+1).ToString();
        }
        private void showQuestion(Question Ques)
        {
            lbQuestion.Text = Ques.Ask;
            radioA.Text = Ques.AnswerA;
            radioB.Text= Ques.AnswerB;
            radioC.Text= Ques.AnswerC;
            radioD.Text= Ques.AnswerD;
        }
        /**
         * mảng arrAns phải được tạo khi form chạy
         * tạo mảng arrAns có kích thước list.Count và khởi tạo các giá trị là -1
         * dựa vào biến đếm sẽ biết người dùng dang ở câu hỏi nào nếu người dùng chọn câu trả lời sẽ lưu vào mảng ở bị trí dem
         * vd người dùng đg trả lời cho câu hỏi số 6 thì mảng sẽ lưu đáp án tại vị trí số 5
         * sử dụng checkedChanged
         * 
         * hệ thống sẽ lưu câu hỏi vào người dùng chọn vào mảng ansArr
         */

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = sender as RadioButton;
            if(Form_Welcome.flagExit != true)
            {
                if (radioBtn != null && radioBtn.Checked)
                {
                    string selctedRadioBtn = radioBtn.Name;

                    switch (selctedRadioBtn)
                    {
                        case "radioA":
                            ansArr[dem] = 1;
                            break;
                        case "radioB":
                            ansArr[dem] = 2;
                            break;
                        case "radioC":
                            ansArr[dem] = 3;
                            break;
                        case "radioD":
                            ansArr[dem] = 4;
                            break;
                    }
                }
            }     
        }

        private void checkedAns(ref int [] a)
        {
            /**
             * duyệt qua mảng lưu câu trả lời của người dùng nếu tại vị trí đếm giá trị phần tử đó là -1
             * (nghĩa là người dùng chưa chọn câu trả lời hoặc chưa đến câu hỏi đó bao giờ ) thì tất cả radioCheacked là false
             */
            for(int i = 0; i < a.Length; i++)
            {
                if (i == dem)
                {
                    switch (a[i])
                    {
                        case 1:
                            radioA.Checked = true;
                            break;
                        case 2:
                            radioB.Checked = true; 
                            break;
                        case 3:
                            radioC.Checked = true;
                            break;
                        case 4:
                            radioD.Checked = true;
                            break;
                        default:
                            radioA.Checked = radioB.Checked = radioC.Checked = radioD.Checked = false;
                            break;
                    }
                    
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Bạn có chắc chắn muốn nộp bài thi không?", "Chương trình trắc nghiệm", MessageBoxButtons.YesNo);
            if(box == DialogResult.Yes)
            {
                finishedAndShowResult();
            }
        }

        public int tinhSoCauDung()
        {
            int soCauDung = 0;
            int[] keyAns = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i].Key)
                {
                    case 'a':
                    case 'A':
                        keyAns[i] = 1;
                        break;
                    case 'b':
                    case 'B':
                        keyAns[i] = 2;
                        break;
                    case 'c':
                    case 'C':
                        keyAns[i] = 3;
                        break;
                    case 'd':
                    case 'D':
                        keyAns[i] = 4;
                        break;
                }
            }
            for (int i = 0; i < ansArr.Length; i++)
            {
                if (ansArr[i] == keyAns[i])
                {
                    soCauDung++;
                }
            }
            return soCauDung;
        }

        private void finishedAndShowResult()
        {
            soCauDung = tinhSoCauDung();
            soCauHoi = list.Count;
            Form_Result form_Result = new Form_Result();
            this.Visible = false;
            form_Result.ShowDialog();
        }
    }
}

