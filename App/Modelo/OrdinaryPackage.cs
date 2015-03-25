using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class OrdinaryPackage : Package
    {
        #region "Atributos"
        private int days = 3;

       
        #endregion

        #region "Propiedades"
        public int Days
        {
            get { return days; }
            set { days = value; }
        }
        #endregion

        #region "Constructores"
        public OrdinaryPackage () : base()
        {
            this.days = 0;
        }

        public OrdinaryPackage (string code, Person sender, Person recipients, double weight, double cost, int days)
            : base (code, sender, recipients, weight, cost)
        {
            this.days = days;
        }
        #endregion

        #region "Metodos SobreEscritos
        public override string ToString()
        {
            return base.ToString() +
                "\n Days: " + this.days +
                "\n _____________________";
        }

        public override bool Equals(object obj)
        {
            OrdinaryPackage or = (OrdinaryPackage)obj;
            bool result = false;

            if (base.Equals(or) && (this.days == or.days))
                result = true;
                    return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region "Métodos"
        
        public double calculateCost()
        {
            return (base.Weight * base.Cost);
        }
        
        #endregion
    }
}