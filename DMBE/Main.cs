using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



using System.IO;

namespace DMBE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.BringToFront();
           
        }


       


        
        /// <summary>
        /// چون با نام فایل خالی نمیتواند در ابتدا فرمی باز کند باید با تابع این کار صورت گیرد 
        /// که در متن برنامه نباشد
        /// </summary>
        public void showform3()
        {

            try
            {
                Form fr3 = new calculation_form();
                fr3.Show();
            }
            catch
            {
            }

        }


        private void set_language()
        {

              //در ابتدا زبان فارسی را علامت میزند
            if (!dade.englishlang)
            {
                this.Text = "DMBE AVERAGE PRESSURE CALCULATOR";
           

                persianToolStripMenuItem.Checked = true;
                this.labelnavar.Text = "محاسبه فشار متوسط با کمک فشار جریانی ته چاهی";
                this.label8.Text = "فشار متوسط محاسبه گردید و در این فایل ذخیره شد.";
                this.label7.Text = "فشار متوسط محاسبه نشده است.";
                this.label5.Text = "b برابر است با";
                this.label4.Text = "مقدار b تعیین نشده است";
                this.label2.Text = "فایل انتخاب شده :";
                this.label1.Text = "هیچ فایلی انتخاب نشده است";

                this.button3.Text = "محاسبه فشار متوسط";
                this.button2.Text = "تعیین مقدار b";
                this.button1.Text = "ورود اطلاعات";

                //تنظیمات فارسی سازی
                Filemenu.Text = "فایل";
                helpmenu.Text = "راهنما";

                //ببین واسه تغییر چب به راست باید چه شکلی نوشت!
                menuStrip1.RightToLeft = RightToLeft.Yes;
                menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                panel1.RightToLeft = RightToLeft.No;
                labelnavar.Anchor = AnchorStyles.Left;
                //. و تغییر مکان
                labelnavar.Location = new System.Drawing.Point(150, 10);

                this.label1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label1.Location = new System.Drawing.Point(307, 109);


                this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label2.Location = new System.Drawing.Point(373, 109);

                this.label3.Font = new System.Drawing.Font("Times New Roman", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label3.Location = new System.Drawing.Point(100, 139);

                //===========================
                this.label4.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label4.Location = new System.Drawing.Point(326, 236);

                this.label5.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label5.Location = new System.Drawing.Point(400, 236);



                //=========================
                this.label7.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label7.Location = new System.Drawing.Point(281, 361);
                this.label8.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                this.label8.Location = new System.Drawing.Point(146, 361);

                //=========================
                menuStrip1.Font = new System.Drawing.Font("B Bardiya", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));


                ToolStripMenuItem_file_open.Text = "ورود اطلاعات";
                ToolStripMenuItem_file_b.Text = "تعیین b";
                ToolStripMenuItem_FILE_P.Text = "محاسبه فشار متوسط";
                ToolStripMenuItem1_file_exit.Text = "خروج";


                ToolStripMenuItem_help_about.Text = "درباره نرم افزار";
                ToolStripMenuItem_Help_open.Text = "راهنمای ورود اطلاعات";


            }
            else
          
                {
                    englishToolStripMenuItem.Checked = true;


                Filemenu.Text = "File";
                helpmenu.Text = "Help";
                

                //ببین واسه تغییر چب به راست باید چه شکلی نوشت!
                menuStrip1.RightToLeft = RightToLeft.No;
                menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                panel1.RightToLeft = RightToLeft.No;
                labelnavar.Anchor = AnchorStyles.Left;
                //. و تغییر مکان
                labelnavar.Location =  new System.Drawing.Point(10, 10);
                label1.Location = new System.Drawing.Point(50,130);
                label2.Location = new System.Drawing.Point(50, 130);
                label3.Location = new System.Drawing.Point(70, 160);

                label4.Location = new System.Drawing.Point(50, 240);
                label5.Location = new System.Drawing.Point(50, 240);
                label6.Location = new System.Drawing.Point(70, 270);

                label7.Location = new System.Drawing.Point(50, 355);
                label8.Location = new System.Drawing.Point(50, 355);

                label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                 label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                
                label1.Text = "Select a file";
                label2.Text = " Selected File is ";
                label4.Text = "b Is Not difined";
                label5.Text = " b equals to ";
                label7.Text = " No Average Pressure Calculated";
                label8.Text = " Result's have Been Saved to";
                labelnavar.Text = "Average Pressure Calculation";
 
                button1.Text = "Import Data";
                button2.Text = "b Determination";
                button3.Text = " Calculation";
                ToolStripMenuItem_file_open.Text = "Open...";
                ToolStripMenuItem_file_b.Text = "b Determination...";
                ToolStripMenuItem_FILE_P.Text = "Pressure Calculation...";
                ToolStripMenuItem1_file_exit.Text = "Exit";

                ToolStripMenuItem_help_about.Text = "About..";
                ToolStripMenuItem_Help_open.Text = "Proper Data Format..";


            }

        }

        private void Englishdisign()
        {

        }

        //هر دکمه فرم خاصی را نمایش میدهد.
          Form fr1 = new open_form();
        private void button1_Click(object sender, EventArgs e)
        {
           
            fr1.Show();
        }


        Form fr2 = new b_form();
        private void button2_Click(object sender, EventArgs e)
        {
            fr2.Show();

        }

        

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Text = "DMBE AVERAGE PRESSURE CALCULATOR";
           


        set_language();

           
           
               
          

            ///برچسب ها و رنگها را تنظیم میکند با توجه به پیشرفت کار
            if (dade.stage1)
            {
                toolStripProgressBar1.Value = 1;
                label2.Visible = true;
                label1.Visible = false;
                label3.Text = dade.filename;
                button1.BackColor = System.Drawing.Color.SpringGreen;
            }
            else
            {
                toolStripProgressBar1.Value = 0;
                label1.Visible = true;
                label2.Visible = false;
                label3.Text = "";
                this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            }
               

            

            if (dade.stage2)
            {
                toolStripProgressBar1.Value = 2;
                label5.Visible = true;
                label4.Visible = false;
                label6.Text = string.Format("{0:n4}", dade.b);

                button2.BackColor = System.Drawing.Color.SpringGreen;
            }

            else
            {
                
                label4.Visible = true;
                label5.Visible = false;
                label6.Text = "";
                this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            
            }



            if (dade.stage3)
            {
                toolStripProgressBar1.Value = 3;
                label7.Visible = false;
                label8.Visible = true;
                textBox1.Text = dade.filenamenahaii;
                textBox1.Visible = true;
                button3.BackColor = System.Drawing.Color.SpringGreen; 
            
            }
            else
            {
                this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //فایلهای موقت را پاک  میکند
            try
            {
                System.IO.File.Delete("c:\\temp.xlsx");
                File.Delete("c:\\nemoodar.xlsx");
                
            }
            catch
            { }



            ///اگر محاسبات ناقص باشد از خروج مطمین میشود
            if (!dade.stage3)
            {
                if (!dade.englishlang)
                {

                    DialogResult result = MessageBox.Show("فایل نهایی ساخته نشده است آیا خارج میشوید؟", "exit", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }

                else
                {
                    DialogResult result = MessageBox.Show("Results File's not Created.  Do You Want to exit?", "exit", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            showform3();
          
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dade.englishlang = true;
            englishToolStripMenuItem.Checked = true;
            persianToolStripMenuItem.Checked = false;
            this.Hide();
            this.Show();

        }

        private void persianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dade.englishlang = false;
            englishToolStripMenuItem.Checked = false;
            persianToolStripMenuItem.Checked = true;
            this.Hide();
            this.Show();
            this.ResetText();
        }

        private void بازکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr1.Show();
        }

        private void ذخیرهکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr2.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showform3();
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
