using System;
using System.Collections.Generic;
using CustomerPortal.Facade.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace CustomerPortalApp.ViewModels
{
    public class StoryViewModel : BindableBase
    {
		/// <summary>
        /// The category.
        /// </summary>
		private string category;

		/// <summary>
        /// The content.
        /// </summary>
		private string content;

		/// <summary>
        /// The date created.
        /// </summary>
		private DateTime dateCreated;

		/// <summary>
        /// The date modified.
        /// </summary>
		private DateTime dateModified;

		/// <summary>
        /// The description.
        /// </summary>
		private string description;

		/// <summary>
        /// The identifier.
        /// </summary>
		private Guid id;

		/// <summary>
        /// The image alternate.
        /// </summary>
		private string imageAlt;

		/// <summary>
        /// The image URL.
        /// </summary>
		private string imageUrl;

		/// <summary>
        /// The story format.
        /// </summary>
		private string storyFormat;

		/// <summary>
        /// The story URL.
        /// </summary>
		private string storyUrl;

		/// <summary>
        /// The tags.
        /// </summary>
		private List<string> tags;

		/// <summary>
        /// The title.
        /// </summary>
		private string title;

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
		public string Category
		{
			get
			{
                return this.category;
			}

			set
			{
                this.SetProperty(ref this.category, value);
			}
		}

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>The content.</value>
		public string Content
		{
			get
			{
				return this.content;
			}

			set
			{
                this.SetProperty(ref this.content, value);
			}
		}

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>The date created.</value>
		public DateTime DateCreated
		{
			get
			{
				return this.dateCreated;
			}

			set
			{
				this.SetProperty(ref this.dateCreated, value);
			}
		}

        /// <summary>
        /// Gets or sets the date modified.
        /// </summary>
        /// <value>The date modified.</value>
        public DateTime DateModified
		{
			get
			{
                return this.dateModified;
			}

			set
			{
				this.SetProperty(ref this.dateModified, value);
			}
		}

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
		public string Description
		{
			get
			{
				return this.description;
			}

			set
			{
				this.SetProperty(ref this.description, value);
			}
		}

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
		public Guid Id
		{
			get
			{
				return this.id;
			}

			set
			{
				this.SetProperty(ref this.id, value);
			}
		}

        /// <summary>
        /// Gets or sets the image alternate.
        /// </summary>
        /// <value>The image alternate.</value>
		public string ImageAlt
		{
			get
			{
                return this.imageAlt;
			}

			set
			{
				this.SetProperty(ref this.imageAlt, value);
			}
		}

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>The image URL.</value>
		public string ImageUrl
		{
			get
			{
				return this.imageUrl;
			}

			set
			{
				this.SetProperty(ref this.imageUrl, value);
			}
		}

        /// <summary>
        /// Gets or sets the story URL.
        /// </summary>
        /// <value>The story URL.</value>
		public string StoryUrl
		{
			get
			{
                return this.storyUrl;
			}

			set
			{
				this.SetProperty(ref this.storyUrl, value);
			}
		}

        /// <summary>
        /// Gets or sets the story format.
        /// </summary>
        /// <value>The story format.</value>
		public string StoryFormat
		{
			get
			{
				return this.storyFormat;
			}

			set
			{
				this.SetProperty(ref this.storyFormat, value);
			}
		}

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
		public List<string> Tags
		{
			get
			{
                return this.tags;
			}

			set
			{
				this.SetProperty(ref this.tags, value);
			}
		}

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
		public string Title
		{
			get
			{
				return this.title;
			}

			set
			{
				this.SetProperty(ref this.title, value);
			}
		}

        /// <summary>
        /// Gets the tap command.
        /// </summary>
        /// <value>The tap command.</value>
        public DelegateCommand<string> ImageTapCommand { get; set; }

    }
}
