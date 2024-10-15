// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqBondMissionReceive_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E8")]
  public sealed class FlowNode_ReqBondMissionReceive_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqBondMissionReceive.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001860")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001861")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002706")]
    [Address(RVA = "0xE7D000", Offset = "0xE7BE00", VA = "0x10E7D000")]
    public FlowNode_ReqBondMissionReceive_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002707")]
    [Address(RVA = "0xE7CD10", Offset = "0xE7BB10", VA = "0x10E7CD10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqBondMissionReceive.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002708")]
    [Address(RVA = "0xE7C8E0", Offset = "0xE7B6E0", VA = "0x10E7C8E0", Slot = "5")]
    public FlowNode_ReqBondMissionReceive.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqBondMissionReceive.MP_Response) null;
    }
  }
}
