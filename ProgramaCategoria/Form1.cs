using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCategoria
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txtIdade.Clear();
			txtNome.Clear();
			txtResultado.Clear();
		}

		private void btnVerificar_Click(object sender, EventArgs e)
		{
			int idade;
			

			idade= Convert.ToInt32(txtIdade.Text);

			if (idade < 6)
			{
				txtResultado.Text = "Essa pessoa ainda é pequena demais para jogar.";


			}else 
			if(idade<=7){
				txtResultado.Text = "Chupetinha";
			}else
			if (idade <= 9)
			{
				txtResultado.Text = "Fraldinha";
			}else
			if (idade <= 11)
			{
				txtResultado.Text = "Pré-Mirim";
			}
			else
			if (idade <= 13)
			{
				txtResultado.Text = "Mirim";
			}
			else
			if (idade <= 15)
			{
				txtResultado.Text = "infantil";
			}
			else
			if (idade <= 17)
			{
				txtResultado.Text = "Juvenil";
			}
			else
			if (idade <= 39)
			{
				txtResultado.Text = "Adulto";
			}
			else
			if (idade <= 49)
			{
				txtResultado.Text = "Master";
			}
			else
			{
				txtResultado.Text = "Sênior";
			}
			
		
		}
	}
}
