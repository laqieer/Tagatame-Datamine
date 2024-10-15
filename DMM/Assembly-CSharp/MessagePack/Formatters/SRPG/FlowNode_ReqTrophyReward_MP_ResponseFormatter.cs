// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqTrophyReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AE5")]
  public sealed class FlowNode_ReqTrophyReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqTrophyReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A5A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A5B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029FD")]
    [Address(RVA = "0xF21800", Offset = "0xF20600", VA = "0x10F21800")]
    public FlowNode_ReqTrophyReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029FE")]
    [Address(RVA = "0xF21510", Offset = "0xF20310", VA = "0x10F21510", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqTrophyReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029FF")]
    [Address(RVA = "0xF210E0", Offset = "0xF1FEE0", VA = "0x10F210E0", Slot = "5")]
    public FlowNode_ReqTrophyReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqTrophyReward.MP_Response) null;
    }
  }
}
