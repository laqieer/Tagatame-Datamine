// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinShopParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200063C")]
  public sealed class JSON_BuyCoinShopParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinShopParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001110")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001111")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C02")]
    [Address(RVA = "0xBCE180", Offset = "0xBCCF80", VA = "0x10BCE180")]
    public JSON_BuyCoinShopParamFormatter()
    {
    }

    [Token(Token = "0x6001C03")]
    [Address(RVA = "0xBCDEE0", Offset = "0xBCCCE0", VA = "0x10BCDEE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinShopParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C04")]
    [Address(RVA = "0xBCDA80", Offset = "0xBCC880", VA = "0x10BCDA80", Slot = "5")]
    public JSON_BuyCoinShopParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinShopParam) null;
    }
  }
}
