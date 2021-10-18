//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
#nullable enable
namespace SumUpSDKBinding {
	[Protocol (Name = "SMPSumUpSDK", WrapperType = typeof (SMPSumUpSDKWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetupWithAPIKey", Selector = "setupWithAPIKey:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "PresentLoginFromViewController", Selector = "presentLoginFromViewController:animated:completionBlock:", ParameterType = new Type [] { typeof (UIViewController), typeof (bool), typeof (SumUpSDKBinding.SMPCompletionBlock) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDSMPCompletionBlock) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "LoginWithToken", Selector = "loginWithToken:completion:", ParameterType = new Type [] { typeof (string), typeof (SumUpSDKBinding.SMPCompletionBlock) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDSMPCompletionBlock) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "PrepareForCheckout", Selector = "prepareForCheckout")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CheckoutWithRequest", Selector = "checkoutWithRequest:fromViewController:completion:", ParameterType = new Type [] { typeof (SumUpSDKBinding.SMPCheckoutRequest), typeof (UIViewController), typeof (SumUpSDKBinding.SMPCheckoutCompletionBlock) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDSMPCheckoutCompletionBlock) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "PresentCheckoutPreferencesFromViewController", Selector = "presentCheckoutPreferencesFromViewController:animated:completion:", ParameterType = new Type [] { typeof (UIViewController), typeof (bool), typeof (SumUpSDKBinding.SMPCompletionBlock) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDSMPCompletionBlock) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "LogoutWithCompletionBlock", Selector = "logoutWithCompletionBlock:", ParameterType = new Type [] { typeof (SumUpSDKBinding.SMPCompletionBlock) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDSMPCompletionBlock) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetUINotificationsForReaderStatusEnabled", Selector = "setUINotificationsForReaderStatusEnabled:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "IsLoggedIn", Selector = "isLoggedIn", PropertyType = typeof (bool), GetterSelector = "isLoggedIn", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "CurrentMerchant", Selector = "currentMerchant", PropertyType = typeof (SumUpSDKBinding.SMPMerchant), GetterSelector = "currentMerchant", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "CheckoutInProgress", Selector = "checkoutInProgress", PropertyType = typeof (bool), GetterSelector = "checkoutInProgress", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "BundleVersion", Selector = "bundleVersion", PropertyType = typeof (string), GetterSelector = "bundleVersion", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "BundleVersionShortString", Selector = "bundleVersionShortString", PropertyType = typeof (string), GetterSelector = "bundleVersionShortString", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "TestSDKIntegration", Selector = "testSDKIntegration", PropertyType = typeof (bool), GetterSelector = "testSDKIntegration", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ISMPSumUpSDK : INativeObject, IDisposable
	{
	}
	internal sealed class SMPSumUpSDKWrapper : BaseWrapper, ISMPSumUpSDK {
		[Preserve (Conditional = true)]
		public SMPSumUpSDKWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace SumUpSDKBinding {
	[Protocol()]
	[Register("SMPSumUpSDK", true)]
	public unsafe partial class SMPSumUpSDK : NSObject, ISMPSumUpSDK {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("SMPSumUpSDK");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SMPSumUpSDK () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SMPSumUpSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SMPSumUpSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("checkoutWithRequest:fromViewController:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CheckoutWithRequest (SMPCheckoutRequest request, global::UIKit.UIViewController controller, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSMPCheckoutCompletionBlock))]SMPCheckoutCompletionBlock? block)
		{
			var request__handle__ = request.GetNonNullHandle (nameof (request));
			var controller__handle__ = controller.GetNonNullHandle (nameof (controller));
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			if (block is null){
				block_ptr_block = null;
			} else {
				block_block = new BlockLiteral ();
				block_ptr_block = &block_block;
				block_block.SetupBlockUnsafe (Trampolines.SDSMPCheckoutCompletionBlock.Handler, block);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("checkoutWithRequest:fromViewController:completion:"), request__handle__, controller__handle__, (IntPtr) block_ptr_block);
			if (block_ptr_block != null)
				block_ptr_block->CleanupBlock ();
		}
		[Export ("loginWithToken:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoginWithToken (string aToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSMPCompletionBlock))]SMPCompletionBlock? block)
		{
			if (aToken is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aToken));
			var nsaToken = CFString.CreateNative (aToken);
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			if (block is null){
				block_ptr_block = null;
			} else {
				block_block = new BlockLiteral ();
				block_ptr_block = &block_block;
				block_block.SetupBlockUnsafe (Trampolines.SDSMPCompletionBlock.Handler, block);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("loginWithToken:completion:"), nsaToken, (IntPtr) block_ptr_block);
			CFString.ReleaseNative (nsaToken);
			if (block_ptr_block != null)
				block_ptr_block->CleanupBlock ();
		}
		[Export ("logoutWithCompletionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LogoutWithCompletionBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSMPCompletionBlock))]SMPCompletionBlock? block)
		{
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			if (block is null){
				block_ptr_block = null;
			} else {
				block_block = new BlockLiteral ();
				block_ptr_block = &block_block;
				block_block.SetupBlockUnsafe (Trampolines.SDSMPCompletionBlock.Handler, block);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("logoutWithCompletionBlock:"), (IntPtr) block_ptr_block);
			if (block_ptr_block != null)
				block_ptr_block->CleanupBlock ();
		}
		[Export ("prepareForCheckout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PrepareForCheckout ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("prepareForCheckout"));
		}
		[Export ("presentCheckoutPreferencesFromViewController:animated:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PresentCheckoutPreferencesFromViewController (global::UIKit.UIViewController fromViewController, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSMPCompletionBlock))]SMPCompletionBlock? block)
		{
			var fromViewController__handle__ = fromViewController.GetNonNullHandle (nameof (fromViewController));
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			if (block is null){
				block_ptr_block = null;
			} else {
				block_block = new BlockLiteral ();
				block_ptr_block = &block_block;
				block_block.SetupBlockUnsafe (Trampolines.SDSMPCompletionBlock.Handler, block);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (class_ptr, Selector.GetHandle ("presentCheckoutPreferencesFromViewController:animated:completion:"), fromViewController__handle__, animated, (IntPtr) block_ptr_block);
			if (block_ptr_block != null)
				block_ptr_block->CleanupBlock ();
		}
		[Export ("presentLoginFromViewController:animated:completionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PresentLoginFromViewController (global::UIKit.UIViewController fromViewController, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSMPCompletionBlock))]SMPCompletionBlock? block)
		{
			var fromViewController__handle__ = fromViewController.GetNonNullHandle (nameof (fromViewController));
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			if (block is null){
				block_ptr_block = null;
			} else {
				block_block = new BlockLiteral ();
				block_ptr_block = &block_block;
				block_block.SetupBlockUnsafe (Trampolines.SDSMPCompletionBlock.Handler, block);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (class_ptr, Selector.GetHandle ("presentLoginFromViewController:animated:completionBlock:"), fromViewController__handle__, animated, (IntPtr) block_ptr_block);
			if (block_ptr_block != null)
				block_ptr_block->CleanupBlock ();
		}
		[Export ("setUINotificationsForReaderStatusEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUINotificationsForReaderStatusEnabled (bool enabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setUINotificationsForReaderStatusEnabled:"), enabled);
		}
		[Export ("setupWithAPIKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetupWithAPIKey (string apiKey)
		{
			if (apiKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			var nsapiKey = CFString.CreateNative (apiKey);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setupWithAPIKey:"), nsapiKey);
			CFString.ReleaseNative (nsapiKey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string BundleVersion {
			[Export ("bundleVersion")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("bundleVersion")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string BundleVersionShortString {
			[Export ("bundleVersionShortString")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("bundleVersionShortString")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CheckoutInProgress {
			[Export ("checkoutInProgress")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("checkoutInProgress"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SMPMerchant? CurrentMerchant {
			[Export ("currentMerchant")]
			get {
				SMPMerchant ret;
				ret =  Runtime.GetNSObject<SMPMerchant> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("currentMerchant")));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsLoggedIn {
			[Export ("isLoggedIn")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isLoggedIn"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool TestSDKIntegration {
			[Export ("testSDKIntegration")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("testSDKIntegration"));
			}
		}
	} /* class SMPSumUpSDK */
}
