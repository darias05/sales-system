using System;
using System.Collections.Generic;
using System.Text;
using sales_system.DTO;
using sales_system.DAO;

namespace sales_system.Logic
{
    class CreateSellers
    {
        public List<Dto_Seller> CreateSeller()
        {
            List<string> Name = new List<string>()
            {
                "Cristian Andres", "Juan Solarte", "Camila Martinez", "Angela Cardona", "Dylan Arias"
            };

            List<int> Age = new List<int>()
            {
                21, 23, 25, 24, 20
            };

            List<int> Document = new List<int>()
            {
                1234, 2345, 3456, 4567, 5678
            };

            List<string> Gender = new List<string>()
            {
                "M", "M", "F", "F", "M"
            };

            Dao_Seller Obj_Dao_Seller = new Dao_Seller();
            List<Dto_Seller> List_Sellers = Obj_Dao_Seller.CreateSeller(Name, Age, Document, Gender);

            return List_Sellers;
        }
    }
}
