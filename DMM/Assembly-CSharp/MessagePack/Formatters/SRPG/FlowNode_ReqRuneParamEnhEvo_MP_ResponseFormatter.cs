// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneParamEnhEvo_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008EA")]
  public sealed class FlowNode_ReqRuneParamEnhEvo_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneParamEnhEvo.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001664")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001665")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600240C")]
    [Address(RVA = "0xDC9DE0", Offset = "0xDC8BE0", VA = "0x10DC9DE0")]
    public FlowNode_ReqRuneParamEnhEvo_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600240D")]
    [Address(RVA = "0xDC9AF0", Offset = "0xDC88F0", VA = "0x10DC9AF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneParamEnhEvo.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600240E")]
    [Address(RVA = "0xDC96C0", Offset = "0xDC84C0", VA = "0x10DC96C0", Slot = "5")]
    public FlowNode_ReqRuneParamEnhEvo.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneParamEnhEvo.MP_Response) null;
    }
  }
}
