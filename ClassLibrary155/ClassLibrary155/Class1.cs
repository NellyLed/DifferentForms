using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ClassLibrary155
{
    public class Processor
    {
        public string Stamp { get; set; }
        public double Frequency { get; set; }
        public decimal Kesh { get; set; }
        public int Cost { get; set; }
        public Processor(string stamp, double frequency, decimal kesh, int cost)
        {
            Stamp = stamp;
            Frequency = frequency;
            Kesh = kesh;
            Cost = cost;
        }

        public Processor(int cost)
        {
            Cost = cost;
        }

        public Processor()
        {
        }

        public string StampCheck(RichTextBox b1)
        {
            if (Stamp.GetTypeCode() == TypeCode.String)

                b1.Text += String.Format("Введенное значение типа марки процессора равно {0}\n", this.Stamp);
            return b1.Text;
        }

        public string FrequencyCheck(RichTextBox b2)
        {
            if (Frequency.GetTypeCode() == TypeCode.Double)
                b2.Text += String.Format("Введенное значение тактовой частоты процессора равно  {0}\n", this.Frequency);
            return b2.Text;
        }

        public string KeshCheck(RichTextBox b3)
        {
            if (Kesh.GetTypeCode() == TypeCode.Decimal)
                b3.Text += String.Format("Введенное значение объема КЭШа процессора равно {0}\n", this.Kesh);
            return b3.Text;
        }

        public string CostCheck(RichTextBox b4)
        {
            if (Cost.GetTypeCode() == TypeCode.Int32)
                b4.Text += String.Format("Введенное значение стоимости процессора равно {0}\n", this.Cost);
            return b4.Text;
        }
    }

    public class MotherBoard : Processor
    {
        public List<string> Specifications = new List<string>();
        public List<string> Formad = new List<string>();
        public string Socket { get; set; }
        public int Core { get; set; }
        public int Threads { get; set; }
        public int Rate { get; set; }
        public double Ram { get; set; }
        public MotherBoard(string stamp, double frequency, decimal kesh, int cost, string socket, int core, int threads, int rate, double ram)
                 : base(stamp, frequency, kesh, cost)
        {
            Socket = socket;
            Core = core;
            Threads = threads;
            Rate = rate;
            Ram = ram;
        }

        public MotherBoard() : base()
        {
        }

        public string Quantity(List<string> Specifications)
        {
            string s = "ОСНОВНЫЕ ХАРАКТЕРИСТИКИ ДАННОГО ТИПА ПРОЦЕССОРА";
            Specifications.Add(s);
            string s1 = " Гнездо процессора=";
            Specifications.Add(s1 + this.Socket);
            string s2 = "Количество ядер=";
            Specifications.Add(s2 + this.Core);
            string s3 = "Количество потоков=";
            Specifications.Add(s3 + Convert.ToString(this.Threads));
            string s4 = "Разрядность вычисления процессора=";
            string s5 = "bit";
            Specifications.Add(s4 + Convert.ToString(this.Rate) + s5);
            if (Ram.GetTypeCode() == TypeCode.Double)
            {
                string s6 = "СПЕЦИФИКАЦИЯ ПАМЯТИ ПРОЦЕССОРА";
                string s7 = "Объем оперативной памяти=";
                string s8 = "Гб";
                Specifications.Add(s6);
                Specifications.Add(s7 + Convert.ToString(this.Ram) + s8);
            }
            this.Specifications = Specifications;
            return Convert.ToString(this.Specifications);
        }

        public string Standard(List<string> Formad)
        {
            string v = "СТАНДАРТНЫЕ ХАРАКТЕРИСТИКИ ДАННОГО ТИПА ПРОЦЕССОРА";
            Formad.Add(v);
            string v1 = "Тип марки процессора";
            Formad.Add(v1 + this.Stamp);
            string v2 = "Объем тактовой частоты процессора";
            Formad.Add(v2 + Convert.ToDouble(this.Frequency));
            string v3 = "Объем КЭШа процессора";
            Formad.Add(v3 + Convert.ToDecimal(this.Kesh));
            string v4 = "Стоимость процессора";
            Formad.Add(v4 + Convert.ToInt32(this.Cost));
            this.Formad = Formad;
           return Convert.ToString(this.Formad);
        }
    }
    public interface IProcessor
    {
        string CostCheck(RichTextBox b4);
        int Quantity(List<int> Components);
    }
    public abstract class Processors
    {
        public string NameFirma { get; set; }
        public int Numbers { get; set; }
        public string Name { get; set; }
        public Processors(string nameFirma, int numbers, string name)
        {
            NameFirma = nameFirma;
            Numbers = numbers;
            Name = name;
        }
    }

    public class Management : Processors, IProcessor
    {
        List<int> Components = new List<int>();
        public int Experience { get; set; }
        public int Ageclient { get; set; }
        public int Clock { get; set; }
        public Management(string nameFirma, int numbers, string name, int clock, int experience, int ageclient) : base(nameFirma, numbers, name)
        {
            Clock = clock;
            Experience = experience;
            Ageclient = ageclient;
        }

        public string CostCheck(RichTextBox b2)
        {
            b2.Text += String.Format("Наименование фирмы: {0},ФИО менеджера:{1}\n", this.NameFirma, this.Name);
            return b2.Text;
        }

        public int Quantity(List<int> Components)
        {
            Components.Add(this.Clock);
            Components.Add(this.Numbers);
            Components.Add(this.Experience);
            Components.Add(this.Ageclient);
            this.Components = Components;
            return Convert.ToInt32(this.Components.Count());
        }
    }
    public class Computer : IProcessor
    {
        List<int> Components = new List<int>();
        public int Harddrive { get; set; }
        public int Videocard { get; set; }
        public int Motherboard { get; set; }
        public int Networkdapter { get; set; }
        public int Powersupply { get; set; }
        public int Floppydrive { get; set; }
        public int Systemunit { get; set; }
        public int Monitor { get; set; }
        public int Soundadapter { get; set; }
        public int Ram1 { get; set; }
        public int Work { get; set; }

        public Computer(int harddrive, int videocard, int motherboard, int networkdapter, int powersupply, int floppydrive, int systemunit,
           int monitor, int soundadapter, int ram1, int work)
        {
            Harddrive = harddrive;
            Videocard = videocard;
            Motherboard = motherboard;
            Networkdapter = networkdapter;
            Powersupply = powersupply;
            Floppydrive = floppydrive;
            Systemunit = systemunit;
            Monitor = monitor;
            Soundadapter = soundadapter;
            Ram1 = ram1;
            Work = work;
        }

        public int Quantity(List<int> Components)
        {
            Components.Add(this.Harddrive);
            Components.Add(this.Videocard);
            Components.Add(this.Motherboard);
            Components.Add(this.Networkdapter);
            Components.Add(this.Powersupply);
            Components.Add(this.Floppydrive);
            Components.Add(this.Systemunit);
            Components.Add(this.Monitor);
            Components.Add(this.Soundadapter);
            Components.Add(this.Ram1);
            Components.Add(this.Work);
            this.Components = Components;
            return Convert.ToInt32(this.Components.Sum());
        }

        public string CostCheck(RichTextBox b4)
        {
            int costworker = this.Work + Quantity(Components);
            b4.Text += String.Format("Полная стоимость сборки компьютера равна {0}\n", costworker);
            return b4.Text;
        }
    }
    public class Client
    {
        public string foto = @"C:\Users\LED\Desktop\1_visual\4_visual\Intel Core i9.jpg";

        public string Nameclient { get; set; }

        public string Nameshope { get; set; }

        public DateTime Data { get; set; }

        public Client(string nameclient, string nameshope, DateTime data)
        {
            Nameclient = nameclient;
            Nameshope = nameshope;
            Data = data;
        }
        public void ShowFoto(PictureBox b2)
        {
            OpenFileDialog m = new OpenFileDialog();
            if (m.ShowDialog() != DialogResult.Cancel)
            {
                Graphics d = Graphics.FromHwnd(b2.Handle);
                d.DrawImage(Image.FromFile(this.foto), new Rectangle(0, 0, b2.Width, b2.Height));
            }
        }
        public string Selected(RichTextBox b4)
        {
            b4.Text += String.Format("ФИО клиента:{0},Наименование магазина, в котором покупали процессор:{1},Дата покупки:{2}\n", this.Nameclient, this.Nameshope, this.Data);
            return b4.Text;
        }
    }
    public class Document
    {
        public Client Client { get => default; set { } }
        public List<Client> Add;
        List<string> Addit;
        public string Form { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public Document(string form, string address, string country)
        {
            Form = form;
            Address = address;
            Country = country;
        }
        public string Format(List<string> Addit)
        {
            string s1 = "Форма заполнения документа";
            Addit.Add(s1 + this.Form);
            string s2 = "Адрес магазина,в котором продавался процессор";
            Addit.Add(s2 + this.Address);
            string s3 = "Страна-производитель процессора";
            Addit.Add(s3 + this.Country);

            string s4 = "Гарантия(мес)";
            Addit.Add(s4 + this.Client);
            this.Addit = Addit;
            return Convert.ToString(this.Addit);
        }
    }
    public class Delivery
    {
        public string Agrofirm { get; set; }
        public DateTime Time { get; set; }
        public string Namefirm { get; set; }
        public Delivery(string agrofirm, DateTime time, string namefirm)
        {
            Agrofirm = agrofirm;
            Time = time;
            Namefirm = namefirm;
        }
        public int Core { get; set; }
        public Delivery(int core)
        {
            Core = core;
        }
        public override string ToString()
        {
            return String.Format("Наименование аэрофирмы, занимающейся перевозками:{0}, Время доставки :{1}, Наименование фирмы-заказчика:{2}\n", this.Agrofirm, this.Time.ToUniversalTime(),
             this.Namefirm);
        }
    }

    public class Check
    {
        public string Personal { get; set; }
        public Delivery Delivery { get => default; set { } }
        public string Condition { get; set; }
        public Check(string personal, Delivery delivery, string condition)
        {
            Personal = personal;
            Delivery = delivery;
            Condition = condition;
        }
        public override string ToString()
        {
            return String.Format(" ФИО персонала магазина,принимающего процессор: {0},Количество доставок:{1},Состояние процессора:{2}\n", this.Personal, this.Delivery, this.Condition);
        }
    }

    public class Company
    {
        public string Namecompany { get; set; }
        public int Quantity { get; set; }
        public int Guarantee { get; set; }
        public Company(string namecompany, int quantity, int guarantee)
        {
            Namecompany = namecompany;
            Quantity = quantity;
            Guarantee = guarantee;
        }

        public Company(string namecompany)
        {
            Namecompany = namecompany;
        }

        public override string ToString()
        {
            return String.Format("Наименовании компании,продающей компоненты компьютера: {0}, Количество компонентов: {1},Гарантия:{2}\n", this.Namecompany, this.Quantity, this.Guarantee);
        }
    }
    public class Accept
    {
        public string Namemail { get; set; }
        public DateTime Onetime { get; set; }
        public DateTime Twotime { get; set; }
        public Company Company { get => default; set { } }
        public Accept(string namemail, DateTime onetime, DateTime twotime, string comp)
        {
            Namemail = namemail;
            Onetime = onetime;
            Twotime = twotime;
            Company = new Company(comp);
        }
        public override string ToString()
        {
            return String.Format("Наименование компании, посылающей заказ клиенту на почту:{0}, Наименование почты,принимающей заказ:{1},Дата поступления заказа на почту:{2}, Дата принятия" +
                     " заказа клиентом:{3}\n",
                   this.Namemail, this.Company, this.Onetime, Twotime);
        }
    }
}
