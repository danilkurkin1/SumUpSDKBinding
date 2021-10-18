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
	[Protocol (Name = "SMPSumUpRegisterSDK", WrapperType = typeof (SMPSumUpRegisterSDKWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartListeningForRegister", Selector = "startListeningForRegister")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StopListeningForRegister", Selector = "stopListeningForRegister")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrintEscPos", Selector = "printEscPos:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenDrawer", Selector = "openDrawer")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartFirmwareUpdateWithCompletion", Selector = "startFirmwareUpdateWithCompletion:", ParameterType = new Type [] { typeof (SumUpSDKBinding.SMPRegisterCompletionBlock) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDSMPRegisterCompletionBlock) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "RegisterIsSupported", Selector = "registerIsSupported", PropertyType = typeof (bool), GetterSelector = "registerIsSupported", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "SharedInstance", Selector = "sharedInstance", PropertyType = typeof (SumUpSDKBinding.SMPSumUpRegisterSDK), GetterSelector = "sharedInstance", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeakDelegate", Selector = "delegate", PropertyType = typeof (NSObject), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DeviceStatus", Selector = "deviceStatus", PropertyType = typeof (SumUpSDKBinding.SMPRegisterSDKStatus), GetterSelector = "deviceStatus", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PrinterStatus", Selector = "printerStatus", PropertyType = typeof (SumUpSDKBinding.SMPRegisterSDKPrinterStatus), GetterSelector = "printerStatus", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DrawerIsOpen", Selector = "drawerIsOpen", PropertyType = typeof (bool), GetterSelector = "drawerIsOpen", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ISMPSumUpRegisterSDK : INativeObject, IDisposable
	{
	}
	public static partial class SMPSumUpRegisterSDK_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartListeningForRegister (this ISMPSumUpRegisterSDK This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("startListeningForRegister"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopListeningForRegister (this ISMPSumUpRegisterSDK This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("stopListeningForRegister"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PrintEscPos (this ISMPSumUpRegisterSDK This, string escposString)
		{
			if (escposString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (escposString));
			var nsescposString = CFString.CreateNative (escposString);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("printEscPos:"), nsescposString);
			CFString.ReleaseNative (nsescposString);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OpenDrawer (this ISMPSumUpRegisterSDK This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("openDrawer"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void StartFirmwareUpdateWithCompletion (this ISMPSumUpRegisterSDK This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSMPRegisterCompletionBlock))]SMPRegisterCompletionBlock completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSMPRegisterCompletionBlock.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("startFirmwareUpdateWithCompletion:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetWeakDelegate (this ISMPSumUpRegisterSDK This)
		{
			return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWeakDelegate (this ISMPSumUpRegisterSDK This, NSObject value)
		{
			var value__handle__ = value.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SMPRegisterSDKStatus GetDeviceStatus (this ISMPSumUpRegisterSDK This)
		{
			return  Runtime.GetNSObject<SMPRegisterSDKStatus> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("deviceStatus")));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SMPRegisterSDKPrinterStatus GetPrinterStatus (this ISMPSumUpRegisterSDK This)
		{
			return  Runtime.GetNSObject<SMPRegisterSDKPrinterStatus> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("printerStatus")));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDrawerIsOpen (this ISMPSumUpRegisterSDK This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("drawerIsOpen"));
		}
	}
	internal sealed class SMPSumUpRegisterSDKWrapper : BaseWrapper, ISMPSumUpRegisterSDK {
		[Preserve (Conditional = true)]
		public SMPSumUpRegisterSDKWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace SumUpSDKBinding {
	[Protocol()]
	[Register("SMPSumUpRegisterSDK", true)]
	public unsafe partial class SMPSumUpRegisterSDK : NSObject, ISMPSumUpRegisterSDK {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("SMPSumUpRegisterSDK");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SMPSumUpRegisterSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SMPSumUpRegisterSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("openDrawer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenDrawer ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("openDrawer"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openDrawer"));
			}
		}
		[Export ("printEscPos:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrintEscPos (string escposString)
		{
			if (escposString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (escposString));
			var nsescposString = CFString.CreateNative (escposString);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("printEscPos:"), nsescposString);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("printEscPos:"), nsescposString);
			}
			CFString.ReleaseNative (nsescposString);
		}
		[Export ("startFirmwareUpdateWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartFirmwareUpdateWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSMPRegisterCompletionBlock))]SMPRegisterCompletionBlock completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDSMPRegisterCompletionBlock.Handler, completion);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startFirmwareUpdateWithCompletion:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startFirmwareUpdateWithCompletion:"), (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("startListeningForRegister")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartListeningForRegister ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startListeningForRegister"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startListeningForRegister"));
			}
		}
		[Export ("stopListeningForRegister")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopListeningForRegister ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopListeningForRegister"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopListeningForRegister"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SMPSumUpRegisterSDKDelegate? Delegate {
			get {
				return (WeakDelegate as SMPSumUpRegisterSDKDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SMPRegisterSDKStatus? DeviceStatus {
			[Export ("deviceStatus")]
			get {
				SMPRegisterSDKStatus ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SMPRegisterSDKStatus> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("deviceStatus")));
				} else {
					ret =  Runtime.GetNSObject<SMPRegisterSDKStatus> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceStatus")));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawerIsOpen {
			[Export ("drawerIsOpen")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("drawerIsOpen"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("drawerIsOpen"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SMPRegisterSDKPrinterStatus? PrinterStatus {
			[Export ("printerStatus")]
			get {
				SMPRegisterSDKPrinterStatus ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SMPRegisterSDKPrinterStatus> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("printerStatus")));
				} else {
					ret =  Runtime.GetNSObject<SMPRegisterSDKPrinterStatus> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("printerStatus")));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RegisterIsSupported {
			[Export ("registerIsSupported")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("registerIsSupported"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SMPSumUpRegisterSDK? SharedInstance {
			[Export ("sharedInstance")]
			get {
				SMPSumUpRegisterSDK ret;
				ret =  Runtime.GetNSObject<SMPSumUpRegisterSDK> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class SMPSumUpRegisterSDK */
}
