using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Phone
    {
        private string _memory;
        private string _model;
        private bool _old;
       

       
        

        public string Memory { get => _memory; set => _memory = value; }
        public string Model { get => _model; set => _model = value; }
        public bool Old { get => _old; set => _old = value; }
        
        

        public override string ToString()
        {
            return Model + " " + Old + " " + Memory;
        }
        
    }

}
