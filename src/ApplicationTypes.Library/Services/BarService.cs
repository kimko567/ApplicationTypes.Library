using ApplicationTypes.Library.Entities;
using ApplicationTypes.Library.Mappers;
using ApplicationTypes.Library.Models.Bar;

namespace ApplicationTypes.Library.Services
{
    internal interface IBarService
    {
        int Create(BarCreateModel model);
        void Delete(int id);
        Bar GetById(int id);
        void Update(int id, BarUpdateModel model);
    }

    internal sealed class BarService : IBarService
    {
        private static int s_id = 1;
        private static List<Bar> s_database = new List<Bar>();

        public int Create(BarCreateModel model)
        {
            var entity = new Bar
            {
                Id = s_id++
            };

            BarMapper.Map(model, entity);

            s_database.Add(entity);

            return entity.Id;
        }

        public void Delete(int id)
        {
            s_database.Remove(s_database.First(bar => bar.Id == id));
        }

        public Bar GetById(int id)
        {
            return s_database.First(bar => bar.Id == id);
        }

        public void Update(int id, BarUpdateModel model)
        {
            var entity = s_database.First(bar => bar.Id == id);

            BarMapper.Map(model, entity);
        }
    }
}
