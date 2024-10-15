// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardDmgRatioParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A7E")]
  public sealed class JSON_GuildRaidRewardDmgRatioParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardDmgRatioParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400198C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400198D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028C8")]
    [Address(RVA = "0xEDCAB0", Offset = "0xEDB8B0", VA = "0x10EDCAB0")]
    public JSON_GuildRaidRewardDmgRatioParamFormatter()
    {
    }

    [Token(Token = "0x60028C9")]
    [Address(RVA = "0xEDC8D0", Offset = "0xEDB6D0", VA = "0x10EDC8D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardDmgRatioParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028CA")]
    [Address(RVA = "0xEDC590", Offset = "0xEDB390", VA = "0x10EDC590", Slot = "5")]
    public JSON_GuildRaidRewardDmgRatioParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardDmgRatioParam) null;
    }
  }
}
