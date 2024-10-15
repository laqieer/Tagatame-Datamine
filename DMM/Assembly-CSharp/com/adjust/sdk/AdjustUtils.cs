// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036E5")]
  public class AdjustUtils
  {
    [Token(Token = "0x401023B")]
    [FieldOffset(Offset = "0x0")]
    public static string KeyAdid;
    [Token(Token = "0x401023C")]
    [FieldOffset(Offset = "0x4")]
    public static string KeyMessage;
    [Token(Token = "0x401023D")]
    [FieldOffset(Offset = "0x8")]
    public static string KeyNetwork;
    [Token(Token = "0x401023E")]
    [FieldOffset(Offset = "0xC")]
    public static string KeyAdgroup;
    [Token(Token = "0x401023F")]
    [FieldOffset(Offset = "0x10")]
    public static string KeyCampaign;
    [Token(Token = "0x4010240")]
    [FieldOffset(Offset = "0x14")]
    public static string KeyCreative;
    [Token(Token = "0x4010241")]
    [FieldOffset(Offset = "0x18")]
    public static string KeyWillRetry;
    [Token(Token = "0x4010242")]
    [FieldOffset(Offset = "0x1C")]
    public static string KeyTimestamp;
    [Token(Token = "0x4010243")]
    [FieldOffset(Offset = "0x20")]
    public static string KeyCallbackId;
    [Token(Token = "0x4010244")]
    [FieldOffset(Offset = "0x24")]
    public static string KeyEventToken;
    [Token(Token = "0x4010245")]
    [FieldOffset(Offset = "0x28")]
    public static string KeyClickLabel;
    [Token(Token = "0x4010246")]
    [FieldOffset(Offset = "0x2C")]
    public static string KeyTrackerName;
    [Token(Token = "0x4010247")]
    [FieldOffset(Offset = "0x30")]
    public static string KeyTrackerToken;
    [Token(Token = "0x4010248")]
    [FieldOffset(Offset = "0x34")]
    public static string KeyJsonResponse;
    [Token(Token = "0x4010249")]
    [FieldOffset(Offset = "0x38")]
    public static string KeyCostType;
    [Token(Token = "0x401024A")]
    [FieldOffset(Offset = "0x3C")]
    public static string KeyCostAmount;
    [Token(Token = "0x401024B")]
    [FieldOffset(Offset = "0x40")]
    public static string KeyCostCurrency;
    [Token(Token = "0x401024C")]
    [FieldOffset(Offset = "0x44")]
    public static string KeyFbInstallReferrer;
    [Token(Token = "0x401024D")]
    [FieldOffset(Offset = "0x48")]
    public static string KeySkadConversionValue;
    [Token(Token = "0x401024E")]
    [FieldOffset(Offset = "0x4C")]
    public static string KeySkadCoarseValue;
    [Token(Token = "0x401024F")]
    [FieldOffset(Offset = "0x50")]
    public static string KeySkadLockWindow;
    [Token(Token = "0x4010250")]
    [FieldOffset(Offset = "0x54")]
    public static string KeyCode;
    [Token(Token = "0x4010251")]
    [FieldOffset(Offset = "0x58")]
    public static string KeyVerificationStatus;
    [Token(Token = "0x4010252")]
    [FieldOffset(Offset = "0x5C")]
    public static string KeyTestOptionsBaseUrl;
    [Token(Token = "0x4010253")]
    [FieldOffset(Offset = "0x60")]
    public static string KeyTestOptionsGdprUrl;
    [Token(Token = "0x4010254")]
    [FieldOffset(Offset = "0x64")]
    public static string KeyTestOptionsSubscriptionUrl;
    [Token(Token = "0x4010255")]
    [FieldOffset(Offset = "0x68")]
    public static string KeyTestOptionsPurchaseVerificationUrl;
    [Token(Token = "0x4010256")]
    [FieldOffset(Offset = "0x6C")]
    public static string KeyTestOptionsOverwriteUrl;
    [Token(Token = "0x4010257")]
    [FieldOffset(Offset = "0x70")]
    public static string KeyTestOptionsExtraPath;
    [Token(Token = "0x4010258")]
    [FieldOffset(Offset = "0x74")]
    public static string KeyTestOptionsBasePath;
    [Token(Token = "0x4010259")]
    [FieldOffset(Offset = "0x78")]
    public static string KeyTestOptionsGdprPath;
    [Token(Token = "0x401025A")]
    [FieldOffset(Offset = "0x7C")]
    public static string KeyTestOptionsDeleteState;
    [Token(Token = "0x401025B")]
    [FieldOffset(Offset = "0x80")]
    public static string KeyTestOptionsUseTestConnectionOptions;
    [Token(Token = "0x401025C")]
    [FieldOffset(Offset = "0x84")]
    public static string KeyTestOptionsTimerIntervalInMilliseconds;
    [Token(Token = "0x401025D")]
    [FieldOffset(Offset = "0x88")]
    public static string KeyTestOptionsTimerStartInMilliseconds;
    [Token(Token = "0x401025E")]
    [FieldOffset(Offset = "0x8C")]
    public static string KeyTestOptionsSessionIntervalInMilliseconds;
    [Token(Token = "0x401025F")]
    [FieldOffset(Offset = "0x90")]
    public static string KeyTestOptionsSubsessionIntervalInMilliseconds;
    [Token(Token = "0x4010260")]
    [FieldOffset(Offset = "0x94")]
    public static string KeyTestOptionsTeardown;
    [Token(Token = "0x4010261")]
    [FieldOffset(Offset = "0x98")]
    public static string KeyTestOptionsNoBackoffWait;
    [Token(Token = "0x4010262")]
    [FieldOffset(Offset = "0x9C")]
    public static string KeyTestOptionsAdServicesFrameworkEnabled;
    [Token(Token = "0x4010263")]
    [FieldOffset(Offset = "0xA0")]
    public static string KeyTestOptionsAttStatus;
    [Token(Token = "0x4010264")]
    [FieldOffset(Offset = "0xA4")]
    public static string KeyTestOptionsIdfa;

    [Token(Token = "0x600F93D")]
    [Address(RVA = "0xB69870", Offset = "0xB68670", VA = "0x10B69870")]
    public static int ConvertLogLevel(AdjustLogLevel? logLevel) => new int();

    [Token(Token = "0x600F93E")]
    [Address(RVA = "0xB694B0", Offset = "0xB682B0", VA = "0x10B694B0")]
    public static int ConvertBool(bool? value) => new int();

    [Token(Token = "0x600F93F")]
    [Address(RVA = "0xB69510", Offset = "0xB68310", VA = "0x10B69510")]
    public static double ConvertDouble(double? value) => new double();

    [Token(Token = "0x600F940")]
    [Address(RVA = "0xB69560", Offset = "0xB68360", VA = "0x10B69560")]
    public static int ConvertInt(int? value) => new int();

    [Token(Token = "0x600F941")]
    [Address(RVA = "0xB698C0", Offset = "0xB686C0", VA = "0x10B698C0")]
    public static long ConvertLong(long? value) => new long();

    [Token(Token = "0x600F942")]
    [Address(RVA = "0xB695B0", Offset = "0xB683B0", VA = "0x10B695B0")]
    public static string ConvertListToJson(List<string> list) => (string) null;

    [Token(Token = "0x600F943")]
    [Address(RVA = "0xB69910", Offset = "0xB68710", VA = "0x10B69910")]
    public static string GetJsonResponseCompact(Dictionary<string, object> dictionary)
    {
      return (string) null;
    }

    [Token(Token = "0x600F944")]
    [Address(RVA = "0xB69EE0", Offset = "0xB68CE0", VA = "0x10B69EE0")]
    public static string GetJsonString(JSONNode node, string key) => (string) null;

    [Token(Token = "0x600F945")]
    [Address(RVA = "0xB6A350", Offset = "0xB69150", VA = "0x10B6A350")]
    public static void WriteJsonResponseDictionary(
      JSONClass jsonObject,
      Dictionary<string, object> output)
    {
    }

    [Token(Token = "0x600F946")]
    [Address(RVA = "0xB6A2D0", Offset = "0xB690D0", VA = "0x10B6A2D0")]
    public static string TryGetValue(Dictionary<string, string> dictionary, string key)
    {
      return (string) null;
    }

    [Token(Token = "0x600F947")]
    [Address(RVA = "0xB6A110", Offset = "0xB68F10", VA = "0x10B6A110")]
    public static int GetSkad4ConversionValue(string conversionValueUpdate) => new int();

    [Token(Token = "0x600F948")]
    [Address(RVA = "0xB6A060", Offset = "0xB68E60", VA = "0x10B6A060")]
    public static string GetSkad4CoarseValue(string conversionValueUpdate) => (string) null;

    [Token(Token = "0x600F949")]
    [Address(RVA = "0xB6A1F0", Offset = "0xB68FF0", VA = "0x10B6A1F0")]
    public static bool GetSkad4LockWindow(string conversionValueUpdate) => new bool();

    [Token(Token = "0x600F94A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdjustUtils()
    {
    }

    [Token(Token = "0x600F94B")]
    [Address(RVA = "0xB6A6A0", Offset = "0xB694A0", VA = "0x10B6A6A0")]
    static AdjustUtils()
    {
    }
  }
}
