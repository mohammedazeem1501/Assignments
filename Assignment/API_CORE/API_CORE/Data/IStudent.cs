using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_CORE.Model;
using API_CORE.Data;
using System.Data;

namespace API_CORE.Data
{
    public interface IStudent
    {
        DataSet GetData();
        DataSet GetDataId(int id);
        bool InsertData(Student student);
        bool UpdateData(int id, Student student);
        bool DeleteData(int id);
    }
}
