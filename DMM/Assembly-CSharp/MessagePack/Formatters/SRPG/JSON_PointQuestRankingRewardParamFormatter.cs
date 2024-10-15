// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestRankingRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A95")]
  public sealed class JSON_PointQuestRankingRewardParamFormatter : 
    IMessagePackFormatter<JSON_PointQuestRankingRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600290D")]
    [Address(RVA = "0xEE6060", Offset = "0xEE4E60", VA = "0x10EE6060")]
    public JSON_PointQuestRankingRewardParamFormatter()
    {
    }

    [Token(Token = "0x600290E")]
    [Address(RVA = "0xEE5E80", Offset = "0xEE4C80", VA = "0x10EE5E80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestRankingRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600290F")]
    [Address(RVA = "0xEE5B40", Offset = "0xEE4940", VA = "0x10EE5B40", Slot = "5")]
    public JSON_PointQuestRankingRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestRankingRewardParam) null;
    }
  }
}
