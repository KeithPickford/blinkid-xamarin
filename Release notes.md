# Release notes

## 4.3.0

- Updated to [Android SDK v4.3.0](https://github.com/BlinkID/blinkid-android/releases/tag/v4.3.0)
- Updated to [iOS SDK v4.3.0](https://github.com/BlinkID/blinkid-ios/releases/tag/v4.3.0)

## 4.2.0

- Updated to [Android SDK v4.2.0](https://github.com/BlinkID/blinkid-android/releases/tag/v4.2.0)
- Updated to [iOS SDK v4.2.0](https://github.com/BlinkID/blinkid-ios/releases/tag/v4.2.0)

## 4.1.0

- Updated to [Android SDK v4.1.0](https://github.com/BlinkID/blinkid-android/releases/tag/v4.1.0)
- Updated to [iOS SDK v4.1.0](https://github.com/BlinkID/blinkid-ios/releases/tag/v4.1.0)

## 4.0.0

### New features

- updated to [BlinkID Android v4.0.0](https://github.com/BlinkID/blinkid-android/releases/tag/v4.0.0) and [BlinkID iOS v4.0.0](https://github.com/BlinkID/blinkid-ios/releases/tag/v4.0.0)
    - BlinkID v4.0.0 for iOS and Android had major API change, please read more in [this post](https://microblink.com/blog/major-change-of-the-api-and-in-the-license-key-formats)
- new API, which is not backwards compatible, but has lots of features that were not previously present, such as:
    - bindings for native iOS and Android SDKs
        - this basically lets you use any feature from native SDK directly from C# code
        - note that some features, such as custom UI development is currently not possible on Android, but this is a known issue and will be resolved in future release. iOS does not have these restrictions.
    - native support for Xamarin Forms - no need for specific iOS/Android development if only builtin recognizers and UI is used
    - NuGet packages that can be used directly from Visual Studio
- new license key format - not backward compatible with old license keys. Please use [Microblink Developer Dashboard](https://microblink.com/login) to generate your new trial key.

## 1.3

### Android

Unchanged since 1.0, same features like iOS 1.3 will be in upcoming release

### iOS

- iOS wrapper upgrade to blinkid-ios [2.15.0](https://github.com/BlinkID/blinkid-ios/releases/tag/v2.15.0)

- Updates and additions
    - added support for reading Malaysian MyTentera documents - use `AddMyTenteraRecognizer`
    - added support for reading Indonesian ID documents - use `AddIndonesianIDFrontRecognizer`
    - added support for reading Polish ID documents - use `AddPolishIDFrontRecognizer` and `AddPolishIDBackRecognizer`
    - added support for reading Australian Drivers License - use `AddAustraliaDLFrontRecognizer` and `AddAustraliaDLBackRecognizer`
    - added support for Combined recognizers - use `AddMrtdCombinedRecognizer`, `AddCroCombinedRecognizer`, `AddCzCombinedRecognizer`, `AddGerCombinedRecognizer`, `AddAusIDCombinedRecognizer`, `AddSerbIDCombinedRecognizer`, `AddSlovakCombinedRecognizer`, `AddPolishIDCombinedRecognizer`, `AddSingaporeCombinedRecognizer`, `AddSlovenianCombinedRecognizer`

- Bugfixes
    - fixed crash in `AddIdCardDetector`

## 1.2

- iOS wrapper upgrade to blinkid-ios [2.13.0](https://github.com/BlinkID/blinkid-ios/releases/tag/v2.13.0)

### Fixes

- Barcode recognizers: `BarDecoder`, `ZXing` and `Barcode` has settings for barcodes recognizing.

## 1.1

- iOS wrapper upgrade to blinkid-ios [2.11.0](https://github.com/BlinkID/blinkid-ios/releases/tag/v2.11.0)

### API changes

- Removed: `AddGerMrzRecognizer`
- Deprecated: `AddBarDecoderRecognizer`, `AddZXingRecognizer`
- Added: `AddAusPassportRecognizer`, `AddBarcodeRecognizer`, `AddGerIDOldRecognizer`, `AddGerPassportRecognizer`, `AddSwissPassportRecognizer`, `AddVinRecognizer`

### Fixes

- MRTD result - returned old items: `DateOfBirth` and `DateOfExpiry` as RAW OCR string

## 1.0

- First official version. 
- BlinkID-xamarin wraps BlinkID-ios native SDK at version [2.7.1](https://github.com/BlinkID/blinkid-ios/releases/tag/v2.7.1), and BlinkID-android at version [3.2.0](https://github.com/BlinkID/blinkid-android/releases/tag/v3.2.0)
