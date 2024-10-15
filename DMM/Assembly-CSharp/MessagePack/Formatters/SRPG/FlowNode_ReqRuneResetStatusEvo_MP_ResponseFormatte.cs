// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneResetStatusEvo_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF3")]
  public sealed class FlowNode_ReqRuneResetStatusEvo_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneResetStatusEvo.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A76")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A77")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A27")]
    [Address(RVA = "0xF20DB0", Offset = "0xF1FBB0", VA = "0x10F20DB0")]
    public FlowNode_ReqRuneResetStatusEvo_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A28")]
    [Address(RVA = "0xF20AC0", Offset = "0xF1F8C0", VA = "0x10F20AC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneResetStatusEvo.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A29")]
    [Address(RVA = "0xF20690", Offset = "0xF1F490", VA = "0x10F20690", Slot = "5")]
    public FlowNode_ReqRuneResetStatusEvo.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneResetStatusEvo.MP_Response) null;
    }
  }
}
