using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace stressTool
{
    public partial class Form1 : Form
    {
        private static long isteklerSaniye = 0;
        private static long birakilaniStekler = 0;
        private static long gonderilenToplamistek = 0;
        private static long toplamAlinanBant = 0;
        private static System.Timers.Timer aTimer;
        private static string Url { set; get; }
        private DateTime baslangicSaat { get; set; }
        private DateTime bitisZaman { get; set; }
        CancellationTokenSource cts = new CancellationTokenSource();
        ParallelOptions po = new ParallelOptions();

        private void testiCalistir()
        {
            HttpClient client = new HttpClient();
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            try
            {
                
                Parallel.For(0, Int32.Parse(kullaniciSayisi.Value.ToString()), async ctr =>
                {
                    while (true)
                    {
                        Task<bool> dwnld = ProcessUrl(client);
                        bool z = await dwnld;
                    }
                });
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                cts.Dispose();
            }

        }

        private async Task<bool> ProcessUrl(HttpClient client)
        {
            try
            {
                isteklerSaniye++;
                gonderilenToplamistek++;
                var xyz = await client.GetAsync(Url);
                if (xyz.IsSuccessStatusCode)
                {
                    var conten = await xyz.Content.ReadAsStringAsync();
                    toplamAlinanBant += conten.Length;
                }
                else
                {
                    Console.WriteLine("Status Code: " + xyz.StatusCode);
                    birakilaniStekler++;
                }
                return true;
            }
            catch (Exception ex)
            {
                birakilaniStekler++;
                return false;
            }
        }

        delegate void StringArgReturningVoidDelegate(string text);

        private void SetText(string text)
        {
            if (this.saniyedeGonderileniSteklabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.saniyedeGonderileniSteklabel.Text = text;
            }
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            this.SetText("Saniyedeki istek " + isteklerSaniye + " hızında gönderme");
            isteklerSaniye = 0;
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void ResetApp()
        {
            saniyedeGonderileniSteklabel.Text = "Saniyede 0 istek hızında gönderme";
            saniyedeGonderileniSteklabel.Visible = false;
            toplamTaleplabel.Text = "Gönderilen Toplam İstek: 0";
            toplamTaleplabel.Visible = false;
            toplamZamanlabel.Text = "Toplam Süre: 0s";
            toplamZamanlabel.Visible = false;
            Birakilanisteklabel.Text = "Sunucu Tarafından Bırakılan Toplam İstekler: 0";
            Birakilanisteklabel.Visible = false;
            toplamVerilabel.Text = "Alınan Toplam Veri: 0 MB";
            toplamVerilabel.Visible = false;
            ortalamaHizlabel.Text = "Ortalama İletim Hızı: 0 MB/s";
            ortalamaHizlabel.Visible = false;
            ortalamaiSteklabel.Text = "Saniyedeki Ortalama İstek Sayısı: 0";
            ortalamaiSteklabel.Visible = false;
            baslaButton.Visible = true;
            baslaButton.Enabled = true;
            bitirButton.Visible = true;
            bitirButton.Enabled = false;
            sıfırlaButton.Visible = true;
            sıfırlaButton.Enabled = true;
            //İptal Simgesi Yapılandırması
            cts = new CancellationTokenSource();
            po = new ParallelOptions
            {
                CancellationToken = cts.Token
            };
            po.MaxDegreeOfParallelism = System.Environment.ProcessorCount * 2;

            Url = "";
            birakilaniStekler = 0;
            isteklerSaniye = 0;
            toplamAlinanBant = 0;
            gonderilenToplamistek = 0;
        }
        //public Form1()
        //{
        //    InitializeComponent();
        //}

       

        

       

        private void AverageRequestsLabel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetApp();
        }

        private void baslaButton_Click(object sender, EventArgs e)
        {
            baslaButton.Enabled = false;
            sıfırlaButton.Enabled = false;
            bool result = Uri.TryCreate(urlGir.Text, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!result)
            {
                System.Windows.Forms.MessageBox.Show("URL: http://www.FullDomainName or https://www.FullDomainName");
                baslaButton.Enabled = true;
                sıfırlaButton.Enabled = true;
                return;
            }
            if (kullaniciSayisi.Value < 1 || kullaniciSayisi.Value > 500)
            {
                System.Windows.Forms.MessageBox.Show("Kullanılacak Kullanıcı Sayısı (0,501)" + kullaniciSayisi.Value);
                baslaButton.Enabled = true;
                sıfırlaButton.Enabled = true;
                return;
            }
            Url = urlGir.Text;
            birakilaniStekler = 0;
            isteklerSaniye = 0;
            saniyedeGonderileniSteklabel.Visible = true;
            bitirButton.Enabled = true;
            baslangicSaat = DateTime.Now;
            testiCalistir();
        }

        private void bitirButton_Click(object sender, EventArgs e)
        {
            bitirButton.Enabled = false;

            

            bitisZaman = DateTime.Now;
            var TimeTaken = (bitisZaman.Subtract(baslangicSaat)).TotalSeconds;
            saniyedeGonderileniSteklabel.Visible = false;
            toplamTaleplabel.Text = "Gönderilen Toplam İstek: " + gonderilenToplamistek;
            toplamTaleplabel.Visible = true;
            toplamZamanlabel.Text = "Toplam Süre: " + $"{TimeTaken:0.#}" + " saniye";
            toplamZamanlabel.Visible = true;
            Birakilanisteklabel.Text = "Sunucu Tarafından Bırakılan Toplam İstekler: " + birakilaniStekler;
            Birakilanisteklabel.Visible = true;
            toplamVerilabel.Text = $"Alınan Toplam Veri: {(toplamAlinanBant / 1048576.0):0.##} MB";
            toplamVerilabel.Visible = true;
            ortalamaHizlabel.Text = $"Ortalama İletim Hızı: {((toplamAlinanBant / 1048576.0) / TimeTaken):0.##} MB/s";
            ortalamaHizlabel.Visible = true;
            ortalamaiSteklabel.Text = $"Saniyede Gönderilen İstekler: {(gonderilenToplamistek / TimeTaken):0.##}";
            ortalamaiSteklabel.Visible = true;
            sıfırlaButton.Visible = true;
            sıfırlaButton.Enabled = true;
            bitirButton.Visible = true;
            bitirButton.Enabled = false;
        }

        private void sıfırlaButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
