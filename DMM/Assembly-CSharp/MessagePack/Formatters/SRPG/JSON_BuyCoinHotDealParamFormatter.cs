// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinHotDealParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000642")]
  public sealed class JSON_BuyCoinHotDealParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinHotDealParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400111C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400111D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C14")]
    [Address(RVA = "0xBCA550", Offset = "0xBC9350", VA = "0x10BCA550")]
    public JSON_BuyCoinHotDealParamFormatter()
    {
    }

    [Token(Token = "0x6001C15")]
    [Address(RVA = "0xBCA140", Offset = "0xBC8F40", VA = "0x10BCA140", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinHotDealParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C16")]
    [Address(RVA = "0xBC9BE0", Offset = "0xBC89E0", VA = "0x10BC9BE0", Slot = "5")]
    public JSON_BuyCoinHotDealParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinHotDealParam) null;
    }
  }
}
