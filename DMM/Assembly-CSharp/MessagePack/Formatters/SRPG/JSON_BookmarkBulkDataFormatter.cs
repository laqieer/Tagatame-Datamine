// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BookmarkBulkDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200084D")]
  public sealed class JSON_BookmarkBulkDataFormatter : 
    IMessagePackFormatter<JSON_BookmarkBulkData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400152A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400152B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002235")]
    [Address(RVA = "0xD85E30", Offset = "0xD84C30", VA = "0x10D85E30")]
    public JSON_BookmarkBulkDataFormatter()
    {
    }

    [Token(Token = "0x6002236")]
    [Address(RVA = "0xD85D00", Offset = "0xD84B00", VA = "0x10D85D00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BookmarkBulkData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002237")]
    [Address(RVA = "0xD859F0", Offset = "0xD847F0", VA = "0x10D859F0", Slot = "5")]
    public JSON_BookmarkBulkData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BookmarkBulkData) null;
    }
  }
}
