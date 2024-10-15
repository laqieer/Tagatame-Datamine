// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGScoreRankingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005CC")]
  public sealed class JSON_GvGScoreRankingFormatter : 
    IMessagePackFormatter<JSON_GvGScoreRanking>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001030")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001031")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AB2")]
    [Address(RVA = "0x958CF0", Offset = "0x957AF0", VA = "0x10958CF0")]
    public JSON_GvGScoreRankingFormatter()
    {
    }

    [Token(Token = "0x6001AB3")]
    [Address(RVA = "0x958A30", Offset = "0x957830", VA = "0x10958A30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGScoreRanking value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AB4")]
    [Address(RVA = "0x9585A0", Offset = "0x9573A0", VA = "0x109585A0", Slot = "5")]
    public JSON_GvGScoreRanking Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGScoreRanking) null;
    }
  }
}
