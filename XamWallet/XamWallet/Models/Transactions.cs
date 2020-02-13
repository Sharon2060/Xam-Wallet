using System;
using System.Collections.Generic;
using System.Text;

namespace XamWallet.Models
{
    class Transactions
    {
        public int TransactionID { get; set; }

        public String SenderID { get; set; }
        public String ReceiverID { get; set; }
    }
}
