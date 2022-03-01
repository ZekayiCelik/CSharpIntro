using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    public class House
    {
        string _suburb; // defaultu private


        public House()
        {
            
        }
        public int Id { get; set; }

        internal string City { get; set; }

        protected string Suburb { get; set; }



    }
    public class HouseTest:House
    {
        public HouseTest()
        {
           
            
        }

    }
}
        //bir propbun defaultu private dir yani birşey yazmazsan başına default değeri private olur
        //clasın internal
        //PRotected sadece kendi sınıfında ve kendi sınıfını inherit eden clasta geçerli
        //private sadece iligili classta geçerli 
        //interval aynı isim uzayında geçerli refereans verilse bile sadece o isim uzayında geçerli
        // ama public hem iisim uzuayında hemde referens verilen yerde geçerli
        // public verildiği sürece her referance verilen yerde
        // eğer bir şeyi public verirsek pascal case yazmalıyız