using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using Xminder;

namespace Xminder
{
    // @interface FaceTec : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTec
    {
        // @property (readonly, nonatomic, strong, class) id<FaceTecSDKProtocol> _Nonnull sdk;
        [Static]
        [Export("sdk", ArgumentSemantic.Strong)]
        IFaceTecSDKProtocol Sdk { get; }
    }

    // @interface FaceTecCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecCustomization
    {
        // @property (nonatomic, strong) FaceTecSessionTimerCustomization * _Nonnull sessionTimerCustomization;
        [Export("sessionTimerCustomization", ArgumentSemantic.Strong)]
        FaceTecSessionTimerCustomization SessionTimerCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecOCRConfirmationCustomization * _Nonnull ocrConfirmationCustomization;
        [Export("ocrConfirmationCustomization", ArgumentSemantic.Strong)]
        FaceTecOCRConfirmationCustomization OcrConfirmationCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecIDScanCustomization * _Nonnull idScanCustomization;
        [Export("idScanCustomization", ArgumentSemantic.Strong)]
        FaceTecIDScanCustomization IdScanCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecOverlayCustomization * _Nonnull overlayCustomization;
        [Export("overlayCustomization", ArgumentSemantic.Strong)]
        FaceTecOverlayCustomization OverlayCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecGuidanceCustomization * _Nonnull guidanceCustomization;
        [Export("guidanceCustomization", ArgumentSemantic.Strong)]
        FaceTecGuidanceCustomization GuidanceCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecResultScreenCustomization * _Nonnull resultScreenCustomization;
        [Export("resultScreenCustomization", ArgumentSemantic.Strong)]
        FaceTecResultScreenCustomization ResultScreenCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecOvalCustomization * _Nonnull ovalCustomization;
        [Export("ovalCustomization", ArgumentSemantic.Strong)]
        FaceTecOvalCustomization OvalCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecFeedbackCustomization * _Nonnull feedbackCustomization;
        [Export("feedbackCustomization", ArgumentSemantic.Strong)]
        FaceTecFeedbackCustomization FeedbackCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecCancelButtonCustomization * _Nonnull cancelButtonCustomization;
        [Export("cancelButtonCustomization", ArgumentSemantic.Strong)]
        FaceTecCancelButtonCustomization CancelButtonCustomization { get; set; }

        // @property (nonatomic, strong) FaceTecFrameCustomization * _Nonnull frameCustomization;
        [Export("frameCustomization", ArgumentSemantic.Strong)]
        FaceTecFrameCustomization FrameCustomization { get; set; }

        // @property (nonatomic) enum FaceTecSecurityWatermarkImage securityWatermarkImage;
        [Export("securityWatermarkImage", ArgumentSemantic.Assign)]
        FaceTecSecurityWatermarkImage SecurityWatermarkImage { get; set; }

        // @property (nonatomic, strong) FaceTecVocalGuidanceCustomization * _Nonnull vocalGuidanceCustomization;
        [Export("vocalGuidanceCustomization", ArgumentSemantic.Strong)]
        FaceTecVocalGuidanceCustomization VocalGuidanceCustomization { get; set; }

        // @property (nonatomic) enum FaceTecExitAnimationStyle exitAnimationUnsuccess;
        [Export("exitAnimationUnsuccess", ArgumentSemantic.Assign)]
        FaceTecExitAnimationStyle ExitAnimationUnsuccess { get; set; }

        // @property (nonatomic) enum FaceTecExitAnimationStyle exitAnimationSuccess;
        [Export("exitAnimationSuccess", ArgumentSemantic.Assign)]
        FaceTecExitAnimationStyle ExitAnimationSuccess { get; set; }

        // +(NSString * _Nullable)overrideResultScreenSuccessMessage;
        // +(void)setOverrideResultScreenSuccessMessage:(NSString * _Nonnull)value;
        [Static]
        [NullAllowed, Export("overrideResultScreenSuccessMessage")]
        string OverrideResultScreenSuccessMessage { get; set; }

        // +(void)setIDScanResultScreenMessageOverridesForSuccessFrontSide:(NSString * _Nonnull)successFrontSide successFrontSideBackNext:(NSString * _Nonnull)successFrontSideBackNext successBackSide:(NSString * _Nonnull)successBackSide successUserConfirmation:(NSString * _Nonnull)successUserConfirmation successNFC:(NSString * _Nonnull)successNFC retryFaceDidNotMatch:(NSString * _Nonnull)retryFaceDidNotMatch retryIDNotFullyVisible:(NSString * _Nonnull)retryIDNotFullyVisible retryOCRResultsNotGoodEnough:(NSString * _Nonnull)retryOCRResultsNotGoodEnough retryIDTypeNotSupported:(NSString * _Nonnull)retryIDTypeNotSupported skipOrErrorNFC:(NSString * _Nonnull)skipOrErrorNFC __attribute__((swift_name("setIDScanResultScreenMessageOverrides(successFrontSide:successFrontSideBackNext:successBackSide:successUserConfirmation:successNFC:retryFaceDidNotMatch:retryIDNotFullyVisible:retryOCRResultsNotGoodEnough:retryIDTypeNotSupported:skipOrErrorNFC:)")));
        [Static]
        [Export("setIDScanResultScreenMessageOverridesForSuccessFrontSide:successFrontSideBackNext:successBackSide:successUserConfirmation:successNFC:retryFaceDidNotMatch:retryIDNotFullyVisible:retryOCRResultsNotGoodEnough:retryIDTypeNotSupported:skipOrErrorNFC:")]
        void SetIDScanResultScreenMessageOverridesForSuccessFrontSide(string successFrontSide, string successFrontSideBackNext, string successBackSide, string successUserConfirmation, string successNFC, string retryFaceDidNotMatch, string retryIDNotFullyVisible, string retryOCRResultsNotGoodEnough, string retryIDTypeNotSupported, string skipOrErrorNFC);

        // +(void)setIDScanResultScreenMessageOverridesForSuccessFrontSide:(NSString * _Nonnull)successFrontSide successFrontSideBackNext:(NSString * _Nonnull)successFrontSideBackNext successBackSide:(NSString * _Nonnull)successBackSide successUserConfirmation:(NSString * _Nonnull)successUserConfirmation successNFC:(NSString * _Nonnull)successNFC retryFaceDidNotMatch:(NSString * _Nonnull)retryFaceDidNotMatch retryIDNotFullyVisible:(NSString * _Nonnull)retryIDNotFullyVisible retryOCRResultsNotGoodEnough:(NSString * _Nonnull)retryOCRResultsNotGoodEnough skipOrErrorNFC:(NSString * _Nonnull)skipOrErrorNFC __attribute__((swift_name("setIDScanResultScreenMessageOverrides(successFrontSide:successFrontSideBackNext:successBackSide:successUserConfirmation:successNFC:retryFaceDidNotMatch:retryIDNotFullyVisible:retryOCRResultsNotGoodEnough:skipOrErrorNFC:)"))) __attribute__((deprecated("This API method is deprecated and will be removed in an upcoming release of the iOS SDK. Use the non-deprecated setIDScanResultScreenMessageOverrides API method instead.")));
        [Static]
        [Export("setIDScanResultScreenMessageOverridesForSuccessFrontSide:successFrontSideBackNext:successBackSide:successUserConfirmation:successNFC:retryFaceDidNotMatch:retryIDNotFullyVisible:retryOCRResultsNotGoodEnough:skipOrErrorNFC:")]
        void SetIDScanResultScreenMessageOverridesForSuccessFrontSide(string successFrontSide, string successFrontSideBackNext, string successBackSide, string successUserConfirmation, string successNFC, string retryFaceDidNotMatch, string retryIDNotFullyVisible, string retryOCRResultsNotGoodEnough, string skipOrErrorNFC);

        // +(void)setIDScanResultScreenMessageOverridesForSuccessFrontSide:(NSString * _Nonnull)successFrontSide successFrontSideBackNext:(NSString * _Nonnull)successFrontSideBackNext successBackSide:(NSString * _Nonnull)successBackSide successUserConfirmation:(NSString * _Nonnull)successUserConfirmation retryFaceDidNotMatch:(NSString * _Nonnull)retryFaceDidNotMatch retryIDNotFullyVisible:(NSString * _Nonnull)retryIDNotFullyVisible retryOCRResultsNotGoodEnough:(NSString * _Nonnull)retryOCRResultsNotGoodEnough __attribute__((swift_name("setIDScanResultScreenMessageOverrides(successFrontSide:successFrontSideBackNext:successBackSide:successUserConfirmation:retryFaceDidNotMatch:retryIDNotFullyVisible:retryOCRResultsNotGoodEnough:)"))) __attribute__((deprecated("This API method is deprecated and will be removed in an upcoming release of the iOS SDK. Use the non-deprecated setIDScanResultScreenMessageOverrides API method instead.")));
        [Static]
        [Export("setIDScanResultScreenMessageOverridesForSuccessFrontSide:successFrontSideBackNext:successBackSide:successUserConfirmation:retryFaceDidNotMatch:retryIDNotFullyVisible:retryOCRResultsNotGoodEnough:")]
        void SetIDScanResultScreenMessageOverridesForSuccessFrontSide(string successFrontSide, string successFrontSideBackNext, string successBackSide, string successUserConfirmation, string retryFaceDidNotMatch, string retryIDNotFullyVisible, string retryOCRResultsNotGoodEnough);

        // +(NSDictionary * _Nullable)idScanResultScreenMessageOverrides;
        [Static]
        [NullAllowed, Export("idScanResultScreenMessageOverrides")]
        NSDictionary IdScanResultScreenMessageOverrides { get; }

        // +(void)setIDScanUploadMessageOverridesForFrontSideUploadStarted:(NSString * _Nonnull)frontSideUploadStarted frontSideStillUploading:(NSString * _Nonnull)frontSideStillUploading frontSideUploadCompleteAwaitingResponse:(NSString * _Nonnull)frontSideUploadCompleteAwaitingResponse frontSideUploadCompleteAwaitingProcessing:(NSString * _Nonnull)frontSideUploadCompleteAwaitingProcessing backSideUploadStarted:(NSString * _Nonnull)backSideUploadStarted backSideStillUploading:(NSString * _Nonnull)backSideStillUploading backSideUploadCompleteAwaitingResponse:(NSString * _Nonnull)backSideUploadCompleteAwaitingResponse backSideUploadCompleteAwaitingProcessing:(NSString * _Nonnull)backSideUploadCompleteAwaitingProcessing userConfirmedInfoUploadStarted:(NSString * _Nonnull)userConfirmedInfoUploadStarted userConfirmedInfoStillUploading:(NSString * _Nonnull)userConfirmedInfoStillUploading userConfirmedInfoUploadCompleteAwaitingResponse:(NSString * _Nonnull)userConfirmedInfoUploadCompleteAwaitingResponse userConfirmedInfoUploadCompleteAwaitingProcessing:(NSString * _Nonnull)userConfirmedInfoUploadCompleteAwaitingProcessing nfcUploadStarted:(NSString * _Nonnull)nfcUploadStarted nfcStillUploading:(NSString * _Nonnull)nfcStillUploading nfcUploadCompleteAwaitingResponse:(NSString * _Nonnull)nfcUploadCompleteAwaitingResponse nfcUploadCompleteAwaitingProcessing:(NSString * _Nonnull)nfcUploadCompleteAwaitingProcessing __attribute__((swift_name("setIDScanUploadMessageOverrides(frontSideUploadStarted:frontSideStillUploading:frontSideUploadCompleteAwaitingResponse:frontSideUploadCompleteAwaitingProcessing:backSideUploadStarted:backSideStillUploading:backSideUploadCompleteAwaitingResponse:backSideUploadCompleteAwaitingProcessing:userConfirmedInfoUploadStarted:userConfirmedInfoStillUploading:userConfirmedInfoUploadCompleteAwaitingResponse:userConfirmedInfoUploadCompleteAwaitingProcessing:nfcUploadStarted:nfcStillUploading:nfcUploadCompleteAwaitingResponse:nfcUploadCompleteAwaitingProcessing:)")));
        [Static]
        [Export("setIDScanUploadMessageOverridesForFrontSideUploadStarted:frontSideStillUploading:frontSideUploadCompleteAwaitingResponse:frontSideUploadCompleteAwaitingProcessing:backSideUploadStarted:backSideStillUploading:backSideUploadCompleteAwaitingResponse:backSideUploadCompleteAwaitingProcessing:userConfirmedInfoUploadStarted:userConfirmedInfoStillUploading:userConfirmedInfoUploadCompleteAwaitingResponse:userConfirmedInfoUploadCompleteAwaitingProcessing:nfcUploadStarted:nfcStillUploading:nfcUploadCompleteAwaitingResponse:nfcUploadCompleteAwaitingProcessing:")]
        void SetIDScanUploadMessageOverridesForFrontSideUploadStarted(string frontSideUploadStarted, string frontSideStillUploading, string frontSideUploadCompleteAwaitingResponse, string frontSideUploadCompleteAwaitingProcessing, string backSideUploadStarted, string backSideStillUploading, string backSideUploadCompleteAwaitingResponse, string backSideUploadCompleteAwaitingProcessing, string userConfirmedInfoUploadStarted, string userConfirmedInfoStillUploading, string userConfirmedInfoUploadCompleteAwaitingResponse, string userConfirmedInfoUploadCompleteAwaitingProcessing, string nfcUploadStarted, string nfcStillUploading, string nfcUploadCompleteAwaitingResponse, string nfcUploadCompleteAwaitingProcessing);

        // +(void)setIDScanUploadMessageOverridesForFrontSideUploadStarted:(NSString * _Nonnull)frontSideUploadStarted frontSideStillUploading:(NSString * _Nonnull)frontSideStillUploading frontSideUploadCompleteAwaitingResponse:(NSString * _Nonnull)frontSideUploadCompleteAwaitingResponse frontSideUploadCompleteAwaitingProcessing:(NSString * _Nonnull)frontSideUploadCompleteAwaitingProcessing backSideUploadStarted:(NSString * _Nonnull)backSideUploadStarted backSideStillUploading:(NSString * _Nonnull)backSideStillUploading backSideUploadCompleteAwaitingResponse:(NSString * _Nonnull)backSideUploadCompleteAwaitingResponse backSideUploadCompleteAwaitingProcessing:(NSString * _Nonnull)backSideUploadCompleteAwaitingProcessing userConfirmedInfoUploadStarted:(NSString * _Nonnull)userConfirmedInfoUploadStarted userConfirmedInfoStillUploading:(NSString * _Nonnull)userConfirmedInfoStillUploading userConfirmedInfoUploadCompleteAwaitingResponse:(NSString * _Nonnull)userConfirmedInfoUploadCompleteAwaitingResponse userConfirmedInfoUploadCompleteAwaitingProcessing:(NSString * _Nonnull)userConfirmedInfoUploadCompleteAwaitingProcessing __attribute__((swift_name("setIDScanUploadMessageOverrides(frontSideUploadStarted:frontSideStillUploading:frontSideUploadCompleteAwaitingResponse:frontSideUploadCompleteAwaitingProcessing:backSideUploadStarted:backSideStillUploading:backSideUploadCompleteAwaitingResponse:backSideUploadCompleteAwaitingProcessing:userConfirmedInfoUploadStarted:userConfirmedInfoStillUploading:userConfirmedInfoUploadCompleteAwaitingResponse:userConfirmedInfoUploadCompleteAwaitingProcessing:)"))) __attribute__((deprecated("This API method is deprecated and will be removed in an upcoming release of the iOS SDK. Use the non-deprecated setIDScanUploadMessageOverrides API method instead.")));
        [Static]
        [Export("setIDScanUploadMessageOverridesForFrontSideUploadStarted:frontSideStillUploading:frontSideUploadCompleteAwaitingResponse:frontSideUploadCompleteAwaitingProcessing:backSideUploadStarted:backSideStillUploading:backSideUploadCompleteAwaitingResponse:backSideUploadCompleteAwaitingProcessing:userConfirmedInfoUploadStarted:userConfirmedInfoStillUploading:userConfirmedInfoUploadCompleteAwaitingResponse:userConfirmedInfoUploadCompleteAwaitingProcessing:")]
        void SetIDScanUploadMessageOverridesForFrontSideUploadStarted(string frontSideUploadStarted, string frontSideStillUploading, string frontSideUploadCompleteAwaitingResponse, string frontSideUploadCompleteAwaitingProcessing, string backSideUploadStarted, string backSideStillUploading, string backSideUploadCompleteAwaitingResponse, string backSideUploadCompleteAwaitingProcessing, string userConfirmedInfoUploadStarted, string userConfirmedInfoStillUploading, string userConfirmedInfoUploadCompleteAwaitingResponse, string userConfirmedInfoUploadCompleteAwaitingProcessing);

        // +(NSDictionary * _Nullable)idScanUploadMessageOverrides;
        [Static]
        [NullAllowed, Export("idScanUploadMessageOverrides")]
        NSDictionary IdScanUploadMessageOverrides { get; }

        // @property (nonatomic) NSDictionary * _Nullable featureFlagsMap;
        [NullAllowed, Export("featureFlagsMap", ArgumentSemantic.Assign)]
        NSDictionary FeatureFlagsMap { get; set; }

        // -(instancetype _Nonnull)initWithFeatureFlagsMap:(NSDictionary * _Nullable)featureFlagsMap __attribute__((swift_name("init(featureFlagsMap:)")));
        [Export("initWithFeatureFlagsMap:")]
        IntPtr Constructor([NullAllowed] NSDictionary featureFlagsMap);

        // +(instancetype _Nonnull)new;
        [Static]
        [Export("new")]
        FaceTecCustomization New();
    }

