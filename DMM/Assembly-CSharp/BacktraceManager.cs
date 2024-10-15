// Decompiled with JetBrains decompiler
// Type: BacktraceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Backtrace.Unity;
using GR;
using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200023A")]
public class BacktraceManager : MonoSingleton<BacktraceManager>
{
  [Token(Token = "0x400098D")]
  [FieldOffset(Offset = "0xC")]
  private BacktraceClient mBacktraceClient;

  [Token(Token = "0x1700015D")]
  public BacktraceClient GetBacktraceClient
  {
    [Token(Token = "0x6000BCD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (BacktraceClient) null;
    }
  }

  [Token(Token = "0x1700015E")]
  private string BacktraceURL
  {
    [Token(Token = "0x6000BCE"), Address(RVA = "0x10765A0", Offset = "0x10753A0", VA = "0x110765A0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6000BCF")]
  [Address(RVA = "0x1076380", Offset = "0x1075180", VA = "0x11076380", Slot = "4")]
  protected override void Initialize()
  {
  }

  [Token(Token = "0x6000BD0")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
  protected override void Release()
  {
  }

  [Token(Token = "0x6000BD1")]
  [Address(RVA = "0x1076260", Offset = "0x1075060", VA = "0x11076260")]
  public void InitializeBacktrace()
  {
  }

  [Token(Token = "0x6000BD2")]
  [Address(RVA = "0x10764F0", Offset = "0x10752F0", VA = "0x110764F0")]
  public void SetBacktraceAttribute(string key, string value)
  {
  }

  [Token(Token = "0x6000BD3")]
  [Address(RVA = "0x10763D0", Offset = "0x10751D0", VA = "0x110763D0")]
  public void RefreshBacktraceAttribute()
  {
  }

  [Token(Token = "0x6000BD4")]
  [Address(RVA = "0x1076440", Offset = "0x1075240", VA = "0x11076440")]
  public void Send(string message)
  {
  }

  [Token(Token = "0x6000BD5")]
  [Address(RVA = "0x1076560", Offset = "0x1075360", VA = "0x11076560")]
  public BacktraceManager()
  {
  }
}
