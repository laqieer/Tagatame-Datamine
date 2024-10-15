// Decompiled with JetBrains decompiler
// Type: GrowthPush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000007")]
public class GrowthPush
{
  [Token(Token = "0x4000016")]
  [FieldOffset(Offset = "0x0")]
  private static GrowthPush instance;

  [Token(Token = "0x6000019")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  private GrowthPush()
  {
  }

  [Token(Token = "0x600001A")]
  [Address(RVA = "0x2C61A0", Offset = "0x2C4FA0", VA = "0x102C61A0")]
  public static GrowthPush GetInstance() => (GrowthPush) null;

  [Token(Token = "0x600001B")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void Initialize(
    string applicationId,
    string credentialId,
    GrowthPush.Environment environment)
  {
  }

  [Token(Token = "0x600001C")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void Initialize(
    string applicationId,
    string credentialId,
    GrowthPush.Environment environment,
    bool adInfoEnable)
  {
  }

  [Token(Token = "0x600001D")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void Initialize(
    string applicationId,
    string credentialId,
    GrowthPush.Environment environment,
    bool adInfoEnable,
    string channelId)
  {
  }

  [Token(Token = "0x600001E")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void RequestDeviceToken(string senderId)
  {
  }

  [Token(Token = "0x600001F")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void RequestDeviceToken()
  {
  }

  [Token(Token = "0x6000020")]
  [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0")]
  public string GetDeviceToken() => (string) null;

  [Token(Token = "0x6000021")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetDeviceToken(string deviceToken)
  {
  }

  [Token(Token = "0x6000022")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void ClearBadge()
  {
  }

  [Token(Token = "0x6000023")]
  [Address(RVA = "0x2C61E0", Offset = "0x2C4FE0", VA = "0x102C61E0")]
  public void SetTag(string name)
  {
  }

  [Token(Token = "0x6000024")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetTag(string name, string value)
  {
  }

  [Token(Token = "0x6000025")]
  [Address(RVA = "0x2C6200", Offset = "0x2C5000", VA = "0x102C6200")]
  public void TrackEvent(string name)
  {
  }

  [Token(Token = "0x6000026")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void TrackEvent(string name, string value)
  {
  }

  [Token(Token = "0x6000027")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void TrackEvent(string name, string value, string gameObject, string methodName)
  {
  }

  [Token(Token = "0x6000028")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void RenderMessage(string uuid)
  {
  }

  [Token(Token = "0x6000029")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetChannelId(string channelId)
  {
  }

  [Token(Token = "0x600002A")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void DeleteDefaultNotificationChannel()
  {
  }

  [Token(Token = "0x600002B")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetBaseUrl(string baseUrl)
  {
  }

  [Token(Token = "0x600002C")]
  [Address(RVA = "0x2C6220", Offset = "0x2C5020", VA = "0x102C6220")]
  static GrowthPush()
  {
  }

  [Token(Token = "0x2000008")]
  public enum Environment
  {
    [Token(Token = "0x4000018")] Unknown,
    [Token(Token = "0x4000019")] Development,
    [Token(Token = "0x400001A")] Production,
  }
}
