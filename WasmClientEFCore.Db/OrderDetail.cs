using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WasmClientEFCore.Db
{
    public class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Weight { get; set; }

        [Required]
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}