namespace ex2
{
    public class TaskService : ITaskService
    {
        static List<Taskk> allTasks = new List<Taskk>();

        //Task t = new Task() { Title = "Clean", Description = "swap and wash the floor", TargetDate = new DateTime(2020, 01, 01), MyPreference = Preference.B };
        //Task ta = new Task() { Title = "Shopping", Description = "go to the super", TargetDate = new DateTime(2022, 10, 05), MyPreference = Preference.D };
        //Task tas = new Task() { Title = "Do H.W", Description = "do H.W in Java and C#", TargetDate = new DateTime(2024, 01, 01), MyPreference = Preference.A };
        //Task task = new Task() { Title = "Folde", Description = "folde the laundry", TargetDate = new DateTime(2023, 06, 11), MyPreference = Preference.C };
        //allTasks.Add(t);
        //allTasks.Add(ta);
        //allTasks.Add(tas);
        //allTasks.Add(task);

        public string CreateTask(Taskk t)
        {
            allTasks.Add(t);
            return t.Title;
        }

        public string DeleteTask(Taskk t)
        {
            allTasks.Remove(t);
            return t.Title;
        }

        public string UpdateTask(Taskk t)
        {
            //update
            Taskk tsk = allTasks.Find((i) => i.Title == t.Title);
            return t.Title;
        }
    }
}
