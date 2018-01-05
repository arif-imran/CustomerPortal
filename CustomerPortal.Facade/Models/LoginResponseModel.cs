// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginResponseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The login response model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System;

    using CustomerPortal.Common.ServerIdentity;

    /// <summary>The login response model.</summary>
    public class LoginResponseModel
    {
        /// <summary>Gets or sets the expires in.</summary>
        public long ExpiresIn { get; set; }

        /// <summary>Gets or sets the user details.</summary>
        public User UserDetails { get; set; }

        /// <summary>Gets or sets the user id.</summary>
        public Guid UserId { get; set; }

        /// <summary>Gets or sets the verification token.</summary>
        public string VerificationToken { get; set; }
    }
}