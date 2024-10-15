// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGachaPickup_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A36")]
  public sealed class FlowNode_ReqGachaPickup_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGachaPickup.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027F0")]
    [Address(RVA = "0xEA9FB0", Offset = "0xEA8DB0", VA = "0x10EA9FB0")]
    public FlowNode_ReqGachaPickup_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027F1")]
    [Address(RVA = "0xEA9CB0", Offset = "0xEA8AB0", VA = "0x10EA9CB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGachaPickup.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027F2")]
    [Address(RVA = "0xEA9880", Offset = "0xEA8680", VA = "0x10EA9880", Slot = "5")]
    public FlowNode_ReqGachaPickup.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGachaPickup.MP_Response) null;
    }
  }
}
