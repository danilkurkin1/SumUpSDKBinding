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
	[Protocol (Name = "SMPSumUpRegisterSDKDelegate", WrapperType = typeof (SMPSumUpRegisterSDKDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RegisterDidConnect", Selector = "registerDidConnect:", ParameterType = new Type [] { typeof (SumUpSDKBinding.SMPRegisterSDKStatus) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RegisterDidDisconnect", Selector = "registerDidDisconnect")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RegisterStatusDidChange", Selector = "registerStatusDidChange:", ParameterType = new Type [] { typeof (SumUpSDKBinding.SMPRegisterSDKStatus) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawerDidOpen", Selector = "drawerDidOpen")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawerDidClose", Selector = "drawerDidClose")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PrinterStatusDidChange", Selector = "printerStatusDidChange:", ParameterType = new Type [] { typeof (SumUpSDKBinding.SMPRegisterSDKPrinterStatus) }, ParameterByRef = new bool [] { false })]
	public partial interface ISMPSumUpRegisterSDKDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("registerDidConnect:")]
		[Preserve (Conditional = true)]
		void RegisterDidConnect (SMPRegisterSDKStatus deviceStatus);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("registerDidDisconnect")]
		[Preserve (Conditional = true)]
		void RegisterDidDisconnect ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("registerStatusDidChange:")]
		[Preserve (Conditional = true)]
		void RegisterStatusDidChange (SMPRegisterSDKStatus? deviceStatus);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("drawerDidOpen")]
		[Preserve (Conditional = true)]
		void DrawerDidOpen ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("drawerDidClose")]
		[Preserve (Conditional = true)]
		void DrawerDidClose ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("printerStatusDidChange:")]
		[Preserve (Conditional = true)]
		void PrinterStatusDidChange (SMPRegisterSDKPrinterStatus? status);
	}
	internal sealed class SMPSumUpRegisterSDKDelegateWrapper : BaseWrapper, ISMPSumUpRegisterSDKDelegate {
		[Preserve (Conditional = true)]
		public SMPSumUpRegisterSDKDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("registerDidConnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RegisterDidConnect (SMPRegisterSDKStatus deviceStatus)
		{
			var deviceStatus__handle__ = deviceStatus.GetNonNullHandle (nameof (deviceStatus));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerDidConnect:"), deviceStatus__handle__);
		}
		[Export ("registerDidDisconnect")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RegisterDidDisconnect ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("registerDidDisconnect"));
		}
		[Export ("registerStatusDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RegisterStatusDidChange (SMPRegisterSDKStatus? deviceStatus)
		{
			var deviceStatus__handle__ = deviceStatus.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerStatusDidChange:"), deviceStatus__handle__);
		}
		[Export ("drawerDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawerDidOpen ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("drawerDidOpen"));
		}
		[Export ("drawerDidClose")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DrawerDidClose ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("drawerDidClose"));
		}
		[Export ("printerStatusDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PrinterStatusDidChange (SMPRegisterSDKPrinterStatus? status)
		{
			var status__handle__ = status.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("printerStatusDidChange:"), status__handle__);
		}
	}
}
namespace SumUpSDKBinding {
	[Protocol()]
	[Register("SMPSumUpRegisterSDKDelegate", false)]
	[Model]
	public unsafe abstract partial class SMPSumUpRegisterSDKDelegate : NSObject, ISMPSumUpRegisterSDKDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SMPSumUpRegisterSDKDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SMPSumUpRegisterSDKDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SMPSumUpRegisterSDKDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("drawerDidClose")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DrawerDidClose ();
		[Export ("drawerDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DrawerDidOpen ();
		[Export ("printerStatusDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void PrinterStatusDidChange (SMPRegisterSDKPrinterStatus? status);
		[Export ("registerDidConnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void RegisterDidConnect (SMPRegisterSDKStatus deviceStatus);
		[Export ("registerDidDisconnect")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void RegisterDidDisconnect ();
		[Export ("registerStatusDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void RegisterStatusDidChange (SMPRegisterSDKStatus? deviceStatus);
	} /* class SMPSumUpRegisterSDKDelegate */
}
