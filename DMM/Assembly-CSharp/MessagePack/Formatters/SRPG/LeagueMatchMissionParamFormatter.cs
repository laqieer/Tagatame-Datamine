// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchMissionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000988")]
  public sealed class LeagueMatchMissionParamFormatter : 
    IMessagePackFormatter<LeagueMatchMissionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025E6")]
    [Address(RVA = "0xE3C510", Offset = "0xE3B310", VA = "0x10E3C510")]
    public LeagueMatchMissionParamFormatter()
    {
    }

    [Token(Token = "0x60025E7")]
    [Address(RVA = "0xE3BFE0", Offset = "0xE3ADE0", VA = "0x10E3BFE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchMissionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025E8")]
    [Address(RVA = "0xE3BA90", Offset = "0xE3A890", VA = "0x10E3BA90", Slot = "5")]
    public LeagueMatchMissionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchMissionParam) null;
    }
  }
}
