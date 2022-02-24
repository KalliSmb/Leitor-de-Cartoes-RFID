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
        static bool _continue;
        static SerialPort _serialPort;

        /* variável que armazena o nome do ficheiro
           o ficheiro será criado na pasta de inicialização "bin/debug" */
        string caminho = Application.StartupPath + "ID_Cartões.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Fechada";
            lblOpenClosed.ForeColor = Color.Red;

            _serialPort = new SerialPort();

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // repõe todos os campos
            txtHEX.Text = "";
            lblDEC.Text = "";

            Terminar_button_Click(sender, e);
            Iniciar_button_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // verifica se o hex foi convertido
            if (lblDEC.Text != "")
            {
                // guarda os dados da lblDEC no ficheiro txt
                StreamWriter txt = File.AppendText(caminho);
                txt.WriteLine("ID: " + lblDEC.Text + "\r\n" + DateTime.UtcNow.ToString() + "\r\n");
                txt.Close();

                // messagebox de informação para o ficheiro guardado
                MessageBox.Show("Ficheiro guardado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // messagebox de aviso para o campo não preenchido
                MessageBox.Show("Hexadecimal não convertido.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void Iniciar_button_Click(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Aberta";
            lblOpenClosed.ForeColor = Color.Green;

            _serialPort.Open();
            _continue = true;
            readCard();
        }

        private void Terminar_button_Click(object sender, EventArgs e)
        {
            lblOpenClosed.Text = "Fechada";
            lblOpenClosed.ForeColor = Color.Red;

            _serialPort.Close();
            _continue = false;
        }

        private void readCard()
        {
            Thread readThread = new Thread(readCard);

            try
            {
                if (!_serialPort.IsOpen)
                {
                    MessageBox.Show("Porta serial fechada!");
                }

                else if (_serialPort.IsOpen)
                {
                    if (_continue == true)
                    {
                        string message = _serialPort.ReadLine();
                        message = message.Substring(1); // remove o primeiro char
                        message = message.Remove(10, 1); // a partir da posição 10, remove 1 char
                        txtHEX.Text = message;
                        Console.WriteLine(message);
                        HexToDec();
                    }
                    else
                    {
                        _serialPort.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HexToDec()
        {
            idHEX = txtHEX.Text;
            idDEC = Convert.ToInt64(idHEX, 16);

            lblDEC.Text = Convert.ToString(idDEC);
        }

        /*public void OpenClosed()
        {
            if (_serialPort.IsOpen)
            {
                lblOpenClosed.Text = "Aberta";
                lblOpenClosed.ForeColor = Color.Green;
            }

            else if (!_serialPort.IsOpen)
            {
                lblOpenClosed.Text = "Fechada";
                lblOpenClosed.ForeColor = Color.Red;
            }
        }*/
    }
}
