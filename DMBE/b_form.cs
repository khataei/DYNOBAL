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
   
    public partial class b_form : Form
    {
        public b_form()
        {
            InitializeComponent();

        }

        public void rasmmehvarha()
        {
            Graphics myg;
            myg = panel1.CreateGraphics();
           // myg.Clear(System.Drawing.Color.Black);

            /*
              myg.DrawLine(new Pen(Brushes.White, 4), 100, 50, 100, 650);
              myg.DrawLine(new Pen(Brushes.White, 4), 98, 650, 800, 650);


              myg.DrawLine(new Pen(Brushes.White, 4), 100, 50, 90 , 60);
              myg.DrawLine(new Pen(Brushes.White, 4), 100, 50, 110, 60);


              myg.DrawLine(new Pen(Brushes.White, 4), 800, 650, 790, 640);
              myg.DrawLine(new Pen(Brushes.White, 4), 800, 650, 790, 660);

              myg.DrawLine(new Pen(Brushes.Wheat, 1), 85, 150, 790, 150);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 85, 250, 790, 250);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 85, 350, 790, 350);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 85, 450, 790, 450);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 85, 550, 790, 550);


              myg.DrawLine(new Pen(Brushes.Wheat, 1), 200, 70, 200, 660);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 300, 70, 300, 660);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 400, 70, 400, 660);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 500, 70, 500, 660);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 600, 70, 600, 660);
              myg.DrawLine(new Pen(Brushes.Wheat, 1), 700, 70, 700, 660);
               /*/
            /// drawing axis

            myg.DrawLine(new Pen(Brushes.White, 4), 100, 50, 100, 650);
            myg.DrawLine(new Pen(Brushes.White, 4), 98, 650, 800, 650);

            myg.DrawLine(new Pen(Brushes.White, 4), 800, 50, 800, 650);
            myg.DrawLine(new Pen(Brushes.White, 4), 100, 50, 800, 50);

            /// define a pen for dash dot lines
            Pen mypen = new Pen(Brushes.AntiqueWhite, 0.2f);
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            float[] dash = new float[5] { 0.2f, 4, 0.5f, 1, 0.1f };
            mypen.DashPattern = dash;
            /// drawing guid lines
            /// horizontal
            myg.DrawLine(mypen, 85, 150, 810, 150);
            myg.DrawLine(mypen, 85, 250, 810, 250);
            myg.DrawLine(mypen, 85, 350, 810, 350);
            myg.DrawLine(mypen, 85, 450, 810, 450);
            myg.DrawLine(mypen, 85, 550, 810, 550);

            //vertical guide lines

            myg.DrawLine(mypen, 200, 40, 200, 660);
            myg.DrawLine(mypen, 300, 40, 300, 660);
            myg.DrawLine(mypen, 400, 40, 400, 660);
            myg.DrawLine(mypen, 500, 40, 500, 660);
            myg.DrawLine(mypen, 600, 40, 600, 660);
            myg.DrawLine(mypen, 700, 40, 700, 660);


            /// axis's label
            myg.DrawString("Np", new System.Drawing.Font("Cambria", 18.25F), Brushes.AntiqueWhite, 420, 680);
            myg.DrawLine(new Pen(Brushes.AntiqueWhite, 2), 415, 715, 470, 715);
            myg.DrawString("q", new System.Drawing.Font("Cambria", 18.25F), Brushes.AntiqueWhite, 425, 710);

            myg.DrawString("Pi-Pwf", new System.Drawing.Font("Cambria", 18.25F), Brushes.AntiqueWhite, 14, 370);
            myg.DrawLine(new Pen(Brushes.AntiqueWhite, 2), 14, 400, 87, 400);
            myg.DrawString("q", new System.Drawing.Font("Cambria", 18.25F), Brushes.AntiqueWhite, 45, 400);


        }
        public void rasmmedadeha()
        {
            Graphics myg;
            myg = panel1.CreateGraphics();
           
            ///چون داده ها در متغییر های کلاس داده ذخیره شده اند ن
            ///نیازی به فراخوانی اینها نیست
            DataTable dt = new DataTable();
            Workbook wb = new Workbook("c:\\nemoodar.xlsx");
                float[] x = new float[100];
                float[] y = new float[100];
             //محاسبه تعداد سطرها برای حلقه ها که زیادی نروند
               //اینها در کلاس داده ذخیره شده اند
            for (int i = 1; i < dade.satr; i++)
            {
                //      dade.x[i] = wb.Worksheets[0].Cells[i, 0].Value.ToString();
                //      dade.y[i] = wb.Worksheets[0].Cells[i, 1].Value.ToString();
                //  }

                x[i] = float.Parse(dade.x[i]) + 100;
                y[i] = 650f - float.Parse(dade.y[i]);
                myg.FillEllipse (Brushes.Tomato, (x[i]) - 2f , (y[i]) -1f  ,  6 , 6);
            }

        }
          public void rasmeadadekenaremehvar()
              {

              /// برای محور ایکس نقطه اول آخر همان
              /// مقاط کمترین و بیشترین است
             
                  Graphics myg;
                    myg = panel1.CreateGraphics();
                  ///برای جهت ایکس
                    double stepx;
                    stepx = (  dade.maxx-dade.minx) /7;
                    
                        for (int i = 0; i < 8; i++)
                        {
                            myg.DrawString(string.Format("{0:n2}", dade.minx + stepx * i),
                                new System.Drawing.Font("Cambria", 8.25F)
                                        , Brushes.Yellow, (90 + 100 * i), 660);
                        }

                   ///برای جهت وای
                        double stepy;
                        stepy = (dade.maxy - dade.miny) / 6;

                        for (int i = 0; i < 7; i++)
                        {
                            myg.DrawString(string.Format("{0:n2}", dade.maxy - stepy * i),
                                new System.Drawing.Font("Cambria", 8.25F)
                                        , Brushes.Yellow ,60, (50 + 100 * i) );
                        }
          }

        double bimg,b;

        public void byaftan()
        {
            yoonvarekhat = 650 - yoonvarekhat;
            yavalie = 650 - yavalie;
            xonvarekhat = xonvarekhat - 100;
            xavalie = xavalie -100;
            double m=3;
            m = (yavalie - yoonvarekhat);
            m=m/ (xavalie - xonvarekhat);
            //یافتن شیب که البته غیر ضروری است
            //textBox7.Text = m.ToString();
            bimg =  yoonvarekhat-(m* xonvarekhat)  ;
            b = dade.miny
                + (dade.maxy - dade.miny) / 600 * bimg;
 
            textBox1.Text =string.Format("{0:n4}", b);
           
        }

    
        

         
       
         

          private void button1_Click(object sender, EventArgs e)
        {
            //رفتن به فرم بعدی
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
              
            e.Cancel = true;
            this.Hide();
        }


        bool bekesh = false;
        int fiooz;
        int xavalie, yavalie,xold,yold, xonvarekhat=1, yoonvarekhat=1;

      
      
    

        
     

        private void button1_Click_1(object sender, EventArgs e)
        {
            dade.stage2 = true;
            dade.b = double.Parse(textBox1.Text);
            this.Hide();
        }






       
        private void b_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


        private void b_form_Load_1(object sender, EventArgs e)
        {

          
            timer1.Enabled = true;

            //چک میکند که کاربر مرحله قبل را انجام داده و داده ها وارد شده اند؟

            if (!dade.stage1)
            {
                if (dade.englishlang)
                {
                    MessageBox.Show("NO File has been Chosen...GO to Main Menu and Select a File");
                }
                else
                {
                    MessageBox.Show("مراحل قبلی به درستی انجام نشده است، بنابراین ممکن است برنامه کامل اجرا نشود");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rasmmehvarha();
                rasmeadadekenaremehvar();
                rasmmedadeha();
            }
            catch
            { }
        }


        private void b_form_Activated(object sender, EventArgs e)
        {


            if (dade.englishlang)
            {
                label2.Visible = false;
                label4.Visible = true;


            }
            else
            {
                label4.Visible = false;
                label2.Visible = true;
            }




            timer1.Enabled = true;
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics myg;
            myg = panel1.CreateGraphics();

            if (bekesh)
            {
                myg.DrawLine(Pens.Black, xavalie, yavalie, xold, yold);
                myg.DrawLine(Pens.Aqua, xavalie, yavalie, e.X, e.Y);
            }
            xold = e.X;
            yold = e.Y;
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

                Graphics myg;
                myg = panel1.CreateGraphics();
                bekesh = !bekesh;
                myg.Clear(Color.Black);
                rasmmehvarha();
                rasmmedadeha();
                rasmeadadekenaremehvar();
                fiooz++;
                if (fiooz % 2 == 1)
                {
                    timer1.Enabled = true;
                    xavalie = e.X;
                    yavalie = e.Y;
                    myg.FillEllipse(Brushes.Aqua, e.X - 3, e.Y - 3, 5, 5);
                }
                if (fiooz % 2 == 0)
                {
                    xonvarekhat = e.X;
                    yoonvarekhat = e.Y;

                    myg.FillEllipse(Brushes.Aqua, xavalie - 3, yavalie - 3, 5, 5);
                    myg.DrawLine(Pens.Aqua, xavalie, yavalie, e.X, e.Y);
                    myg.FillEllipse(Brushes.Aqua, e.X - 3, e.Y - 3, 5, 5);
                    byaftan();
                    timer1.Enabled = false;
                }
            }
            catch
            { }
        }
        



    }
}
