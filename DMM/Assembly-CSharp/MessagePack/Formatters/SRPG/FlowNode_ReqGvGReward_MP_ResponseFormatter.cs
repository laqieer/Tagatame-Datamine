// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009EE")]
  public sealed class FlowNode_ReqGvGReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400186C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400186D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002718")]
    [Address(RVA = "0xE7EEF0", Offset = "0xE7DCF0", VA = "0x10E7EEF0")]
    public FlowNode_ReqGvGReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002719")]
    [Address(RVA = "0xE7EC00", Offset = "0xE7DA00", VA = "0x10E7EC00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600271A")]
    [Address(RVA = "0xE7E7D0", Offset = "0xE7D5D0", VA = "0x10E7E7D0", Slot = "5")]
    public FlowNode_ReqGvGReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGReward.MP_Response) null;
    }
  }
}
