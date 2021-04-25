using Microsoft.AspNetCore.Mvc;
using databaseConnector.dbconnector;
using databaseConnector.model;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MySqlConnector;
using System;
using System.Linq;
using System.Text.Json;
using databaseConnector.filter;

namespace databaseConnector.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MoviveController : ControllerBase{
        private readonly MoiveConnector _moiveConnector;

        private readonly ILogger<Moive> _logger;

        private readonly ConnectorStringOptions _connectorStringOptions;

        public MoviveController(MoiveConnector moiveConnector,
        ILogger<Moive>logger,
        IOptionsMonitor<ConnectorStringOptions> connectorStringOptions){
            _moiveConnector = moiveConnector;
            _logger = logger;
            _connectorStringOptions = connectorStringOptions.CurrentValue;
        }

        [HttpGet]
        [TypeFilter(typeof(processableResultFilter))]
        public List<Moive> GetList(){
            // string connectorString = _connectorStringOptions.DefaultConnection;
            // using var con = new MySqlConnection(connectorString);
            // con.Open();
            // var sql = "SELECT * FROM tb_moive";
            // var mySqlCommand = new MySqlCommand(sql, con);
            // var mySqlDataReader = mySqlCommand.ExecuteReader();
            // List<Moive> res = new List<Moive>();

            // if(mySqlDataReader.HasRows){
            //     while(mySqlDataReader.Read()){
            //         Moive t = new Moive();
            //         for (int i = 0; i < mySqlDataReader.FieldCount; i++)
            //         {
            //             object v = mySqlDataReader.GetValue(i);
            //         }
            //         res.Add(t);
            //     }

            // }
            // con.Close();
            // returnString returnString = new returnString();
            // try{
                List<Moive> moives = this._moiveConnector.moives.ToList();
            //     string results = JsonSerializer.Serialize(moives);
            //     returnString.Code = 10000;
            //     returnString.Data = results;
            // }
            // catch(Exception e){
            //     returnString.Code = -1;
            //     returnString.Data = e.Message.ToString();
            //     returnString.Success = false;
            // }
            return (moives);
            // return res;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Moive moive)
        {
            this._moiveConnector.Add(moive);
            var count=_moiveConnector.SaveChanges();
            _logger.LogDebug($"save {count} entitys successfully.");
            return Ok(count);
        }
    }
}