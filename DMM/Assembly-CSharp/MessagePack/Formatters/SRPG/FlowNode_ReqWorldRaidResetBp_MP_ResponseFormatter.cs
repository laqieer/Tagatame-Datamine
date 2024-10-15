// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqWorldRaidResetBp_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E4")]
  public sealed class FlowNode_ReqWorldRaidResetBp_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqWorldRaidResetBp.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001458")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001459")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020FA")]
    [Address(RVA = "0xD2B180", Offset = "0xD29F80", VA = "0x10D2B180")]
    public FlowNode_ReqWorldRaidResetBp_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60020FB")]
    [Address(RVA = "0xD2AE90", Offset = "0xD29C90", VA = "0x10D2AE90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqWorldRaidResetBp.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020FC")]
    [Address(RVA = "0xD2AA60", Offset = "0xD29860", VA = "0x10D2AA60", Slot = "5")]
    public FlowNode_ReqWorldRaidResetBp.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqWorldRaidResetBp.MP_Response) null;
    }
  }
}
