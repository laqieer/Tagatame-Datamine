// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InitUnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000705")]
  public sealed class JSON_InitUnitFormatter : 
    IMessagePackFormatter<JSON_InitUnit>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E5D")]
    [Address(RVA = "0xC27CE0", Offset = "0xC26AE0", VA = "0x10C27CE0")]
    public JSON_InitUnitFormatter()
    {
    }

    [Token(Token = "0x6001E5E")]
    [Address(RVA = "0xC27B10", Offset = "0xC26910", VA = "0x10C27B10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InitUnit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E5F")]
    [Address(RVA = "0xC27770", Offset = "0xC26570", VA = "0x10C27770", Slot = "5")]
    public JSON_InitUnit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InitUnit) null;
    }
  }
}
