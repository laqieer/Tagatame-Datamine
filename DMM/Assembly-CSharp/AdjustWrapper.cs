// Decompiled with JetBrains decompiler
// Type: AdjustWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200002D")]
public class AdjustWrapper
{
  [Token(Token = "0x40000D1")]
  private const string APP_TOKEN = "urt8vz8z0hkw";
  [Token(Token = "0x40000D2")]
  public const string EVENTTOKEN_PAYMENT = "q8j451";
  [Token(Token = "0x40000D3")]
  public const string EVENTTOKEN_TEST = "jgiyg4";
  [Token(Token = "0x40000D4")]
  public const string EVENTTOKEN_TUTORIAL_END = "unh23k";
  [Token(Token = "0x40000D5")]
  public const string EVENTTOKEN_PLAYNEW = "uuozli";
  [Token(Token = "0x40000D6")]
  public const string SESSION_CALLBACK_DEVICEID = "device_id";
  [Token(Token = "0x40000D7")]
  [FieldOffset(Offset = "0x0")]
  private static bool m_enable;

  [Token(Token = "0x17000017")]
  public static bool IsEnable
  {
    [Token(Token = "0x6000112"), Address(RVA = "0x2BB260", Offset = "0x2BA060", VA = "0x102BB260")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000018")]
  public static long[] AppSecrets
  {
    [Token(Token = "0x6000113"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0")] get
    {
      return (long[]) null;
    }
  }

  [Token(Token = "0x6000114")]
  [Address(RVA = "0x2BAE20", Offset = "0x2B9C20", VA = "0x102BAE20")]
  public static void Setup()
  {
  }

  [Token(Token = "0x6000115")]
  [Address(RVA = "0x2BB180", Offset = "0x2B9F80", VA = "0x102BB180")]
  public static void TrackRevenue(
    string ev_token,
    string currency,
    double price,
    string transactionId)
  {
  }

  [Token(Token = "0x6000116")]
  [Address(RVA = "0x2BB0A0", Offset = "0x2B9EA0", VA = "0x102BB0A0")]
  public static void TrackEventSimple(string ev_token)
  {
  }

  [Token(Token = "0x6000117")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public AdjustWrapper()
  {
  }
}
