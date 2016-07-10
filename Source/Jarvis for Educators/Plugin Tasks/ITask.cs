using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin_Tasks
{
    interface ITask
    {
        void Init();
        void New(List<object> values);
        void Start();
        void Open();
        void Close();
        void MoveToTrash();
        void Edit(List<object> newValues, List<object> olValues, int key);
    }
}
