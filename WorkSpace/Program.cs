using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.FirstName = "Ömer Faruk";
            person1.LastName = "Gözegir";

            PttMenager pttMenager = new PttMenager(new ForeignerMenager());
            pttMenager.GiveMask(person1);
        
        }

       
    }
     
  

  


}
