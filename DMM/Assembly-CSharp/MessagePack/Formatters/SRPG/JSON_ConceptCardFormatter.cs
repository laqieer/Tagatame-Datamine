// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A0")]
  public sealed class JSON_ConceptCardFormatter : 
    IMessagePackFormatter<JSON_ConceptCard>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FD8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FD9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A2E")]
    [Address(RVA = "0x78FBE0", Offset = "0x78E9E0", VA = "0x1078FBE0")]
    public JSON_ConceptCardFormatter()
    {
    }

    [Token(Token = "0x6001A2F")]
    [Address(RVA = "0x78F8F0", Offset = "0x78E6F0", VA = "0x1078F8F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCard value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A30")]
    [Address(RVA = "0x78F400", Offset = "0x78E200", VA = "0x1078F400", Slot = "5")]
    public JSON_ConceptCard Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCard) null;
    }
  }
}
