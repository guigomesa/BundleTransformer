﻿namespace BundleTransformer.CoffeeScript.Translators
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using SassAndCoffee.Core;
	using SassAndCoffee.JavaScript;
	using SassAndCoffee.JavaScript.CoffeeScript;

	using Core.Assets;
	using CoreStrings = Core.Resources.Strings;
	using Core.Translators;

	using CoffeeStrings = Resources.Strings;

	/// <summary>
	/// Translator that responsible for translation of CoffeeScript-code to JS-code
	/// </summary>
	public sealed class CoffeeScriptTranslator : ITranslator
	{
		/// <summary>
		/// Flag that object is destroyed
		/// </summary>
		private bool _disposed;

		/// <summary>
		/// Gets or sets a flag that web application is in debug mode
		/// </summary>
		public bool IsDebugMode
		{
			get;
			set;
		}


		/// <summary>
		/// Constructs instance of CoffeeScript-translator
		/// </summary>
		public CoffeeScriptTranslator()
		{
		}

		/// <summary>
		/// Destructs instance of CoffeeScript-translator
		/// </summary>
		~CoffeeScriptTranslator()
		{
			Dispose(false /* disposing */);
		}


		/// <summary>
		/// Translates code of assets written on CoffeeScript to JS-code
		/// </summary>
		/// <param name="assets">Set of assets with code written on CoffeeScript</param>
		/// <returns>Set of assets with translated code</returns>
		public IList<IAsset> Translate(IList<IAsset> assets)
		{
			if (assets == null)
			{
				throw new ArgumentException(CoreStrings.Common_ValueIsEmpty, "assets");
			}

			if (assets.Count == 0)
			{
				return assets;
			}

			foreach (var asset in assets.Where(a => a.AssetType == AssetType.CoffeeScript))
			{
				string newContent = String.Empty;

				using (var coffeeScriptCompiler = new CoffeeScriptCompiler(new InstanceProvider<IJavaScriptRuntime>(
					() => new IEJavaScriptRuntime())))
				{
					try
					{
						newContent = coffeeScriptCompiler.Compile(asset.Content);
					}
					catch (Exception e)
					{
						throw new AssetTranslationException(
							String.Format(CoffeeStrings.Translators_CoffeeScriptTranslationFailed, asset.Path), e);
					}
				}

				asset.Content = newContent;
			}

			return assets;
		}

		/// <summary>
		/// Destroys object
		/// </summary>
		public void Dispose()
		{
			Dispose(true /* disposing */);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Destroys object
		/// </summary>
		/// <param name="disposing">Flag, allowing destruction of 
		/// managed objects contained in fields of class</param>
		private void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				_disposed = true;
			}
		}
	}
}