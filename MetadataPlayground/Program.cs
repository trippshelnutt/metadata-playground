using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MetadataPlayground.WithMetadata;

namespace MetadataPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var metadataAttrs = typeof(TestClass).GetCustomAttributes(typeof(MetadataTypeAttribute), true).OfType<MetadataTypeAttribute>().ToArray();

            var metadataAttr = metadataAttrs.FirstOrDefault();

            if (metadataAttr != null)
            {
                Console.WriteLine($"Metadata type found: {metadataAttr.MetadataClassType}.");

                var props = metadataAttr.MetadataClassType.GetProperties();

                foreach (var prop in props)
                {
                    Console.WriteLine($"Attributes for property: {prop.Name}");

                    var attrs = prop.GetCustomAttributes(true);
                    foreach (var attr in attrs)
                    {
                        Console.WriteLine($"Attribute: {attr.GetType()}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No metadata type found.");
            }
        }
    }
}
