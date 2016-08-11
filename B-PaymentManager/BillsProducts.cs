using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PaymentManager
{
    class BillsProducts
    {
        public int productId;
        public String productName;
        public int productPrice;
        public int productQuant;
        public int productTotalPrice;
        public int productPaidValue;

        public BillsProducts(string pN,int pPri,int pQuan,int pTotalPri,int pPaid,int id= 0)
        {
            this.productId = id;
            this.productName = pN;
            this.productPrice = pPri;
            this.productQuant = pQuan;
            this.productTotalPrice = pTotalPri;
            this.productPaidValue = pPaid;
        } 
    }
}
