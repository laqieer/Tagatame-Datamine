// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A4D")]
  public sealed class JSON_GuildRaidRewardParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400192A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400192B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002835")]
    [Address(RVA = "0xEAE230", Offset = "0xEAD030", VA = "0x10EAE230")]
    public JSON_GuildRaidRewardParamFormatter()
    {
    }

    [Token(Token = "0x6002836")]
    [Address(RVA = "0xEAE050", Offset = "0xEACE50", VA = "0x10EAE050", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002837")]
    [Address(RVA = "0xEADD10", Offset = "0xEACB10", VA = "0x10EADD10", Slot = "5")]
    public JSON_GuildRaidRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardParam) null;
    }
  }
}
