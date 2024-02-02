using Coravel.Invocable;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetScheduling
{
    public class MyRepeatableTask : IInvocable
    {
        private readonly ILogger<MyRepeatableTask> _logger;
        private readonly string _connectionstring;

        //public MyRepeatableTask(ILogger<MyRepeatableTask> logger, string connectionstring)
        //{
        //    this._logger = logger;
        //    _connectionstring = connectionstring;

        //}


        public MyRepeatableTask(ILogger<MyRepeatableTask> logger)
        {
            this._logger = logger;

        }


        public async Task Invoke()
        {
            _logger.LogInformation("Hello! This is from InVokable method");

            //// If you want to pass the connection_string
            //_logger.LogInformation("Hello! This is from InVokable method with Connection {_connection}",_connectionstring);

        }
    }
}
