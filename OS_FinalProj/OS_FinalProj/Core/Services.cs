using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProj.Core
{
    class Services
    {
        [Table("services")]
        public class Service : BaseModel
        {
            [PrimaryKey("id", false)]
            public Guid Id { get; set; }

            [Column("category_id")]
            public Guid CategoryId { get; set; }

            [Column("name")]
            public string Name { get; set; }

            [Column("description")]
            public string Description { get; set; }

            [Column("price")]
            public decimal Price { get; set; }

            [Column("estimated_minutes")]
            public int EstimatedMinutes { get; set; }
        }
    }
}
