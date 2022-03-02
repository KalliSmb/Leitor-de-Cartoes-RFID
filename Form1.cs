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
        string idHEX;
        long idDEC;
        bool _continue;
        SerialPort _serialPort;

        public void Form1_Load(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Fechada";
            lblOpenClosed.ForeColor = Color.Red;

            // criação da instância para a serial port
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
        }

        public void HexToDec()
        {
            // conversão Hexadecimal para Decimal
            idHEX = txtHEX.Text;
            idDEC = Convert.ToInt64(idHEX, 16);

            lblDEC.Text = Convert.ToString(idDEC);
        }

        public void readCard()
        {
            // criação da instância para a thread
            Thread readThread = new Thread(readCard);

            try
            {
                if (_serialPort.IsOpen)
                {
                    if (_continue == true)
                    {
                        string message = _serialPort.ReadLine();
                        message = message.Substring(1); // remove o primeiro char
                        message = message.Remove(10, 1); // a partir da posição 10, remove 1 char
                        txtHEX.Text = message;
                        HexToDec();
                    }
                    else
                    {
                        MessageBox.Show("Porta serial fechada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Guardar();
        }

        private void btnAbrirCOM_Click(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Aberta";
            lblOpenClosed.ForeColor = Color.Green;

            _serialPort.Open();
            _continue = true;
            readCard();
        }

        private void btnFecharCOM_Click(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Fechada";
            lblOpenClosed.ForeColor = Color.Red;

            _serialPort.Close();
            _continue = false;

            txtHEX.Text = "";
            lblDEC.Text = "";
        }

        public void Guardar()
        {
            /* variável que armazena o nome do ficheiro
               o ficheiro será criado na pasta de inicialização */
            string caminho = Application.StartupPath + "ID_Cartões.txt";

            // guarda os dados da lblDEC no ficheiro txt
            StreamWriter txt = File.AppendText(caminho);
            txt.WriteLine(lblDEC.Text + " " + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss"));
            txt.Close();

            // messagebox de informação para o ficheiro guardado
            MessageBox.Show("Ficheiro guardado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void btnLimpar_Click(object sender, EventArgs e)
        {
            // repõe todos os campos
            txtHEX.Text = "";
            lblDEC.Text = "";

            // reinicia as portas
            _serialPort.Close();
            _continue = false;
            _serialPort.Open();
            _continue = true;

            readCard();
        }
    }
}
