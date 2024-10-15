// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelRankingRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000807")]
  public sealed class JSON_DuelRankingRewardFormatter : 
    IMessagePackFormatter<JSON_DuelRankingReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400149E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400149F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002163")]
    [Address(RVA = "0xD41650", Offset = "0xD40450", VA = "0x10D41650")]
    public JSON_DuelRankingRewardFormatter()
    {
    }

    [Token(Token = "0x6002164")]
    [Address(RVA = "0xD41520", Offset = "0xD40320", VA = "0x10D41520", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelRankingReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002165")]
    [Address(RVA = "0xD41210", Offset = "0xD40010", VA = "0x10D41210", Slot = "5")]
    public JSON_DuelRankingReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelRankingReward) null;
    }
  }
}
