// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardGroupFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000616")]
  public sealed class JSON_ConceptCardGroupFormatter : 
    IMessagePackFormatter<JSON_ConceptCardGroup>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B90")]
    [Address(RVA = "0xBB70E0", Offset = "0xBB5EE0", VA = "0x10BB70E0")]
    public JSON_ConceptCardGroupFormatter()
    {
    }

    [Token(Token = "0x6001B91")]
    [Address(RVA = "0xBB6F80", Offset = "0xBB5D80", VA = "0x10BB6F80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardGroup value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B92")]
    [Address(RVA = "0xBB6C40", Offset = "0xBB5A40", VA = "0x10BB6C40", Slot = "5")]
    public JSON_ConceptCardGroup Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardGroup) null;
    }
  }
}
