// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ChapterCountFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000849")]
  public sealed class JSON_ChapterCountFormatter : 
    IMessagePackFormatter<JSON_ChapterCount>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001522")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001523")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002229")]
    [Address(RVA = "0xD6B8D0", Offset = "0xD6A6D0", VA = "0x10D6B8D0")]
    public JSON_ChapterCountFormatter()
    {
    }

    [Token(Token = "0x600222A")]
    [Address(RVA = "0xD6B7A0", Offset = "0xD6A5A0", VA = "0x10D6B7A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ChapterCount value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600222B")]
    [Address(RVA = "0xD6B490", Offset = "0xD6A290", VA = "0x10D6B490", Slot = "5")]
    public JSON_ChapterCount Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ChapterCount) null;
    }
  }
}
