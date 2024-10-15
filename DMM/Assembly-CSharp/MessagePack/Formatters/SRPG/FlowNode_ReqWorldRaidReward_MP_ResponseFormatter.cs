// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqWorldRaidReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A11")]
  public sealed class FlowNode_ReqWorldRaidReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqWorldRaidReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002781")]
    [Address(RVA = "0xE9DA00", Offset = "0xE9C800", VA = "0x10E9DA00")]
    public FlowNode_ReqWorldRaidReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002782")]
    [Address(RVA = "0xE9D710", Offset = "0xE9C510", VA = "0x10E9D710", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqWorldRaidReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002783")]
    [Address(RVA = "0xE9D2E0", Offset = "0xE9C0E0", VA = "0x10E9D2E0", Slot = "5")]
    public FlowNode_ReqWorldRaidReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqWorldRaidReward.MP_Response) null;
    }
  }
}
