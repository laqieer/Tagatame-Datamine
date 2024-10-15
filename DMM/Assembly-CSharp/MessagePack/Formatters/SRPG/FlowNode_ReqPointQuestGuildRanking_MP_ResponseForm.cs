// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPointQuestGuildRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ACD")]
  public sealed class FlowNode_ReqPointQuestGuildRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPointQuestGuildRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A2A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A2B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029B5")]
    [Address(RVA = "0xF0AC80", Offset = "0xF09A80", VA = "0x10F0AC80")]
    public FlowNode_ReqPointQuestGuildRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029B6")]
    [Address(RVA = "0xF0A990", Offset = "0xF09790", VA = "0x10F0A990", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPointQuestGuildRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029B7")]
    [Address(RVA = "0xF0A560", Offset = "0xF09360", VA = "0x10F0A560", Slot = "5")]
    public FlowNode_ReqPointQuestGuildRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPointQuestGuildRanking.MP_Response) null;
    }
  }
}
