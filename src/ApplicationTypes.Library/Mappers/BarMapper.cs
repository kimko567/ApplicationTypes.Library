using ApplicationTypes.Library.Entities;
using ApplicationTypes.Library.Models.Bar;

namespace ApplicationTypes.Library.Mappers
{
    internal static class BarMapper
    {
        public static void Map(BarCreateModel model, Bar entity)
        {
            entity.IsEnabled = model.IsEnabled;
            entity.Title = model.Title;
        }

        public static void Map(BarUpdateModel model, Bar entity)
        {
            entity.IsEnabled = model.IsEnabled;
            entity.Title = model.Title;
        }
    }
}
