// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchRewardItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AED")]
  public sealed class LeagueMatchRewardItemParamFormatter : 
    IMessagePackFormatter<LeagueMatchRewardItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A6A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A6B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A15")]
    [Address(RVA = "0xF247E0", Offset = "0xF235E0", VA = "0x10F247E0")]
    public LeagueMatchRewardItemParamFormatter()
    {
    }

    [Token(Token = "0x6002A16")]
    [Address(RVA = "0xF245B0", Offset = "0xF233B0", VA = "0x10F245B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchRewardItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A17")]
    [Address(RVA = "0xF24270", Offset = "0xF23070", VA = "0x10F24270", Slot = "5")]
    public LeagueMatchRewardItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchRewardItemParam) null;
    }
  }
}
