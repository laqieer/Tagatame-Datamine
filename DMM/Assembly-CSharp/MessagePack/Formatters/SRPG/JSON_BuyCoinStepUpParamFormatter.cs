// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BuyCoinStepUpParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000644")]
  public sealed class JSON_BuyCoinStepUpParamFormatter : 
    IMessagePackFormatter<JSON_BuyCoinStepUpParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001120")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001121")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C1A")]
    [Address(RVA = "0xBCEBD0", Offset = "0xBCD9D0", VA = "0x10BCEBD0")]
    public JSON_BuyCoinStepUpParamFormatter()
    {
    }

    [Token(Token = "0x6001C1B")]
    [Address(RVA = "0xBCE8E0", Offset = "0xBCD6E0", VA = "0x10BCE8E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BuyCoinStepUpParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C1C")]
    [Address(RVA = "0xBCE4B0", Offset = "0xBCD2B0", VA = "0x10BCE4B0", Slot = "5")]
    public JSON_BuyCoinStepUpParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BuyCoinStepUpParam) null;
    }
  }
}
