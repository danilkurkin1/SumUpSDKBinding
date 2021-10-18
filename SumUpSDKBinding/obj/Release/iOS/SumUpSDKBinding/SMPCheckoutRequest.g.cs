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
	[Protocol (Name = "SMPCheckoutRequest", WrapperType = typeof (SMPCheckoutRequestWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "RequestWithTotal", Selector = "requestWithTotal:title:currencyCode:paymentOptions:", ReturnType = typeof (SumUpSDKBinding.SMPCheckoutRequest), ParameterType = new Type [] { typeof (NSDecimalNumber), typeof (string), typeof (string), typeof (SumUpSDKBinding.SMPPaymentOptions) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "RequestWithTotal", Selector = "requestWithTotal:title:currencyCode:", ReturnType = typeof (SumUpSDKBinding.SMPCheckoutRequest), ParameterType = new Type [] { typeof (NSDecimalNumber), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TotalAmount", Selector = "totalAmount", PropertyType = typeof (NSDecimalNumber), GetterSelector = "totalAmount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof (string), GetterSelector = "title", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrencyCode", Selector = "currencyCode", PropertyType = typeof (string), GetterSelector = "currencyCode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PaymentOptions", Selector = "paymentOptions", PropertyType = typeof (SumUpSDKBinding.SMPPaymentOptions), GetterSelector = "paymentOptions", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ForeignTransactionID", Selector = "foreignTransactionID", PropertyType = typeof (string), GetterSelector = "foreignTransactionID", SetterSelector = "setForeignTransactionID:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TipAmount", Selector = "tipAmount", PropertyType = typeof (NSDecimalNumber), GetterSelector = "tipAmount", SetterSelector = "setTipAmount:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SaleItemsCount", Selector = "saleItemsCount", PropertyType = typeof (nuint), GetterSelector = "saleItemsCount", SetterSelector = "setSaleItemsCount:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SkipScreenOptions", Selector = "skipScreenOptions", PropertyType = typeof (SumUpSDKBinding.SMPSkipScreenOptions), GetterSelector = "skipScreenOptions", SetterSelector = "setSkipScreenOptions:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	public partial interface ISMPCheckoutRequest : INativeObject, IDisposable
	{
	}
	public static partial class SMPCheckoutRequest_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber GetTotalAmount (this ISMPCheckoutRequest This)
		{
			return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("totalAmount")));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetTitle (this ISMPCheckoutRequest This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("title")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetCurrencyCode (this ISMPCheckoutRequest This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("currencyCode")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SMPPaymentOptions GetPaymentOptions (this ISMPCheckoutRequest This)
		{
			SMPPaymentOptions ret;
			ret = (SumUpSDKBinding.SMPPaymentOptions) (long) global::ApiDefinition.Messaging.nint_objc_msgSend (This.Handle, Selector.GetHandle ("paymentOptions"));
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetForeignTransactionID (this ISMPCheckoutRequest This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("foreignTransactionID")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetForeignTransactionID (this ISMPCheckoutRequest This, string value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setForeignTransactionID:"), nsvalue);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber GetTipAmount (this ISMPCheckoutRequest This)
		{
			return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tipAmount")));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTipAmount (this ISMPCheckoutRequest This, NSDecimalNumber value)
		{
			var value__handle__ = value.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTipAmount:"), value__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetSaleItemsCount (this ISMPCheckoutRequest This)
		{
			return global::ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("saleItemsCount"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSaleItemsCount (this ISMPCheckoutRequest This, nuint value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nuint (This.Handle, Selector.GetHandle ("setSaleItemsCount:"), value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SMPSkipScreenOptions GetSkipScreenOptions (this ISMPCheckoutRequest This)
		{
			SMPSkipScreenOptions ret;
			ret = (SumUpSDKBinding.SMPSkipScreenOptions) (long) global::ApiDefinition.Messaging.nint_objc_msgSend (This.Handle, Selector.GetHandle ("skipScreenOptions"));
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSkipScreenOptions (this ISMPCheckoutRequest This, SMPSkipScreenOptions value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("setSkipScreenOptions:"), (nint) (long) value);
		}
	}
	internal sealed class SMPCheckoutRequestWrapper : BaseWrapper, ISMPCheckoutRequest {
		[Preserve (Conditional = true)]
		public SMPCheckoutRequestWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace SumUpSDKBinding {
	[Protocol()]
	[Register("SMPCheckoutRequest", true)]
	public unsafe partial class SMPCheckoutRequest : NSObject, ISMPCheckoutRequest {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("SMPCheckoutRequest");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SMPCheckoutRequest () : base (NSObjectFlag.Empty)
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
		protected SMPCheckoutRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SMPCheckoutRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("requestWithTotal:title:currencyCode:paymentOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SMPCheckoutRequest RequestWithTotal (NSDecimalNumber totalAmount, string? title, string currencyCode, SMPPaymentOptions paymentOptions)
		{
			var totalAmount__handle__ = totalAmount.GetNonNullHandle (nameof (totalAmount));
			if (currencyCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currencyCode));
			var nstitle = CFString.CreateNative (title);
			var nscurrencyCode = CFString.CreateNative (currencyCode);
			SMPCheckoutRequest ret;
			ret =  Runtime.GetNSObject<SMPCheckoutRequest> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nint (class_ptr, Selector.GetHandle ("requestWithTotal:title:currencyCode:paymentOptions:"), totalAmount__handle__, nstitle, nscurrencyCode, (nint) (long) paymentOptions));
			CFString.ReleaseNative (nstitle);
			CFString.ReleaseNative (nscurrencyCode);
			return ret!;
		}
		[Export ("requestWithTotal:title:currencyCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SMPCheckoutRequest RequestWithTotal (NSDecimalNumber totalAmount, string? title, string currencyCode)
		{
			var totalAmount__handle__ = totalAmount.GetNonNullHandle (nameof (totalAmount));
			if (currencyCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currencyCode));
			var nstitle = CFString.CreateNative (title);
			var nscurrencyCode = CFString.CreateNative (currencyCode);
			SMPCheckoutRequest ret;
			ret =  Runtime.GetNSObject<SMPCheckoutRequest> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("requestWithTotal:title:currencyCode:"), totalAmount__handle__, nstitle, nscurrencyCode));
			CFString.ReleaseNative (nstitle);
			CFString.ReleaseNative (nscurrencyCode);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CurrencyCode {
			[Export ("currencyCode")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currencyCode")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currencyCode")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ForeignTransactionID {
			[Export ("foreignTransactionID")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("foreignTransactionID")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("foreignTransactionID")))!;
				}
			}
			[Export ("setForeignTransactionID:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setForeignTransactionID:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setForeignTransactionID:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SMPPaymentOptions PaymentOptions {
			[Export ("paymentOptions")]
			get {
				SMPPaymentOptions ret;
				if (IsDirectBinding) {
					ret = (SumUpSDKBinding.SMPPaymentOptions) (long) global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("paymentOptions"));
				} else {
					ret = (SumUpSDKBinding.SMPPaymentOptions) (long) global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentOptions"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint SaleItemsCount {
			[Export ("saleItemsCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("saleItemsCount"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("saleItemsCount"));
				}
			}
			[Export ("setSaleItemsCount:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setSaleItemsCount:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setSaleItemsCount:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SMPSkipScreenOptions SkipScreenOptions {
			[Export ("skipScreenOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				SMPSkipScreenOptions ret;
				if (IsDirectBinding) {
					ret = (SumUpSDKBinding.SMPSkipScreenOptions) (long) global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("skipScreenOptions"));
				} else {
					ret = (SumUpSDKBinding.SMPSkipScreenOptions) (long) global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("skipScreenOptions"));
				}
				return ret!;
			}
			[Export ("setSkipScreenOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setSkipScreenOptions:"), (nint) (long) value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setSkipScreenOptions:"), (nint) (long) value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber? TipAmount {
			[Export ("tipAmount", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tipAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tipAmount")));
				}
				return ret!;
			}
			[Export ("setTipAmount:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTipAmount:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTipAmount:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber? TotalAmount {
			[Export ("totalAmount")]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("totalAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("totalAmount")));
				}
				return ret!;
			}
		}
	} /* class SMPCheckoutRequest */
}
