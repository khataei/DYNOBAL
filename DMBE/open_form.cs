using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells;

namespace DMBE
{
    public partial class open_form : Form
    {
        public open_form()
        {
            InitializeComponent();
        }

        //تعریف متغیرهای مورد نیاز 
        //  public static string[] time = new string[100];
        string[] time = new string[100];
        string[] pwf = new string[100];
        string[] q = new string[100];
        string[] Np = new string[100];
        string[] x = new string[100];
        string[] y = new string[100];
        string[] ximg = new string[100];
        string[] yimg = new string[100];
        int satr;
        double pi;


        private void setlang()
        {
            if (dade.englishlang)
            {
                button1.Text = "Open";
                button2.Text = "Confirm";
                this.label1.Location = new System.Drawing.Point(50, 150);
                this.label2.Location = new System.Drawing.Point(30, 300);
                label1.RightToLeft = RightToLeft.No;
                label2.RightToLeft = RightToLeft.No;
                label1.Text = "Select a File...";
                label2.Text = "Initial Pressure:";
                errorProvider2.SetError(textBox1, "Insert initial Pressure Here");
                errorProviderpersian.Clear();
                menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                menuStrip1.RightToLeft = RightToLeft.No;
                خروجToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                راهنماToolStripMenuItem .Font= new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                
                خروجToolStripMenuItem.Text = "Exit";
                راهنماToolStripMenuItem.Text = "Help";

            }
            else
            {
                button1.Text = "باز کردن...";
                label1.Text = "فایلی را اتخاب نمایید";
                label2.Text = "فشار اولیه:";
                label2.Location =new System.Drawing.Point(110, 310);
                label2.RightToLeft = RightToLeft.Yes;
                label1.RightToLeft = RightToLeft.Yes;
                button2.Text = "تائید";
                this.errorProviderpersian.SetError(this.textBox1, "  از صحت فرمت فشار اولیه اطمینان حاصل کنید.درصورت لزوم میتوانید از همین جا آنرا تغییر دهید");
                errorProvider2.Clear();

                خروجToolStripMenuItem.Font = new System.Drawing.Font("B Bardiya", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                راهنماToolStripMenuItem.Font = new System.Drawing.Font("B Bardiya", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
               
                menuStrip1.RightToLeft = RightToLeft.Yes;
                خروجToolStripMenuItem.Text = "خروج";
                راهنماToolStripMenuItem.Text = "راهنما";
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                //باز کردن فایل

                OpenFileDialog op = new OpenFileDialog();

                op.Filter = "Excel File|*.xlsx|Excel 97-2003|*.xls";
                DialogResult dr;
                dr = op.ShowDialog();
                if (dr == DialogResult.OK)
                  {
                   

                    
                    // در جعبه ای دیگر نام فایل
                    // برای استفاده های بعدی نیز از این جعبه استفاده خواهد شد
                    // پس مستوان ان را فقط خوواندنی کرد تا کاربر تغییرش ندهد
                    // و برنامه خطا ندهد
                   
                    dade.filename = op.FileName;
                    this.Text = op.FileName;
                 
                    DataTable dt = new DataTable();

                    Workbook wb1 = new Workbook(dade.filename);
                   
                    //super important
                    //ریختن از فایل اکسل به درون دیتا تیبل
                   dt= wb1.Worksheets[0].Cells.ExportDataTable(1, 0, 
                       wb1.Worksheets[0].Cells.Count/4-1, 4);
                   
                    //در جعبه ای که در فرم هست فشار اولیه ی پیشنهادی نمایش داده میشود
              
                    textBox1.Text = wb1.Worksheets[0].Cells[1, 1].Value.ToString();


                    dataGridView1.DataSource = dt;

                    ///نامگذاری بالای جدول
                    dataGridView1.Columns[0].HeaderText = "TIME";
                    dataGridView1.Columns[1].HeaderText = "Flowing Pressure";
                    dataGridView1.Columns[2].HeaderText = "Q";
                    dataGridView1.Columns[3].HeaderText = "NP";

                    ///نمایان ساختن موارد مورد نیاز مرحله بعد
                    button2.Visible = true;
                    textBox1.Visible = true;
                    label1.Visible = false;
                    label2.Visible = true;
                  
                   }
            
                if (dr == DialogResult.Cancel)
                   {
                       if (dade.englishlang)
                           {
                                  MessageBox.Show("To Start the Calculation Process, Select a File");
                           }
                      else
                           {

                                    MessageBox.Show("!برای شروع محاسبات،می بایست  فایلی را برگزینید");
                             }
                }
            }
            
            catch
            {
                if (dade.englishlang)
                {
                    MessageBox.Show("Input Format is not Correct");
                }
                else
                {
                    MessageBox.Show("mmmmmفرمت فایل ورودی صحیح نمی باشد.  برای اطلاع از فرمت صحیح راهنما را مطالعه فرمایید  ");
                }
            }

        
        
    }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                {





                    //انجام محاسبات برای ساختن داده ها


                    ///باز کردن فایل اکسل و پر کردن آرایه ها
                    Workbook wb = new Workbook(dade.filename);



                    //if (dataGridView1.Columns.Count != 4)
                    //{

                    //    throw new Exception("تعداد ستونها برابر با 4 نیست");
                    //}


                    //خواندن فشار اولیه

                    pi = double.Parse(textBox1.Text);

                    //محاسبه تعداد سطرها برای حلقه ها که زیادی نروند


                    satr = wb.Worksheets[0].Cells.Rows.Count;
                    for (int i = 0; i < satr; i++)
                    {
                        time[i] = wb.Worksheets[0].Cells[i, 0].Value.ToString();
                    }
                    for (int i = 0; i < satr; i++)
                    {
                        pwf[i] = wb.Worksheets[0].Cells[i, 1].Value.ToString();
                    }
                    for (int i = 0; i < satr; i++)
                    {
                        q[i] = wb.Worksheets[0].Cells[i, 2].Value.ToString();

                        //اینجا یه فکری برای مواقعی که نرخ صفر توی داده ها هست میکنیم
                        // نرخ صفر داده ی بینهایت میسازه که نمایش رو خراب میکنه
                        //با این روش صفرها رو خذف میکنیم
                        try
                        {
                            if (Int32.Parse(q[i - 1]) == 0)
                            {
                                q[i - 1] = q[i];
                                pwf[i - 1] = pwf[i];
                                Np[i - 1] = Np[i];
                                time[i - 1] = time[i];
                            }
                        }
                        catch
                        { }


                    }
                    for (int i = 0; i < satr; i++)
                    {
                        Np[i] = wb.Worksheets[0].Cells[i, 3].Value.ToString();
                    }

                    // ساختن آرایه های محور ایکس و وای
                    for (int i = 1; i < satr; i++)
                    {
                        x[i] = (double.Parse(Np[i]) / double.Parse(q[i])).ToString();

                        y[i] = ((pi - double.Parse(pwf[i])) / double.Parse(q[i])).ToString();
                    }

                    // ذخیره کردن داده های ساخته شده در فایل اکسلی دیگر
                    Workbook ws = new Workbook();

                    ws.Worksheets[0].Cells[0, 0].Value = "Np/q";
                    ws.Worksheets[0].Cells[0, 1].Value = "(Pi-Pwf)/q";
                    for (int i = 1; i < satr; i++)
                    {
                        ws.Worksheets[0].Cells[i, 0].Value = string.Format("{0:n4}", double.Parse(x[i]));
                        ws.Worksheets[0].Cells[i, 1].Value = string.Format("{0:n4}", double.Parse(y[i]));
                    }

                    ///ذخیره کردن فایل و 
                    ws.Save("c:\\temp.xlsx");


                    dataGridView1.AutoGenerateColumns = true;



                    //============================================================


                    /// محاسبه ماکزیمم و مینیمهای داده های اصلی
                    /// این مقادیر در تبدیل داده اصلی به نموداری به کار میرود
                    /// 
                    double maxx = 0;
                    double maxy = 0.00;
                    for (int i = 1; i < satr; i++)
                    {
                        if (maxx < double.Parse(x[i]))
                        {
                            maxx = double.Parse(x[i]);
                            dade.imaxx = i;

                        }
                    }
                    dade.minx = double.Parse(x[1]);
                    dade.miny = double.Parse(y[1]);
                    for (int i = 1; i < satr; i++)
                    {
                        if (maxy < double.Parse(y[i]))
                        {
                            maxy = double.Parse(y[i]);
                            dade.imaxy = i;
                        }


                        if (dade.minx > double.Parse(x[i]))
                        {
                            dade.minx = double.Parse(x[i]);
                            dade.iminx = i;
                        }

                        if (dade.miny > double.Parse(y[i]))
                        {
                            dade.miny = double.Parse(y[i]);
                            dade.iminy = i;
                        }

                    }
                    dade.maxx = maxx;
                    dade.maxy = maxy;
                    for (int i = 1; i < satr; i++)
                    {
                        ximg[i] = ((double.Parse(x[i]) - dade.minx) * 700 / (maxx - dade.minx)).ToString();
                        dade.x[i] = ximg[i];
                        yimg[i] = ((double.Parse(y[i]) - dade.miny) * 600 / (maxy - dade.miny)).ToString();
                        dade.y[i] = yimg[i];
                    }
                    Workbook nemodari = new Workbook();
                    // نوشتن داده های نموداری در فایلی جدید
                    for (int i = 1; i < satr; i++)
                    {
                        nemodari.Worksheets[0].Cells[i, 0].Value = string.Format("{0:n4}", double.Parse(ximg[i]));
                        nemodari.Worksheets[0].Cells[i, 1].Value = string.Format("{0:n4}", double.Parse(yimg[i]));
                    }
                    nemodari.Worksheets[0].Cells[0, 0].Value = "X";
                    nemodari.Worksheets[0].Cells[0, 1].Value = "Y";

                    dade.satr = satr;
                    nemodari.Save("c:\\nemoodar.xlsx");
                    dade.stage1 = true;
                    dade.stage2 = false;
                    dade.stage3 = false;
                    this.Hide();


                }


            }
            catch
            {
                if (dade.englishlang)
                {
                    MessageBox.Show("Input Format is not correct");
                }
                else
                {
                    MessageBox.Show("فرمت فایل ورودی صحیح نمی باشد.  برای اطلاع از فرمت صحیح راهنما را مطالعه فرمایید");
                }
            }

        }
        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void open_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        Form frhelp = new Help();
        private void راهنماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frhelp.Show();

        }

        private void open_form_Activated(object sender, EventArgs e)
        {
            setlang();
        }

      

    }
}
   