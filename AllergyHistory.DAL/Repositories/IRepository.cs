using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllergyHistory.DAL.Repositories
{
    public interface IRepository<TEntity>
    {
        //IEnumerable<TEntity> GetAll();
        //IQueryable<TEntity> GetAll_Q();
        //TEntity Get(long id);
        //void Add(TEntity entity);
        //void Update(TEntity dbEntity, TEntity entity);
        //void Delete(TEntity entity);


        /// <summary>
        /// This is for fake response, assumption we have a databse and A SELECT query returns results as a rowset XML. 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/xml/for-xml-sql-server?view=sql-server-2017
        /// </summary>
        /// <returns>XML string with multiple row fragments</returns>
        string GetAllXml(string fakeDataFolderPath);
    }
}
