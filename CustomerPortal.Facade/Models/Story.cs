// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Story.cs" company="">
//   
// </copyright>
// <summary>
//   The story.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.Facade.Models
{
    using System;
    using System.Collections.Generic;

    using MvvmHelpers;

    /// <summary>The story.</summary>
    public class Story : ObservableObject
    {
        /// <summary>Gets or sets the category.</summary>
        public string Category { get; set; }

        /// <summary>Gets or sets the content.</summary>
        public string Content { get; set; }

        /// <summary>Gets or sets the date created.</summary>
        public DateTime DateCreated { get; set; }

        /// <summary>Gets or sets the date modified.</summary>
        public DateTime DateModified { get; set; }

        /// <summary>Gets or sets the description.</summary>
        public string Description { get; set; }

        /// <summary>Gets or sets the id.</summary>
        public Guid Id { get; set; }

        /// <summary>Gets or sets the image alt.</summary>
        public string ImageAlt { get; set; }

        /// <summary>Gets or sets the image url.</summary>
        public string ImageUrl { get; set; }

        /// <summary>Gets or sets the story format.</summary>
        public string StoryFormat { get; set; }

        /// <summary>Gets or sets the story url.</summary>
        public string StoryUrl { get; set; }

        /// <summary>Gets or sets the tags.</summary>
        public List<string> Tags { get; set; }

        /// <summary>Gets or sets the title.</summary>
        public string Title { get; set; }
    }
}