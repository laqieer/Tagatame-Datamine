// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_HighlightGiftDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000651")]
  public sealed class JSON_HighlightGiftDataFormatter : 
    IMessagePackFormatter<JSON_HighlightGiftData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400113A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400113B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C41")]
    [Address(RVA = "0xBD8980", Offset = "0xBD7780", VA = "0x10BD8980")]
    public JSON_HighlightGiftDataFormatter()
    {
    }

    [Token(Token = "0x6001C42")]
    [Address(RVA = "0xBD8820", Offset = "0xBD7620", VA = "0x10BD8820", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_HighlightGiftData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C43")]
    [Address(RVA = "0xBD84D0", Offset = "0xBD72D0", VA = "0x10BD84D0", Slot = "5")]
    public JSON_HighlightGiftData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_HighlightGiftData) null;
    }
  }
}
