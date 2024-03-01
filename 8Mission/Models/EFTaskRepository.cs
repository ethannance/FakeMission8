
namespace _8Mission.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private AddTaskContext _context;
        
        public EFTaskRepository(AddTaskContext temp) 
        {
            _context = temp;
        }

        public List<AddTask> AddTasks => _context.AddTask.ToList();
        public List<Categories> Categories => _context.Categories.ToList();

        public void AddTask(AddTask task)
        {
            _context.AddTask.Add(task);
            _context.SaveChanges();
        }
        public void UpdateTask(AddTask task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }
        public void DeleteTask(AddTask task)
        {
            _context.AddTask.Remove(task);
            _context.SaveChanges();
        }
        public AddTask GetTaskById(int id)
        {
            return _context.AddTask.FirstOrDefault(t => t.TaskId == id);
        }

    }

}
