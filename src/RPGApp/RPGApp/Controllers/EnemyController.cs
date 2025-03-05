using Microsoft.AspNetCore.Mvc;
using RPGApp.DAL;

namespace RPGApp.Controllers;

[Route("api/[controller]")]

public class EnemyController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DBDriver _dbDriver;


    public EnemyController(ILogger<HomeController> logger, DBDriver dbDriver)
    {
        _logger = logger;
        _dbDriver = dbDriver;
    }

    [HttpGet]
    public List<Enemy> GetAllEnemies()
    {
        return _dbDriver.GetEnemies();
    }

    public Enemy InsertEnemy([FromBody] Enemy enemy)
    {
        _dbDriver.Insert(enemy);
        return enemy;
    }
}