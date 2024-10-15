// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ArchiveParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A0B")]
  public sealed class JSON_ArchiveParamFormatter : 
    IMessagePackFormatter<JSON_ArchiveParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018A6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600276F")]
    [Address(RVA = "0xEA0140", Offset = "0xE9EF40", VA = "0x10EA0140")]
    public JSON_ArchiveParamFormatter()
    {
    }

    [Token(Token = "0x6002770")]
    [Address(RVA = "0xE9FBD0", Offset = "0xE9E9D0", VA = "0x10E9FBD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ArchiveParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002771")]
    [Address(RVA = "0xE9F540", Offset = "0xE9E340", VA = "0x10E9F540", Slot = "5")]
    public JSON_ArchiveParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ArchiveParam) null;
    }
  }
}
