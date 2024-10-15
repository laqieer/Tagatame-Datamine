// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidPeriodTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B4D")]
  public class GuildRaidPeriodTime
  {
    [Token(Token = "0x17000D59")]
    public string Begin
    {
      [Token(Token = "0x600708B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600708C"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000D5A")]
    public string Open
    {
      [Token(Token = "0x600708D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600708E"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600708F")]
    [Address(RVA = "0x362350", Offset = "0x361150", VA = "0x10362350")]
    public bool Deserialize(JSON_GuildRaidPeriodTime json) => new bool();

    [Token(Token = "0x6007090")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidPeriodTime()
    {
    }
  }
}
