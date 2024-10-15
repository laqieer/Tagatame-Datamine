// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGNodeDetail_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B02")]
  public sealed class FlowNode_ReqGvGNodeDetail_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGNodeDetail.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A94")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A95")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A54")]
    [Address(RVA = "0xF1EEC0", Offset = "0xF1DCC0", VA = "0x10F1EEC0")]
    public FlowNode_ReqGvGNodeDetail_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A55")]
    [Address(RVA = "0xF1EBD0", Offset = "0xF1D9D0", VA = "0x10F1EBD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGNodeDetail.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A56")]
    [Address(RVA = "0xF1E7A0", Offset = "0xF1D5A0", VA = "0x10F1E7A0", Slot = "5")]
    public FlowNode_ReqGvGNodeDetail.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGNodeDetail.MP_Response) null;
    }
  }
}
