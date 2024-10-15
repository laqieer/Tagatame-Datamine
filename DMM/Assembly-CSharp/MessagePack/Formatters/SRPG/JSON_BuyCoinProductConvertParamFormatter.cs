// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinProductConvertParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000640")]
  public sealed class JSON_BuyCoinProductConvertParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinProductConvertParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001118")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001119")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C0E")]
    [Address(RVA = "0xBCB470", Offset = "0xBCA270", VA = "0x10BCB470")]
    public JSON_BuyCoinProductConvertParamFormatter()
    {
    }

    [Token(Token = "0x6001C0F")]
    [Address(RVA = "0xBCB320", Offset = "0xBCA120", VA = "0x10BCB320", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinProductConvertParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C10")]
    [Address(RVA = "0xBCAFF0", Offset = "0xBC9DF0", VA = "0x10BCAFF0", Slot = "5")]
    public JSON_BuyCoinProductConvertParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinProductConvertParam) null;
    }
  }
}
