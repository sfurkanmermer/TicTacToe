using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XoX_Oyunu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("X olarak adlandırılacak ilk oyuncu, ilk dönüş sırasında işaretlemek için 3 olası pozisyona sahiptir. Yüzeysel olarak, ızgaradaki 9 kareye karşılık gelen 9 olası konumun olduğu görülmektedir. Ancak, tahtayı döndürerek, ilk dönüşte her köşe işaretinin stratejik olarak diğer tüm köşe işaretlerine eşdeğer olduğunu göreceğiz. Aynısı her kenar (yan orta) işareti için geçerlidir. Strateji amaçlı olarak, sadece üç olası ilk işaret vardır: köşe, kenar veya merkez. Oyuncu X, bu başlangıç ​​işaretlerinden herhangi birinden bir çek kazanabilir veya zorlayabilir; Ancak, köşeyi oynatmak, rakibin kaybedilmemesi için oynanması gereken en küçük kareler seçimini sağlar.  Bu, köşenin X için en iyi açılış hareketi olduğunu gösterebilir, ancak başka bir çalışma , eğer oyuncular mükemmel değilse, merkezdeki bir açılış hareketinin X için en iyi olduğunu gösterir. O olarak adlandırılacak ikinci oyuncu, zorlu galibiyetin önüne geçmek için X in açılış işaretine cevap vermelidir. Oyuncu O, her zaman bir merkez işareti bulunan bir köşe açıklığına ve köşe işaretli bir orta açıklığa tepki vermelidir. Bir kenar açıklığı, bir orta işareti, X'in yanında bir köşe işareti veya X'in karşısındaki bir kenar işareti ile yanıtlanmalıdır. Diğer tüm yanıtlar, X'in kazanmayı zorlamasına izin verecektir.Açılış tamamlandığında, O'nun görevi, çekmeyi zorlamak için yukarıdaki öncelikler listesini veya X'in zayıf bir oyun oynaması durumunda bir kazanç elde etmektir.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
