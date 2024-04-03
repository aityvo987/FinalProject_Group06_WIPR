using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject_Group06
{

    public class TaskDAO
    {
        DBConnection dbConn = new DBConnection();
        public DataTable LoadTable(int topicId)
        {
            string sqlStr = string.Format("SELECT *FROM Task WHERE TopicId = {0}",topicId);
            return dbConn.LoadTable(sqlStr);
        }

        public void CreateTask(Task task, string name, string detail, int topicId, DateTime deadLine, int status)
        {
            if (name != null)
            {
                task.name = name;
                task.detail = detail;
                task.topicId = topicId;
                task.deadLine = deadLine;
                task.status = status;
            }
        }
        public bool AddTask(Task task)
        {
            string sqlStr = string.Format("INSERT INTO Task(Name, Detail, TopicId, Deadline, Status) VALUES ('{0}', '{1}','{2}','{3}','{4}')",
                task.name,task.detail,task.topicId,task.deadLine,task.status);
            return dbConn.Execute(sqlStr);
        }
        public bool DeleteTask(Task task)
        {
            string sqlStr = string.Format("DELETE FROM Task WHERE Id = '{0}'", task.id);
            return dbConn.Execute(sqlStr);

        }
        public bool EditTask(Task task)
        {
            string sqlStr = string.Format("UPDATE Task SET Name = '{1}', Detail =  '{2}', TopicId= '{3}',Deadline= '{4}',Status= '{5}'" +
                "WHERE id = {0}",
                task.id, task.name, task.detail, task.topicId, task.deadLine, task.status);
            return dbConn.Execute(sqlStr);

        }
        public bool ApproveTask(Topic topic)
        {
            string sqlStr = string.Format("UPDATE Task SET Status= '{1}' WHERE Id = {0}", topic.id, 1);
            return dbConn.Execute(sqlStr);

        }



    }
}