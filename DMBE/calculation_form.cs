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
    public partial class calculation_form : Form
    {
        public calculation_form()
        {
            InitializeComponent();
        }



        public void setlang()
        {
            if (!dade.englishlang)
            {
                this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label2.Location = new System.Drawing.Point(31, 83);
                this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.label2.Size = new System.Drawing.Size(194, 33);
                this.label2.Text = "محاسبات پایان یافت      ";


                this.label3.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label3.Location = new System.Drawing.Point(12, 83);
                this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.label3.Size = new System.Drawing.Size(213, 33);
                this.label3.Text = "در حال انجام محاسبات . . . ";


                this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label1.Location = new System.Drawing.Point(71, 194);
                this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.label1.Size = new System.Drawing.Size(163, 24);
                this.label1.Text = "نتایج در فایل زیر ذخیره گردید";


                // 
                // linkLabel1
                // 
                this.linkLabel1.AutoSize = true;
                this.linkLabel1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.linkLabel1.Location = new System.Drawing.Point(92, 281);
                this.linkLabel1.Name = "linkLabel1";
                this.linkLabel1.Size = new System.Drawing.Size(127, 28);
                this.linkLabel1.TabIndex = 2;
                this.linkLabel1.TabStop = true;
                this.linkLabel1.Text = "باز کردن فایل اکسل";
               
                this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

                // button2
                // 
                this.button2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.button2.Location = new System.Drawing.Point(71, 430);
                this.button2.Name = "button2";
                this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.button2.Size = new System.Drawing.Size(153, 41);
                this.button2.TabIndex = 7;
                this.button2.Text = "ذخیره  مجدد ";
                this.button2.UseVisualStyleBackColor = true;
               

                //but1      
                this.button1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.button1.Location = new System.Drawing.Point(71, 356);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(153, 41);
                this.button1.TabIndex = 6;
                this.button1.Text = "بستن این پنجره";
                this.button1.UseVisualStyleBackColor = true;
              

            }

            else
            {
                this.label2.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label2.Location = new System.Drawing.Point(31, 83);
                this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.label2.Size = new System.Drawing.Size(194, 33);
                this.label2.Text = "Completed";


                this.label3.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label3.Location = new System.Drawing.Point(12, 83);
                this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.label3.Size = new System.Drawing.Size(213, 33);
                this.label3.Text = "Calculating... ";


                this.label1.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label1.Location = new System.Drawing.Point(40, 194);
                this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.label1.Size = new System.Drawing.Size(163, 24);
                this.label1.Text = "Result's Saved Here:";


                // 
                // linkLabel1
                // 
                this.linkLabel1.AutoSize = true;
                this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.linkLabel1.Location = new System.Drawing.Point(50, 281);
                this.linkLabel1.Name = "linkLabel1";
                this.linkLabel1.Size = new System.Drawing.Size(127, 28);
                linkLabel1.RightToLeft = RightToLeft.No;
                this.linkLabel1.TabStop = true;
                this.linkLabel1.Text = "Open Results";
             
                this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

                // button2
                // 
                this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.button2.Location = new System.Drawing.Point(71, 430);
                this.button2.Name = "button2";
                this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.button2.Size = new System.Drawing.Size(153, 41);
                this.button2.TabIndex = 7;
                this.button2.Text = "Save As... ";
                this.button2.UseVisualStyleBackColor = true;
              

                //but1      
                this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.button1.Location = new System.Drawing.Point(71, 356);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(153, 41);
                this.button1.TabIndex = 6;
                this.button1.Text = "Close";
                this.button1.UseVisualStyleBackColor = true;
              


            }
        }
        
        bool done = false;
        double pwf, q;
        public string st;
        Workbook wb = new Workbook(dade.filename);



        public void mohasebenahaii()
        { 
           
            for (int i=1;i<dade.satr;i++)
            {
           //ذخیره کردن مقدار بی در فایل
                wb.Worksheets[0].Cells[1, 7].Value = "b =";
                wb.Worksheets[0].Cells[1, 8].Value = Math.Round(dade.b, 4);

                //ذخیره کردن فشار متوسط
            wb.Worksheets[0].Cells[0, 4].Value = "EST Average P";
            pwf=double.Parse( wb.Worksheets[0].Cells[i,1].Value.ToString());
            q = double.Parse(wb.Worksheets[0].Cells[i, 2].Value.ToString());
            wb.Worksheets[0].Cells[i, 4].Value = Math.Round(pwf + q * dade.b,3);
           
            }


            //+========================================
           //کار با رشته ها



            //نام گذاری فایل جدید
            ///نکته ای که اینجا هست اینه که اگر کاربر 
            ///با پسوند 4 حرفی داده بدهد ما مجبوریم
            ///5تا کم کنیم تا نقطه هم برود
            ///اما اگر  با پسوند 3 تایی یعنی
            ///xls
            ///داده بدهد و ما 5 تا کم کنیم یکی از نام فایل میزنیم
            ///و در مواقعی که کل نام فایل 5 تا است دچار مشکل شویم
            ///پس به یک اگر نیاز داریم که
            ///بفهمد کاربر از چه نوع پسوندی استفاده کرده است
            ///


            //استفاده از
            //replace

            //ابتدا اونهایی که 4 تایی اند 3 تایی میکنم
            st=dade.filename.Replace(".xlsx",".xls");


            // الان همه سه تایی اند که من 4 تاییشون میکنم
            // میدونی اگه یک دونه
            //replace
            //مینوشتم چی میشد؟؟
            st=st.Replace(".xls",".xlsx");

            st=dade.filename.Substring(0, st.Length - 5);

            // یا به جای این همه کار میشد از 
            //remove
            //هم استفاده کرد


            //ذخیره کردن قایل نهایی
            //اگر باز باشد این فایل خطا میدهد
            //پس به کار میگویم آن را ببند و دوباره تلاش کن
            try
            {
                wb.Save(st + "-DMBE.xlsx");
                textBox1.Text = st + "-DMBE.xlsx";
                dade.filenamenahaii = st + "-DMBE.xlsx";
            }
            catch
            {

                if (dade.englishlang)
                {
                    MessageBox.Show("Close this File and Run this Section Again==> " + st + "-DMBE.xls");
                }
                else
                {

                    MessageBox.Show("  باز  است.   فایل را بسته، از صفحه ی جاری خارج شوید و دوباره این صفحه را باز کنید " + st + "-DMBE.xls" + " فایل");
                }
            }
        }


        public void nemaieshnahaii() 
        {

            ///تنظیم نوشته های مربوط تمام شدن کار
            label3.Visible = false;
            label2.Visible = true;
            label1.Visible = true;
          textBox1.Visible=true;
          button1.Visible = true;
          button2.Visible = true;
          linkLabel1.Visible = true;
            //فراخوانی داده ها و نمایش آنها در  سمت چپ
              DataTable dt = new DataTable();
            
            dt= wb.Worksheets[0].Cells.ExportDataTable(1, 0, 
                       wb.Worksheets[0].Cells.Count/5-1, 5);

           
            dataGridView1.DataSource = dt;


            //نامگذاری هدر گرید ویو

                    dataGridView1.Columns[0].HeaderText = "TIME";
                    dataGridView1.Columns[1].HeaderText = "Flowing Pressure";
                    dataGridView1.Columns[2].HeaderText = "Q";
                    dataGridView1.Columns[3].HeaderText = "NP";
                    dataGridView1.Columns[4].HeaderText = "Estimated Average Pressure";

        }

       

      


        private void timer1_Tick_1(object sender, EventArgs e)
        {
        ///تنظیم سرعت حرکت نوار
        ///

          int progrestime = 30/(dataGridView1.RowCount+1)+1;
            
            progressBar1.Increment(progrestime);
            if (progressBar1.Value == 100)
            {
                done = true;
                timer1.Enabled = false;
                mohasebenahaii();
                nemaieshnahaii();
                dade.stage3 = true;

                //اینها برای اینه که یک لحظه فرم اصلی فعال بشه تا رنگ دکمه سبز بشه
                this.Hide();
                this.Show();
                this.BringToFront();



            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(st + "-DMBE.xlsx");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void calculation_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            this.Hide();
        }

        private void calculation_form_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            try
            {
                wb.Save(saveFileDialog1.FileName);
            }
            catch
            { }
        }

        private void calculation_form_Activated(object sender, EventArgs e)
        {
            setlang();
        }
    }
}

   