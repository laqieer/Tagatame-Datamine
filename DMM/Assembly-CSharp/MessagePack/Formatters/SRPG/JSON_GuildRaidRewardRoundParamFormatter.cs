// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardRoundParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E5")]
  public sealed class JSON_GuildRaidRewardRoundParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardRoundParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400165A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400165B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023FD")]
    [Address(RVA = "0xDD2200", Offset = "0xDD1000", VA = "0x10DD2200")]
    public JSON_GuildRaidRewardRoundParamFormatter()
    {
    }

    [Token(Token = "0x60023FE")]
    [Address(RVA = "0xDD2020", Offset = "0xDD0E20", VA = "0x10DD2020", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardRoundParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023FF")]
    [Address(RVA = "0xDD1CE0", Offset = "0xDD0AE0", VA = "0x10DD1CE0", Slot = "5")]
    public JSON_GuildRaidRewardRoundParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardRoundParam) null;
    }
  }
}
