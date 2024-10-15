// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraCondsUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200060D")]
  public sealed class JSON_TobiraCondsUnitParamFormatter : 
    IMessagePackFormatter<JSON_TobiraCondsUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B75")]
    [Address(RVA = "0xBAB4B0", Offset = "0xBAA2B0", VA = "0x10BAB4B0")]
    public JSON_TobiraCondsUnitParamFormatter()
    {
    }

    [Token(Token = "0x6001B76")]
    [Address(RVA = "0xBAB190", Offset = "0xBA9F90", VA = "0x10BAB190", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraCondsUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B77")]
    [Address(RVA = "0xBAAD20", Offset = "0xBA9B20", VA = "0x10BAAD20", Slot = "5")]
    public JSON_TobiraCondsUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraCondsUnitParam) null;
    }
  }
}
