// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AEE")]
  public sealed class LeagueMatchRewardParamFormatter : 
    IMessagePackFormatter<LeagueMatchRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A6C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A6D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A18")]
    [Address(RVA = "0xF24EC0", Offset = "0xF23CC0", VA = "0x10F24EC0")]
    public LeagueMatchRewardParamFormatter()
    {
    }

    [Token(Token = "0x6002A19")]
    [Address(RVA = "0xF24CE0", Offset = "0xF23AE0", VA = "0x10F24CE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A1A")]
    [Address(RVA = "0xF249D0", Offset = "0xF237D0", VA = "0x10F249D0", Slot = "5")]
    public LeagueMatchRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchRewardParam) null;
    }
  }
}
