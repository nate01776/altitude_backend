/*
 * DoomsdAPI
 *
 * This is service is designed to return current information and historical data related to the Doomsday Clock maintained by the Bulletin of Atomic Scientists. There is a lightweight front end application designed to emmulate the motif of the clock as described here - https://www.theatlantic.com/entertainment/archive/2015/11/doomsday-clock-michael-bierut-design/412936/
 *
 * OpenAPI spec version: 1.0.0
 * Contact: nate01776@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ProviderApiController : ControllerBase
    { 
        /// <summary>
        /// History of clocks status
        /// </summary>
        /// <remarks>Returns a history of the clock&#x27;s time to midnight with optional descriptions</remarks>
        /// <param name="startDate">Hyphen seperated start date from which status objects are returned.</param>
        /// <param name="endDate">Hyphen seperated end date of history window, if not included default will be the current date</param>
        /// <response code="200">Array of status objects describing the various changes the clock has gone through, scoped based on submitted parameters.</response>
        /// <response code="404">Bad Request</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/history")]
        [ValidateModelState]
        [SwaggerOperation("ClockHistory")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<StatusModel>), description: "Array of status objects describing the various changes the clock has gone through, scoped based on submitted parameters.")]
        public virtual IActionResult ClockHistory([FromQuery]string startDate, [FromQuery]string endDate)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<StatusModel>));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "[ {\n  \"date\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"ref\" : \"https://thebulletin.org/doomsday-clock/current-time/\",\n  \"timeToMidnight\" : \"100 seconds\",\n  \"shortMessage\" : \"It is 100 seconds to midnight.\",\n  \"id\" : 3,\n  \"longMessage\" : \"longMessage\"\n}, {\n  \"date\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"ref\" : \"https://thebulletin.org/doomsday-clock/current-time/\",\n  \"timeToMidnight\" : \"100 seconds\",\n  \"shortMessage\" : \"It is 100 seconds to midnight.\",\n  \"id\" : 3,\n  \"longMessage\" : \"longMessage\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<StatusModel>>(exampleJson)
                        : default(List<StatusModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Current status of clock.
        /// </summary>
        /// <remarks>By passing in the appropriate options, you can search for available inventory in the system </remarks>
        /// <param name="searchString">pass an optional search string for looking up inventory</param>
        /// <response code="200">Current status of clock.</response>
        /// <response code="404">Bad Request</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/time")]
        [ValidateModelState]
        [SwaggerOperation("ClockStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<StatusModel>), description: "Current status of clock.")]
        public virtual IActionResult ClockStatus([FromQuery]string searchString)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<StatusModel>));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "[ {\n  \"date\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"ref\" : \"https://thebulletin.org/doomsday-clock/current-time/\",\n  \"timeToMidnight\" : \"100 seconds\",\n  \"shortMessage\" : \"It is 100 seconds to midnight.\",\n  \"id\" : 3,\n  \"longMessage\" : \"longMessage\"\n}, {\n  \"date\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"ref\" : \"https://thebulletin.org/doomsday-clock/current-time/\",\n  \"timeToMidnight\" : \"100 seconds\",\n  \"shortMessage\" : \"It is 100 seconds to midnight.\",\n  \"id\" : 3,\n  \"longMessage\" : \"longMessage\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<StatusModel>>(exampleJson)
                        : default(List<StatusModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// History of clocks status
        /// </summary>
        /// <remarks>Returns a</remarks>
        /// <param name="type">Defines the type of influence data, provider directly from the Bulletin of Atomic Scientist&#x27;s sources.</param>
        /// <response code="200">Array of status objects describing the various changes the clock has gone through, scoped based on submitted parameters.</response>
        /// <response code="404">Bad Request</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [Route("/data/{type}")]
        [ValidateModelState]
        [SwaggerOperation("DataQuery")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<StatusModel>), description: "Array of status objects describing the various changes the clock has gone through, scoped based on submitted parameters.")]
        public virtual IActionResult DataQuery([FromRoute][Required]string type)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<StatusModel>));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "[ {\n  \"date\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"ref\" : \"https://thebulletin.org/doomsday-clock/current-time/\",\n  \"timeToMidnight\" : \"100 seconds\",\n  \"shortMessage\" : \"It is 100 seconds to midnight.\",\n  \"id\" : 3,\n  \"longMessage\" : \"longMessage\"\n}, {\n  \"date\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"ref\" : \"https://thebulletin.org/doomsday-clock/current-time/\",\n  \"timeToMidnight\" : \"100 seconds\",\n  \"shortMessage\" : \"It is 100 seconds to midnight.\",\n  \"id\" : 3,\n  \"longMessage\" : \"longMessage\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<StatusModel>>(exampleJson)
                        : default(List<StatusModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
