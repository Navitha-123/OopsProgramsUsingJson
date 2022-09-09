using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgramUsingJson
{
    public class Rice
    {
        public List<TypeOfRice> typeOfRice;

        public List<TypeOfPluse> TypeOfPluse;

        public List<TypeOfWheat> TypeOfWheat;


    }

    public class TypeOfRice
    {

        //properties of rice

        public string name { get; set; }
        public int weight { get; set; }

        public int price { get; set; }
    }

    public class TypeOfPluse
    {

        //properties of Pluse

        public string name { get; set; }
        public int weight { get; set; }

        public int price { get; set; }
    }

    public class TypeOfWheat
    {

        //properties of Wheat

        public string name { get; set; }
        public int weight { get; set; }

        public int price { get; set; }
    }
    public class Calculatevalues
    {

        //properties of Wheat,Rice,Pluse

        public string name { get; set; }
        public int weight { get; set; }

        public int price { get; set; }
    }
}

