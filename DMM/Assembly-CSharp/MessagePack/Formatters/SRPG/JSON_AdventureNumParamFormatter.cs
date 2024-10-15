// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureNumParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000953")]
  public sealed class JSON_AdventureNumParamFormatter : 
    IMessagePackFormatter<JSON_AdventureNumParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001736")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001737")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002547")]
    [Address(RVA = "0xE13F00", Offset = "0xE12D00", VA = "0x10E13F00")]
    public JSON_AdventureNumParamFormatter()
    {
    }

    [Token(Token = "0x6002548")]
    [Address(RVA = "0xE13D60", Offset = "0xE12B60", VA = "0x10E13D60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureNumParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002549")]
    [Address(RVA = "0xE13A50", Offset = "0xE12850", VA = "0x10E13A50", Slot = "5")]
    public JSON_AdventureNumParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureNumParam) null;
    }
  }
}
