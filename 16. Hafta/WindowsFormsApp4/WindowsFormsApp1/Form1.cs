using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //#region Constructors
            //ClassBase cb = new ClassBase("Ercan", "Uykan");

            //ChildClass c1 = new ChildClass("Ercan"
            //    , "Uykan");
            //c1.Adı = "levent";
            //c1.Soyadı = "sendinç";
            //c1.Durumu = "Çalışıyor";

            //Child1Class c2 = new Child1Class("f", "şl");
            //c2.Adı = "Emir Buğra";
            //c2.Soyadı = "Sendinç";
            //c2.test = "Yapıldı";
            //#endregion

            //#region 2 soru 
            //Fenerbahce fb = new Fenerbahce();
            //fb.Adı = "levent";
            //fb.degeri =1000;
            //fb.Soyadı = "Sendinç";
            //galatasaray gs = new galatasaray();
            //gs.Adı = "Emir";
            //gs.Soyadı = "Sendinç";
            //gs.durumu = "Devam ediyor";
            //besiktas bsk = new besiktas();
            //bsk.Adı = "Buğra";
            //bsk.Soyadı = "Sendinç";
            //bsk.mevkiisi = "Kaleci";
            //#endregion

            //#region 3 soru interface 3 adet , abstract 1 adet ve class 5 adet
            //Interface3 cl1 = new Class1();
            //Class2 cl2 = new Class2();
            //Class3 cl3 = new Class3();
            //Class4 cl4 = new Class4();
            //Class5 cl5 = new Class5();
            ////cl1.adı = "levent";
            ////cl1.soyadı = "Sendinç";

            //cl2.adı = "levent";
            //cl2.soyadı = "Sendinç";

            //cl3.adı = "levent";
            //cl3.soyadı = "Sendinç";

            //cl4.adı = "levent";
            //cl4.soyadı = "Sendinç";

            //cl5.adı = "levent";
            //cl5.soyadı = "Sendinç";

            //cl1.find();
            //cl2.update();
            //cl3.select();
            //cl4.delete();

            //#endregion

            string mesaj = Statikclass.Deneme(false);

            mesaj.GetFirstThreeCharacters();

            int value = 10;
            value.GetMod();

            var result = mesaj.Contains("K");


        }


    }
}
