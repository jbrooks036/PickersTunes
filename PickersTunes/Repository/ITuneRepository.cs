using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PickersTunes.Models;

namespace PickersTunes.Repository
{
    public interface ITuneRepository
    {
        int GetCount();
        void Add(Tune T);
        void Delete(Tune T);
        void Clear();
        IEnumerable<Tune> GetAllTunesByUserId(string userId);
        IEnumerable<Models.Tune> All();
        // Tune GetTuneByIdAndUserId(string userId);
        // ObservableCollection<Models.Tune> GetByTuneName(string name);
        // IQueryable<Tune> SearchFor(Expression<Func<Tune, bool>> predicate);
    }
}
