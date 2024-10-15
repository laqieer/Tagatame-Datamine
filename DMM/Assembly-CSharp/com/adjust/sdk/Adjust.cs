// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.Adjust
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036D0")]
  public class Adjust : MonoBehaviour
  {
    [Token(Token = "0x401017C")]
    private const string errorMsgEditor = "[Adjust]: SDK can not be used in Editor.";
    [Token(Token = "0x401017D")]
    private const string errorMsgStart = "[Adjust]: SDK not started. Start it manually using the 'start' method.";
    [Token(Token = "0x401017E")]
    private const string errorMsgPlatform = "[Adjust]: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";
    [Token(Token = "0x401017F")]
    [FieldOffset(Offset = "0xC")]
    [HideInInspector]
    public bool startManually;
    [Token(Token = "0x4010180")]
    [FieldOffset(Offset = "0x10")]
    [HideInInspector]
    public string appToken;
    [Token(Token = "0x4010181")]
    [FieldOffset(Offset = "0x14")]
    [HideInInspector]
    public AdjustEnvironment environment;
    [Token(Token = "0x4010182")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public AdjustLogLevel logLevel;
    [Token(Token = "0x4010183")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public bool eventBuffering;
    [Token(Token = "0x4010184")]
    [FieldOffset(Offset = "0x1D")]
    [HideInInspector]
    public bool sendInBackground;
    [Token(Token = "0x4010185")]
    [FieldOffset(Offset = "0x1E")]
    [HideInInspector]
    public bool launchDeferredDeeplink;
    [Token(Token = "0x4010186")]
    [FieldOffset(Offset = "0x1F")]
    [HideInInspector]
    public bool needsCost;
    [Token(Token = "0x4010187")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public bool coppaCompliant;
    [Token(Token = "0x4010188")]
    [FieldOffset(Offset = "0x21")]
    [HideInInspector]
    public bool linkMe;
    [Token(Token = "0x4010189")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public string defaultTracker;
    [Token(Token = "0x401018A")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public AdjustUrlStrategy urlStrategy;
    [Token(Token = "0x401018B")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    public double startDelay;
    [Token(Token = "0x401018C")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public long secretId;
    [Token(Token = "0x401018D")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    public long info1;
    [Token(Token = "0x401018E")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    public long info2;
    [Token(Token = "0x401018F")]
    [FieldOffset(Offset = "0x50")]
    [HideInInspector]
    public long info3;
    [Token(Token = "0x4010190")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    public long info4;
    [Token(Token = "0x4010191")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    public bool preinstallTracking;
    [Token(Token = "0x4010192")]
    [FieldOffset(Offset = "0x64")]
    [HideInInspector]
    public string preinstallFilePath;
    [Token(Token = "0x4010193")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    public bool playStoreKidsApp;
    [Token(Token = "0x4010194")]
    [FieldOffset(Offset = "0x69")]
    [HideInInspector]
    public bool adServicesInfoReading;
    [Token(Token = "0x4010195")]
    [FieldOffset(Offset = "0x6A")]
    [HideInInspector]
    public bool idfaInfoReading;
    [Token(Token = "0x4010196")]
    [FieldOffset(Offset = "0x6B")]
    [HideInInspector]
    public bool skAdNetworkHandling;

    [Token(Token = "0x600F859")]
    [Address(RVA = "0xB6AF10", Offset = "0xB69D10", VA = "0x10B6AF10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600F85A")]
    [Address(RVA = "0xB6B620", Offset = "0xB6A420", VA = "0x10B6B620")]
    private void OnApplicationPause(bool pauseStatus)
    {
    }

    [Token(Token = "0x600F85B")]
    [Address(RVA = "0xB6C020", Offset = "0xB6AE20", VA = "0x10B6C020")]
    public static void start(AdjustConfig adjustConfig)
    {
    }

    [Token(Token = "0x600F85C")]
    [Address(RVA = "0xB6C1A0", Offset = "0xB6AFA0", VA = "0x10B6C1A0")]
    public static void trackEvent(AdjustEvent adjustEvent)
    {
    }

    [Token(Token = "0x600F85D")]
    [Address(RVA = "0xB6BF30", Offset = "0xB6AD30", VA = "0x10B6BF30")]
    public static void setEnabled(bool enabled)
    {
    }

    [Token(Token = "0x600F85E")]
    [Address(RVA = "0xB6BC60", Offset = "0xB6AA60", VA = "0x10B6BC60")]
    public static bool isEnabled() => new bool();

    [Token(Token = "0x600F85F")]
    [Address(RVA = "0xB6BF80", Offset = "0xB6AD80", VA = "0x10B6BF80")]
    public static void setOfflineMode(bool enabled)
    {
    }

    [Token(Token = "0x600F860")]
    [Address(RVA = "0xB6BEE0", Offset = "0xB6ACE0", VA = "0x10B6BEE0")]
    public static void setDeviceToken(string deviceToken)
    {
    }

    [Token(Token = "0x600F861")]
    [Address(RVA = "0xB6B880", Offset = "0xB6A680", VA = "0x10B6B880")]
    public static void gdprForgetMe()
    {
    }

    [Token(Token = "0x600F862")]
    [Address(RVA = "0xB6B830", Offset = "0xB6A630", VA = "0x10B6B830")]
    public static void disableThirdPartySharing()
    {
    }

    [Token(Token = "0x600F863")]
    [Address(RVA = "0xB6B790", Offset = "0xB6A590", VA = "0x10B6B790")]
    public static void appWillOpenUrl(string url)
    {
    }

    [Token(Token = "0x600F864")]
    [Address(RVA = "0xB6BE90", Offset = "0xB6AC90", VA = "0x10B6BE90")]
    public static void sendFirstPackages()
    {
    }

    [Token(Token = "0x600F865")]
    [Address(RVA = "0xB6B740", Offset = "0xB6A540", VA = "0x10B6B740")]
    public static void addSessionPartnerParameter(string key, string value)
    {
    }

    [Token(Token = "0x600F866")]
    [Address(RVA = "0xB6B6F0", Offset = "0xB6A4F0", VA = "0x10B6B6F0")]
    public static void addSessionCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x600F867")]
    [Address(RVA = "0xB6BD50", Offset = "0xB6AB50", VA = "0x10B6BD50")]
    public static void removeSessionPartnerParameter(string key)
    {
    }

    [Token(Token = "0x600F868")]
    [Address(RVA = "0xB6BD00", Offset = "0xB6AB00", VA = "0x10B6BD00")]
    public static void removeSessionCallbackParameter(string key)
    {
    }

    [Token(Token = "0x600F869")]
    [Address(RVA = "0xB6BE40", Offset = "0xB6AC40", VA = "0x10B6BE40")]
    public static void resetSessionPartnerParameters()
    {
    }

    [Token(Token = "0x600F86A")]
    [Address(RVA = "0xB6BDF0", Offset = "0xB6ABF0", VA = "0x10B6BDF0")]
    public static void resetSessionCallbackParameters()
    {
    }

    [Token(Token = "0x600F86B")]
    [Address(RVA = "0xB6C100", Offset = "0xB6AF00", VA = "0x10B6C100")]
    public static void trackAdRevenue(string source, string payload)
    {
    }

    [Token(Token = "0x600F86C")]
    [Address(RVA = "0xB6C0B0", Offset = "0xB6AEB0", VA = "0x10B6C0B0")]
    public static void trackAdRevenue(AdjustAdRevenue adRevenue)
    {
    }

    [Token(Token = "0x600F86D")]
    [Address(RVA = "0xB6C150", Offset = "0xB6AF50", VA = "0x10B6C150")]
    public static void trackAppStoreSubscription(AdjustAppStoreSubscription subscription)
    {
    }

    [Token(Token = "0x600F86E")]
    [Address(RVA = "0xB6C280", Offset = "0xB6B080", VA = "0x10B6C280")]
    public static void trackPlayStoreSubscription(AdjustPlayStoreSubscription subscription)
    {
    }

    [Token(Token = "0x600F86F")]
    [Address(RVA = "0xB6C2D0", Offset = "0xB6B0D0", VA = "0x10B6C2D0")]
    public static void trackThirdPartySharing(AdjustThirdPartySharing thirdPartySharing)
    {
    }

    [Token(Token = "0x600F870")]
    [Address(RVA = "0xB6C230", Offset = "0xB6B030", VA = "0x10B6C230")]
    public static void trackMeasurementConsent(bool measurementConsent)
    {
    }

    [Token(Token = "0x600F871")]
    [Address(RVA = "0xB6BDA0", Offset = "0xB6ABA0", VA = "0x10B6BDA0")]
    public static void requestTrackingAuthorizationWithCompletionHandler(
      Action<int> statusCallback,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F872")]
    [Address(RVA = "0xB6C3C0", Offset = "0xB6B1C0", VA = "0x10B6C3C0")]
    public static void updateConversionValue(int conversionValue)
    {
    }

    [Token(Token = "0x600F873")]
    [Address(RVA = "0xB6C320", Offset = "0xB6B120", VA = "0x10B6C320")]
    public static void updateConversionValue(
      int conversionValue,
      Action<string> completionCallback,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F874")]
    [Address(RVA = "0xB6C370", Offset = "0xB6B170", VA = "0x10B6C370")]
    public static void updateConversionValue(
      int conversionValue,
      string coarseValue,
      bool lockWindow,
      Action<string> completionCallback,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F875")]
    [Address(RVA = "0xB6B7E0", Offset = "0xB6A5E0", VA = "0x10B6B7E0")]
    public static void checkForNewAttStatus()
    {
    }

    [Token(Token = "0x600F876")]
    [Address(RVA = "0xB6B990", Offset = "0xB6A790", VA = "0x10B6B990")]
    public static int getAppTrackingAuthorizationStatus() => new int();

    [Token(Token = "0x600F877")]
    [Address(RVA = "0xB6B8D0", Offset = "0xB6A6D0", VA = "0x10B6B8D0")]
    public static string getAdid() => (string) null;

    [Token(Token = "0x600F878")]
    [Address(RVA = "0xB6B9E0", Offset = "0xB6A7E0", VA = "0x10B6B9E0")]
    public static AdjustAttribution getAttribution() => (AdjustAttribution) null;

    [Token(Token = "0x600F879")]
    [Address(RVA = "0xB6BC00", Offset = "0xB6AA00", VA = "0x10B6BC00")]
    public static string getWinAdid() => (string) null;

    [Token(Token = "0x600F87A")]
    [Address(RVA = "0xB6BA80", Offset = "0xB6A880", VA = "0x10B6BA80")]
    public static string getIdfa() => (string) null;

    [Token(Token = "0x600F87B")]
    [Address(RVA = "0xB6BAE0", Offset = "0xB6A8E0", VA = "0x10B6BAE0")]
    public static string getIdfv() => (string) null;

    [Token(Token = "0x600F87C")]
    [Address(RVA = "0xB6BBA0", Offset = "0xB6A9A0", VA = "0x10B6BBA0")]
    public static string getSdkVersion() => (string) null;

    [Token(Token = "0x600F87D")]
    [Address(RVA = "0xB6BFD0", Offset = "0xB6ADD0", VA = "0x10B6BFD0")]
    [Obsolete("This method is intended for testing purposes only. Do not use it.")]
    public static void setReferrer(string referrer)
    {
    }

    [Token(Token = "0x600F87E")]
    [Address(RVA = "0xB6BA30", Offset = "0xB6A830", VA = "0x10B6BA30")]
    public static void getGoogleAdId(Action<string> onDeviceIdsRead)
    {
    }

    [Token(Token = "0x600F87F")]
    [Address(RVA = "0xB6B930", Offset = "0xB6A730", VA = "0x10B6B930")]
    public static string getAmazonAdId() => (string) null;

    [Token(Token = "0x600F880")]
    [Address(RVA = "0xB6BB40", Offset = "0xB6A940", VA = "0x10B6BB40")]
    public static string getLastDeeplink() => (string) null;

    [Token(Token = "0x600F881")]
    [Address(RVA = "0xB6C410", Offset = "0xB6B210", VA = "0x10B6C410")]
    public static void verifyAppStorePurchase(
      AdjustAppStorePurchase purchase,
      Action<AdjustPurchaseVerificationInfo> verificationInfoDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F882")]
    [Address(RVA = "0xB6C460", Offset = "0xB6B260", VA = "0x10B6C460")]
    public static void verifyPlayStorePurchase(
      AdjustPlayStorePurchase purchase,
      Action<AdjustPurchaseVerificationInfo> verificationInfoDelegate)
    {
    }

    [Token(Token = "0x600F883")]
    [Address(RVA = "0xB6BCB0", Offset = "0xB6AAB0", VA = "0x10B6BCB0")]
    public static void processDeeplink(
      string url,
      Action<string> resolvedLinkDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F884")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0")]
    private static bool IsEditor() => new bool();

    [Token(Token = "0x600F885")]
    [Address(RVA = "0xB6B670", Offset = "0xB6A470", VA = "0x10B6B670")]
    public static void SetTestOptions(Dictionary<string, string> testOptions)
    {
    }

    [Token(Token = "0x600F886")]
    [Address(RVA = "0xB6B6C0", Offset = "0xB6A4C0", VA = "0x10B6B6C0")]
    public Adjust()
    {
    }
  }
}
