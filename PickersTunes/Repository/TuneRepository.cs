using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PickersTunes;
using PickersTunes.Models;

namespace PickersTunes.Repository 
{
    public class TuneRepository : ITuneRepository
    {
        private TuneContext _dbContext;

        public TuneRepository()
        {
            _dbContext = new TuneContext();
            _dbContext.Tunes.Load();

            // see the database
            _dbContext.Tunes.Add(new Models.Tune("Little Maggie"));
            _dbContext.Tunes.Add(new Models.Tune("Foggy Mountain Breakdown"));
            _dbContext.SaveChanges();
        }

        public TuneContext Context()
        {
            return _dbContext;
        }

        public DbSet<Models.Tune> GetDbSet()
        {
            return _dbContext.Tunes;
        }

        public int GetCount()
        {
            return _dbContext.Tunes.Count<Models.Tune>();
        }

        public void Add(Models.Tune T)
        {
            // TBD: error checking for adding duplicate tune, or migration on table
            _dbContext.Tunes.Add(T);
            _dbContext.SaveChanges();
        }

        public void Delete(Models.Tune T)
        {
            throw new NotImplementedException();
        }

        public Models.Tune GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Models.Tune> GetByTuneName(string name)
        {
            var query = from Tune in _dbContext.Tunes
                        where name == Tune.Name
                        select Tune;
            var tunes = new ObservableCollection<Tune>(query.ToList<Tune>());
            return tunes;
        }



        public void Clear()
        {
            var a = this.All();
            _dbContext.Tunes.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Models.Tune> All()
        {
            var qu = from Tune in _dbContext.Tunes
                     select Tune;
            return qu.ToList<Models.Tune>();
        }

    }
}