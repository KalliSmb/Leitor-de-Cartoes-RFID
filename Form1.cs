using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // using para a manipulação de ficheiros
using System.IO.Ports; // using para a manipulação das portas serial
using System.Threading; // using para criar e manipular thread

namespace Conversor_Cartão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // variáveis global
        long idDEC;
        SerialPort _serialPort;

        public void Form1_Load(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Fechada";
            lblOpenClosed.ForeColor = Color.Red;

            // criação da instância para a porta serial
            _serialPort = new SerialPort();

            // introduzir portas com e baud rate nas combo box
            PortaCom_comboBox.DataSource = SerialPort.GetPortNames();
            _serialPort.PortName = PortaCom_comboBox.Text;

            BaudRate_comboBox.SelectedIndex = 0;
            _serialPort.BaudRate = int.Parse(BaudRate_comboBox.Text);

            PortaCom_comboBox.TextChanged += (s, ev) =>
            {
                if (PortaCom_comboBox.Text != "")
                {
                    _serialPort.PortName = PortaCom_comboBox.Text;
                }
            };

            _serialPort.DataReceived += _serialPort_DataReceived;

            btnAbrirCOM.PerformClick(); // faz um click no botão abrir com
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1000); // método para esperar o programa receber o código lido antes de escrevê-lo

            // lê o código e guarda numa variável
            string message = _serialPort.ReadLine();
            _serialPort.DiscardInBuffer();

            // remove os caracteres indesejados
            message = message.Substring(1);
            message = message.Replace("\r", string.Empty);

            Invoke(new Action(() =>
            {
                txtHEX.Text = message;
                HexToDec(message);
            }));

        }

        public void HexToDec(string hexCode)
        {
            // conversão Hexadecimal para Decimal
            idDEC = Convert.ToInt64(hexCode, 16);

            var decCode = Convert.ToString(idDEC);
            lblDEC.Text = decCode;
            listBox1.Items.Add(decCode);
        }

        private void btnAbrirCOM_Click(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Aberta";
            lblOpenClosed.ForeColor = Color.Green;

            _serialPort.Open();
        }

        private void btnFecharCOM_Click(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Fechada";
            lblOpenClosed.ForeColor = Color.Red;

            _serialPort.Close();

            txtHEX.Text = "";
            lblDEC.Text = "";
        }

        public void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHEX.Text = "";
            lblDEC.Text = "";
            listBox1.Items.Clear();
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); // criação da instância para guardar o ficheiro
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "IDs_Cartões";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) // dialog para escolher o caminho do ficheiro
            {
                // ciclo para percorrer e escrever todos os itens da listbox
                foreach (var item in listBox1.Items)
                {
                    File.AppendAllLines(saveFileDialog1.FileName, new string[] { item.ToString() + " " + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") });
                }
            }
        }
    }
}
