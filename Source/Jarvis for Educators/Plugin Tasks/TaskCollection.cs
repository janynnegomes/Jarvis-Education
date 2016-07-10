using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Plugin_Tasks
{
    public class TaskCollection
    {
        List<Task> collection;
        List<Task> removedValues;
        List<Task> addedValues;

        Persistence persistence;

        public TaskCollection()
        {
            persistence = new Persistence();

            // Initializing the lists
            this.collection = new List<Task>();
            this.removedValues = new List<Task>();
            this.addedValues = new List<Task>();

            // Load from database                        
            this.Load();            
        }

        public List<Task> Load()
        {
            // Clear all lists
            this.collection.Clear();
            this.removedValues.Clear();
            this.addedValues.Clear();

            persistence.Connection.Open();

            using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(persistence.Connection))
            {
               com.CommandText = "Select * FROM Tasks ORDER BY Title ";

                using (System.Data.SQLite.SQLiteDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.collection.Add(new Task(Convert.ToInt32(reader["ID"]), Convert.ToString(reader["Title"])));
                    }
                }
            }
                       
            persistence.Connection.Close();

            return this.collection;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveTask(Task taskToSave)
        {

            System.Threading.Tasks.Task t = System.Threading.Tasks.Task.Run(() => {

                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(persistence.Connection))
                {

                    persistence.Connection.Open();
                    
                    // Save on the database
                    com.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Title", taskToSave.Title));
                    com.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Description", taskToSave.Description));

                    com.CommandText = "INSERT INTO Tasks (Title, Description) Values (@Title, @Description)";

                    com.ExecuteNonQuery();

                    persistence.Connection.Close();        
                }

                collection.Clear();
                removedValues.Clear();
                addedValues.Clear();

            });

            t.Wait();

                
                      
        }

        public void Save()
        {
            
                System.Threading.Tasks.Task t = System.Threading.Tasks.Task.Run(() => {

                    using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(persistence.Connection))
                    {

                        // Delete
                        if (removedValues.Count > 0)
                        {
                            string strFilter = "";

                            foreach (var item in removedValues)
                            {
                                strFilter += ", " + item.ID.ToString();
                            }

                            persistence.Connection.Open();

                            com.CommandText = "DELETE FROM Tasks WHERE ID in(" + strFilter + ")";

                            com.ExecuteNonQuery();

                            persistence.Connection.Close();

                        }

                        // Insert
                        if (addedValues.Count > 0)
                        {
                            string strFilter = "";

                            foreach (var item in addedValues)
                            {
                                strFilter += com.CommandText = " INSERT INTO Tasks (Title, Description) Values ('"+ item.Title+ "', '" + item.Description + "'); ";
                            }

                            persistence.Connection.Open();

                            com.CommandText = strFilter;

                            com.ExecuteNonQuery();

                            persistence.Connection.Close();

                        }

                        // Clear all lists
                        this.collection.Clear();
                        this.removedValues.Clear();
                        this.addedValues.Clear();
                    }

                });

                t.Wait();              
          
        }

        public void AddNewTask(Task newTask)
        {
            this.collection.Add(newTask);
            this.addedValues.Add(newTask);

        }

        public void RemoveTask(int ID)
        {

           Task result = this.collection.Find(item => item.ID == ID);

            if(result != null)
            {
                this.collection.Remove(result);
                this.removedValues.Add(result);
            }
            
        }

            
    }

    
}
