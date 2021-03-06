﻿namespace SafeAuthenticator.Helpers
{
    internal static class Constants
    {
        // StringStrength
        internal const string StrengthVeryWeak = "VERY_WEAK";
        internal const string StrengthWeak = "WEAK";
        internal const string StrengthSomewhatSecure = "SOMEWHAT_SECURE";
        internal const string StrengthSecure = "SECURE";

        // StringStrengthScore
        internal const int StrengthScoreVeryWeak = 4;
        internal const int StrengthScoreWeak = 8;
        internal const int StrengthScoreSomeWhatSecure = 10;

        // ErrorCode
        internal const int UnexpectedError = -2000;
        internal const int RoutingInterfaceError = -11;
        internal const int NoSuchAccountError = -101;
        internal const int SymmetricDecipherFailureError = -3;
        internal const int AccountExistsError = -102;
        internal const int InvalidInvitationError = -116;
        internal const int InvitationAlreadyClaimedError = -117;
        internal const int SharedMDataDeniedError = -206;
        internal const int LowBalanceError = -113;

        // ErrorCodeMessage
        internal const string CouldNotConnect = "Could not connect to the SAFE Network";
        internal const string UpdateIp = "Try updating your IP on invite.maidsafe.net";
        internal const string AccountNotPresent = "Account does not exist";
        internal const string IncorrectPassword = "Incorrect password";
        internal const string AccountAlreadyExists = "Account already exists";
        internal const string InvalidInvitationToken = "Invalid invitation token";
        internal const string InvitationAlreadyClaimed = "Invitation already claimed";
        internal const string SharedMDataRequestDenied = "SharedMData request denied";
        internal const string InsufficientAccountBalance = "Insufficient account balance";

        // ContainerName
        internal const string AppContainer = "apps/";
        internal const string PublicNamesContainer = "_publicNames";
        internal const string PublicContainer = "_public";
        internal const string DocumentsContainer = "_documents";
        internal const string DownloadsContainer = "_downloads";
        internal const string MusicContainer = "_music";
        internal const string PicturesContainer = "_pictures";
        internal const string VideosContainer = "_videos";

        // ContainerImage
        internal const string PublicContainerImage = "PublicContainer";
        internal const string PublicNamesContainerImage = "PublicNames";
        internal const string AppContainerImage = "AppContainer";

        // FormattedContainerName
        internal const string AppOwnFormattedContainer = "App's own Container";
        internal const string PublicNamesFormattedContainer = "Public Names";
        internal const string PublicFormattedContainer = "Public";
        internal const string DocumentsFormattedContainer = "Documents";
        internal const string DownloadsFormattedContainer = "Downloads";
        internal const string MusicFormattedContainer = "Music";
        internal const string PicturesFormattedContainer = "Pictures";
        internal const string VideosFormattedContainer = "Videos";

        internal const string AppName = "SAFE Authenticator";
        internal const string IsTutorialComplete = "IsTutorialComplete";
        internal const string NoInternetMessage = "No internet connection";

        // Authentication PopupState
        internal const string None = "None";
        internal const string Error = "Error";
        internal const string Loading = "Loading";

        // Dialogs
        internal const string AutoReconnectInfoDialog = "Enable this feature to automatically reconnect to the network." +
            " Your credentials will be securely stored on your device. Logging out will clear the credentials from memory.";

        // URL
        internal const string ClaimTokenUrl = @"https://invite.maidsafe.net/";
        internal const string ForumLinkUrl = @"https://safenetforum.org/t/trust-level-1-basic-user-requirements/15200";
        internal const string PrivacyInfoUrl = @"https://safenetwork.tech/privacy/";
        internal const string FaqUrl = @"https://safenetforum.org/t/safe-authenticator-faq/26683";
    }
}
