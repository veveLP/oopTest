using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp43
{
    public partial class Form1 : Form
    {
        public NPC npc;
        public Form1()
        {
            /*Vytvořte třídu Herní postava, která bude obsahovat:
            Vlastnost Jméno pro čtení i zápis. Vlastnost naprogramujte tak, aby se při údaji delším než 10 znaků vypsalo upozornění „Příliš dlouhé jméno!“ a hodnota se neuložila.
Veřejný atribut level inicializovaný na 1.
Vlastnost Pozice X pouze pro čtení inicializovaná na 0. 
Vlastnost Pozice Y pouze pro čtení inicializovaná na 0.
Třída bude obsahovat jediný konstruktor:
Nastaví jméno. 
Třída bude obsahovat metody:
Změna pozice - přepočítá X a Y souřadnice postavy na uživatelem zadanou hodnotu.
Přepsanou metodu ToString - vrátí text se všemi údaji.
Level UP – přidá level.
Vytvořte instanci třídy a příslušné GUI na ovládání třídy.
Odevzdejte odkaz na GitHub repozitář do classroomu.*/
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            npc = new NPC(textBox1.Text);
            button1.Enabled = false;
        }
    }
}