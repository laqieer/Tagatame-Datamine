// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalSaleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D4")]
  public sealed class JSON_CrystalSaleParamFormatter : 
    IMessagePackFormatter<JSON_CrystalSaleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001240")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001241")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DCA")]
    [Address(RVA = "0xC115A0", Offset = "0xC103A0", VA = "0x10C115A0")]
    public JSON_CrystalSaleParamFormatter()
    {
    }

    [Token(Token = "0x6001DCB")]
    [Address(RVA = "0xC113C0", Offset = "0xC101C0", VA = "0x10C113C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalSaleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DCC")]
    [Address(RVA = "0xC11080", Offset = "0xC0FE80", VA = "0x10C11080", Slot = "5")]
    public JSON_CrystalSaleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalSaleParam) null;
    }
  }
}
