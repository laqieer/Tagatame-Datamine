// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvG_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007F6")]
  public sealed class FlowNode_ReqGvG_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvG.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400147C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400147D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002130")]
    [Address(RVA = "0xD2A730", Offset = "0xD29530", VA = "0x10D2A730")]
    public FlowNode_ReqGvG_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002131")]
    [Address(RVA = "0xD2A440", Offset = "0xD29240", VA = "0x10D2A440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvG.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002132")]
    [Address(RVA = "0xD2A010", Offset = "0xD28E10", VA = "0x10D2A010", Slot = "5")]
    public FlowNode_ReqGvG.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvG.MP_Response) null;
    }
  }
}
