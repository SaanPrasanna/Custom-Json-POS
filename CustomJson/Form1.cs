using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Root json = new Root {
                Total=1150,
                GrandTotal=1150,
                CustomerInfo = new CustomerInfo{Address1 ="Address 1",Address2="Address 2",Phone="01234456789"},
                BillSummary = new List<BillSummary> { new BillSummary {Key ="Shopping",Value =10.00} },
                Header= new Header {HotelName="Demo Name",Phone="0123456789",Address= "මීගමු පාර‍,කුරුණැගල‍", City="කුරුණෑගල",BillNo="INVO0001",DateOfBill="2020-02-20",FssaiNo="",FSSAI= 12345678901234,CustomerRemarks="",OrderNote=""},
                Items = new List<Item> { new Item { No = "1", ItemAmt = 350, ItemName = "තේ කොල 1Kg", Qty = 1, Rate = "" },new Item { No = "2", ItemAmt = 200, ItemName = "මැගී නූඩ්ල්ස් චිකන්", Qty = 4, Rate = "" } },
                Settings = new Settings {PrinterName="Canon TS200 series",PrinterType="Default",ItemLength=40,PrintLogo=true,ThankYouNote="Thank you for choosing to order from us",Eidrmk="Thank you",PrintType="Cash"}
            };
            String jsonString = JsonConvert.SerializeObject(json,Formatting.None,new JsonSerializerSettings { NullValueHandling=NullValueHandling.Ignore,Formatting=Formatting.Indented});
            Console.WriteLine(jsonString);
            System.IO.File.WriteAllText(@"sample.txt", jsonString);
        }

    }
    public partial class Root
    {
        public double Total { get; set; }
        public double GrandTotal { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public List<BillSummary> BillSummary { get; set; }
        public Header Header { get; set; }
        public List<Item> Items { get; set; }
        public Settings Settings { get; set; }
    }

    public partial class BillSummary
    {
        public string Key { get; set; }
        public double Value { get; set; }
    }

    public partial class CustomerInfo
    {
        public String Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
    }

    public partial class Header
    {
        public string HotelName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public String BillNo { get; set; }
        public string DateOfBill { get; set; }
        public object Table { get; set; }
        public string FssaiNo { get; set; }
        public  Int64 FSSAI { get; set; }
        public string GstNo { get; set; }
        public string CustomerRemarks { get; set; }
        public string OrderNote { get; set; }
    }

    public partial class Item
    {
        public String No { get; set; }
        public double ItemAmt { get; set; }
        public string ItemName { get; set; }
        public int Qty { get; set; }
        public String Rate { get; set; }
    }

    public partial class Settings
    {
        public string PrinterName { get; set; }
        public string PrinterType { get; set; }
        public int ItemLength { get; set; }
        public bool PrintLogo { get; set; }
        public string ThankYouNote { get; set; }
        public string Eidrmk { get; set; }
        public string PrintType { get; set; }
    }

}
