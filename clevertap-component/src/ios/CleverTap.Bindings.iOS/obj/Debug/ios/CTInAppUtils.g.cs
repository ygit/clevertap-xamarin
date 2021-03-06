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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
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

namespace CleverTapSDK {
	[Protocol (Name = "CTInAppUtils", WrapperType = typeof (CTInAppUtilsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "InAppTypeFromString", Selector = "inAppTypeFromString:", ReturnType = typeof (CleverTapSDK.CTInAppType), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "XibNameForControllerName", Selector = "XibNameForControllerName:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "ImageForName", Selector = "imageForName:type:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Ct_colorWithHexString", Selector = "ct_colorWithHexString:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Ct_colorWithHexString", Selector = "ct_colorWithHexString:withAlpha:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (string), typeof (nfloat) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Bundle", Selector = "bundle", PropertyType = typeof (NSBundle), GetterSelector = "bundle", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICTInAppUtils : INativeObject, IDisposable
	{
	}
	
	internal sealed class CTInAppUtilsWrapper : BaseWrapper, ICTInAppUtils {
		[Preserve (Conditional = true)]
		public CTInAppUtilsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTInAppUtils", true)]
	public unsafe partial class CTInAppUtils : NSObject, ICTInAppUtils {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTInAppUtils");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTInAppUtils () : base (NSObjectFlag.Empty)
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
		protected CTInAppUtils (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTInAppUtils (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("ct_colorWithHexString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor Ct_colorWithHexString (string @string)
		{
			if (@string == null)
				throw new ArgumentNullException ("@string");
			var nsstring = NSString.CreateNative (@string);
			
			global::UIKit.UIColor ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("ct_colorWithHexString:"), nsstring));
			NSString.ReleaseNative (nsstring);
			
			return ret;
		}
		
		[Export ("ct_colorWithHexString:withAlpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor Ct_colorWithHexString (string @string, nfloat alpha)
		{
			if (@string == null)
				throw new ArgumentNullException ("@string");
			var nsstring = NSString.CreateNative (@string);
			
			global::UIKit.UIColor ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nfloat (class_ptr, Selector.GetHandle ("ct_colorWithHexString:withAlpha:"), nsstring, alpha));
			NSString.ReleaseNative (nsstring);
			
			return ret;
		}
		
		[Export ("imageForName:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage ImageForName (string name, string type)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (type == null)
				throw new ArgumentNullException ("type");
			var nsname = NSString.CreateNative (name);
			var nstype = NSString.CreateNative (type);
			
			global::UIKit.UIImage ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("imageForName:type:"), nsname, nstype));
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nstype);
			
			return ret;
		}
		
		[Export ("inAppTypeFromString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTInAppType InAppTypeFromString (string type)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			var nstype = NSString.CreateNative (type);
			
			CTInAppType ret;
			if (IntPtr.Size == 8) {
				ret = (CTInAppType) global::ApiDefinition.Messaging.UInt64_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("inAppTypeFromString:"), nstype);
			} else {
				ret = (CTInAppType) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("inAppTypeFromString:"), nstype);
			}
			NSString.ReleaseNative (nstype);
			
			return ret;
		}
		
		[Export ("XibNameForControllerName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string XibNameForControllerName (string controllerName)
		{
			if (controllerName == null)
				throw new ArgumentNullException ("controllerName");
			var nscontrollerName = NSString.CreateNative (controllerName);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("XibNameForControllerName:"), nscontrollerName));
			NSString.ReleaseNative (nscontrollerName);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle Bundle {
			[Export ("bundle")]
			get {
				NSBundle ret;
				ret =  Runtime.GetNSObject<NSBundle> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("bundle")));
				return ret;
			}
			
		}
		
	} /* class CTInAppUtils */
}
