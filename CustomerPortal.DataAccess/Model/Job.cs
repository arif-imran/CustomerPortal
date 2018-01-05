// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Job.cs" company="">
//   
// </copyright>
// <summary>
//   The job.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomerPortal.DataAccess.Model
{
    using System;
    using System.Collections.Generic;

    using SQLite;

    /// <summary>The job.</summary>
    public class Job
    {
        /// <summary>Gets or sets the estimated start date.</summary>
        public DateTime EstimatedStartDate { get; set; }

        /// <summary>Gets or sets the job description.</summary>
        public string JobDescription { get; set; }

        /// <summary>Gets or sets the job number.</summary>
        public string JobNumber { get; set; }

        /// <summary>Gets or sets the job status.</summary>
        public string JobStatus { get; set; }

        /// <summary>Gets or sets the location.</summary>
        public string Location { get; set; }

        /// <summary>Gets or sets the maintenance type.</summary>
        public string MaintenanceType { get; set; }
    }

    /// <summary>
    /// The story.
    /// </summary>
    public class Story
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Story"/> class.
        /// </summary>
        public Story()
        {
            this.Tags = new List<StoryTag>();
        }

        /// <summary>
        /// Gets or sets the buisness contact.
        /// </summary>
        [MaxLength(1000)]
        public string BuisnessContact { get; set; }

        /// <summary>
        /// Gets or sets the buisness name.
        /// </summary>
        [MaxLength(1000)]
        public string BuisnessName { get; set; }

        /// <summary>
        ///     Gets or sets the category.
        /// </summary>
        [MaxLength(250)]
        public string Category { get; set; }

        /// <summary>
        ///     Gets or sets the date created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        ///     Gets or sets the date modified.
        /// </summary>
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the html content.
        /// </summary>
        public string HtmlContent { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the image alt.
        /// </summary>
        public string ImageAlt { get; set; }

        /// <summary>
        ///     Gets or sets the image url.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [MaxLength(100)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public Guid? Status { get; set; }

        /// <summary>
        ///     Gets or sets the story format.
        /// </summary>
        [MaxLength(100)]

        // 
        public string StoryFormat { get; set; }

        /// <summary>
        ///     Gets or sets the story id.
        /// </summary>
        public int StoryId { get; set; }

        /// <summary>
        /// Gets or sets the story status.
        /// </summary>
        public virtual object StoryStatus { get; set; }

        /// <summary>
        /// Gets or sets the story type.
        /// </summary>
        [MaxLength(100)]
        public string StoryType { get; set; }

        /// <summary>
        ///     Gets or sets the source url.
        /// </summary>
        public string StoryUrl { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        public virtual ICollection<StoryTag> Tags { get; set; }

        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        public virtual Theme Theme { get; set; }

        /// <summary>
        /// Gets or sets the theme id.
        /// </summary>
        public Guid? ThemeId { get; set; }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        // public string Tags { get; set; }
        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the valid until date.
        /// </summary>
        public DateTime? ValidUntilDate { get; set; }

        /// <summary>
        ///     Gets or sets the video url.
        /// </summary>
        public string VideoUrl { get; set; }
    }

    /// <summary>
    /// The story tag.
    /// </summary>
    public class StoryTag
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the story.
        /// </summary>
        public virtual Story Story { get; set; }

        /// <summary>
        /// Gets or sets the story id.
        /// </summary>
        public Guid StoryId { get; set; }

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        public string Tag { get; set; }
    }

    /// <summary>
    /// The theme.
    /// </summary>
    public class Theme
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the stories.
        /// </summary>
        public virtual ICollection<Story> Stories { get; set; }
    }
}