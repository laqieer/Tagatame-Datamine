// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGNodeDefenseEntry_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B36")]
  public sealed class FlowNode_ReqGvGNodeDefenseEntry_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGNodeDefenseEntry.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AFC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AFD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AF0")]
    [Address(RVA = "0xF60C10", Offset = "0xF5FA10", VA = "0x10F60C10")]
    public FlowNode_ReqGvGNodeDefenseEntry_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AF1")]
    [Address(RVA = "0xF60920", Offset = "0xF5F720", VA = "0x10F60920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGNodeDefenseEntry.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AF2")]
    [Address(RVA = "0xF604F0", Offset = "0xF5F2F0", VA = "0x10F604F0", Slot = "5")]
    public FlowNode_ReqGvGNodeDefenseEntry.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGNodeDefenseEntry.MP_Response) null;
    }
  }
}
