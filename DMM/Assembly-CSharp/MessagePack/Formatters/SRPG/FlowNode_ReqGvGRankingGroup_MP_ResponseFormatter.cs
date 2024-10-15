// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGRankingGroup_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A32")]
  public sealed class FlowNode_ReqGvGRankingGroup_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGRankingGroup.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027E4")]
    [Address(RVA = "0xEAC8F0", Offset = "0xEAB6F0", VA = "0x10EAC8F0")]
    public FlowNode_ReqGvGRankingGroup_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027E5")]
    [Address(RVA = "0xEAC600", Offset = "0xEAB400", VA = "0x10EAC600", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGRankingGroup.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027E6")]
    [Address(RVA = "0xEAC1D0", Offset = "0xEAAFD0", VA = "0x10EAC1D0", Slot = "5")]
    public FlowNode_ReqGvGRankingGroup.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGRankingGroup.MP_Response) null;
    }
  }
}
