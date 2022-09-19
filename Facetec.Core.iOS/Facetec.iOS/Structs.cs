using ObjCRuntime;

namespace Xminder
{
    [Native]
    public enum FaceTecAuditTrailType : long
    {
        Disabled = 0,
        FullResolution = 1,
        Height640 = 2
    }

    [Native]
    public enum FaceTecCancelButtonLocation : long
    {
        TopLeft = 0,
        TopRight = 1,
        Disabled = 2,
        Custom = 3
    }

    [Native]
    public enum FaceTecExitAnimationStyle : long
    {
        None = 0,
        RippleOut = 1,
        RippleOutSlow = 2
    }

    [Native]
    public enum FaceTecSecurityWatermarkImage : long
    {
        Zoom = 0,
        FaceTecSecurityWatermarkImageFaceTec = 1
    }

    [Native]
    public enum FaceTecVocalGuidanceMode : long
    {
        NoVocalGuidance = 0,
        MinimalVocalGuidance = 1,
        FullVocalGuidance = 2
    }

    [Native]
    public enum FaceTecCameraPermissionStatus : long
    {
        NotDetermined = 0,
        Denied = 1,
        Restricted = 2,
        Authorized = 3
    }

    [Native]
    public enum FaceTecSDKStatus : long
    {
        NeverInitialized = 0,
        Initialized = 1,
        NetworkIssues = 2,
        InvalidDeviceKeyIdentifier = 3,
        VersionDeprecated = 4,
        OfflineSessionsExceeded = 5,
        UnknownError = 6,
        DeviceLockedOut = 7,
        DeviceInLandscapeMode = 8,
        DeviceInReversePortraitMode = 9,
        KeyExpiredOrInvalid,
        EncryptionKeyInvalid
    }

    [Native]
    public enum FaceTecSessionStatus : long
    {
        SessionCompletedSuccessfully,
        SessionUnsuccessful,
        UserCancelled,
        NonProductionModeKeyInvalid,
        CameraPermissionDenied,
        ContextSwitch,
        LandscapeModeNotAllowed,
        ReversePortraitNotAllowed,
        Timeout,
        LowMemory,
        NonProductionModeNetworkRequired,
        GracePeriodExceeded,
        EncryptionKeyInvalid,
        MissingGuidanceImages,
        CameraInitializationIssue,
        LockedOut,
        UnknownInternalError,
        UserCancelledViaClickableReadyScreenSubtext
    }

    [Native]
    public enum FaceTecIDScanStatus : long
    {
        Success,
        Unsuccess,
        UserCancelled,
        TimedOut,
        ContextSwitch,
        CameraError,
        NetworkError,
        LandscapeModeNotAllowed,
        ReversePortraitNotAllowed,
        Skipped
    }

    [Native]
    public enum FaceTecIDScanNextStep : long
    {
        electionScreen,
        kip
    }
}
