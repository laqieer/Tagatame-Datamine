// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdvanceEventParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000933")]
  public sealed class JSON_AdvanceEventParamFormatter : 
    IMessagePackFormatter<JSON_AdvanceEventParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024E7")]
    [Address(RVA = "0xDFC000", Offset = "0xDFAE00", VA = "0x10DFC000")]
    public JSON_AdvanceEventParamFormatter()
    {
    }

    [Token(Token = "0x60024E8")]
    [Address(RVA = "0xDFBB50", Offset = "0xDFA950", VA = "0x10DFBB50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdvanceEventParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024E9")]
    [Address(RVA = "0xDFB570", Offset = "0xDFA370", VA = "0x10DFB570", Slot = "5")]
    public JSON_AdvanceEventParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdvanceEventParam) null;
    }
  }
}
