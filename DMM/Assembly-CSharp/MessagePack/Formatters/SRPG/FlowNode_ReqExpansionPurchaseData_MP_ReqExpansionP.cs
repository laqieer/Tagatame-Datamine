// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqExpansionPurchaseData_MP_ReqExpansionPurchaseResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009CB")]
  public sealed class FlowNode_ReqExpansionPurchaseData_MP_ReqExpansionPurchaseResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqExpansionPurchaseData.MP_ReqExpansionPurchaseResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001826")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001827")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026AF")]
    [Address(RVA = "0xE687F0", Offset = "0xE675F0", VA = "0x10E687F0")]
    public FlowNode_ReqExpansionPurchaseData_MP_ReqExpansionPurchaseResponseFormatter()
    {
    }

    [Token(Token = "0x60026B0")]
    [Address(RVA = "0xE68500", Offset = "0xE67300", VA = "0x10E68500", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqExpansionPurchaseData.MP_ReqExpansionPurchaseResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026B1")]
    [Address(RVA = "0xE680D0", Offset = "0xE66ED0", VA = "0x10E680D0", Slot = "5")]
    public FlowNode_ReqExpansionPurchaseData.MP_ReqExpansionPurchaseResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqExpansionPurchaseData.MP_ReqExpansionPurchaseResponse) null;
    }
  }
}
