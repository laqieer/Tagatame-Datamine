// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200062E")]
  public sealed class JSON_RaidRewardFormatter : 
    IMessagePackFormatter<JSON_RaidReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BD8")]
    [Address(RVA = "0xBC6160", Offset = "0xBC4F60", VA = "0x10BC6160")]
    public JSON_RaidRewardFormatter()
    {
    }

    [Token(Token = "0x6001BD9")]
    [Address(RVA = "0xBC6000", Offset = "0xBC4E00", VA = "0x10BC6000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BDA")]
    [Address(RVA = "0xBC5CA0", Offset = "0xBC4AA0", VA = "0x10BC5CA0", Slot = "5")]
    public JSON_RaidReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidReward) null;
    }
  }
}
