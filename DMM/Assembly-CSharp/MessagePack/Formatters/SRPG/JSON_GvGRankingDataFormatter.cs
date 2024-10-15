// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGRankingDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C9")]
  public sealed class JSON_GvGRankingDataFormatter : 
    IMessagePackFormatter<JSON_GvGRankingData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400102A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400102B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AA9")]
    [Address(RVA = "0x957A10", Offset = "0x956810", VA = "0x10957A10")]
    public JSON_GvGRankingDataFormatter()
    {
    }

    [Token(Token = "0x6001AAA")]
    [Address(RVA = "0x9576E0", Offset = "0x9564E0", VA = "0x109576E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGRankingData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AAB")]
    [Address(RVA = "0x9571C0", Offset = "0x955FC0", VA = "0x109571C0", Slot = "5")]
    public JSON_GvGRankingData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGRankingData) null;
    }
  }
}
