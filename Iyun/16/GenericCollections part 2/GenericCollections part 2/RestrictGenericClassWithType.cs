namespace GenericCollections_part_2
{
    public class RestrictGenericClassWithType<A> where A : class, new()
    {
        public A StructTypeProperty { get; set; }
    }
}
