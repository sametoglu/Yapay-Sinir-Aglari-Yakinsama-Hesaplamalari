using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapay_sinir_ağları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int j = 0; j < 7; j++)/*j=8 di*/
            {
                
                dgw_sonucekranı.Rows.Add();
            }
            

        }
        int x1, x2, x3, y, xx1, xx2, xx3, yy;
        double w11, w12, w21, w22, w31, w32, w13, w23, wb1, wb2, wb3;
        double ww11, ww12, ww21, ww22, ww31, ww32, ww13, ww23, wwb1, wwb2, wwb3, testYDegeri;
        int xb = 1;
        double F1, F2, F3;
        double net1, net2, net3;
        double E = 0.0;
        double hataDegeri;
        int a = 1;
        double d1, d2, d3;
        double deltaW11, delataW12, delataW21, delataW22, delataW31, delataW32, delataW13, delataW23, delataWb1, delataWb2, delataWb3;
        int epok;
        int test;
        int ii, j, l = 0;

        int sayac = 0;
        int sayac2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            rb_satır1.Checked = false;
            rb_satır2.Checked = false;
            rb_satır3.Checked = false;
            rb_satır4.Checked = false;
            rb_satır5.Checked = false;
            rb_satır6.Checked = false;
            rb_satır7.Checked = false;
            rb_satır8.Checked = false;
            timer1.Start();

        }

        private void btn_degerata_Click(object sender, EventArgs e)
        {
            w11 = double.Parse(tb_w11.Text);
            w12 = double.Parse(tb_w12.Text);
            w21 = double.Parse(tb_w21.Text);
            w22 = double.Parse(tb_w22.Text);
            w31 = double.Parse(tb_w31.Text);
            w32 = double.Parse(tb_w32.Text);
            w13 = double.Parse(tb_w13.Text);
            w23 = double.Parse(tb_w23.Text);
            wb1 = double.Parse(tb_wb1.Text);
            wb2 = double.Parse(tb_wb2.Text);
            wb3 = double.Parse(tb_wb3.Text);
            MessageBox.Show("degerler atandi");

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {



                //epok Değeri
                if (tb_epokdegeri.Text == "")
                    epok = 1;
                else
                    epok = Convert.ToInt32(tb_epokdegeri.Text);

                if (rb_satır1.Checked == true)
                    test = Convert.ToInt32(rb_satır1.Text);
                if (rb_satır2.Checked == true)
                    test = Convert.ToInt32(rb_satır2.Text);
                if (rb_satır3.Checked == true)
                    test = Convert.ToInt32(rb_satır3.Text);
                if (rb_satır4.Checked == true)
                    test = Convert.ToInt32(rb_satır4.Text);
                if (rb_satır5.Checked == true)
                    test = Convert.ToInt32(rb_satır5.Text);
                if (rb_satır6.Checked == true)
                    test = Convert.ToInt32(rb_satır6.Text);
                if (rb_satır7.Checked == true)
                    test = Convert.ToInt32(rb_satır7.Text);
                if (rb_satır8.Checked == true)
                    test = Convert.ToInt32(rb_satır8.Text);

             //hataDegeri = Convert.ToDouble(textBox2.Text);

            //X1,X2,X3 değerleri 

                MessageBox.Show(ii + ":" + ":" + j + ":" + l + ":" + sayac);

            for (ii = 0; ii < 2; ii++)
                {

                    for (j = 0; j < 2; j++)
                    {

                        for (l = 0; l < 2; l++)
                        {
                            dgw_sonucekranı.Rows[sayac].Cells[0].Value = ii;
                            dgw_sonucekranı.Rows[sayac].Cells[1].Value = j;
                            dgw_sonucekranı.Rows[sayac].Cells[2].Value = l;
                        
                        sayac++;
                        }

                    }

                }
            MessageBox.Show(ii + ":" + ":" + j + ":" + l + ":" + sayac);

                dgw_sonucekranı.Rows[0].Cells[3].Value = w11;
                dgw_sonucekranı.Rows[0].Cells[4].Value = w12;
                dgw_sonucekranı.Rows[0].Cells[5].Value = w21;
                dgw_sonucekranı.Rows[0].Cells[6].Value = w22;
                dgw_sonucekranı.Rows[0].Cells[7].Value = w31;
                dgw_sonucekranı.Rows[0].Cells[8].Value = w32;
                dgw_sonucekranı.Rows[0].Cells[9].Value = w13;
                dgw_sonucekranı.Rows[0].Cells[10].Value = w23;
                dgw_sonucekranı.Rows[0].Cells[11].Value = wb1;
                dgw_sonucekranı.Rows[0].Cells[12].Value = wb2;
                dgw_sonucekranı.Rows[0].Cells[13].Value = wb3;


                x1 = Convert.ToInt32(dgw_sonucekranı.Rows[0].Cells[0].Value);
                x2 = Convert.ToInt32(dgw_sonucekranı.Rows[0].Cells[1].Value);
                x3 = Convert.ToInt32(dgw_sonucekranı.Rows[0].Cells[2].Value);
                w11 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[3].Value);
                w12 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[4].Value);
                w21 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[5].Value);
                w22 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[6].Value);
                w31 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[7].Value);
                w32 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[8].Value);
                w13 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[9].Value);
                w23 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[10].Value);
                wb1 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[11].Value);
                wb2 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[12].Value);
                wb3 = Convert.ToDouble(dgw_sonucekranı.Rows[0].Cells[13].Value);

                //epok işlemi
                for (int k = 0; k < epok; k++)
                {

                    //int sayac = 0;
                    int sayac2 = 0;
                    for (int i = 0; i < 8; i++)
                    {

                        x1 = Convert.ToInt32(dgw_sonucekranı.Rows[i].Cells[0].Value);
                        x2 = Convert.ToInt32(dgw_sonucekranı.Rows[i].Cells[1].Value);
                        x3 = Convert.ToInt32(dgw_sonucekranı.Rows[i].Cells[2].Value);

                        // Verilen Y değerleri
                        if (sayac2 == 1 || sayac2 == 6 || sayac2 == 7)
                            dgw_sonucekranı.Rows[sayac2].Cells[14].Value = 1;
                        else
                            dgw_sonucekranı.Rows[sayac2].Cells[14].Value = 0;

                        y = Convert.ToInt32(dgw_sonucekranı.Rows[sayac2].Cells[14].Value);
                        sayac2++;


                        //test işlemi için

                        if (i == test - 1)
                        {
                            //net1 = (x1 * w11 + x2 * w21 + x3 * w31 + xb * wb1);
                            //F1 = 1 / (1 + (Math.Exp(-net1)));

                            //net2 = (x1 * w12 + x2 * w22 + x3 * w32 + xb * wb2);
                            //F2 = 1 / (1 + (Math.Exp(-net2)));

                            //net3 = (F1 * w13 + F2 * w23 + xb * wb3);
                            //F3 = 1 / (1 + (Math.Exp(-net3)));

                            //dgw_sonucekranı.Rows[i].Cells[15].Value = F3;

                            xx1 = x1;
                            xx2 = x2;
                            xx3 = x3;
                            yy = y;


                        }

                        // kaydırma

                        if (i == test - 1)
                            continue;


                        dgw_sonucekranı.Rows[i].Cells[3].Value = w11;
                        dgw_sonucekranı.Rows[i].Cells[4].Value = w12;
                        dgw_sonucekranı.Rows[i].Cells[5].Value = w21;
                        dgw_sonucekranı.Rows[i].Cells[6].Value = w22;
                        dgw_sonucekranı.Rows[i].Cells[7].Value = w31;
                        dgw_sonucekranı.Rows[i].Cells[8].Value = w32;
                        dgw_sonucekranı.Rows[i].Cells[9].Value = w13;
                        dgw_sonucekranı.Rows[i].Cells[10].Value = w23;
                        dgw_sonucekranı.Rows[i].Cells[11].Value = wb1;
                        dgw_sonucekranı.Rows[i].Cells[12].Value = wb2;
                        dgw_sonucekranı.Rows[i].Cells[13].Value = wb3;


                        net1 = (x1 * w11 + x2 * w21 + x3 * w31 + xb * wb1);
                        F1 = 1 / (1 + (Math.Exp(-net1)));

                        net2 = (x1 * w12 + x2 * w22 + x3 * w32 + xb * wb2);
                        F2 = 1 / (1 + (Math.Exp(-net2)));

                        net3 = (F1 * w13 + F2 * w23 + xb * wb3);
                        F3 = 1 / (1 + (Math.Exp(-net3)));

                        dgw_sonucekranı.Rows[i].Cells[15].Value = F3;

                        //Hata Değeri ile Hesaplama 
                        E = E + (0.5) * (y - F3) * (y - F3);

                        if (E < hataDegeri)
                        {
                            break;
                        }

                        d3 = F3 * (1 - F3) * (y - F3);

                        delataWb3 = a * d3 * xb;
                        wb3 = wb3 + delataWb3;

                        delataW13 = a * d3 * F1;
                        w13 = w13 + delataW13;

                        delataW23 = a * d3 * F2;
                        w23 = w23 + delataW23;



                        d1 = F1 * (1 - F1) * w13 * d3;

                        delataWb1 = a * d1 * xb;
                        wb1 = wb1 + delataWb1;
                        deltaW11 = a * d1 * x1;
                        w11 = w11 + deltaW11;
                        delataW21 = a * d1 * x2;
                        w21 = w21 + delataW21;
                        delataW31 = a * d1 * x3;
                        w31 = w31 + delataW31;


                        d2 = F2 * (1 - F2) * w23 * d3;

                        delataWb2 = a * d2 * xb;
                        wb2 = wb2 + delataWb2;
                        delataW12 = a * d2 * x1;
                        w12 = w12 + delataW12;
                        delataW22 = a * d2 * x2;
                        w22 = w22 + delataW22;
                        delataW32 = a * d2 * x3;
                        w32 = w32 + delataW32;




                    if (i == 7)
                        {

                            net1 = (xx1 * w11 + xx2 * w21 + xx3 * w31 + xb * wb1);
                            F1 = 1 / (1 + (Math.Exp(-net1)));

                            net2 = (xx1 * w12 + xx2 * w22 + xx3 * w32 + xb * wb2);
                            F2 = 1 / (1 + (Math.Exp(-net2)));

                            net3 = (F1 * w13 + F2 * w23 + xb * wb3);
                            F3 = 1 / (1 + (Math.Exp(-net3)));


                            testYDegeri = F3;
                        }


                    // test y degeri atama

                                if (rb_satır1.Checked == true)
                                    dgw_sonucekranı.Rows[test - 1].Cells[15].Value = testYDegeri;
                                if (rb_satır2.Checked == true)
                                    dgw_sonucekranı.Rows[test - 1].Cells[15].Value = testYDegeri;
                                if (rb_satır3.Checked == true)
                                    dgw_sonucekranı.Rows[test - 1].Cells[15].Value = testYDegeri;
                                if (rb_satır4.Checked == true)
                                    dgw_sonucekranı.Rows[test - 1].Cells[15].Value = testYDegeri;
                                if (rb_satır5.Checked == true)
                                    dgw_sonucekranı.Rows[test - 1].Cells[15].Value = testYDegeri;
                                if (rb_satır6.Checked == true)
                                    dgw_sonucekranı.Rows[test - 1].Cells[15].Value = testYDegeri;
                                if (rb_satır7.Checked == true)
                                    dgw_sonucekranı.Rows[test - 1].Cells[15].Value = testYDegeri;
                                if (rb_satır8.Checked == true)
                                    dgw_sonucekranı.Rows[test - 1].Cells[15].Value = testYDegeri;

                    }
                }


               


            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text=DateTime.Now.Hour + ":" + DateTime.Now.Minute+" : "+DateTime.Now.Second;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ii + ":" + ":" + j + ":" + l + ":" + sayac);
            /*hata yukarıda ki degerlerin birikmesi ile oluyordu galiba düzeldi.*/
            /*makine ögrenmesi yapay sinir agları projesi*/

            for (j = 0; j < 8; j++)
            {

                for (l = 0; l < 16; l++)
                {
                    dgw_sonucekranı.Rows[j].Cells[l].Value = dgw_sonucekranı.RowsDefaultCellStyle.NullValue;


                }

            }
            ii = 0;
            j = 0;
            l = 0;
            sayac = 0;
            w11 = 0;
            w12 = 0;
            w13 = 0;
            w21 = 0;
            w22 = 0;
            w31 = 0;
            w32 = 0;
            w13 = 0;
            w23 = 0;
            wb1 = 0;
            wb2 = 0;
            wb3 = 0;
            x1 = 0;
            x2 = 0;
            x3 = 0;
                

            //MessageBox.Show(ii + ":" + ":" + j + ":" + l + ":" + sayac);
            //MessageBox.Show(dgw_sonucekranı.Rows[sayac].Cells[0].Value.ToString());
            //MessageBox.Show(dgw_sonucekranı.Rows[sayac].Cells[1].Value.ToString());
            //MessageBox.Show(dgw_sonucekranı.Rows[sayac].Cells[2].Value.ToString());


        }

        }
    }

