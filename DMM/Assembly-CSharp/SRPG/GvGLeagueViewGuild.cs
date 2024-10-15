// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueViewGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025C3")]
  public class GvGLeagueViewGuild : ViewGuildData, IRankingContent
  {
    [Token(Token = "0x400AF3F")]
    [FieldOffset(Offset = "0x30")]
    public GvGLeagueData league;

    [Token(Token = "0x1700179B")]
    public int Rank
    {
      [Token(Token = "0x600A7C6"), Address(RVA = "0x6B9A40", Offset = "0x6B8840", VA = "0x106B9A40", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A7C7")]
    [Address(RVA = "0x6B9910", Offset = "0x6B8710", VA = "0x106B9910")]
    public void Deserialize(JSON_GvGLeagueViewGuild json)
    {
    }

    [Token(Token = "0x600A7C8")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public GvGLeagueViewGuild()
    {
    }
  }
}
