using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount.Models
{
    [Table("BankAccount")]
    public class BankAccountModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string BankName { get; set; }

        [Required]
        public string BankAddress { get; set; }

        public decimal Amount { get; set; }
    }
}
