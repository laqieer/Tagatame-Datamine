// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidRewardParam_RewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000958")]
  public sealed class JSON_WorldRaidRewardParam_RewardFormatter : 
    IMessagePackFormatter<JSON_WorldRaidRewardParam.Reward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001740")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001741")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002556")]
    [Address(RVA = "0xE17010", Offset = "0xE15E10", VA = "0x10E17010")]
    public JSON_WorldRaidRewardParam_RewardFormatter()
    {
    }

    [Token(Token = "0x6002557")]
    [Address(RVA = "0xE16EB0", Offset = "0xE15CB0", VA = "0x10E16EB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidRewardParam.Reward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002558")]
    [Address(RVA = "0xE16B60", Offset = "0xE15960", VA = "0x10E16B60", Slot = "5")]
    public JSON_WorldRaidRewardParam.Reward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidRewardParam.Reward) null;
    }
  }
}
