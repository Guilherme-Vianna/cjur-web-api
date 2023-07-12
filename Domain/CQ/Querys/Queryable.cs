using cjuridico.Infra;

namespace cjuridico.Domain.CQ.Querys;

public abstract class Queryable
{
    public DataBase QueryDB;

    public Queryable(DataBase queryDb)
    {
        QueryDB = queryDb;
    }
}