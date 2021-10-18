How to update to a new version:

1) Download the new SDK from here:

  https://github.com/sumup/sumup-ios-sdk

2) On the mac, install Objective Sharpie.  See here:

   https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie

3) Run Objective Sharpie.  The commands will be something like:

      SumUp providing new version of lib for iOS xcframework
	so need to run command for every file in headers folder 
	SumUpSDK.framework/Headers/
		SMPCheckoutResult.h
		SMPCheckoutRequest.h
		SMPCurrencyCodes.h
		etc


     sharpie bind -output Binding  -sdk iphoneos15.0 SumUpSDK.framework/Headers/SMPCheckoutRequest.h -scope SumUpSDK.framework/Headers/ -n SumUpSDKBinding -c -F /Users/danilkurkin/SumUp/SumUpSDK.xcframework/ios-arm64_armv7/SumUpSDK.framework

  

4) Compare the generated .cs files with the existing ones in SumUpSDK.framework, and merge any required changes.  There will be
   many [Verify] attributes which need to be removed - these indicate where Objective Sharpie may have generated incorrect code.

5) Remove the SumUpSDK, PPHR_BLE, native references from the SumUpSDKBinding project, delete
   any leftover files in the folder and add the new versions of the frameworks from <path-to-sdk>/frameworks and
   <path-to-sdk>/RSDK/Release.

6) If building on Windows you will need to fix the hard-link files in the frameworks.  These can be viewed in Notepad to see
   what they point to, and should be replaced with that file or folder.

7) If Building from windows  - might not work as Xamarin has unresolved issues to build this lib under Windows 
