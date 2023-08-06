using ApplicationTypes.Library.Entities;
using ApplicationTypes.Library.Models.Foo;

namespace ApplicationTypes.Library.Mappers
{
    internal static class FooMapper
    {
        public static void Map(FooCreateModel model, Foo entity)
        {
            entity.Name = model.Name;
            entity.Value = model.Value;
        }

        public static void Map(FooUpdateModel model, Foo entity)
        {
            entity.Name = model.Name;
            entity.Value = model.Value;
        }
    }
}
