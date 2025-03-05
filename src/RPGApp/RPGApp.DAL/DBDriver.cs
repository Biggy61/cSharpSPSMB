namespace RPGApp.DAL;
using System.Data;
using MySqlConnector;


public class DBDriver
{
    private static string ServerDomain = "vydb1.spsmb.cz";
    private static string Username = "stepan.zdansky";
    private static string Password = "";
    private static string Database = "student_stepan.zdansky_RPGApp";

    private static string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password};Port=3306;";

    public MySqlException? ThrownException;

    public DBDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public List<Enemy> GetEnemies()
    {
        List<Enemy> users = new List<Enemy>();
        MySqlConnection connection = GetConnection();
        try
        {
            connection.Open();
            string query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, connection);
            // execute reader
            var reader = command.ExecuteReader();
            // while reader.next
            while (reader.Read())
            {
                users.Add(new Enemy(
                    reader.GetString(1),
                    reader.GetInt16(2),
                    reader.GetInt16(3),
                    reader.GetInt16(4),
                    reader.GetFloat(5),
                    reader.GetFloat(6)));
            }
        }
        catch (MySqlException ex)
        {
            ThrownException = ex;
        }

        // return list
        return users;
    }

    public void Insert(Enemy enemy)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           "INSERT INTO users VALUES (@id, @username, @health, @damage, @armor, @criticalChance, @criticalScaler)",
                           connection))
                {
                    command.Parameters.AddWithValue("@id", enemy.Id);
                    command.Parameters.AddWithValue("@username", enemy.Name);
                    command.Parameters.AddWithValue("@health", enemy.Health);
                    command.Parameters.AddWithValue("@damage", enemy.Damage);
                    command.Parameters.AddWithValue("@armor", enemy.Armor);
                    command.Parameters.AddWithValue("@criticalChance", enemy.CriticalChance);
                    command.Parameters.AddWithValue("@criticalScaler", enemy.CriticalScaler);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
   
    public void Delete(string ID)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           " DELETE FROM users WHERE id=@id",
                           connection))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("User not found");
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
}