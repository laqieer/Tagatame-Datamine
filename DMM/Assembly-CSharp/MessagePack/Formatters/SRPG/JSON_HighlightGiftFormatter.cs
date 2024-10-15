// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_HighlightGiftFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000652")]
  public sealed class JSON_HighlightGiftFormatter : 
    IMessagePackFormatter<JSON_HighlightGift>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400113C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400113D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C44")]
    [Address(RVA = "0xBD9150", Offset = "0xBD7F50", VA = "0x10BD9150")]
    public JSON_HighlightGiftFormatter()
    {
    }

    [Token(Token = "0x6001C45")]
    [Address(RVA = "0xBD8F10", Offset = "0xBD7D10", VA = "0x10BD8F10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_HighlightGift value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C46")]
    [Address(RVA = "0xBD8B70", Offset = "0xBD7970", VA = "0x10BD8B70", Slot = "5")]
    public JSON_HighlightGift Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_HighlightGift) null;
    }
  }
}
