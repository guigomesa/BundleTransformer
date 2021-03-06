﻿using System;
using System.Configuration;

using BundleTransformer.Core.Configuration;

namespace BundleTransformer.Csso.Configuration
{
	/// <summary>
	/// Configuration context extensions
	/// </summary>
	public static class ConfigurationContextExtensions
	{
		/// <summary>
		/// Configuration settings of Sergey Kryzhanovsky's Minifier
		/// </summary>
		private static readonly Lazy<CssoSettings> _cssoConfig =
			new Lazy<CssoSettings>(() => (CssoSettings)ConfigurationManager.GetSection("bundleTransformer/csso"));

		/// <summary>
		/// Gets a Sergey Kryzhanovsky's Minifier configuration settings
		/// </summary>
		/// <param name="context">Configuration context</param>
		/// <returns>Configuration settings of Sergey Kryzhanovsky's Minifier</returns>
		public static CssoSettings GetCssoSettings(this IConfigurationContext context)
		{
			return _cssoConfig.Value;
		}
	}
}