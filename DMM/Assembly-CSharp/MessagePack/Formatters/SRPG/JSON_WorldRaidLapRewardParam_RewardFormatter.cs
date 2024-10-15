// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidLapRewardParam_RewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A19")]
  public sealed class JSON_WorldRaidLapRewardParam_RewardFormatter : 
    IMessagePackFormatter<JSON_WorldRaidLapRewardParam.Reward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002799")]
    [Address(RVA = "0xEA4CD0", Offset = "0xEA3AD0", VA = "0x10EA4CD0")]
    public JSON_WorldRaidLapRewardParam_RewardFormatter()
    {
    }

    [Token(Token = "0x600279A")]
    [Address(RVA = "0xEA4B70", Offset = "0xEA3970", VA = "0x10EA4B70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidLapRewardParam.Reward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600279B")]
    [Address(RVA = "0xEA4820", Offset = "0xEA3620", VA = "0x10EA4820", Slot = "5")]
    public JSON_WorldRaidLapRewardParam.Reward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidLapRewardParam.Reward) null;
    }
  }
}
