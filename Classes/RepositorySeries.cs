using System;
using System.Collections.Generic;
using DIO.Series.Interface;

namespace DIO.Series
{
    public class RepositorySeries : IRepository<Series>
    {
        private List<Series> ListSeries = new List<Series>();
        public void Delete(int id)
        {
            ListSeries[id].Delete();
        }

        public Series getId(int id)
        {
            return ListSeries[id];
        }

        public void Insert(Series entity)
        {
            ListSeries.Add(entity);
        }

        public List<Series> List()
        {
            return ListSeries;
        }

        public int NextId()
        {
            return ListSeries.Count;
        }

        public void Update(int id, Series entity)
        {
            ListSeries[id] = entity;
        }
    }
}