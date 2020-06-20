using System.ComponentModel.DataAnnotations;

namespace MetadataPlayground.WithMetadata
{
    [MetadataType(typeof(TestClassMetadata))]
    public partial class TestClass
    {
    }
}
