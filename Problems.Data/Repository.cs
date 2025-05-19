using Problems.Entites.Helper;

namespace Problems.Data
{
    public class Repository<T> where T : class, IIdEntity
    {
        ProblemContext ctx;

        public Repository(ProblemContext ctx)
        {
            this.ctx = ctx;
        }

        //public void Create(T entity)
        //{
        //    ctx.Set<T>().Add(entity);
        //    ctx.SaveChanges();
        //}

        //public void CreateMany(IEnumerable<T> entities)
        //{
        //    ctx.Set<T>().AddRange(entities);
        //    ctx.SaveChanges();
        //}

        //public async Task CreateManyAsync(IEnumerable<T> entities)
        //{
        //    ctx.Set<T>().AddRange(entities);
        //    await ctx.SaveChangesAsync();
        //}

        public async Task CreateAsync(T entity)
        {
            ctx.Set<T>().Add(entity);
            await ctx.SaveChangesAsync();
        }

        public T FindById(string id)
        {
            return ctx.Set<T>().First(t => t.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }

    }
}
