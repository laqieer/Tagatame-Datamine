// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BookmarkDropDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000850")]
  public sealed class BookmarkDropDataFormatter : 
    IMessagePackFormatter<BookmarkDropData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001530")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001531")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600223E")]
    [Address(RVA = "0xD81430", Offset = "0xD80230", VA = "0x10D81430")]
    public BookmarkDropDataFormatter()
    {
    }

    [Token(Token = "0x600223F")]
    [Address(RVA = "0xD81300", Offset = "0xD80100", VA = "0x10D81300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BookmarkDropData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002240")]
    [Address(RVA = "0xD81020", Offset = "0xD7FE20", VA = "0x10D81020", Slot = "5")]
    public BookmarkDropData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BookmarkDropData) null;
    }
  }
}
