// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MyProfile.cs" company="">
//   
// </copyright>
// <summary>
//   The my profile.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;

    /// <summary>The my profile.</summary>
    public class MyProfile
    {
        /// <summary>Gets or sets the address 1.</summary>
        public string Address1 { get; set; }

        /// <summary>Gets or sets the address 2.</summary>
        public string Address2 { get; set; }

        /// <summary>Gets or sets the country.</summary>
        public string Country { get; set; }

        /// <summary>Gets or sets the dob.</summary>
        public DateTime? Dob { get; set; }

        /// <summary>Gets or sets the email address.</summary>
        public string EmailAddress { get; set; }

        /// <summary>Gets or sets the first name.</summary>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the gender.</summary>
        public string Gender { get; set; }

        /// <summary>Gets or sets a value indicating whether is signed for exclusive benefits.</summary>
        public bool IsSignedForExclusiveBenefits { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        public string LastName { get; set; }

        /// <summary>Gets or sets the postcode.</summary>
        public string Postcode { get; set; }

        /// <summary>Gets or sets the title.</summary>
        public string Title { get; set; }

        /// <summary>Gets or sets the town.</summary>
        public string Town { get; set; }
    }
}