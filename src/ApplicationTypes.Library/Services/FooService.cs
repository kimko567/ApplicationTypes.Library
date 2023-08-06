using ApplicationTypes.Library.Entities;
using ApplicationTypes.Library.Mappers;
using ApplicationTypes.Library.Models.Foo;

namespace ApplicationTypes.Library.Services
{
    public interface IFooService
    {
        int Create(FooCreateModel model);
        void Delete(int id);
        Foo GetById(int id);
        void Update(int id, FooUpdateModel model);
    }

    public sealed class FooService : IFooService
    {
        public static int s_id = 1;
        private static List<Foo> s_database = new List<Foo>();

        public int Create(FooCreateModel model)
        {
            var entity = new Foo
            {
                Id = s_id++
            };

            FooMapper.Map(model, entity);

            s_database.Add(entity);

            return entity.Id;
        }

        public void Delete(int id)
        {
            s_database.Remove(s_database.First(foo => foo.Id == id));
        }

        public Foo GetById(int id)
        {
            return s_database.First(x => x.Id == id);
        }

        public void Update(int id, FooUpdateModel model)
        {
            var entity = s_database.First(foo => foo.Id == id);

            FooMapper.Map(model, entity);
        }
    }
}
