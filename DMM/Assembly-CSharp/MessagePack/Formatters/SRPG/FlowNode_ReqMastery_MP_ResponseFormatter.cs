// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqMastery_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AAD")]
  public sealed class FlowNode_ReqMastery_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqMastery.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002955")]
    [Address(RVA = "0xF0A230", Offset = "0xF09030", VA = "0x10F0A230")]
    public FlowNode_ReqMastery_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002956")]
    [Address(RVA = "0xF09F40", Offset = "0xF08D40", VA = "0x10F09F40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqMastery.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002957")]
    [Address(RVA = "0xF09B10", Offset = "0xF08910", VA = "0x10F09B10", Slot = "5")]
    public FlowNode_ReqMastery.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqMastery.MP_Response) null;
    }
  }
}
