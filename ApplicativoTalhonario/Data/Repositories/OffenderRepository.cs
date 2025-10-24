using ApplicativoTalhonario.Bussines.Dtos;
using ApplicativoTalhonario.Bussines.Interfaces.Repository;
using ApplicativoTalhonario.Data.Context;
using ApplicativoTalhonario.models;

namespace ApplicativoTalhonario.Data.Repositories;

public class OffenderRepository : IOffenderRepository
{
    public readonly BaseContext _db;
    
    public void saveOffender(Offender offender)
    {
        _db.Offenders.Add(offender);
        _db.SaveChanges();
    }

    public Offender findById(int id)
    {
        Offender offender = _db.Offenders.Find(id);

        if (offender == null)
        {
            return null;
        }
        return offender;
    }

    public void deleteOffender(int id)
    {
        _db.Offenders.Remove(_db.Offenders.Find(id));
    }
}