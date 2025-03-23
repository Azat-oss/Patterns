

namespace Home_Work.Singlton;

public class DatabaseConnection
{
    private static DatabaseConnection database;
    private DatabaseConnection()
    {

    }

    public static DatabaseConnection GetInstance()
    {
        if (database == null)
        {
            database = new DatabaseConnection();
        }

        return database;
    }

}
