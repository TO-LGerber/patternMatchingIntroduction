namespace APIExample.Models;

public class BodyObject
{
    public int ID { get; set; }

    public string Name { get; set; }

    public BodyObjectNested Nested { get; set; }

    public partial class BodyObjectNested
    {
        public int? MyProperty { get; set; }
    }
}
