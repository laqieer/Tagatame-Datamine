// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqDuelRankingReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200090C")]
  public sealed class FlowNode_ReqDuelRankingReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqDuelRankingReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002472")]
    [Address(RVA = "0xDDE360", Offset = "0xDDD160", VA = "0x10DDE360")]
    public FlowNode_ReqDuelRankingReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002473")]
    [Address(RVA = "0xDDE070", Offset = "0xDDCE70", VA = "0x10DDE070", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqDuelRankingReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002474")]
    [Address(RVA = "0xDDDC40", Offset = "0xDDCA40", VA = "0x10DDDC40", Slot = "5")]
    public FlowNode_ReqDuelRankingReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqDuelRankingReward.MP_Response) null;
    }
  }
}
