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
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::SumUpSDKBinding.SMPCheckoutCompletionBlock))]
		internal delegate void DSMPCheckoutCompletionBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSMPCheckoutCompletionBlock {
			static internal readonly DSMPCheckoutCompletionBlock Handler = Invoke;
			[MonoPInvokeCallback (typeof (DSMPCheckoutCompletionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::SumUpSDKBinding.SMPCheckoutCompletionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SumUpSDKBinding.SMPCheckoutResult> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDSMPCheckoutCompletionBlock */
		internal sealed class NIDSMPCheckoutCompletionBlock : TrampolineBlockBase {
			DSMPCheckoutCompletionBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSMPCheckoutCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSMPCheckoutCompletionBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::SumUpSDKBinding.SMPCheckoutCompletionBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::SumUpSDKBinding.SMPCheckoutCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSMPCheckoutCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::SumUpSDKBinding.SMPCheckoutResult? arg0, NSError? arg1)
			{
				var arg0__handle__ = arg0.GetHandle ();
				var arg1__handle__ = arg1.GetHandle ();
				invoker (BlockPointer, arg0__handle__, arg1__handle__);
			}
		} /* class NIDSMPCheckoutCompletionBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::SumUpSDKBinding.SMPCompletionBlock))]
		internal delegate void DSMPCompletionBlock (IntPtr block, bool arg0, IntPtr arg1);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSMPCompletionBlock {
			static internal readonly DSMPCompletionBlock Handler = Invoke;
			[MonoPInvokeCallback (typeof (DSMPCompletionBlock))]
			static unsafe void Invoke (IntPtr block, bool arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::SumUpSDKBinding.SMPCompletionBlock) (descriptor->Target);
				if (del != null)
					del (arg0,  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDSMPCompletionBlock */
		internal sealed class NIDSMPCompletionBlock : TrampolineBlockBase {
			DSMPCompletionBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSMPCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSMPCompletionBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::SumUpSDKBinding.SMPCompletionBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::SumUpSDKBinding.SMPCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSMPCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool arg0, NSError? arg1)
			{
				var arg1__handle__ = arg1.GetHandle ();
				invoker (BlockPointer, arg0, arg1__handle__);
			}
		} /* class NIDSMPCompletionBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::SumUpSDKBinding.SMPRegisterCompletionBlock))]
		internal delegate void DSMPRegisterCompletionBlock (IntPtr block, bool arg0, IntPtr arg1);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSMPRegisterCompletionBlock {
			static internal readonly DSMPRegisterCompletionBlock Handler = Invoke;
			[MonoPInvokeCallback (typeof (DSMPRegisterCompletionBlock))]
			static unsafe void Invoke (IntPtr block, bool arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::SumUpSDKBinding.SMPRegisterCompletionBlock) (descriptor->Target);
				if (del != null)
					del (arg0,  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDSMPRegisterCompletionBlock */
		internal sealed class NIDSMPRegisterCompletionBlock : TrampolineBlockBase {
			DSMPRegisterCompletionBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDSMPRegisterCompletionBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DSMPRegisterCompletionBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::SumUpSDKBinding.SMPRegisterCompletionBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::SumUpSDKBinding.SMPRegisterCompletionBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDSMPRegisterCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool arg0, NSError? arg1)
			{
				var arg1__handle__ = arg1.GetHandle ();
				invoker (BlockPointer, arg0, arg1__handle__);
			}
		} /* class NIDSMPRegisterCompletionBlock */
	}
}
