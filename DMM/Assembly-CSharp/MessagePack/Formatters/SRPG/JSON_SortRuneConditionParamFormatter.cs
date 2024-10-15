// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SortRuneConditionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000674")]
  public sealed class JSON_SortRuneConditionParamFormatter : 
    IMessagePackFormatter<JSON_SortRuneConditionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001180")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001181")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CAA")]
    [Address(RVA = "0xBEE3E0", Offset = "0xBED1E0", VA = "0x10BEE3E0")]
    public JSON_SortRuneConditionParamFormatter()
    {
    }

    [Token(Token = "0x6001CAB")]
    [Address(RVA = "0xBEE250", Offset = "0xBED050", VA = "0x10BEE250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SortRuneConditionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CAC")]
    [Address(RVA = "0xBEDEE0", Offset = "0xBECCE0", VA = "0x10BEDEE0", Slot = "5")]
    public JSON_SortRuneConditionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SortRuneConditionParam) null;
    }
  }
}
