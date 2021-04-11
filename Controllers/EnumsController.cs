using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerEnumDescriptions.Controllers
{
    /// <summary>
    /// Contains endpoints that use different enums.
    /// </summary>
    [Route("api/data")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        /// <summary>
        /// Executes operation of requested type and returns result status.
        /// </summary>
        /// <param name="id">Operation id.</param>
        /// <param name="type">Operation type.</param>
        /// <returns>Result status.</returns>
        [HttpGet]
        public Task<Result> ExecuteOperation(int id, OperationType type)
        {
            return Task.FromResult(Result.Success);
        }

        /// <summary>
        /// Changes data
        /// </summary>
        [HttpPost]
        public Task<IActionResult> Change(DataChange change)
        {
            return Task.FromResult<IActionResult>(Ok());
        }
    }

    /// <summary>
    /// Operation types.
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Do operation.
        /// </summary>
        Do,
        /// <summary>
        /// Undo operation.
        /// </summary>
        Undo
    }

    /// <summary>
    /// Operation results.
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// Operations was completed successfully.
        /// </summary>
        Success,
        /// <summary>
        /// Operation failed.
        /// </summary>
        Failure
    }

    /// <summary>
    /// Data change information.
    /// </summary>
    public class DataChange
    {
        /// <summary>
        /// Data id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Source type.
        /// </summary>
        public Sources Source { get; set; }

        /// <summary>
        /// Operation type.
        /// </summary>
        public OperationType Operation { get; set; }
    }

    /// <summary>
    /// Types of sources.
    /// </summary>
    public enum Sources
    {
        /// <summary>
        /// In-memory data source.
        /// </summary>
        Memory,
        /// <summary>
        /// Database data source.
        /// </summary>
        Database
    }
}
