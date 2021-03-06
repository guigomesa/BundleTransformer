﻿using System.Configuration;

namespace BundleTransformer.Csso.Configuration
{
	/// <summary>
	/// Configuration settings of Sergey Kryzhanovsky's CSS minifier
	/// </summary>
	public sealed class CssMinifierSettings : ConfigurationElement
	{
		/// <summary>
		/// Gets or sets a flag for whether to disable structure minification
		/// </summary>
		[ConfigurationProperty("disableRestructuring", DefaultValue = false)]
		public bool DisableRestructuring
		{
			get { return (bool)this["disableRestructuring"]; }
			set { this["disableRestructuring"] = value; }
		}

		/// <summary>
		/// Gets or sets a comments mode
		/// </summary>
		[ConfigurationProperty("comments", DefaultValue = CommentsMode.Exclamation)]
		public CommentsMode Comments
		{
			get { return (CommentsMode)this["comments"]; }
			set { this["comments"] = value; }
		}
	}
}