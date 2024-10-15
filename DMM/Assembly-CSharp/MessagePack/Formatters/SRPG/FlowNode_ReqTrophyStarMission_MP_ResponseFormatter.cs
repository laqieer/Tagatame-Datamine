// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqTrophyStarMission_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000938")]
  public sealed class FlowNode_ReqTrophyStarMission_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqTrophyStarMission.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001700")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001701")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024F6")]
    [Address(RVA = "0xDFA580", Offset = "0xDF9380", VA = "0x10DFA580")]
    public FlowNode_ReqTrophyStarMission_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024F7")]
    [Address(RVA = "0xDFA290", Offset = "0xDF9090", VA = "0x10DFA290", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqTrophyStarMission.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024F8")]
    [Address(RVA = "0xDF9E60", Offset = "0xDF8C60", VA = "0x10DF9E60", Slot = "5")]
    public FlowNode_ReqTrophyStarMission.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqTrophyStarMission.MP_Response) null;
    }
  }
}
