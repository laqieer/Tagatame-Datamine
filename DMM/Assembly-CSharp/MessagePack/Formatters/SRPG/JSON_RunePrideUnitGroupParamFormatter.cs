// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideUnitGroupParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006EF")]
  public sealed class JSON_RunePrideUnitGroupParamFormatter : 
    IMessagePackFormatter<JSON_RunePrideUnitGroupParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001276")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001277")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E1B")]
    [Address(RVA = "0xC362C0", Offset = "0xC350C0", VA = "0x10C362C0")]
    public JSON_RunePrideUnitGroupParamFormatter()
    {
    }

    [Token(Token = "0x6001E1C")]
    [Address(RVA = "0xC36160", Offset = "0xC34F60", VA = "0x10C36160", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideUnitGroupParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E1D")]
    [Address(RVA = "0xC35E20", Offset = "0xC34C20", VA = "0x10C35E20", Slot = "5")]
    public JSON_RunePrideUnitGroupParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideUnitGroupParam) null;
    }
  }
}
