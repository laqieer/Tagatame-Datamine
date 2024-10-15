// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPointQuestGuildPersonRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000955")]
  public sealed class FlowNode_ReqPointQuestGuildPersonRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPointQuestGuildPersonRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400173A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400173B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600254D")]
    [Address(RVA = "0xE10DE0", Offset = "0xE0FBE0", VA = "0x10E10DE0")]
    public FlowNode_ReqPointQuestGuildPersonRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600254E")]
    [Address(RVA = "0xE10AF0", Offset = "0xE0F8F0", VA = "0x10E10AF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPointQuestGuildPersonRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600254F")]
    [Address(RVA = "0xE106C0", Offset = "0xE0F4C0", VA = "0x10E106C0", Slot = "5")]
    public FlowNode_ReqPointQuestGuildPersonRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPointQuestGuildPersonRanking.MP_Response) null;
    }
  }
}
