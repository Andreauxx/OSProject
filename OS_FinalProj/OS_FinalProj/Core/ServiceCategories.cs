using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProj.Core
{
    class ServiceCategories
    {
        [Table("service_categories")]
        public class ServiceCategory : BaseModel
        {
            [PrimaryKey("id", false)]
            public Guid Id { get; set; }

            [Column("name")]
            public string Name { get; set; }

            [Column("description")]
            public string Description { get; set; }

            [Column("icon_url")]
            public string IconUrl { get; set; }

            [Column("created_at")]
            public DateTimeOffset CreatedAt { get; set; }
        }
    }
}
