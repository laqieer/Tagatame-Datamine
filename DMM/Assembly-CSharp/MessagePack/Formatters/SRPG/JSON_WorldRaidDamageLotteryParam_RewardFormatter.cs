// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidDamageLotteryParam_RewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A2C")]
  public sealed class JSON_WorldRaidDamageLotteryParam_RewardFormatter : 
    IMessagePackFormatter<JSON_WorldRaidDamageLotteryParam.Reward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027D2")]
    [Address(RVA = "0xEB3710", Offset = "0xEB2510", VA = "0x10EB3710")]
    public JSON_WorldRaidDamageLotteryParam_RewardFormatter()
    {
    }

    [Token(Token = "0x60027D3")]
    [Address(RVA = "0xEB3570", Offset = "0xEB2370", VA = "0x10EB3570", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidDamageLotteryParam.Reward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027D4")]
    [Address(RVA = "0xEB31F0", Offset = "0xEB1FF0", VA = "0x10EB31F0", Slot = "5")]
    public JSON_WorldRaidDamageLotteryParam.Reward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidDamageLotteryParam.Reward) null;
    }
  }
}
