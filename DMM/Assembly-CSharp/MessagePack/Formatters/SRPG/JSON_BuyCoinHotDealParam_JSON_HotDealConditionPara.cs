// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinHotDealParam_JSON_HotDealConditionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000641")]
  public sealed class JSON_BuyCoinHotDealParam_JSON_HotDealConditionParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinHotDealParam.JSON_HotDealConditionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400111A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400111B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C11")]
    [Address(RVA = "0xBCAE70", Offset = "0xBC9C70", VA = "0x10BCAE70")]
    public JSON_BuyCoinHotDealParam_JSON_HotDealConditionParamFormatter()
    {
    }

    [Token(Token = "0x6001C12")]
    [Address(RVA = "0xBCAD40", Offset = "0xBC9B40", VA = "0x10BCAD40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinHotDealParam.JSON_HotDealConditionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C13")]
    [Address(RVA = "0xBCAA30", Offset = "0xBC9830", VA = "0x10BCAA30", Slot = "5")]
    public JSON_BuyCoinHotDealParam.JSON_HotDealConditionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinHotDealParam.JSON_HotDealConditionParam) null;
    }
  }
}
