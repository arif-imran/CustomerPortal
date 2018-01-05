// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddLogEntryApiRequestModel.cs" company="">
//   
// </copyright>
// <summary>
//   The add log entry api request model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;

    /// <summary>The add log entry api request model.</summary>
    public class AddLogEntryApiRequestModel
    {
        /// <summary>Gets or sets the date.</summary>
        public DateTime Date { get; set; }

        /// <summary>Gets or sets the ip address.</summary>
        public string IpAddress { get; set; }

        /// <summary>Gets or sets the message.</summary>
        public string Message { get; set; }

        /// <summary>Gets or sets the status code.</summary>
        public int? StatusCode { get; set; }

        /// <summary>Gets or sets the type.</summary>
        public string Type { get; set; }
    }
}