// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036D5")]
  public class AdjustConfig
  {
    [Token(Token = "0x40101B8")]
    public const string AdjustUrlStrategyChina = "china";
    [Token(Token = "0x40101B9")]
    public const string AdjustUrlStrategyIndia = "india";
    [Token(Token = "0x40101BA")]
    public const string AdjustUrlStrategyCn = "cn";
    [Token(Token = "0x40101BB")]
    public const string AdjustUrlStrategyCnOnly = "cn-only";
    [Token(Token = "0x40101BC")]
    public const string AdjustDataResidencyEU = "data-residency-eu";
    [Token(Token = "0x40101BD")]
    public const string AdjustDataResidencyTR = "data-residency-tr";
    [Token(Token = "0x40101BE")]
    public const string AdjustDataResidencyUS = "data-residency-us";
    [Token(Token = "0x40101BF")]
    public const string AdjustAdRevenueSourceAppLovinMAX = "applovin_max_sdk";
    [Token(Token = "0x40101C0")]
    public const string AdjustAdRevenueSourceMopub = "mopub";
    [Token(Token = "0x40101C1")]
    public const string AdjustAdRevenueSourceAdMob = "admob_sdk";
    [Token(Token = "0x40101C2")]
    public const string AdjustAdRevenueSourceIronSource = "ironsource_sdk";
    [Token(Token = "0x40101C3")]
    public const string AdjustAdRevenueSourceAdmost = "admost_sdk";
    [Token(Token = "0x40101C4")]
    public const string AdjustAdRevenueSourceUnity = "unity_sdk";
    [Token(Token = "0x40101C5")]
    public const string AdjustAdRevenueSourceHeliumChartboost = "helium_chartboost_sdk";
    [Token(Token = "0x40101C6")]
    public const string AdjustAdRevenueSourcePublisher = "publisher_sdk";
    [Token(Token = "0x40101C7")]
    public const string AdjustAdRevenueSourceTopOn = "topon_sdk";
    [Token(Token = "0x40101C8")]
    public const string AdjustAdRevenueSourceAdx = "adx_sdk";
    [Token(Token = "0x40101C9")]
    public const string AdjustAdRevenueTradPlus = "tradplus_sdk";
    [Token(Token = "0x40101CA")]
    [FieldOffset(Offset = "0x8")]
    internal string appToken;
    [Token(Token = "0x40101CB")]
    [FieldOffset(Offset = "0xC")]
    internal string sceneName;
    [Token(Token = "0x40101CC")]
    [FieldOffset(Offset = "0x10")]
    internal string userAgent;
    [Token(Token = "0x40101CD")]
    [FieldOffset(Offset = "0x14")]
    internal string defaultTracker;
    [Token(Token = "0x40101CE")]
    [FieldOffset(Offset = "0x18")]
    internal string externalDeviceId;
    [Token(Token = "0x40101CF")]
    [FieldOffset(Offset = "0x1C")]
    internal string urlStrategy;
    [Token(Token = "0x40101D0")]
    [FieldOffset(Offset = "0x20")]
    internal long? info1;
    [Token(Token = "0x40101D1")]
    [FieldOffset(Offset = "0x30")]
    internal long? info2;
    [Token(Token = "0x40101D2")]
    [FieldOffset(Offset = "0x40")]
    internal long? info3;
    [Token(Token = "0x40101D3")]
    [FieldOffset(Offset = "0x50")]
    internal long? info4;
    [Token(Token = "0x40101D4")]
    [FieldOffset(Offset = "0x60")]
    internal long? secretId;
    [Token(Token = "0x40101D5")]
    [FieldOffset(Offset = "0x70")]
    internal double? delayStart;
    [Token(Token = "0x40101D6")]
    [FieldOffset(Offset = "0x80")]
    internal bool? isDeviceKnown;
    [Token(Token = "0x40101D7")]
    [FieldOffset(Offset = "0x82")]
    internal bool? sendInBackground;
    [Token(Token = "0x40101D8")]
    [FieldOffset(Offset = "0x84")]
    internal bool? eventBufferingEnabled;
    [Token(Token = "0x40101D9")]
    [FieldOffset(Offset = "0x86")]
    internal bool? coppaCompliantEnabled;
    [Token(Token = "0x40101DA")]
    [FieldOffset(Offset = "0x88")]
    internal bool? playStoreKidsAppEnabled;
    [Token(Token = "0x40101DB")]
    [FieldOffset(Offset = "0x8A")]
    internal bool? allowSuppressLogLevel;
    [Token(Token = "0x40101DC")]
    [FieldOffset(Offset = "0x8C")]
    internal bool? needsCost;
    [Token(Token = "0x40101DD")]
    [FieldOffset(Offset = "0x8E")]
    internal bool? readDeviceInfoOnceEnabled;
    [Token(Token = "0x40101DE")]
    [FieldOffset(Offset = "0x90")]
    internal bool launchDeferredDeeplink;
    [Token(Token = "0x40101DF")]
    [FieldOffset(Offset = "0x94")]
    internal AdjustLogLevel? logLevel;
    [Token(Token = "0x40101E0")]
    [FieldOffset(Offset = "0x9C")]
    internal AdjustEnvironment environment;
    [Token(Token = "0x40101E1")]
    [FieldOffset(Offset = "0xA0")]
    internal Action<string> deferredDeeplinkDelegate;
    [Token(Token = "0x40101E2")]
    [FieldOffset(Offset = "0xA4")]
    internal Action<AdjustEventSuccess> eventSuccessDelegate;
    [Token(Token = "0x40101E3")]
    [FieldOffset(Offset = "0xA8")]
    internal Action<AdjustEventFailure> eventFailureDelegate;
    [Token(Token = "0x40101E4")]
    [FieldOffset(Offset = "0xAC")]
    internal Action<AdjustSessionSuccess> sessionSuccessDelegate;
    [Token(Token = "0x40101E5")]
    [FieldOffset(Offset = "0xB0")]
    internal Action<AdjustSessionFailure> sessionFailureDelegate;
    [Token(Token = "0x40101E6")]
    [FieldOffset(Offset = "0xB4")]
    internal Action<AdjustAttribution> attributionChangedDelegate;
    [Token(Token = "0x40101E7")]
    [FieldOffset(Offset = "0xB8")]
    internal Action<int> conversionValueUpdatedDelegate;
    [Token(Token = "0x40101E8")]
    [FieldOffset(Offset = "0xBC")]
    internal Action<int, string, bool> skad4ConversionValueUpdatedDelegate;
    [Token(Token = "0x40101E9")]
    [FieldOffset(Offset = "0xC0")]
    internal string processName;
    [Token(Token = "0x40101EA")]
    [FieldOffset(Offset = "0xC4")]
    internal bool? readImei;
    [Token(Token = "0x40101EB")]
    [FieldOffset(Offset = "0xC6")]
    internal bool? preinstallTrackingEnabled;
    [Token(Token = "0x40101EC")]
    [FieldOffset(Offset = "0xC8")]
    internal string preinstallFilePath;
    [Token(Token = "0x40101ED")]
    [FieldOffset(Offset = "0xCC")]
    internal bool? finalAndroidAttributionEnabled;
    [Token(Token = "0x40101EE")]
    [FieldOffset(Offset = "0xD0")]
    internal string fbAppId;
    [Token(Token = "0x40101EF")]
    [FieldOffset(Offset = "0xD4")]
    internal bool? allowAdServicesInfoReading;
    [Token(Token = "0x40101F0")]
    [FieldOffset(Offset = "0xD6")]
    internal bool? allowIdfaReading;
    [Token(Token = "0x40101F1")]
    [FieldOffset(Offset = "0xD8")]
    internal bool? skAdNetworkHandling;
    [Token(Token = "0x40101F2")]
    [FieldOffset(Offset = "0xDA")]
    internal bool? linkMeEnabled;
    [Token(Token = "0x40101F3")]
    [FieldOffset(Offset = "0xDC")]
    internal int? attConsentWaitingInterval;
    [Token(Token = "0x40101F4")]
    [FieldOffset(Offset = "0xE4")]
    internal Action<string> logDelegate;

    [Token(Token = "0x600F8B0")]
    [Address(RVA = "0xB65EE0", Offset = "0xB64CE0", VA = "0x10B65EE0")]
    public AdjustConfig(string appToken, AdjustEnvironment environment)
    {
    }

    [Token(Token = "0x600F8B1")]
    [Address(RVA = "0xB65F60", Offset = "0xB64D60", VA = "0x10B65F60")]
    public AdjustConfig(string appToken, AdjustEnvironment environment, bool allowSuppressLogLevel)
    {
    }

    [Token(Token = "0x600F8B2")]
    [Address(RVA = "0xB66550", Offset = "0xB65350", VA = "0x10B66550")]
    public void setLogLevel(AdjustLogLevel logLevel)
    {
    }

    [Token(Token = "0x600F8B3")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void setDefaultTracker(string defaultTracker)
    {
    }

    [Token(Token = "0x600F8B4")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void setExternalDeviceId(string externalDeviceId)
    {
    }

    [Token(Token = "0x600F8B5")]
    [Address(RVA = "0xA464D0", Offset = "0xA452D0", VA = "0x10A464D0")]
    public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink)
    {
    }

    [Token(Token = "0x600F8B6")]
    [Address(RVA = "0xB666F0", Offset = "0xB654F0", VA = "0x10B666F0")]
    public void setSendInBackground(bool sendInBackground)
    {
    }

    [Token(Token = "0x600F8B7")]
    [Address(RVA = "0xB66390", Offset = "0xB65190", VA = "0x10B66390")]
    public void setEventBufferingEnabled(bool eventBufferingEnabled)
    {
    }

    [Token(Token = "0x600F8B8")]
    [Address(RVA = "0xB662B0", Offset = "0xB650B0", VA = "0x10B662B0")]
    public void setCoppaCompliantEnabled(bool coppaCompliantEnabled)
    {
    }

    [Token(Token = "0x600F8B9")]
    [Address(RVA = "0xB665B0", Offset = "0xB653B0", VA = "0x10B665B0")]
    public void setNeedsCost(bool needsCost)
    {
    }

    [Token(Token = "0x600F8BA")]
    [Address(RVA = "0xB66330", Offset = "0xB65130", VA = "0x10B66330")]
    public void setDelayStart(double delayStart)
    {
    }

    [Token(Token = "0x600F8BB")]
    [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
    public void setUserAgent(string userAgent)
    {
    }

    [Token(Token = "0x600F8BC")]
    [Address(RVA = "0xB66490", Offset = "0xB65290", VA = "0x10B66490")]
    public void setIsDeviceKnown(bool isDeviceKnown)
    {
    }

    [Token(Token = "0x600F8BD")]
    [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
    public void setUrlStrategy(string urlStrategy)
    {
    }

    [Token(Token = "0x600F8BE")]
    [Address(RVA = "0xB66100", Offset = "0xB64F00", VA = "0x10B66100")]
    public void setAppSecret(long secretId, long info1, long info2, long info3, long info4)
    {
    }

    [Token(Token = "0x600F8BF")]
    [Address(RVA = "0xB66300", Offset = "0xB65100", VA = "0x10B66300")]
    public void setDeferredDeeplinkDelegate(
      Action<string> deferredDeeplinkDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F8C0")]
    [Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")]
    public Action<string> getDeferredDeeplinkDelegate() => (Action<string>) null;

    [Token(Token = "0x600F8C1")]
    [Address(RVA = "0xB66250", Offset = "0xB65050", VA = "0x10B66250")]
    public void setAttributionChangedDelegate(
      Action<AdjustAttribution> attributionChangedDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F8C2")]
    [Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")]
    public Action<AdjustAttribution> getAttributionChangedDelegate()
    {
      return (Action<AdjustAttribution>) null;
    }

    [Token(Token = "0x600F8C3")]
    [Address(RVA = "0xB66410", Offset = "0xB65210", VA = "0x10B66410")]
    public void setEventSuccessDelegate(
      Action<AdjustEventSuccess> eventSuccessDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F8C4")]
    [Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")]
    public Action<AdjustEventSuccess> getEventSuccessDelegate()
    {
      return (Action<AdjustEventSuccess>) null;
    }

    [Token(Token = "0x600F8C5")]
    [Address(RVA = "0xB663E0", Offset = "0xB651E0", VA = "0x10B663E0")]
    public void setEventFailureDelegate(
      Action<AdjustEventFailure> eventFailureDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F8C6")]
    [Address(RVA = "0x4601C0", Offset = "0x45EFC0", VA = "0x104601C0")]
    public Action<AdjustEventFailure> getEventFailureDelegate()
    {
      return (Action<AdjustEventFailure>) null;
    }

    [Token(Token = "0x600F8C7")]
    [Address(RVA = "0xB66770", Offset = "0xB65570", VA = "0x10B66770")]
    public void setSessionSuccessDelegate(
      Action<AdjustSessionSuccess> sessionSuccessDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F8C8")]
    [Address(RVA = "0x349120", Offset = "0x347F20", VA = "0x10349120")]
    public Action<AdjustSessionSuccess> getSessionSuccessDelegate()
    {
      return (Action<AdjustSessionSuccess>) null;
    }

    [Token(Token = "0x600F8C9")]
    [Address(RVA = "0xB66740", Offset = "0xB65540", VA = "0x10B66740")]
    public void setSessionFailureDelegate(
      Action<AdjustSessionFailure> sessionFailureDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F8CA")]
    [Address(RVA = "0x5FC000", Offset = "0x5FAE00", VA = "0x105FC000")]
    public Action<AdjustSessionFailure> getSessionFailureDelegate()
    {
      return (Action<AdjustSessionFailure>) null;
    }

    [Token(Token = "0x600F8CB")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    [Obsolete("This is an obsolete method. Apple Search Ads attribution with usage of iAd.framework has been sunset by Apple as of February 7th 2023.")]
    public void setAllowiAdInfoReading(bool allowiAdInfoReading)
    {
    }

    [Token(Token = "0x600F8CC")]
    [Address(RVA = "0xB66060", Offset = "0xB64E60", VA = "0x10B66060")]
    public void setAllowAdServicesInfoReading(bool allowAdServicesInfoReading)
    {
    }

    [Token(Token = "0x600F8CD")]
    [Address(RVA = "0xB660B0", Offset = "0xB64EB0", VA = "0x10B660B0")]
    public void setAllowIdfaReading(bool allowIdfaReading)
    {
    }

    [Token(Token = "0x600F8CE")]
    [Address(RVA = "0xB66010", Offset = "0xB64E10", VA = "0x10B66010")]
    public void deactivateSKAdNetworkHandling()
    {
    }

    [Token(Token = "0x600F8CF")]
    [Address(RVA = "0xB664E0", Offset = "0xB652E0", VA = "0x10B664E0")]
    public void setLinkMeEnabled(bool linkMeEnabled)
    {
    }

    [Token(Token = "0x600F8D0")]
    [Address(RVA = "0xB66280", Offset = "0xB65080", VA = "0x10B66280")]
    public void setConversionValueUpdatedDelegate(
      Action<int> conversionValueUpdatedDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F8D1")]
    [Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")]
    public Action<int> getConversionValueUpdatedDelegate() => (Action<int>) null;

    [Token(Token = "0x600F8D2")]
    [Address(RVA = "0xB667A0", Offset = "0xB655A0", VA = "0x10B667A0")]
    public void setSkad4ConversionValueUpdatedDelegate(
      Action<int, string, bool> skad4ConversionValueUpdatedDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x600F8D3")]
    [Address(RVA = "0x36AA10", Offset = "0x369810", VA = "0x1036AA10")]
    public Action<int, string, bool> getSkad4ConversionValueUpdatedDelegate()
    {
      return (Action<int, string, bool>) null;
    }

    [Token(Token = "0x600F8D4")]
    [Address(RVA = "0xB661F0", Offset = "0xB64FF0", VA = "0x10B661F0")]
    public void setAttConsentWaitingInterval(int numberOfSeconds)
    {
    }

    [Token(Token = "0x600F8D5")]
    [Address(RVA = "0x7D9580", Offset = "0x7D8380", VA = "0x107D9580")]
    public void setProcessName(string processName)
    {
    }

    [Token(Token = "0x600F8D6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    [Obsolete("This is an obsolete method.")]
    public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity)
    {
    }

    [Token(Token = "0x600F8D7")]
    [Address(RVA = "0xB66650", Offset = "0xB65450", VA = "0x10B66650")]
    public void setPreinstallTrackingEnabled(bool preinstallTrackingEnabled)
    {
    }

    [Token(Token = "0x600F8D8")]
    [Address(RVA = "0x45A300", Offset = "0x459100", VA = "0x1045A300")]
    public void setPreinstallFilePath(string preinstallFilePath)
    {
    }

    [Token(Token = "0x600F8D9")]
    [Address(RVA = "0xB66600", Offset = "0xB65400", VA = "0x10B66600")]
    public void setPlayStoreKidsAppEnabled(bool playStoreKidsAppEnabled)
    {
    }

    [Token(Token = "0x600F8DA")]
    [Address(RVA = "0xB66440", Offset = "0xB65240", VA = "0x10B66440")]
    public void setFinalAndroidAttributionEnabled(bool finalAndroidAttributionEnabled)
    {
    }

    [Token(Token = "0x600F8DB")]
    [Address(RVA = "0x45A2C0", Offset = "0x4590C0", VA = "0x1045A2C0")]
    public void setFbAppId(string fbAppId)
    {
    }

    [Token(Token = "0x600F8DC")]
    [Address(RVA = "0xB666A0", Offset = "0xB654A0", VA = "0x10B666A0")]
    public void setReadDeviceInfoOnceEnabled(bool readDeviceInfoOnceEnabled)
    {
    }

    [Token(Token = "0x600F8DD")]
    [Address(RVA = "0xB66530", Offset = "0xB65330", VA = "0x10B66530")]
    public void setLogDelegate(Action<string> logDelegate)
    {
    }
  }
}
