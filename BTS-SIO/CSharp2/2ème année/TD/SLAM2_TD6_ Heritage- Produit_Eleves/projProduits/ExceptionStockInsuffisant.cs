using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projProduitsHeritage {
    public class ExceptionStockInsuffisant : Exception {
        public ExceptionStockInsuffisant(string message) : base(message){} //appel constructeur classe mere Exception
       
    }
}
