﻿using System.Web;
using System.Web.Caching;

using BundleTransformer.Core;
using BundleTransformer.Core.Assets;
using BundleTransformer.Core.Configuration;
using BundleTransformer.Core.FileSystem;
using BundleTransformer.Core.HttpHandlers;
using BundleTransformer.Core.Transformers;

using BundleTransformer.CoffeeScript.Translators;

namespace BundleTransformer.CoffeeScript.HttpHandlers
{
	/// <summary>
	/// Debugging HTTP handler that responsible for text output
	/// of translated CoffeeScript asset
	/// </summary>
	public sealed class CoffeeScriptAssetHandler : ScriptAssetHandlerBase
	{
		/// <summary>
		/// Gets a value indicating whether asset is static
		/// </summary>
		protected override bool IsStaticAsset
		{
			get { return false; }
		}


		/// <summary>
		/// Constructs a instance of the debugging CoffeeScript HTTP handler
		/// </summary>
		public CoffeeScriptAssetHandler()
			: this(HttpContext.Current.Cache,
				BundleTransformerContext.Current.FileSystem.GetVirtualFileSystemWrapper(),
				BundleTransformerContext.Current.Configuration.GetCoreSettings().AssetHandler)
		{ }

		/// <summary>
		/// Constructs a instance of the debugging CoffeeScript HTTP handler
		/// </summary>
		/// <param name="cache">Server cache</param>
		/// <param name="virtualFileSystemWrapper">Virtual file system wrapper</param>
		/// <param name="assetHandlerConfig">Configuration settings of the debugging HTTP handler</param>
		public CoffeeScriptAssetHandler(Cache cache,
			IVirtualFileSystemWrapper virtualFileSystemWrapper,
			AssetHandlerSettings assetHandlerConfig)
			: base(cache, virtualFileSystemWrapper, assetHandlerConfig)
		{ }


		/// <summary>
		/// Translates a code of asset written on CoffeeScript to JS code
		/// </summary>
		/// <param name="asset">Asset</param>
		/// <param name="transformer">Transformer</param>
		/// <param name="isDebugMode">Flag that web application is in debug mode</param>
		/// <returns>Translated asset</returns>
		protected override IAsset TranslateAsset(IAsset asset, ITransformer transformer, bool isDebugMode)
		{
			IAsset processedAsset = InnerTranslateAsset<CoffeeScriptTranslator>(
				Constants.TranslatorName.CoffeeScriptTranslator, asset, transformer, isDebugMode);

			return processedAsset;
		}
	}
}