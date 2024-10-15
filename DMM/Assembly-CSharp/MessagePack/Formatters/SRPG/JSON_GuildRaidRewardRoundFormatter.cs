// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardRoundFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E4")]
  public sealed class JSON_GuildRaidRewardRoundFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardRound>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001658")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001659")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023FA")]
    [Address(RVA = "0xDD1B60", Offset = "0xDD0960", VA = "0x10DD1B60")]
    public JSON_GuildRaidRewardRoundFormatter()
    {
    }

    [Token(Token = "0x60023FB")]
    [Address(RVA = "0xDD1A30", Offset = "0xDD0830", VA = "0x10DD1A30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardRound value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023FC")]
    [Address(RVA = "0xDD1720", Offset = "0xDD0520", VA = "0x10DD1720", Slot = "5")]
    public JSON_GuildRaidRewardRound Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardRound) null;
    }
  }
}
