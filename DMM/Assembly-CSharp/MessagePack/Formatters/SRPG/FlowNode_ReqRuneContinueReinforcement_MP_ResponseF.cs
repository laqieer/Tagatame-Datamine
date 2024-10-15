// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneContinueReinforcement_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B0A")]
  public sealed class FlowNode_ReqRuneContinueReinforcement_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneContinueReinforcement.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AA4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AA5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A6C")]
    [Address(RVA = "0xF39990", Offset = "0xF38790", VA = "0x10F39990")]
    public FlowNode_ReqRuneContinueReinforcement_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A6D")]
    [Address(RVA = "0xF396A0", Offset = "0xF384A0", VA = "0x10F396A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneContinueReinforcement.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A6E")]
    [Address(RVA = "0xF39270", Offset = "0xF38070", VA = "0x10F39270", Slot = "5")]
    public FlowNode_ReqRuneContinueReinforcement.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneContinueReinforcement.MP_Response) null;
    }
  }
}
