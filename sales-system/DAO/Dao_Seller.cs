using System;
using System.Collections.Generic;
using System.Text;
using sales_system.DTO;

namespace sales_system.DAO
{
    public class Dao_Seller
    {
        public List<Dto_Seller> CreateSeller(List<string> Name, List<int> Age, List<int> Document,
                                        List<string> Gender)
        {
            List<Dto_Seller> sellers = new List<Dto_Seller>();

            for (int i = 0; i < Name.Count; i++)
            {
                sellers.Add(new Dto_Seller()
                {
                    Name = Name[i],
                    Age = Age[i],
                    Document = Document[i],
                    Gender = Gender[i]
                });
            }

            return sellers;
        }
    }
}
