// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinStepUpParam_JSON_BuyCoinStepUpProductListParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000643")]
  public sealed class JSON_BuyCoinStepUpParam_JSON_BuyCoinStepUpProductListParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinStepUpParam.JSON_BuyCoinStepUpProductListParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400111E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400111F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C17")]
    [Address(RVA = "0xBCF710", Offset = "0xBCE510", VA = "0x10BCF710")]
    public JSON_BuyCoinStepUpParam_JSON_BuyCoinStepUpProductListParamFormatter()
    {
    }

    [Token(Token = "0x6001C18")]
    [Address(RVA = "0xBCF3E0", Offset = "0xBCE1E0", VA = "0x10BCF3E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinStepUpParam.JSON_BuyCoinStepUpProductListParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C19")]
    [Address(RVA = "0xBCEF00", Offset = "0xBCDD00", VA = "0x10BCEF00", Slot = "5")]
    public JSON_BuyCoinStepUpParam.JSON_BuyCoinStepUpProductListParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinStepUpParam.JSON_BuyCoinStepUpProductListParam) null;
    }
  }
}
