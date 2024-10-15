// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGCalcRateSettingParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A83")]
  public sealed class JSON_GvGCalcRateSettingParamFormatter : 
    IMessagePackFormatter<JSON_GvGCalcRateSettingParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001996")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001997")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028D7")]
    [Address(RVA = "0xEDD0E0", Offset = "0xEDBEE0", VA = "0x10EDD0E0")]
    public JSON_GvGCalcRateSettingParamFormatter()
    {
    }

    [Token(Token = "0x60028D8")]
    [Address(RVA = "0xEDCF80", Offset = "0xEDBD80", VA = "0x10EDCF80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGCalcRateSettingParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028D9")]
    [Address(RVA = "0xEDCC30", Offset = "0xEDBA30", VA = "0x10EDCC30", Slot = "5")]
    public JSON_GvGCalcRateSettingParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGCalcRateSettingParam) null;
    }
  }
}
