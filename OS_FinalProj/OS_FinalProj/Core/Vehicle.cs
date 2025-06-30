using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProj.Core
{
    [Table("vehicles")]
    public class Vehicle : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("plate_number")]
        public string PlateNumber { get; set; }

        [Column("make")]
        public string Make { get; set; }

        [Column("model")]
        public string Model { get; set; }

        [Column("year")]
        public int Year { get; set; }

        [Column("owner_id")]
        public string OwnerId { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
