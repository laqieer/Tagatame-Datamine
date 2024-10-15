// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchRankParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B09")]
  public sealed class LeagueMatchRankParamFormatter : 
    IMessagePackFormatter<LeagueMatchRankParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AA2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AA3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A69")]
    [Address(RVA = "0xF3FE90", Offset = "0xF3EC90", VA = "0x10F3FE90")]
    public LeagueMatchRankParamFormatter()
    {
    }

    [Token(Token = "0x6002A6A")]
    [Address(RVA = "0xF3FCB0", Offset = "0xF3EAB0", VA = "0x10F3FCB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchRankParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A6B")]
    [Address(RVA = "0xF3F9A0", Offset = "0xF3E7A0", VA = "0x10F3F9A0", Slot = "5")]
    public LeagueMatchRankParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchRankParam) null;
    }
  }
}
