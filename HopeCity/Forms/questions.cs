using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeCity
{


    public partial class questions : Form
    {

        int num;
        List<quest> quests;
        string[,] q;
        public questions()
        {
            InitializeComponent();
        }

        private void questions_Load(object sender, EventArgs e)
        {
            q = new string[42, 5];
            quests = new List<quest>();
            quests.Add(new quest { Typ = 'A', Quest = "هل توجد صلة القرابة بين الاب والام؟", subQuest = "اوصف صلة القرابة؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل توجد حالات مشابهة في الأسرة", subQuest = "ما درجة القرابة ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "ما هي مدة الحمل ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل كانت الام تعاني من اي امراض اثناء الحمل ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل اصيبت الام بأي عدوي أو فيروس ؟", subQuest = "ما نوع هذه العدوي أو فيروس ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل اصيبت الام بأي إصابة مباشرة في البطن ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هي تعرضت الام للإشعاع ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل تعاطت الام أي عقاقير ؟", subQuest = "ما اسم العقار و ما سبب تناوله و ما مدة تناوله ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل كانت الام تدخن او تتعاطي اي نوع من المكيفات", subQuest = "ما نوع هذه المكيفات ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل كانت الولادة طبيعية ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل كانت الولادة متعثرة ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل تم استخدام أدوات مثل الجفت والشفاط اثناء الولادة ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل عاني الطفل من أي مشاكل في التنفس او نقص الاكسجين ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "ما هو وزن الطفل عند الولادة ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل تم وضع الطفل في حضانة بعد الولادة ؟", subQuest = "ما سبب وضعه في حضانة ؟ و ما المدة ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل يعاني الطفل من اي أمراض أو عيوب خلقية ؟", subQuest = "ما هي هذه الامراض والعيوب الخلقية ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هي أصيب الطفل بالصفراء ؟", subQuest = "ما هي درجتها ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل كانت رضاعة الطفل طبيعية ؟", subQuest = "ما السبب ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل يعاني الطفل من صععوبة في البلع ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل أصيب الطفل بأي إصابة صدمية مباشرة ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل أصيب الطفل بأي عدوي حادة ؟", subQuest = "ما نوع العدوي ؟ و ما سن الطفل في هذه الفترة ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل تناول الطفل أي عقاقير ؟", subQuest = "ما هو نوع العقار ؟ و ماسبب تناوله ؟ و ما المدة ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل تم إجراء أي جراحات للطفل ؟", subQuest = "ما نوع الجراحة ؟ و ما عمر الطفل عند اجرائها ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل توجد مشاكل خاصة بالسمع ؟", subQuest = "ما هي هذه المشاكل ؟ و ما اسم طبيب السمعيات المباشر للسمع" });
            quests.Add(new quest { Typ = 'A', Quest = "هل توجد مشاكل خاصة بالبصر ؟", subQuest = "ما هي هذه المشاكل ؟ و ما اسم طبيب العيون المباشر للبصر" });
            quests.Add(new quest { Typ = 'A', Quest = "هل توجد مشاكل خاصة بالحركة ؟", subQuest = "ما هي هذه المشاكل ؟ " });
            quests.Add(new quest { Typ = 'C', subQuest = "متي بدأ في الجلوس ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "متي بدأ في المشي ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل يحصل الطفل علي جلسات علاج طبيعي بإنتظام ؟", subQuest = "ما عدد الجلسات في الأسبوع ؟ " });
            quests.Add(new quest { Typ = 'B', Quest = "هل يعاني الطفل من نوبات صرعية ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "ما اسم طبيب المخ والأعصاب المباشر للطفل ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "متي بدأ في نطق أول كلمة ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل يحصل علي جلسات تخاطب بإنتظام ؟", subQuest = "ما عدد الجلسات في الأسبوع ؟ " });
            quests.Add(new quest { Typ = 'C', subQuest = "كيف يتواصل الطفل مع الاخرين ؟ هل من خلال السمع او البصر او اللمس ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل يتواصل الطفل مع أخوته ؟" });
            quests.Add(new quest { Typ = 'B', Quest = "هل يطيع الأوامر البسيطة ؟" });
            quests.Add(new quest { Typ = 'A', Quest = "هل ينطق كلمات أو يعبر بالإشارة ؟", subQuest = "كم عدد الكلمات التي ينطقها او الإشارات ؟ و ما هي ؟ " });
            quests.Add(new quest { Typ = 'B', Quest = "هل ينطق جمل ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "ما اسم طبيب التخاطب الخاص بالطفل ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "ما اسم اخصائي التخاطب القائم بجلسات الطفل ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "ما النشاط المفضل للطفل ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "ما اللعبة المفضلة للطفل ؟" });
            quests.Add(new quest { Typ = 'C', subQuest = "هل يوجد معلومات إضافية ؟" });

            num = 0;

            myQuest(num, quests);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (num < quests.Count - 1)
            {
                if (num == 41)
                {
                    button1.Text = "انتهاء";
                }
                else
                {
                    button1.Text = "التالي";
                }

                if (quests[num].Typ == 'A')
                {
                    q[num, 0] = quests[num].Typ.ToString();
                    q[num, 1] = quests[num].Quest.ToString();
                    q[num, 2] = radioButton1.Checked ? "نعم" : radioButton2.Checked ? "لا" : null;
                    q[num, 3] = quests[num].subQuest.ToString();
                    q[num, 4] = richTextBox1.Text;
                }
                else if (quests[num].Typ == 'B')
                {
                    q[num, 0] = quests[num].Typ.ToString();
                    q[num, 1] = quests[num].Quest.ToString();
                    q[num, 2] = radioButton1.Checked ? "نعم" : radioButton2.Checked ? "لا" : null;
                    q[num, 3] = "";
                    q[num, 4] = "";
                }
                else if (quests[num].Typ == 'C')
                {
                    q[num, 0] = quests[num].Typ.ToString();
                    q[num, 1] = "";
                    q[num, 2] = "";
                    q[num, 3] = quests[num].subQuest.ToString();
                    q[num, 4] = richTextBox1.Text;
                }
                num += 1;
                myQuest(num, quests);





            }
            else
            {

                DataTable dt = new DataTable();
                dt.Columns.Add("Question");
                dt.Columns.Add("QAnswer");
                dt.Columns.Add("SubQuestion");
                dt.Columns.Add("SQAnswer");
                dt.Columns.Add("sonid");

                for (int i = 0; i < 42; i++)
                {
                    dt.Rows.Add(q[i, 1], q[i, 2], q[i, 3], q[i, 4],9);
                }
                  dataGridView1.DataSource = dt;


                using (SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.hccs))
                {


                    using (var bulk = new SqlBulkCopy(myConnection, SqlBulkCopyOptions.KeepNulls & SqlBulkCopyOptions.KeepIdentity,null))
                    {
                        bulk.ColumnMappings.Add(0, 1);
                        bulk.ColumnMappings.Add(1, 2);
                        bulk.ColumnMappings.Add(2, 3);
                        bulk.ColumnMappings.Add(3, 4);
                        bulk.ColumnMappings.Add(4, 5);
                        myConnection.Open();
                        bulk.DestinationTableName = "QA";
                        bulk.WriteToServer(dt);
                    }


                }
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (num > 0)
            {
                if (num < 43)
                {
                    button1.Text = "التالي";
                }
                num -= 1;
                myQuest(num, quests);
            }
        }
        void myQuest(int num, List<quest> qu)
        {



            if (qu[num].Typ == 'A')
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                richTextBox1.Visible = true;
                label1.Location = new Point(12, 22);
                radioButton1.Location = new Point(393, 94);
                radioButton2.Location = new Point(297, 94);
                label2.Location = new Point(16, 153);
                richTextBox1.Location = new Point(213, 210);

                label1.Text = qu[num].Quest;
                label2.Text = qu[num].subQuest;
            }
            else if (qu[num].Typ == 'B')
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
                richTextBox1.Visible = false;
                label1.Location = new Point(16, 94);
                radioButton1.Location = new Point(393, 151);
                radioButton2.Location = new Point(297, 151);


                label1.Text = qu[num].Quest;

            }
            else if (qu[num].Typ == 'C')
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                label1.Visible = false;
                label2.Visible = true;
                richTextBox1.Visible = true;

                label2.Location = new Point(16, 94);
                richTextBox1.Location = new Point(213, 151);

                label2.Text = qu[num].subQuest;
            }

        }


    }
}
