// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidTrainingBtlLogDetail_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000875")]
  public sealed class FlowNode_ReqGuildRaidTrainingBtlLogDetail_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidTrainingBtlLogDetail.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400157A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400157B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022AD")]
    [Address(RVA = "0xD9A8B0", Offset = "0xD996B0", VA = "0x10D9A8B0")]
    public FlowNode_ReqGuildRaidTrainingBtlLogDetail_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022AE")]
    [Address(RVA = "0xD9A5C0", Offset = "0xD993C0", VA = "0x10D9A5C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidTrainingBtlLogDetail.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022AF")]
    [Address(RVA = "0xD9A190", Offset = "0xD98F90", VA = "0x10D9A190", Slot = "5")]
    public FlowNode_ReqGuildRaidTrainingBtlLogDetail.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidTrainingBtlLogDetail.MP_Response) null;
    }
  }
}
