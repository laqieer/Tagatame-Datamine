// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelResultRankPointDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A00")]
  public sealed class JSON_DuelResultRankPointDataFormatter : 
    IMessagePackFormatter<JSON_DuelResultRankPointData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001890")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001891")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600274E")]
    [Address(RVA = "0xE837E0", Offset = "0xE825E0", VA = "0x10E837E0")]
    public JSON_DuelResultRankPointDataFormatter()
    {
    }

    [Token(Token = "0x600274F")]
    [Address(RVA = "0xE83640", Offset = "0xE82440", VA = "0x10E83640", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelResultRankPointData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002750")]
    [Address(RVA = "0xE832B0", Offset = "0xE820B0", VA = "0x10E832B0", Slot = "5")]
    public JSON_DuelResultRankPointData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelResultRankPointData) null;
    }
  }
}
