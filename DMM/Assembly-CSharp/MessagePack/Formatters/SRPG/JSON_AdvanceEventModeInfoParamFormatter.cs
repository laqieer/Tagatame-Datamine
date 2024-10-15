// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdvanceEventModeInfoParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000932")]
  public sealed class JSON_AdvanceEventModeInfoParamFormatter : 
    IMessagePackFormatter<JSON_AdvanceEventModeInfoParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024E4")]
    [Address(RVA = "0xDFB0F0", Offset = "0xDF9EF0", VA = "0x10DFB0F0")]
    public JSON_AdvanceEventModeInfoParamFormatter()
    {
    }

    [Token(Token = "0x60024E5")]
    [Address(RVA = "0xDFADB0", Offset = "0xDF9BB0", VA = "0x10DFADB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdvanceEventModeInfoParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024E6")]
    [Address(RVA = "0xDFA8B0", Offset = "0xDF96B0", VA = "0x10DFA8B0", Slot = "5")]
    public JSON_AdvanceEventModeInfoParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdvanceEventModeInfoParam) null;
    }
  }
}
