// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqArtifactStoneConfirm_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A9C")]
  public sealed class FlowNode_ReqArtifactStoneConfirm_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqArtifactStoneConfirm.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002922")]
    [Address(RVA = "0xEEBFD0", Offset = "0xEEADD0", VA = "0x10EEBFD0")]
    public FlowNode_ReqArtifactStoneConfirm_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002923")]
    [Address(RVA = "0xEEBCE0", Offset = "0xEEAAE0", VA = "0x10EEBCE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqArtifactStoneConfirm.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002924")]
    [Address(RVA = "0xEEB8B0", Offset = "0xEEA6B0", VA = "0x10EEB8B0", Slot = "5")]
    public FlowNode_ReqArtifactStoneConfirm.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqArtifactStoneConfirm.MP_Response) null;
    }
  }
}
