using cjuridico.Infra;

namespace cjuridico.Domain.CQ.Commands;

public abstract class Commitable
{
    public DataBase CommandDB;

    public Commitable(DataBase commandDb)
    {
        CommandDB = commandDb;
    }
}