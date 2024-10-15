// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneResetParamBase_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B22")]
  public sealed class FlowNode_ReqRuneResetParamBase_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneResetParamBase.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AD4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AD5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AB4")]
    [Address(RVA = "0xF3AE30", Offset = "0xF39C30", VA = "0x10F3AE30")]
    public FlowNode_ReqRuneResetParamBase_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AB5")]
    [Address(RVA = "0xF3AB40", Offset = "0xF39940", VA = "0x10F3AB40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneResetParamBase.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AB6")]
    [Address(RVA = "0xF3A710", Offset = "0xF39510", VA = "0x10F3A710", Slot = "5")]
    public FlowNode_ReqRuneResetParamBase.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneResetParamBase.MP_Response) null;
    }
  }
}
