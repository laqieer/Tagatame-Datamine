// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqBondMission_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000948")]
  public sealed class FlowNode_ReqBondMission_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqBondMission.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001720")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001721")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002526")]
    [Address(RVA = "0xE0BB60", Offset = "0xE0A960", VA = "0x10E0BB60")]
    public FlowNode_ReqBondMission_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002527")]
    [Address(RVA = "0xE0B870", Offset = "0xE0A670", VA = "0x10E0B870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqBondMission.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002528")]
    [Address(RVA = "0xE0B440", Offset = "0xE0A240", VA = "0x10E0B440", Slot = "5")]
    public FlowNode_ReqBondMission.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqBondMission.MP_Response) null;
    }
  }
}
