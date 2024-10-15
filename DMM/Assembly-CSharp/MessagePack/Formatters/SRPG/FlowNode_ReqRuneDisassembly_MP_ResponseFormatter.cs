// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneDisassembly_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA3")]
  public sealed class FlowNode_ReqRuneDisassembly_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneDisassembly.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002937")]
    [Address(RVA = "0xEEF360", Offset = "0xEEE160", VA = "0x10EEF360")]
    public FlowNode_ReqRuneDisassembly_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002938")]
    [Address(RVA = "0xEEF070", Offset = "0xEEDE70", VA = "0x10EEF070", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneDisassembly.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002939")]
    [Address(RVA = "0xEEEC40", Offset = "0xEEDA40", VA = "0x10EEEC40", Slot = "5")]
    public FlowNode_ReqRuneDisassembly.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneDisassembly.MP_Response) null;
    }
  }
}
