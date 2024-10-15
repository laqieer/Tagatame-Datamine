// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitGroupParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000618")]
  public sealed class JSON_UnitGroupParamFormatter : 
    IMessagePackFormatter<JSON_UnitGroupParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B96")]
    [Address(RVA = "0xBC99F0", Offset = "0xBC87F0", VA = "0x10BC99F0")]
    public JSON_UnitGroupParamFormatter()
    {
    }

    [Token(Token = "0x6001B97")]
    [Address(RVA = "0xBC9830", Offset = "0xBC8630", VA = "0x10BC9830", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitGroupParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B98")]
    [Address(RVA = "0xBC9490", Offset = "0xBC8290", VA = "0x10BC9490", Slot = "5")]
    public JSON_UnitGroupParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitGroupParam) null;
    }
  }
}
