using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis_Library
{
    class Task : Interfaces.ITask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DesireDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CloseDate { get; set; }
        public TaskStatus CurrentStatus { get; set; }

        public void Close()
        {
            CurrentStatus = TaskStatus.Done;
            CloseDate = DateTime.Now;
        }
      

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void MoveToTrash()
        {
            throw new NotImplementedException();
        }       

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void New(List<object> values)
        {
            throw new NotImplementedException();
        }

        public void Edit(List<object> newValues, List<object> olValues, int key)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.Title + "" + this.CreateDate.ToShortDateString();
        }
    }

    public enum TaskStatus
    {
        Waiting, InProgress, Done
    }
}
