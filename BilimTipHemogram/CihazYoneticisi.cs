using System;
using System.IO.Ports;


namespace BilimTipHemogram
{
    class CihazYoneticisi
    {
        private SerialPort mySerialPort;
        public CihazYoneticisi(SerialPort _mySerialPort)
        {
            mySerialPort = _mySerialPort;
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();

            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            OlcumSonucKaydet(indata);
        }

        private void OlcumSonucKaydet(string sonucString)
        {
            OlcumSonuc sonuc = new OlcumSonuc(sonucString, DateTime.Now);
            using (BilimTipHemogramEntities db = new BilimTipHemogramEntities())
            {
                db.OlcumSonuc.Add(sonuc);
                db.SaveChanges();
            }
        }
                
    }   
}
