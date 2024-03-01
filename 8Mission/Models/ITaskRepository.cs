namespace _8Mission.Models;
public interface ITaskRepository
{
    List<AddTask> AddTasks { get; } //read only
    List<Categories> Categories { get; } //read only

    public void AddTask(AddTask task);
    public void UpdateTask(AddTask task);
    public void DeleteTask(AddTask task);
    AddTask GetTaskById(int id);

}
