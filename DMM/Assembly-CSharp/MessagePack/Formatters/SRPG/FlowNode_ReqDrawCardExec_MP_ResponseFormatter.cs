// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqDrawCardExec_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA2")]
  public sealed class FlowNode_ReqDrawCardExec_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqDrawCardExec.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002934")]
    [Address(RVA = "0xEECA20", Offset = "0xEEB820", VA = "0x10EECA20")]
    public FlowNode_ReqDrawCardExec_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002935")]
    [Address(RVA = "0xEEC730", Offset = "0xEEB530", VA = "0x10EEC730", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqDrawCardExec.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002936")]
    [Address(RVA = "0xEEC300", Offset = "0xEEB100", VA = "0x10EEC300", Slot = "5")]
    public FlowNode_ReqDrawCardExec.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqDrawCardExec.MP_Response) null;
    }
  }
}
