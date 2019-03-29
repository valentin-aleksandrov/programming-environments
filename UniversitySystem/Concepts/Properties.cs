using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    class Properties
    {
        private string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
        }

    
        public int Age 
        {get; set;}

        public int Height {get; set;}
        private int weight;
        public int Weight 
        {
            get { return weight * 10;}
            set
            {
                if (value > 0) {weight = value;}
                else { weight = -1;}
            }
        }

        public string HairColour {get; set;}
        private int iq;
        public int IQ
        {
            get {return iq;}
            set
            {
                if (value > 500) { iq = 120; }
                else if (value < 0) { iq = 1; }
                else { iq = value; }

            }
        }



    }
}
