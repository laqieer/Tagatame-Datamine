// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ArchiveItemsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A0A")]
  public sealed class JSON_ArchiveItemsParamFormatter : 
    IMessagePackFormatter<JSON_ArchiveItemsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600276C")]
    [Address(RVA = "0xE9F3C0", Offset = "0xE9E1C0", VA = "0x10E9F3C0")]
    public JSON_ArchiveItemsParamFormatter()
    {
    }

    [Token(Token = "0x600276D")]
    [Address(RVA = "0xE9F290", Offset = "0xE9E090", VA = "0x10E9F290", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ArchiveItemsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600276E")]
    [Address(RVA = "0xE9EF80", Offset = "0xE9DD80", VA = "0x10E9EF80", Slot = "5")]
    public JSON_ArchiveItemsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ArchiveItemsParam) null;
    }
  }
}
