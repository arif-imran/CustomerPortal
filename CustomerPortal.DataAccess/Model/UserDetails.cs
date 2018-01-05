// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="">
//   
// </copyright>
// <summary>
//   The user details.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;

    using CustomerPortal.Common.ServerIdentity;

    /// <summary>The user details.</summary>
    public class UserDetails : User
    {
        /// <summary>Gets or sets the user id.</summary>
        public Guid UserId { get; set; }
    }
}