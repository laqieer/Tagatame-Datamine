// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025C9")]
  public class GvGLeagueResult
  {
    [Token(Token = "0x1700179C")]
    public GvGLeagueData From
    {
      [Token(Token = "0x600A7D9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (GvGLeagueData) null;
      }
      [Token(Token = "0x600A7DA"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700179D")]
    public GvGLeagueData To
    {
      [Token(Token = "0x600A7DB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GvGLeagueData) null;
      }
      [Token(Token = "0x600A7DC"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600A7DD")]
    [Address(RVA = "0x6B8E30", Offset = "0x6B7C30", VA = "0x106B8E30")]
    public bool Deserialize(JSON_GvGLeagueResult json) => new bool();

    [Token(Token = "0x600A7DE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGLeagueResult()
    {
    }
  }
}