    // @interface FaceTecShadow : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecShadow
    {
        // @property (nonatomic) UIColor * _Nonnull color;
        [Export("color", ArgumentSemantic.Assign)]
        UIColor Color { get; set; }

        // @property (nonatomic) float opacity;
        [Export("opacity")]
        float Opacity { get; set; }

        // @property (nonatomic) float radius;
        [Export("radius")]
        float Radius { get; set; }

        // @property (nonatomic) CGSize offset;
        [Export("offset", ArgumentSemantic.Assign)]
        CGSize Offset { get; set; }

        // @property (nonatomic) UIEdgeInsets insets;
        [Export("insets", ArgumentSemantic.Assign)]
        UIEdgeInsets Insets { get; set; }

        // -(instancetype _Nonnull)initWithColor:(UIColor * _Nonnull)color opacity:(float)opacity radius:(float)radius offset:(CGSize)offset insets:(UIEdgeInsets)insets;
        [Export("initWithColor:opacity:radius:offset:insets:")]
        IntPtr Constructor(UIColor color, float opacity, float radius, CGSize offset, UIEdgeInsets insets);
    }

    // @interface FaceTecSessionTimerCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecSessionTimerCustomization
    {
        // @property (nonatomic) int livenessCheckNoInteractionTimeout;
        [Export("livenessCheckNoInteractionTimeout")]
        int LivenessCheckNoInteractionTimeout { get; set; }

        // @property (nonatomic) int idScanNoInteractionTimeout;
        [Export("idScanNoInteractionTimeout")]
        int IdScanNoInteractionTimeout { get; set; }
    }

    // @interface FaceTecOCRConfirmationCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecOCRConfirmationCustomization
    {
        // @property (nonatomic, strong) NSArray<UIColor *> * _Nonnull backgroundColors;
        [Export("backgroundColors", ArgumentSemantic.Strong)]
        UIColor[] BackgroundColors { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull mainHeaderDividerLineColor;
        [Export("mainHeaderDividerLineColor", ArgumentSemantic.Strong)]
        UIColor MainHeaderDividerLineColor { get; set; }

        // @property (nonatomic) int mainHeaderDividerLineWidth;
        [Export("mainHeaderDividerLineWidth")]
        int MainHeaderDividerLineWidth { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull mainHeaderFont;
        [Export("mainHeaderFont", ArgumentSemantic.Strong)]
        UIFont MainHeaderFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull mainHeaderTextColor;
        [Export("mainHeaderTextColor", ArgumentSemantic.Strong)]
        UIColor MainHeaderTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull sectionHeaderFont;
        [Export("sectionHeaderFont", ArgumentSemantic.Strong)]
        UIFont SectionHeaderFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull sectionHeaderTextColor;
        [Export("sectionHeaderTextColor", ArgumentSemantic.Strong)]
        UIColor SectionHeaderTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull fieldLabelFont;
        [Export("fieldLabelFont", ArgumentSemantic.Strong)]
        UIFont FieldLabelFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fieldLabelTextColor;
        [Export("fieldLabelTextColor", ArgumentSemantic.Strong)]
        UIColor FieldLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull fieldValueFont;
        [Export("fieldValueFont", ArgumentSemantic.Strong)]
        UIFont FieldValueFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fieldValueTextColor;
        [Export("fieldValueTextColor", ArgumentSemantic.Strong)]
        UIColor FieldValueTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull inputFieldBackgroundColor;
        [Export("inputFieldBackgroundColor", ArgumentSemantic.Strong)]
        UIColor InputFieldBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable inputFieldFont;
        [NullAllowed, Export("inputFieldFont", ArgumentSemantic.Strong)]
        UIFont InputFieldFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable inputFieldTextColor;
        [NullAllowed, Export("inputFieldTextColor", ArgumentSemantic.Strong)]
        UIColor InputFieldTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull inputFieldBorderColor;
        [Export("inputFieldBorderColor", ArgumentSemantic.Strong)]
        UIColor InputFieldBorderColor { get; set; }

        // @property (nonatomic) int inputFieldBorderWidth;
        [Export("inputFieldBorderWidth")]
        int InputFieldBorderWidth { get; set; }

        // @property (nonatomic) int inputFieldCornerRadius;
        [Export("inputFieldCornerRadius")]
        int InputFieldCornerRadius { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable inputFieldPlaceholderFont;
        [NullAllowed, Export("inputFieldPlaceholderFont", ArgumentSemantic.Strong)]
        UIFont InputFieldPlaceholderFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull inputFieldPlaceholderTextColor;
        [Export("inputFieldPlaceholderTextColor", ArgumentSemantic.Strong)]
        UIColor InputFieldPlaceholderTextColor { get; set; }

        // @property (nonatomic) BOOL showInputFieldBottomBorderOnly;
        [Export("showInputFieldBottomBorderOnly")]
        bool ShowInputFieldBottomBorderOnly { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull buttonFont;
        [Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextNormalColor;
        [Export("buttonTextNormalColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextNormalColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundNormalColor;
        [Export("buttonBackgroundNormalColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundNormalColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextHighlightColor;
        [Export("buttonTextHighlightColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundHighlightColor;
        [Export("buttonBackgroundHighlightColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextDisabledColor;
        [Export("buttonTextDisabledColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundDisabledColor;
        [Export("buttonBackgroundDisabledColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBorderColor;
        [Export("buttonBorderColor", ArgumentSemantic.Strong)]
        UIColor ButtonBorderColor { get; set; }

        // @property (nonatomic) int buttonBorderWidth;
        [Export("buttonBorderWidth")]
        int ButtonBorderWidth { get; set; }

        // @property (nonatomic) int buttonCornerRadius;
        [Export("buttonCornerRadius")]
        int ButtonCornerRadius { get; set; }
    }

    // @interface FaceTecIDScanCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecIDScanCustomization
    {
        // @property (nonatomic) BOOL showSelectionScreenBrandingImage;
        [Export("showSelectionScreenBrandingImage")]
        bool ShowSelectionScreenBrandingImage { get; set; }

        // @property (nonatomic) BOOL showSelectionScreenDocumentImage;
        [Export("showSelectionScreenDocumentImage")]
        bool ShowSelectionScreenDocumentImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable selectionScreenDocumentImage;
        [NullAllowed, Export("selectionScreenDocumentImage", ArgumentSemantic.Strong)]
        UIImage SelectionScreenDocumentImage { get; set; }

        // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull selectionScreenBackgroundColors;
        [Export("selectionScreenBackgroundColors", ArgumentSemantic.Copy)]
        UIColor[] SelectionScreenBackgroundColors { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull selectionScreenForegroundColor;
        [Export("selectionScreenForegroundColor", ArgumentSemantic.Strong)]
        UIColor SelectionScreenForegroundColor { get; set; }

        // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull reviewScreenBackgroundColors;
        [Export("reviewScreenBackgroundColors", ArgumentSemantic.Copy)]
        UIColor[] ReviewScreenBackgroundColors { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull reviewScreenForegroundColor;
        [Export("reviewScreenForegroundColor", ArgumentSemantic.Strong)]
        UIColor ReviewScreenForegroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull reviewScreenTextBackgroundColor;
        [Export("reviewScreenTextBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ReviewScreenTextBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull reviewScreenTextBackgroundBorderColor;
        [Export("reviewScreenTextBackgroundBorderColor", ArgumentSemantic.Strong)]
        UIColor ReviewScreenTextBackgroundBorderColor { get; set; }

        // @property (nonatomic) int reviewScreenTextBackgroundCornerRadius;
        [Export("reviewScreenTextBackgroundCornerRadius")]
        int ReviewScreenTextBackgroundCornerRadius { get; set; }

        // @property (nonatomic) int reviewScreenTextBackgroundBorderWidth;
        [Export("reviewScreenTextBackgroundBorderWidth")]
        int ReviewScreenTextBackgroundBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull captureScreenForegroundColor;
        [Export("captureScreenForegroundColor", ArgumentSemantic.Strong)]
        UIColor CaptureScreenForegroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull captureScreenTextBackgroundColor;
        [Export("captureScreenTextBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CaptureScreenTextBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull captureScreenTextBackgroundBorderColor;
        [Export("captureScreenTextBackgroundBorderColor", ArgumentSemantic.Strong)]
        UIColor CaptureScreenTextBackgroundBorderColor { get; set; }

        // @property (nonatomic) int captureScreenTextBackgroundCornerRadius;
        [Export("captureScreenTextBackgroundCornerRadius")]
        int CaptureScreenTextBackgroundCornerRadius { get; set; }

        // @property (nonatomic) int captureScreenTextBackgroundBorderWidth;
        [Export("captureScreenTextBackgroundBorderWidth")]
        int CaptureScreenTextBackgroundBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull captureScreenFocusMessageTextColor;
        [Export("captureScreenFocusMessageTextColor", ArgumentSemantic.Strong)]
        UIColor CaptureScreenFocusMessageTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull captureScreenFocusMessageFont;
        [Export("captureScreenFocusMessageFont", ArgumentSemantic.Strong)]
        UIFont CaptureScreenFocusMessageFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextNormalColor;
        [Export("buttonTextNormalColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextNormalColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundNormalColor;
        [Export("buttonBackgroundNormalColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundNormalColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextHighlightColor;
        [Export("buttonTextHighlightColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundHighlightColor;
        [Export("buttonBackgroundHighlightColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextDisabledColor;
        [Export("buttonTextDisabledColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundDisabledColor;
        [Export("buttonBackgroundDisabledColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBorderColor;
        [Export("buttonBorderColor", ArgumentSemantic.Strong)]
        UIColor ButtonBorderColor { get; set; }

        // @property (nonatomic) int buttonBorderWidth;
        [Export("buttonBorderWidth")]
        int ButtonBorderWidth { get; set; }

        // @property (nonatomic) int buttonCornerRadius;
        [Export("buttonCornerRadius")]
        int ButtonCornerRadius { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull headerFont;
        [Export("headerFont", ArgumentSemantic.Strong)]
        UIFont HeaderFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull subtextFont;
        [Export("subtextFont", ArgumentSemantic.Strong)]
        UIFont SubtextFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull buttonFont;
        [Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable selectionScreenBrandingImage;
        [NullAllowed, Export("selectionScreenBrandingImage", ArgumentSemantic.Strong)]
        UIImage SelectionScreenBrandingImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull captureScreenBackgroundColor;
        [Export("captureScreenBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CaptureScreenBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull captureFrameStrokeColor;
        [Export("captureFrameStrokeColor", ArgumentSemantic.Strong)]
        UIColor CaptureFrameStrokeColor { get; set; }

        // @property (nonatomic) int captureFrameStrokeWith;
        [Export("captureFrameStrokeWith")]
        int CaptureFrameStrokeWith { get; set; }

        // @property (nonatomic) int captureFrameCornerRadius;
        [Export("captureFrameCornerRadius")]
        int CaptureFrameCornerRadius { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable activeTorchButtonImage;
        [NullAllowed, Export("activeTorchButtonImage", ArgumentSemantic.Strong)]
        UIImage ActiveTorchButtonImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable inactiveTorchButtonImage;
        [NullAllowed, Export("inactiveTorchButtonImage", ArgumentSemantic.Strong)]
        UIImage InactiveTorchButtonImage { get; set; }
    }

    // @interface FaceTecGuidanceCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecGuidanceCustomization
    {
        // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull backgroundColors;
        [Export("backgroundColors", ArgumentSemantic.Copy)]
        UIColor[] BackgroundColors { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull foregroundColor;
        [Export("foregroundColor", ArgumentSemantic.Strong)]
        UIColor ForegroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextNormalColor;
        [Export("buttonTextNormalColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextNormalColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundNormalColor;
        [Export("buttonBackgroundNormalColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundNormalColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextHighlightColor;
        [Export("buttonTextHighlightColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundHighlightColor;
        [Export("buttonBackgroundHighlightColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonTextDisabledColor;
        [Export("buttonTextDisabledColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBackgroundDisabledColor;
        [Export("buttonBackgroundDisabledColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull buttonBorderColor;
        [Export("buttonBorderColor", ArgumentSemantic.Strong)]
        UIColor ButtonBorderColor { get; set; }

        // @property (nonatomic) int buttonBorderWidth;
        [Export("buttonBorderWidth")]
        int ButtonBorderWidth { get; set; }

        // @property (nonatomic) int buttonCornerRadius;
        [Export("buttonCornerRadius")]
        int ButtonCornerRadius { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull headerFont;
        [Export("headerFont", ArgumentSemantic.Strong)]
        UIFont HeaderFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull subtextFont;
        [Export("subtextFont", ArgumentSemantic.Strong)]
        UIFont SubtextFont { get; set; }

        // @property (nonatomic, strong) NSAttributedString * _Nullable readyScreenHeaderAttributedString;
        [NullAllowed, Export("readyScreenHeaderAttributedString", ArgumentSemantic.Strong)]
        NSAttributedString ReadyScreenHeaderAttributedString { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable readyScreenHeaderFont;
        [NullAllowed, Export("readyScreenHeaderFont", ArgumentSemantic.Strong)]
        UIFont ReadyScreenHeaderFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable readyScreenHeaderTextColor;
        [NullAllowed, Export("readyScreenHeaderTextColor", ArgumentSemantic.Strong)]
        UIColor ReadyScreenHeaderTextColor { get; set; }

        // @property (nonatomic, strong) NSAttributedString * _Nullable readyScreenSubtextAttributedString;
        [NullAllowed, Export("readyScreenSubtextAttributedString", ArgumentSemantic.Strong)]
        NSAttributedString ReadyScreenSubtextAttributedString { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable readyScreenSubtextFont;
        [NullAllowed, Export("readyScreenSubtextFont", ArgumentSemantic.Strong)]
        UIFont ReadyScreenSubtextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable readyScreenSubtextTextColor;
        [NullAllowed, Export("readyScreenSubtextTextColor", ArgumentSemantic.Strong)]
        UIColor ReadyScreenSubtextTextColor { get; set; }

        // @property (nonatomic, strong) NSAttributedString * _Nullable retryScreenHeaderAttributedString;
        [NullAllowed, Export("retryScreenHeaderAttributedString", ArgumentSemantic.Strong)]
        NSAttributedString RetryScreenHeaderAttributedString { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable retryScreenHeaderFont;
        [NullAllowed, Export("retryScreenHeaderFont", ArgumentSemantic.Strong)]
        UIFont RetryScreenHeaderFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable retryScreenHeaderTextColor;
        [NullAllowed, Export("retryScreenHeaderTextColor", ArgumentSemantic.Strong)]
        UIColor RetryScreenHeaderTextColor { get; set; }

        // @property (nonatomic, strong) NSAttributedString * _Nullable retryScreenSubtextAttributedString;
        [NullAllowed, Export("retryScreenSubtextAttributedString", ArgumentSemantic.Strong)]
        NSAttributedString RetryScreenSubtextAttributedString { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable retryScreenSubtextFont;
        [NullAllowed, Export("retryScreenSubtextFont", ArgumentSemantic.Strong)]
        UIFont RetryScreenSubtextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable retryScreenSubtextTextColor;
        [NullAllowed, Export("retryScreenSubtextTextColor", ArgumentSemantic.Strong)]
        UIColor RetryScreenSubtextTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull buttonFont;
        [Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull readyScreenTextBackgroundColor;
        [Export("readyScreenTextBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ReadyScreenTextBackgroundColor { get; set; }

        // @property (nonatomic) int readyScreenTextBackgroundCornerRadius;
        [Export("readyScreenTextBackgroundCornerRadius")]
        int ReadyScreenTextBackgroundCornerRadius { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull readyScreenOvalFillColor;
        [Export("readyScreenOvalFillColor", ArgumentSemantic.Strong)]
        UIColor ReadyScreenOvalFillColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable retryScreenIdealImage;
        [NullAllowed, Export("retryScreenIdealImage", ArgumentSemantic.Strong)]
        UIImage RetryScreenIdealImage { get; set; }

        // @property (nonatomic, strong) NSArray<UIImage *> * _Nullable retryScreenSlideshowImages;
        [NullAllowed, Export("retryScreenSlideshowImages", ArgumentSemantic.Strong)]
        UIImage[] RetryScreenSlideshowImages { get; set; }

        // @property (nonatomic) int retryScreenSlideshowInterval;
        [Export("retryScreenSlideshowInterval")]
        int RetryScreenSlideshowInterval { get; set; }

        // @property (nonatomic) BOOL enableRetryScreenSlideshowShuffle;
        [Export("enableRetryScreenSlideshowShuffle")]
        bool EnableRetryScreenSlideshowShuffle { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull retryScreenImageBorderColor;
        [Export("retryScreenImageBorderColor", ArgumentSemantic.Strong)]
        UIColor RetryScreenImageBorderColor { get; set; }

        // @property (nonatomic) int retryScreenImageBorderWidth;
        [Export("retryScreenImageBorderWidth")]
        int RetryScreenImageBorderWidth { get; set; }

        // @property (nonatomic) int retryScreenImageCornerRadius;
        [Export("retryScreenImageCornerRadius")]
        int RetryScreenImageCornerRadius { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull retryScreenOvalStrokeColor;
        [Export("retryScreenOvalStrokeColor", ArgumentSemantic.Strong)]
        UIColor RetryScreenOvalStrokeColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable cameraPermissionsScreenImage;
        [NullAllowed, Export("cameraPermissionsScreenImage", ArgumentSemantic.Strong)]
        UIImage CameraPermissionsScreenImage { get; set; }
    }

    // @interface FaceTecResultScreenCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecResultScreenCustomization
    {
        // @property (nonatomic) float animationRelativeScale;
        [Export("animationRelativeScale")]
        float AnimationRelativeScale { get; set; }

        // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull backgroundColors;
        [Export("backgroundColors", ArgumentSemantic.Copy)]
        UIColor[] BackgroundColors { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull foregroundColor;
        [Export("foregroundColor", ArgumentSemantic.Strong)]
        UIColor ForegroundColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull messageFont;
        [Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull activityIndicatorColor;
        [Export("activityIndicatorColor", ArgumentSemantic.Strong)]
        UIColor ActivityIndicatorColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable customActivityIndicatorImage;
        [NullAllowed, Export("customActivityIndicatorImage", ArgumentSemantic.Strong)]
        UIImage CustomActivityIndicatorImage { get; set; }

        // @property (nonatomic) int customActivityIndicatorRotationInterval;
        [Export("customActivityIndicatorRotationInterval")]
        int CustomActivityIndicatorRotationInterval { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull resultAnimationBackgroundColor;
        [Export("resultAnimationBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ResultAnimationBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull resultAnimationForegroundColor;
        [Export("resultAnimationForegroundColor", ArgumentSemantic.Strong)]
        UIColor ResultAnimationForegroundColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable resultAnimationSuccessBackgroundImage;
        [NullAllowed, Export("resultAnimationSuccessBackgroundImage", ArgumentSemantic.Strong)]
        UIImage ResultAnimationSuccessBackgroundImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable resultAnimationUnsuccessBackgroundImage;
        [NullAllowed, Export("resultAnimationUnsuccessBackgroundImage", ArgumentSemantic.Strong)]
        UIImage ResultAnimationUnsuccessBackgroundImage { get; set; }

        // @property (nonatomic) BOOL showUploadProgressBar;
        [Export("showUploadProgressBar")]
        bool ShowUploadProgressBar { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull uploadProgressFillColor;
        [Export("uploadProgressFillColor", ArgumentSemantic.Strong)]
        UIColor UploadProgressFillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull uploadProgressTrackColor;
        [Export("uploadProgressTrackColor", ArgumentSemantic.Strong)]
        UIColor UploadProgressTrackColor { get; set; }
    }

    // @interface FaceTecOvalCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecOvalCustomization
    {
        // @property (nonatomic, strong) UIColor * _Nonnull strokeColor;
        [Export("strokeColor", ArgumentSemantic.Strong)]
        UIColor StrokeColor { get; set; }

        // @property (nonatomic) int strokeWidth;
        [Export("strokeWidth")]
        int StrokeWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull progressColor1;
        [Export("progressColor1", ArgumentSemantic.Strong)]
        UIColor ProgressColor1 { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull progressColor2;
        [Export("progressColor2", ArgumentSemantic.Strong)]
        UIColor ProgressColor2 { get; set; }

        // @property (nonatomic) int progressRadialOffset;
        [Export("progressRadialOffset")]
        int ProgressRadialOffset { get; set; }

        // @property (nonatomic) int progressStrokeWidth;
        [Export("progressStrokeWidth")]
        int ProgressStrokeWidth { get; set; }
    }

    // @interface FaceTecFeedbackCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecFeedbackCustomization
    {
        // @property (nonatomic) FaceTecShadow * _Nullable shadow;
        [NullAllowed, Export("shadow", ArgumentSemantic.Assign)]
        FaceTecShadow Shadow { get; set; }

        // @property (nonatomic) int cornerRadius;
        [Export("cornerRadius")]
        int CornerRadius { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @property (nonatomic) UIFont * _Nonnull textFont;
        [Export("textFont", ArgumentSemantic.Assign)]
        UIFont TextFont { get; set; }

        // @property (nonatomic) BOOL enablePulsatingText;
        [Export("enablePulsatingText")]
        bool EnablePulsatingText { get; set; }

        // @property (nonatomic, strong) CAGradientLayer * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        CAGradientLayer BackgroundColor { get; set; }
    }

    // @interface FaceTecFrameCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecFrameCustomization
    {
        // @property (nonatomic) FaceTecShadow * _Nullable shadow;
        [NullAllowed, Export("shadow", ArgumentSemantic.Assign)]
        FaceTecShadow Shadow { get; set; }

        // @property (nonatomic) int cornerRadius;
        [Export("cornerRadius")]
        int CornerRadius { get; set; }

        // @property (nonatomic) int borderWidth;
        [Export("borderWidth")]
        int BorderWidth { get; set; }

        // @property (nonatomic) UIColor * _Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Assign)]
        UIColor BorderColor { get; set; }

        // @property (nonatomic) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Assign)]
        UIColor BackgroundColor { get; set; }
    }

    // @interface FaceTecCancelButtonCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecCancelButtonCustomization
    {
        // @property (nonatomic, strong) UIImage * _Nullable customImage;
        [NullAllowed, Export("customImage", ArgumentSemantic.Strong)]
        UIImage CustomImage { get; set; }

        // @property (nonatomic) enum FaceTecCancelButtonLocation location;
        [Export("location", ArgumentSemantic.Assign)]
        FaceTecCancelButtonLocation Location { get; set; }

        // @property (nonatomic) CGRect customLocation;
        [Export("customLocation", ArgumentSemantic.Assign)]
        CGRect CustomLocation { get; set; }
    }

    // @interface FaceTecOverlayCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecOverlayCustomization
    {
        // @property (copy, nonatomic) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Copy)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable brandingImage;
        [NullAllowed, Export("brandingImage", ArgumentSemantic.Strong)]
        UIImage BrandingImage { get; set; }

        // @property (nonatomic) BOOL showBrandingImage;
        [Export("showBrandingImage")]
        bool ShowBrandingImage { get; set; }
    }

    // @interface FaceTecVocalGuidanceCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface FaceTecVocalGuidanceCustomization
    {
        // @property (nonatomic) enum FaceTecVocalGuidanceMode mode;
        [Export("mode", ArgumentSemantic.Assign)]
        FaceTecVocalGuidanceMode Mode { get; set; }

        // @property (nonatomic) NSString * _Nonnull pleaseFrameYourFaceInTheOvalSoundFile;
        [Export("pleaseFrameYourFaceInTheOvalSoundFile")]
        string PleaseFrameYourFaceInTheOvalSoundFile { get; set; }

        // @property (nonatomic) NSString * _Nonnull pleaseMoveCloserSoundFile;
        [Export("pleaseMoveCloserSoundFile")]
        string PleaseMoveCloserSoundFile { get; set; }

        // @property (nonatomic) NSString * _Nonnull pleaseRetrySoundFile;
        [Export("pleaseRetrySoundFile")]
        string PleaseRetrySoundFile { get; set; }

        // @property (nonatomic) NSString * _Nonnull uploadingSoundFile;
        [Export("uploadingSoundFile")]
        string UploadingSoundFile { get; set; }

        // @property (nonatomic) NSString * _Nonnull facescanSuccessfulSoundFile;
        [Export("facescanSuccessfulSoundFile")]
        string FacescanSuccessfulSoundFile { get; set; }

        // @property (nonatomic) NSString * _Nonnull pleasePressTheButtonToStartSoundFile;
        [Export("pleasePressTheButtonToStartSoundFile")]
        string PleasePressTheButtonToStartSoundFile { get; set; }
    }

    interface IFaceTecFaceScanProcessorDelegate { }

    interface IFaceTecIDScanProcessorDelegate { }

    // @protocol FaceTecSDKProtocol
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface FaceTecSDKProtocol
    {
        // @required -(void)initializeInDevelopmentMode:(NSString * _Nonnull)deviceKeyIdentifier faceScanEncryptionKey:(NSString * _Nonnull)faceScanEncryptionKey completion:(void (^ _Nullable)(BOOL))completion __attribute__((swift_name("initializeInDevelopmentMode(deviceKeyIdentifier:faceScanEncryptionKey:completion:)")));
        [Abstract]
        [Export("initializeInDevelopmentMode:faceScanEncryptionKey:completion:")]
        void InitializeInDevelopmentMode(string deviceKeyIdentifier, string faceScanEncryptionKey, [NullAllowed] Action<bool> completion);

        // @required -(void)initializeInProductionMode:(NSString * _Nonnull)productionKeyText deviceKeyIdentifier:(NSString * _Nonnull)deviceKeyIdentifier faceScanEncryptionKey:(NSString * _Nonnull)faceScanEncryptionKey completion:(void (^ _Nullable)(BOOL))completion __attribute__((swift_name("initializeInProductionMode(productionKeyText:deviceKeyIdentifier:faceScanEncryptionKey:completion:)")));
        [Abstract]
        [Export("initializeInProductionMode:deviceKeyIdentifier:faceScanEncryptionKey:completion:")]
        void InitializeInProductionMode(string productionKeyText, string deviceKeyIdentifier, string faceScanEncryptionKey, [NullAllowed] Action<bool> completion);

        // @required -(void)setCustomization:(FaceTecCustomization * _Nonnull)customization;
        [Abstract]
        [Export("setCustomization:")]
        void SetCustomization(FaceTecCustomization customization);

        // @required -(void)setLowLightCustomization:(FaceTecCustomization * _Nullable)lowLightCustomization __attribute__((swift_name("setLowLightCustomization(_:)")));
        [Abstract]
        [Export("setLowLightCustomization:")]
        void SetLowLightCustomization([NullAllowed] FaceTecCustomization lowLightCustomization);

        // @required -(void)setDynamicDimmingCustomization:(FaceTecCustomization * _Nullable)dynamicDimmingCustomization __attribute__((swift_name("setDynamicDimmingCustomization(_:)")));
        [Abstract]
        [Export("setDynamicDimmingCustomization:")]
        void SetDynamicDimmingCustomization([NullAllowed] FaceTecCustomization dynamicDimmingCustomization);

        // @required -(enum FaceTecSDKStatus)getStatus;
        [Abstract]
        [Export("getStatus")]
        //[Verify(MethodToProperty)]
        FaceTecSDKStatus Status { get; }

        // @required -(NSDate * _Nullable)getLockoutEndTime;
        [Abstract]
        [NullAllowed, Export("getLockoutEndTime")]
        //[Verify(MethodToProperty)]
        NSDate LockoutEndTime { get; }

        // @required -(BOOL)isLockedOut;
        [Abstract]
        [Export("isLockedOut")]
        //[Verify(MethodToProperty)]
        bool IsLockedOut { get; }

        // @required -(void)unload;
        [Abstract]
        [Export("unload")]
        void Unload();

        // @required @property (readonly, nonatomic) enum FaceTecCameraPermissionStatus cameraPermissionStatus;
        [Abstract]
        [Export("cameraPermissionStatus")]
        FaceTecCameraPermissionStatus CameraPermissionStatus { get; }

        // @required -(void)setLanguage:(NSString * _Nonnull)language;
        [Abstract]
        [Export("setLanguage:")]
        void SetLanguage(string language);

        // @required -(void)configureLocalizationWithTable:(NSString * _Nullable)table bundle:(NSBundle * _Nullable)bundle;
        [Abstract]
        [Export("configureLocalizationWithTable:bundle:")]
        void ConfigureLocalizationWithTable([NullAllowed] string table, [NullAllowed] NSBundle bundle);

        // @required -(void)configureOCRLocalizationWithDictionary:(NSDictionary * _Nullable)dictionary __attribute__((swift_name("configureOCRLocalization(dictionary:)")));
        [Abstract]
        [Export("configureOCRLocalizationWithDictionary:")]
        void ConfigureOCRLocalizationWithDictionary([NullAllowed] NSDictionary dictionary);

        // @required -(void)setBundleForFaceTecImages:(NSBundle * _Nullable)bundle;
        [Abstract]
        [Export("setBundleForFaceTecImages:")]
        void SetBundleForFaceTecImages([NullAllowed] NSBundle bundle);

        // @required @property (nonatomic) enum FaceTecAuditTrailType auditTrailType;
        [Abstract]
        [Export("auditTrailType", ArgumentSemantic.Assign)]
        FaceTecAuditTrailType AuditTrailType { get; set; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull version;
        [Abstract]
        [Export("version")]
        string Version { get; }

        // @required -(NSString * _Nonnull)createFaceTecAPIUserAgentString:(NSString * _Nonnull)sessionId;
        //[Abstract]
        [Export("createFaceTecAPIUserAgentString:")]
        string CreateFaceTecAPIUserAgentString(string sessionId);

        // @required -(UIViewController * _Nonnull)createSessionVCWithFaceScanProcessor:(id<FaceTecFaceScanProcessorDelegate> _Nullable)faceScanProcessorDelegate __attribute__((swift_name("createSessionVC(faceScanProcessorDelegate:)")));
        [Abstract]
        [Export("createSessionVCWithFaceScanProcessor:")]
        UIViewController CreateSessionVCWithFaceScanProcessor([NullAllowed] IFaceTecFaceScanProcessorDelegate faceScanProcessorDelegate);

        // @required -(UIViewController * _Nonnull)createSessionVCWithFaceScanProcessor:(id<FaceTecFaceScanProcessorDelegate> _Nullable)faceScanProcessorDelegate sessionToken:(NSString * _Nonnull)sessionToken __attribute__((swift_name("createSessionVC(faceScanProcessorDelegate:sessionToken:)")));
        [Abstract]
        [Export("createSessionVCWithFaceScanProcessor:sessionToken:")]
        UIViewController CreateSessionVCWithFaceScanProcessor([NullAllowed] IFaceTecFaceScanProcessorDelegate faceScanProcessorDelegate, string sessionToken);

        // @required -(UIViewController * _Nonnull)createSessionVCWithFaceScanProcessor:(id<FaceTecFaceScanProcessorDelegate> _Nullable)faceScanProcessorDelegate idScanProcessorDelegate:(id<FaceTecIDScanProcessorDelegate> _Nullable)idScanProcessorDelegate __attribute__((swift_name("createSessionVC(faceScanProcessorDelegate:idScanProcessorDelegate:)")));
        [Abstract]
        [Export("createSessionVCWithFaceScanProcessor:idScanProcessorDelegate:")]
        UIViewController CreateSessionVCWithFaceScanProcessor([NullAllowed] IFaceTecFaceScanProcessorDelegate faceScanProcessorDelegate, [NullAllowed] IFaceTecIDScanProcessorDelegate idScanProcessorDelegate);

        // @required -(UIViewController * _Nonnull)createSessionVCWithFaceScanProcessor:(id<FaceTecFaceScanProcessorDelegate> _Nullable)faceScanProcessorDelegate idScanProcessorDelegate:(id<FaceTecIDScanProcessorDelegate> _Nullable)idScanProcessorDelegate sessionToken:(NSString * _Nonnull)sessionToken __attribute__((swift_name("createSessionVC(faceScanProcessorDelegate:idScanProcessorDelegate:sessionToken:)")));
        [Abstract]
        [Export("createSessionVCWithFaceScanProcessor:idScanProcessorDelegate:sessionToken:")]
        UIViewController CreateSessionVCWithFaceScanProcessor([NullAllowed] IFaceTecFaceScanProcessorDelegate faceScanProcessorDelegate, [NullAllowed] IFaceTecIDScanProcessorDelegate idScanProcessorDelegate, string sessionToken);

        // @required -(void)setDynamicStrings:(NSDictionary<NSString *,NSString *> * _Nonnull)strings;
        [Abstract]
        [Export("setDynamicStrings:")]
        void SetDynamicStrings(NSDictionary<NSString, NSString> strings);

        // @required -(NSString * _Nonnull)descriptionForSessionStatus:(enum FaceTecSessionStatus)status;
        [Abstract]
        [Export("descriptionForSessionStatus:")]
        string DescriptionForSessionStatus(FaceTecSessionStatus status);

        // @required -(NSString * _Nonnull)descriptionForIDScanStatus:(enum FaceTecIDScanStatus)status;
        [Abstract]
        [Export("descriptionForIDScanStatus:")]
        string DescriptionForIDScanStatus(FaceTecIDScanStatus status);

        // @required -(NSString * _Nonnull)descriptionForSDKStatus:(enum FaceTecSDKStatus)status;
        [Abstract]
        [Export("descriptionForSDKStatus:")]
        string DescriptionForSDKStatus(FaceTecSDKStatus status);
    }

    interface IFaceTecSDKProtocol { }

    // @protocol FaceTecFaceScanProcessorDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface FaceTecFaceScanProcessorDelegate
    {
        // @required -(void)processSessionWhileFaceTecSDKWaits:(id<FaceTecSessionResult> _Nonnull)sessionResult faceScanResultCallback:(id<FaceTecFaceScanResultCallback> _Nonnull)faceScanResultCallback __attribute__((swift_name("processSessionWhileFaceTecSDKWaits(sessionResult:faceScanResultCallback:)")));
        [Abstract]
        [Export("processSessionWhileFaceTecSDKWaits:faceScanResultCallback:")]
        void ProcessSessionWhileFaceTecSDKWaits(FaceTecSessionResult sessionResult, FaceTecFaceScanResultCallback faceScanResultCallback);

        // @required -(void)onFaceTecSDKCompletelyDone __attribute__((swift_name("onFaceTecSDKCompletelyDone()")));
        [Abstract]
        [Export("onFaceTecSDKCompletelyDone")]
        void OnFaceTecSDKCompletelyDone();
    }

    // @protocol FaceTecIDScanProcessorDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface FaceTecIDScanProcessorDelegate
    {
        // @required -(void)processIDScanWhileFaceTecSDKWaits:(id<FaceTecIDScanResult> _Nonnull)idScanResult idScanResultCallback:(id<FaceTecIDScanResultCallback> _Nonnull)idScanResultCallback __attribute__((swift_name("processIDScanWhileFaceTecSDKWaits(idScanResult:idScanResultCallback:)")));
        [Abstract]
        [Export("processIDScanWhileFaceTecSDKWaits:idScanResultCallback:")]
        void IdScanResultCallback(FaceTecIDScanResult idScanResult, FaceTecIDScanResultCallback idScanResultCallback);
    }

    // @protocol FaceTecFaceScanResultCallback <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface FaceTecFaceScanResultCallback
    {
        // @required -(void)onFaceScanUploadMessageOverride:(NSMutableAttributedString * _Nonnull)uploadMessageOverride __attribute__((swift_name("onFaceScanUploadMessageOverride(uploadMessageOverride:)")));
        //[Abstract]
        [Export("onFaceScanUploadMessageOverride:")]
        void OnFaceScanUploadMessageOverride(NSMutableAttributedString uploadMessageOverride);

        // @required -(void)onFaceScanUploadProgress:(float)uploadedPercent __attribute__((swift_name("onFaceScanUploadProgress(uploadedPercent:)")));
        //[Abstract]
        [Export("onFaceScanUploadProgress:")]
        void OnFaceScanUploadProgress(float uploadedPercent);

        // @required -(void)onFaceScanResultSucceed __attribute__((swift_name("onFaceScanResultSucceed()"))) __attribute__((deprecated("This method has been replaced by onFaceScanResultProceedToNextStep()")));
        //[Abstract]
        [Export("onFaceScanResultSucceed")]
        void OnFaceScanResultSucceed();

        // @required -(void)onFaceScanResultSucceedWithIDScanNextStep:(enum FaceTecIDScanNextStep)idScanNextStep __attribute__((swift_name("onFaceScanResultSucceedWithIDScanNextStep(idScanNextStep:)"))) __attribute__((deprecated("This method has been replaced by onFaceScanResultProceedToNextStep()")));
        //[Abstract]
        [Export("onFaceScanResultSucceedWithIDScanNextStep:")]
        void OnFaceScanResultSucceedWithIDScanNextStep(FaceTecIDScanNextStep idScanNextStep);

        // @required -(void)onFaceScanResultRetry __attribute__((swift_name("onFaceScanResultRetry()"))) __attribute__((deprecated("This method has been replaced by onFaceScanResultProceedToNextStep()")));
        //[Abstract]
        [Export("onFaceScanResultRetry")]
        void OnFaceScanResultRetry();

        // @required -(void)onFaceScanResultCancel __attribute__((swift_name("onFaceScanResultCancel()")));
        //[Abstract]
        [Export("onFaceScanResultCancel")]
        void OnFaceScanResultCancel();

        // @required -(BOOL)onFaceScanResultProceedToNextStep:(NSString * _Nonnull)scanResultBlob __attribute__((swift_name("onFaceScanGoToNextStep(scanResultBlob:)")));
        //[Abstract]
        [Export("onFaceScanResultProceedToNextStep:")]
        bool OnFaceScanResultProceedToNextStep(string scanResultBlob);

        // @required -(BOOL)onFaceScanResultProceedToNextStep:(NSString * _Nonnull)scanResultBlob idScanNextStep:(enum FaceTecIDScanNextStep)idScanNextStep __attribute__((swift_name("onFaceScanGoToNextStep(scanResultBlob:idScanNextStep:)")));
        //[Abstract]
        [Export("onFaceScanResultProceedToNextStep:idScanNextStep:")]
        bool OnFaceScanResultProceedToNextStep(string scanResultBlob, FaceTecIDScanNextStep idScanNextStep);
    }

    // @protocol FaceTecIDScanResultCallback <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface FaceTecIDScanResultCallback
    {
        // @required -(void)onIDScanUploadMessageOverride:(NSMutableAttributedString * _Nonnull)uploadMessageOverride __attribute__((swift_name("onIDScanUploadMessageOverride(uploadMessageOverride:)")));
        //[Abstract]
        [Export("onIDScanUploadMessageOverride:")]
        void OnIDScanUploadMessageOverride(NSMutableAttributedString uploadMessageOverride);

        // @required -(void)onIDScanUploadProgress:(float)uploadedPercent __attribute__((swift_name("onIDScanUploadProgress(uploadedPercent:)")));
        //[Abstract]
        [Export("onIDScanUploadProgress:")]
        void OnIDScanUploadProgress(float uploadedPercent);

        // @required -(BOOL)onIDScanResultProceedToNextStep:(NSString * _Nonnull)scanResultBlob __attribute__((swift_name("onIDScanResultProceedToNextStep(scanResultBlob:)")));
        //[Abstract]
        [Export("onIDScanResultProceedToNextStep:")]
        bool OnIDScanResultProceedToNextStep(string scanResultBlob);

        // @required -(void)onIDScanResultCancel __attribute__((swift_name("onIDScanResultCancel()")));
        //[Abstract]
        [Export("onIDScanResultCancel")]
        void OnIDScanResultCancel();
    }

    // @protocol FaceTecSessionResult <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    // [DisableDefaultCtor]
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface FaceTecSessionResult
    {
        // @required @property (readonly, nonatomic) enum FaceTecSessionStatus status;
        //[Abstract]
        [Export("status")]
        FaceTecSessionStatus Status { get; }

        // @required @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable auditTrailCompressedBase64;
        //[Abstract]
        [NullAllowed, Export("auditTrailCompressedBase64", ArgumentSemantic.Copy)]
        string[] AuditTrailCompressedBase64 { get; }

        // @required @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable lowQualityAuditTrailCompressedBase64;
        //[Abstract]
        [NullAllowed, Export("lowQualityAuditTrailCompressedBase64", ArgumentSemantic.Copy)]
        string[] LowQualityAuditTrailCompressedBase64 { get; }

        // @required @property (readonly, copy, nonatomic) NSData * _Nullable faceScan;
        //[Abstract]
        [NullAllowed, Export("faceScan", ArgumentSemantic.Copy)]
        NSData FaceScan { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable faceScanBase64;
        //[Abstract]
        [NullAllowed, Export("faceScanBase64")]
        string FaceScanBase64 { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull sessionId;
        //[Abstract]
        [Export("sessionId")]
        string SessionId { get; }
    }

    // @protocol FaceTecIDScanResult <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface FaceTecIDScanResult
    {
        // @required @property (readonly, nonatomic) enum FaceTecIDScanStatus status;
        //[Abstract]
        [Export("status")]
        FaceTecIDScanStatus Status { get; }

        // @required @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable frontImagesCompressedBase64;
        //[Abstract]
        [NullAllowed, Export("frontImagesCompressedBase64", ArgumentSemantic.Copy)]
        string[] FrontImagesCompressedBase64 { get; }

        // @required @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable backImagesCompressedBase64;
        //[Abstract]
        [NullAllowed, Export("backImagesCompressedBase64", ArgumentSemantic.Copy)]
        string[] BackImagesCompressedBase64 { get; }

        // @required @property (readonly, copy, nonatomic) NSData * _Nullable idScan;
        //[Abstract]
        [NullAllowed, Export("idScan", ArgumentSemantic.Copy)]
        NSData IdScan { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable idScanBase64;
        //[Abstract]
        [NullAllowed, Export("idScanBase64")]
        string IdScanBase64 { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable sessionId;
        //[Abstract]
        [NullAllowed, Export("sessionId")]
        string SessionId { get; }
    }

}
