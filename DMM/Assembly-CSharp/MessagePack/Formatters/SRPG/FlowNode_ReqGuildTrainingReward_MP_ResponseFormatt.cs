// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildTrainingReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AAE")]
  public sealed class FlowNode_ReqGuildTrainingReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildTrainingReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002958")]
    [Address(RVA = "0xF08340", Offset = "0xF07140", VA = "0x10F08340")]
    public FlowNode_ReqGuildTrainingReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002959")]
    [Address(RVA = "0xF08050", Offset = "0xF06E50", VA = "0x10F08050", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildTrainingReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600295A")]
    [Address(RVA = "0xF07C20", Offset = "0xF06A20", VA = "0x10F07C20", Slot = "5")]
    public FlowNode_ReqGuildTrainingReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildTrainingReward.MP_Response) null;
    }
  }
}
