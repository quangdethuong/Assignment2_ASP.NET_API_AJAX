using System.ComponentModel.DataAnnotations;
using System;

namespace EstoreAPI.DTO.OrdersDTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        [Required]
        public string MemberId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequiredDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }
        [Required]
        public decimal Freight { get; set; }
    }
}
