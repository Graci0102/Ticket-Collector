using AutoMapper;
using Problems.Data;
using Problems.Entites;
using Problems.Entites.DTO;

namespace Problems.Logic
{
    public class ProblemLogic
    {
        public Repository<Problem> repository;
        public Mapper mapper;

        public ProblemLogic(Repository<Problem> repository, DTOProvider provider)
        {
            this.repository = repository;
            this.mapper = provider.Mapper;
        }

        public IEnumerable<ProblemGetDTO> Read()
        {
            return repository.GetAll().Select(t => mapper.Map<ProblemGetDTO>(t));
        }

        public async Task Create(ProblemPostDTO dto,string userid,string username)
        {
            //minta kivétel dobás
            //if (dto.Title.Contains("asd"))
            //{
            //    throw new Exception("Title cannot contain asd");
            //}
            var problem = mapper.Map<Problem>(dto);
            problem.CreatorId = userid;
            problem.CreatorName = username;
            problem.CreatedAt = DateTime.Now;
            await repository.CreateAsync(problem);
        }
    }
}
