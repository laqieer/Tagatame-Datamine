// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalGet_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A54")]
  public sealed class FlowNode_ReqCrystalGet_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalGet.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001938")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001939")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600284A")]
    [Address(RVA = "0xEC04D0", Offset = "0xEBF2D0", VA = "0x10EC04D0")]
    public FlowNode_ReqCrystalGet_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600284B")]
    [Address(RVA = "0xEC01E0", Offset = "0xEBEFE0", VA = "0x10EC01E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalGet.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600284C")]
    [Address(RVA = "0xEBFDB0", Offset = "0xEBEBB0", VA = "0x10EBFDB0", Slot = "5")]
    public FlowNode_ReqCrystalGet.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalGet.MP_Response) null;
    }
  }
}
