using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProj.Core
{
    [Table("basket_items")]
    public class BasketItem : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("basket_id")]
        public Guid BasketId { get; set; }

        [Column("service_id")]
        public Guid ServiceId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
