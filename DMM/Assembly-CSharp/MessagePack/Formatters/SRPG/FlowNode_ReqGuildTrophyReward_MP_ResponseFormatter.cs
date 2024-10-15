// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildTrophyReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C0")]
  public sealed class FlowNode_ReqGuildTrophyReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildTrophyReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001810")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001811")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600268E")]
    [Address(RVA = "0xE69240", Offset = "0xE68040", VA = "0x10E69240")]
    public FlowNode_ReqGuildTrophyReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600268F")]
    [Address(RVA = "0xE68F50", Offset = "0xE67D50", VA = "0x10E68F50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildTrophyReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002690")]
    [Address(RVA = "0xE68B20", Offset = "0xE67920", VA = "0x10E68B20", Slot = "5")]
    public FlowNode_ReqGuildTrophyReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildTrophyReward.MP_Response) null;
    }
  }
}
