

   ----------------------------------------------------------------------
             README file for Bundle Transformer: UglifyJS 1.6.1
 
   ----------------------------------------------------------------------

          Copyright 2012 Andrey Taritsyn - http://www.taritsyn.ru


   ===========
   DESCRIPTION
   ===========
   BundleTransformer.UglifyJs contains one minifier-adapter for 
   minification of JS-code - UglifyJsMinifier. UglifyJsMinifier is based 
   on the Mihai Bazon's UglifyJS (http://github.com/mishoo/UglifyJS) 
   version 1.3.3.
   
   ====================
   POST-INSTALL ACTIONS
   ====================
   To make UglifyJsMinifier is the default JS-minifier, you need to 
   make changes to the Web.config file. In the defaultMinifier attribute 
   of the \configuration\bundleTransformer\core\js element must be set 
   value equal to UglifyJsMinifier.
   
   =============
   DOCUMENTATION
   =============
   See documentation on CodePlex - 
   http://bundletransformer.codeplex.com/documentation