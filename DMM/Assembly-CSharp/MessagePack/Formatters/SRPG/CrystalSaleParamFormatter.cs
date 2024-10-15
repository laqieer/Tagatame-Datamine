// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalSaleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A9E")]
  public sealed class CrystalSaleParamFormatter : 
    IMessagePackFormatter<CrystalSaleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002928")]
    [Address(RVA = "0xEEA610", Offset = "0xEE9410", VA = "0x10EEA610")]
    public CrystalSaleParamFormatter()
    {
    }

    [Token(Token = "0x6002929")]
    [Address(RVA = "0xEEA430", Offset = "0xEE9230", VA = "0x10EEA430", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalSaleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600292A")]
    [Address(RVA = "0xEEA120", Offset = "0xEE8F20", VA = "0x10EEA120", Slot = "5")]
    public CrystalSaleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalSaleParam) null;
    }
  }
}
