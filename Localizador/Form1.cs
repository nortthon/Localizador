using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Remoting.Contexts;
using System.Net;

namespace Localizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum tipoXML 
        {
            CEP,
            IP
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep = mtxtCEP.Text;
            if(!string.IsNullOrEmpty(cep) && cep.Length >= 8)
                buscarCEP(cep);
            else
                MessageBox.Show("CEP Inválido");
        }

        private void buscarCEP(string CEP)
        {
            string XML = getXML(tipoXML.CEP, CEP);
            DataSet dsCep = new DataSet();
            try
            {
                dsCep.ReadXml(XML);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar a web. "+ex.Message);
                XmlTextReader reader = new XmlTextReader(@"C:\Documents and Settings\aluno\Meus documentos\Visual Studio 2008\Projects\Localizador\Localizador\XMLs\CEP.xml");
                dsCep.ReadXml(reader);
                throw;
            }
            
            if (dsCep != null)
            {
                txtEndereco.Text = dsCep.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + dsCep.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dsCep.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dsCep.Tables[0].Rows[0]["cidade"].ToString();
                txtUF.Text = dsCep.Tables[0].Rows[0]["uf"].ToString();
            }
        }

        private string getXML(tipoXML tipoXML, string variavel)
        {
            string ret = string.Empty;
            try
            {
                switch (tipoXML)
                {
                    case tipoXML.CEP:
                        ret = "http://cep.republicavirtual.com.br/web_cep.php?cep=" + variavel + "&formato=xml";
                        break;
                    case tipoXML.IP:
                        ret = "http://freegeoip.appspot.com/xml/" + variavel;
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = mtxtIP.Text;
            if (!string.IsNullOrEmpty(ip))
                buscarIP(ip);
            else
                MessageBox.Show("IP Inválido");
            
            buscarIP(mtxtIP.Text);
        }

        private void buscarIP(string IP)
        {
            WebBrowser wbWs = new WebBrowser();

            string XML = getXML(tipoXML.IP, IP);
            DataSet dsCep = new DataSet();

            try
            {
                dsCep.ReadXml(XML);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar a web. "+ex.Message);
                XmlTextReader reader = new XmlTextReader(@"C:\Documents and Settings\aluno\Meus documentos\Visual Studio 2008\Projects\Localizador\Localizador\XMLs\IP.xml");
                dsCep.ReadXml(reader);
                throw;
            }
            
            if (dsCep != null)
            {                
                txtIPCidade.Text = dsCep.Tables[0].Rows[0]["City"].ToString();
                txtIPUF.Text = dsCep.Tables[0].Rows[0]["RegionCode"].ToString();
                txtIPPais.Text = dsCep.Tables[0].Rows[0]["CountryName"].ToString();
                if (!string.IsNullOrEmpty(dsCep.Tables[0].Rows[0]["ZipCode"].ToString()))
                    mtxtCEP.Text = dsCep.Tables[0].Rows[0]["ZipCode"].ToString();
            }

        }

        private void btnIPLocal_Click(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostByName(Dns.GetHostName());
            string IP = he.AddressList[0].ToString();
            mtxtIP.Text = IP;
            buscarIP(IP);
        }

    }
}
