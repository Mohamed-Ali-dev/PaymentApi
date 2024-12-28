using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using PaymentApi.Data;

namespace PaymentApi.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string CardOwnerName { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(5)")]

        public string ExpireationDate { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(5)")] 
        public string SecurityCode { get; set; } = string.Empty;
    }

}
