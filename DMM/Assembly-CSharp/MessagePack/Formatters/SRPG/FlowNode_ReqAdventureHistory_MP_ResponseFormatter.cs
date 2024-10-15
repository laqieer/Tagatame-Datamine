// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAdventureHistory_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000973")]
  public sealed class FlowNode_ReqAdventureHistory_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAdventureHistory.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001776")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001777")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025A7")]
    [Address(RVA = "0xE26600", Offset = "0xE25400", VA = "0x10E26600")]
    public FlowNode_ReqAdventureHistory_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025A8")]
    [Address(RVA = "0xE26310", Offset = "0xE25110", VA = "0x10E26310", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAdventureHistory.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025A9")]
    [Address(RVA = "0xE25EE0", Offset = "0xE24CE0", VA = "0x10E25EE0", Slot = "5")]
    public FlowNode_ReqAdventureHistory.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAdventureHistory.MP_Response) null;
    }
  }
}
