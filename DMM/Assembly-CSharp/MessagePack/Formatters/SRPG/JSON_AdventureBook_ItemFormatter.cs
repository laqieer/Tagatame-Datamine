// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureBook_ItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008DC")]
  public sealed class JSON_AdventureBook_ItemFormatter : 
    IMessagePackFormatter<JSON_AdventureBook.Item>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001648")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001649")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023E2")]
    [Address(RVA = "0xDCC180", Offset = "0xDCAF80", VA = "0x10DCC180")]
    public JSON_AdventureBook_ItemFormatter()
    {
    }

    [Token(Token = "0x60023E3")]
    [Address(RVA = "0xDCBFE0", Offset = "0xDCADE0", VA = "0x10DCBFE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureBook.Item value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023E4")]
    [Address(RVA = "0xDCBC50", Offset = "0xDCAA50", VA = "0x10DCBC50", Slot = "5")]
    public JSON_AdventureBook.Item Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureBook.Item) null;
    }
  }
}
