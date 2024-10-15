// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqHotDealConfirm_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F1")]
  public sealed class FlowNode_ReqHotDealConfirm_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqHotDealConfirm.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001672")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001673")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002421")]
    [Address(RVA = "0xDDF800", Offset = "0xDDE600", VA = "0x10DDF800")]
    public FlowNode_ReqHotDealConfirm_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002422")]
    [Address(RVA = "0xDDF510", Offset = "0xDDE310", VA = "0x10DDF510", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqHotDealConfirm.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002423")]
    [Address(RVA = "0xDDF0E0", Offset = "0xDDDEE0", VA = "0x10DDF0E0", Slot = "5")]
    public FlowNode_ReqHotDealConfirm.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqHotDealConfirm.MP_Response) null;
    }
  }
}
