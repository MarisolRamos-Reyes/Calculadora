﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2;
        string operación;
        

        private void MiMetodo_Click(object sender, EventArgs e)
        {
            double resultado;
            string textoboton = ((Button)sender).Text;
     
            switch(textoboton)
            {
                case "R":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    num1 = double.Parse(lblnumeros.Text);
                    resultado = Math.Sqrt(num1);
                    lblnumeros.Text = resultado+"";
                    break;
                case "sin":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    num1 = double.Parse(lblnumeros.Text);
                    resultado = Math.Sin(num1);
                    lblnumeros.Text = resultado + "";
                    break;
                case "cos":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    num1 = double.Parse(lblnumeros.Text);
                    resultado = Math.Cos(num1);
                    lblnumeros.Text = resultado + "";
                    break;
                case "tan":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    num1 = double.Parse(lblnumeros.Text);
                    resultado = Math.Tan(num1);
                    lblnumeros.Text = resultado + "";
                    break;
                case "log":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    num1 = double.Parse(lblnumeros.Text);
                    resultado = Math.Log(num1);
                    lblnumeros.Text = resultado + "";
                    break;
                case "Abs":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    num1 = double.Parse(lblnumeros.Text);
                    resultado = Math.Abs(num1);
                    lblnumeros.Text = resultado + "";
                    break;

                case "+":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    operación = textoboton;
                    num1 = double.Parse(lblnumeros.Text);
                    lblnumeros.Text = "";
                break;
                case "-":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    operación = textoboton;
                    num1 = double.Parse(lblnumeros.Text);
                    lblnumeros.Text = "";

                break;
                case "x":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    operación = textoboton;
                    num1 = double.Parse(lblnumeros.Text);
                    lblnumeros.Text = "";
                    break;
                case "/":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    operación = textoboton;
                    num1 = double.Parse(lblnumeros.Text);
                    lblnumeros.Text = "";
                    break;
                case "=":
                    if (lblnumeros.Text=="")
                    {
                        break;
                    }
                    switch (operación)
                    {
                        case "+":
                            num2 = double.Parse(lblnumeros.Text);
                            lblnumeros.Text = (num1 + num2) + "";
                            break;

                        case "-":
                            num2 = double.Parse(lblnumeros.Text);
                            lblnumeros.Text = (num1 - num2) + "";
                            break;
                        case "x":
                            num2 = double.Parse(lblnumeros.Text);
                            lblnumeros.Text = (num1 * num2) + "";
                            break;
                        case "/":
                            num2 = double.Parse(lblnumeros.Text);
                            lblnumeros.Text = (num1 / num2) + "";
                            break;
                            }
                    break;
                        case "Eliminar":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                         lblnumeros.Text = "";
                            break;
                        case "Borrar":
                    if (lblnumeros.Text == "")
                    {
                        return;
                    }
                    lblnumeros.Text = lblnumeros.Text.Substring(0, lblnumeros.Text.Count() - 1); ;
                            break;
                case ".":
                    if (lblnumeros.Text.IndexOf(".")==-1)
                    {
                        lblnumeros.Text += textoboton;
                    }
                    break;
                default:
                    lblnumeros.Text += textoboton;
                break;
            }
            
        } 

       
        

        
        
        
    }
}