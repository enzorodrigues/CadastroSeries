using System.Collections.Generic;
using DIO.Series.Interface;
using System;

namespace DIO.Series
{
    public class RepositoryMovies : IRepository<Movies>
    {
        private List<Movies> ListMovies = new List<Movies>();
        public void Delete(int id)
        {
            ListMovies[id].Delete();
        }

        public Movies getId(int id)
        {
            return ListMovies[id];
        }

        public void Insert(Movies entity)
        {
            ListMovies.Add(entity);
        }

        public List<Movies> List()
        {
            return ListMovies;
        }

        public int NextId()
        {
            return ListMovies.Count;
        }

        public void Update(int id, Movies entity)
        {
            ListMovies[id] = entity;
        }
    }
}