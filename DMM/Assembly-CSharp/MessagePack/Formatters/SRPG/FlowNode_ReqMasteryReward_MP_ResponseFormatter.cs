// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqMasteryReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000921")]
  public sealed class FlowNode_ReqMasteryReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqMasteryReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024B1")]
    [Address(RVA = "0xDF7C40", Offset = "0xDF6A40", VA = "0x10DF7C40")]
    public FlowNode_ReqMasteryReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024B2")]
    [Address(RVA = "0xDF7950", Offset = "0xDF6750", VA = "0x10DF7950", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqMasteryReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024B3")]
    [Address(RVA = "0xDF7520", Offset = "0xDF6320", VA = "0x10DF7520", Slot = "5")]
    public FlowNode_ReqMasteryReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqMasteryReward.MP_Response) null;
    }
  }
}
