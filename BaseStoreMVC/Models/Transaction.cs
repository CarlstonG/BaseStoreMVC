using System.ComponentModel.DataAnnotations; //added
using System.ComponentModel.DataAnnotations.Schema; //added

namespace BaseStoreMVC.Models
{
    public class Transaction
    {
        [Key] //added
        public int TransactionId { get; set; }
        //added 
        [Column(TypeName ="nvarchar(12)")]
        public string AccountNum { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set;}
        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCODE { get; set; }
     
        public int Amount { get; set; }
  
        public DateTime Date { get; set; }
    }
}
