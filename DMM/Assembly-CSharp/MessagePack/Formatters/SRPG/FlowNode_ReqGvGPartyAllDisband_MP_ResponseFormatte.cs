// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGPartyAllDisband_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D2")]
  public sealed class FlowNode_ReqGvGPartyAllDisband_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGPartyAllDisband.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001634")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001635")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023C4")]
    [Address(RVA = "0xDC8940", Offset = "0xDC7740", VA = "0x10DC8940")]
    public FlowNode_ReqGvGPartyAllDisband_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023C5")]
    [Address(RVA = "0xDC8650", Offset = "0xDC7450", VA = "0x10DC8650", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGPartyAllDisband.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023C6")]
    [Address(RVA = "0xDC8220", Offset = "0xDC7020", VA = "0x10DC8220", Slot = "5")]
    public FlowNode_ReqGvGPartyAllDisband.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGPartyAllDisband.MP_Response) null;
    }
  }
}
