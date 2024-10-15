// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqArtifactStoneLottery_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D5")]
  public sealed class FlowNode_ReqArtifactStoneLottery_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqArtifactStoneLottery.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400183A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400183B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026CD")]
    [Address(RVA = "0xE67DA0", Offset = "0xE66BA0", VA = "0x10E67DA0")]
    public FlowNode_ReqArtifactStoneLottery_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026CE")]
    [Address(RVA = "0xE67AB0", Offset = "0xE668B0", VA = "0x10E67AB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqArtifactStoneLottery.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026CF")]
    [Address(RVA = "0xE67680", Offset = "0xE66480", VA = "0x10E67680", Slot = "5")]
    public FlowNode_ReqArtifactStoneLottery.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqArtifactStoneLottery.MP_Response) null;
    }
  }
}
