using LinqLambdaExpression.Contexts;

namespace LinqLambdaExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwndContext db = new NorthwndContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private void button1_Click(object sender, EventArgs e)
        {
            //�ift say�lar� bul-Linq
            var ciftSayilar = from num in numbers
                              where num % 2 == 0
                              select num;

            //foreach (var item in ciftSayilar)
            //{
            //    lstListe.Items.Add(item);
            //}

            lstListe.DataSource = ciftSayilar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //�ift say�lar� bul-Lambda
            var ciftSayilar = numbers.Where(x => x % 2 == 0).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //T�m �r�nleri listeleyelim.

            var urunListesi = db.Products.ToList();
            urunListesi.ForEach(x => lstListe.Items.Add(x.ProductName));


            var productNames = from p in db.Products
                               select p.ProductName;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //�r�n Ad�, Birim Fiyat�, Kategori Ad�
            var productInfo = from p in db.Products
                              select new
                              {
                                  p.ProductName,
                                  p.UnitPrice,
                                  p.Category.CategoryName
                              };

            lstListe.DisplayMember = "ProductName";
            lstListe.DataSource = productInfo.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var orders = from o in db.Orders
                         where o.OrderDetails.Sum(x => x.Quantity) > 20
                         select new
                         {
                             SiparisID = o.OrderId,
                             MusteriAdi = o.Customer != null ? o.Customer.CompanyName : "-"
                         };

            dgwRapor.DataSource = orders.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //1998 den sonra yap�lan sipari�ler

            var list = from o in db.Orders
                       where o.OrderDate >= new DateTime(1998, 1, 1)
                       select new
                       {
                           o.CustomerId,
                           o.Customer.CompanyName,
                           o.OrderDate,
                           o.OrderId
                       };

            dgwRapor.DataSource = list.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //inner join
            //Washington da oturan (WA), m��terilerin 1997 den sonra yapm�� olduklar� sipari�ler hangileridir.

            var list = from c in db.Customers
                       where c.Region == "WA"
                       join o in db.Orders on c.CustomerId equals o.CustomerId
                       where o.OrderDate >= new DateTime(1997, 1, 1)
                       select new
                       {
                           MusteriID = c.CustomerId,
                           SiparisID = o.OrderId
                       };

            dgwRapor.DataSource = list.ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Stok miktar� 0 dan b�y�k olan ve ayn� zamanda birim fiyat� 15 dolardan fazla olan �r�nleri listeleyiniz.

            var urunList = from p in db.Products
                           where p.UnitsInStock > 0 && p.UnitPrice > 15
                           select new
                           {
                               UrunAdi = p.ProductName,
                               BirimFiyati = p.UnitPrice
                           };

            dgwRapor.DataSource = urunList.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Hangi kategoriden ka� adet �r�n�m bulunmaktad�r.

            var data = from p in db.Products
                       group p by p.Category.CategoryName into g
                       select new
                       {
                           KategoriAdi = g.Key,
                           UrunSayisi = g.Count()
                       };

            dgwRapor.DataSource = data.ToList();         
        }
    }
}
