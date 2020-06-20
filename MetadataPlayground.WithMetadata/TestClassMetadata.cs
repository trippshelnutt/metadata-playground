using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetadataPlayground.WithMetadata
{
    [Table("TestClass")]
    public class TestClassMetadata
    {
        [Required, MaxLength(10)]
        public string Name { get; set; }
        [Required, Column("Time")]
        public DateTime ExecutionTime { get; set; }
        [Required]
        public int Timeout { get; set; }
    }
}
