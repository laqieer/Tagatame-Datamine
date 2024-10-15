// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LoginInfoParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F9")]
  public sealed class JSON_LoginInfoParamFormatter : 
    IMessagePackFormatter<JSON_LoginInfoParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400108A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400108B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B39")]
    [Address(RVA = "0xBA7E40", Offset = "0xBA6C40", VA = "0x10BA7E40")]
    public JSON_LoginInfoParamFormatter()
    {
    }

    [Token(Token = "0x6001B3A")]
    [Address(RVA = "0xBA7A40", Offset = "0xBA6840", VA = "0x10BA7A40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LoginInfoParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B3B")]
    [Address(RVA = "0xBA7470", Offset = "0xBA6270", VA = "0x10BA7470", Slot = "5")]
    public JSON_LoginInfoParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LoginInfoParam) null;
    }
  }
}
