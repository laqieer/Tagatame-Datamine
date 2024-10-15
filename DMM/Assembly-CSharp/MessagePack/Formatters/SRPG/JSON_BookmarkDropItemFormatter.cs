// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BookmarkDropItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200084E")]
  public sealed class JSON_BookmarkDropItemFormatter : 
    IMessagePackFormatter<JSON_BookmarkDropItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400152C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400152D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002238")]
    [Address(RVA = "0xD863F0", Offset = "0xD851F0", VA = "0x10D863F0")]
    public JSON_BookmarkDropItemFormatter()
    {
    }

    [Token(Token = "0x6002239")]
    [Address(RVA = "0xD862C0", Offset = "0xD850C0", VA = "0x10D862C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BookmarkDropItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600223A")]
    [Address(RVA = "0xD85FB0", Offset = "0xD84DB0", VA = "0x10D85FB0", Slot = "5")]
    public JSON_BookmarkDropItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BookmarkDropItem) null;
    }
  }
}
