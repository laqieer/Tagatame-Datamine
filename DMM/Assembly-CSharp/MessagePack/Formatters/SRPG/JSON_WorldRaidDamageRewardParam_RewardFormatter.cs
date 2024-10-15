// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidDamageRewardParam_RewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C3")]
  public sealed class JSON_WorldRaidDamageRewardParam_RewardFormatter : 
    IMessagePackFormatter<JSON_WorldRaidDamageRewardParam.Reward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001616")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001617")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002397")]
    [Address(RVA = "0xDD56E0", Offset = "0xDD44E0", VA = "0x10DD56E0")]
    public JSON_WorldRaidDamageRewardParam_RewardFormatter()
    {
    }

    [Token(Token = "0x6002398")]
    [Address(RVA = "0xDD5540", Offset = "0xDD4340", VA = "0x10DD5540", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidDamageRewardParam.Reward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002399")]
    [Address(RVA = "0xDD51C0", Offset = "0xDD3FC0", VA = "0x10DD51C0", Slot = "5")]
    public JSON_WorldRaidDamageRewardParam.Reward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidDamageRewardParam.Reward) null;
    }
  }
}
