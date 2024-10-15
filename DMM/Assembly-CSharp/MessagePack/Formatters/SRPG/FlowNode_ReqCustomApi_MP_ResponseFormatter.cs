// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCustomApi_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF5")]
  public sealed class FlowNode_ReqCustomApi_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCustomApi.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A7A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A7B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A2D")]
    [Address(RVA = "0xF1BB30", Offset = "0xF1A930", VA = "0x10F1BB30")]
    public FlowNode_ReqCustomApi_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A2E")]
    [Address(RVA = "0xF1B840", Offset = "0xF1A640", VA = "0x10F1B840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCustomApi.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A2F")]
    [Address(RVA = "0xF1B410", Offset = "0xF1A210", VA = "0x10F1B410", Slot = "5")]
    public FlowNode_ReqCustomApi.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCustomApi.MP_Response) null;
    }
  }
}
