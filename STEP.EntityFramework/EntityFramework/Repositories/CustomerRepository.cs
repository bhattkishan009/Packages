//using Abp.Domain.Repositories;
//using Abp.EntityFramework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace STEP.EntityFramework.Repositories
//{
//    public interface ICustomerRepository : IRepository<Customer, long>
//    {
//        //List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state);
//    }

//    public class CustomerRepository : STEPRepositoryBase<Customer, long>, ICustomerRepository
//    {
//        public CustomerRepository(IDbContextProvider<STEPRepositoryBase> dbContextProvider)
//            : base(dbContextProvider)
//        {
//        }

//        //public List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state)
//        //{
//        //    var query = GetAll();

//        //    if (assignedPersonId.HasValue)
//        //    {
//        //        query = query.Where(task => task.AssignedPerson.Id == assignedPersonId.Value);
//        //    }

//        //    if (state.HasValue)
//        //    {
//        //        query = query.Where(task => task.State == state);
//        //    }

//        //    return query
//        //        .OrderByDescending(task => task.CreationTime)
//        //        .Include(task => task.AssignedPerson)
//        //        .ToList();
//        //}
//    }

//}
