// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000653")]
  public sealed class JSON_GenesisParamFormatter : 
    IMessagePackFormatter<JSON_GenesisParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400113E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400113F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C47")]
    [Address(RVA = "0xBD4000", Offset = "0xBD2E00", VA = "0x10BD4000")]
    public JSON_GenesisParamFormatter()
    {
    }

    [Token(Token = "0x6001C48")]
    [Address(RVA = "0xBD3E20", Offset = "0xBD2C20", VA = "0x10BD3E20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C49")]
    [Address(RVA = "0xBD3A70", Offset = "0xBD2870", VA = "0x10BD3A70", Slot = "5")]
    public JSON_GenesisParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisParam) null;
    }
  }
}
