using System;
using System.Windows.Forms;

namespace WindowsFormsApp43
{
    public class NPC
    {
        /*Vlastnost Jméno pro čtení i zápis. Vlastnost naprogramujte tak, aby se při údaji delším než 10 znaků vypsalo upozornění „Příliš dlouhé jméno!“ a hodnota se neuložila.
Veřejný atribut level inicializovaný na 1.
Vlastnost Pozice X pouze pro čtení inicializovaná na 0. 
Vlastnost Pozice Y pouze pro čtení inicializovaná na 0.*/
        private String jmeno;
        private int level;
        private int x;
        private int y;

        public NPC(string jmeno)
        {
            setJmeno(jmeno);
            this.level = 1;
            this.x = 0;
            this.y = 0;
        }

        public void setJmeno(String jmeno)
        {
            if (jmeno.Length > 10)
            {
                MessageBox.Show("Příliš dlouhé jméno!");
                return;
            }

            this.jmeno = jmeno;
        }

        public int getY()
        {
            return y;
        }

        public int getX()
        {
            return x;
        }

        public void zmenaPozice(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void levelUp()
        {
            this.level++;
        }

        public override string ToString()
        {
            return ("jmeno:" + jmeno + ", level:" + level + ", X:" + x + ", Y:" + y);
        }
    }
}