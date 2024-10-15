// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRunePrideUsedItems_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000915")]
  public sealed class FlowNode_ReqRunePrideUsedItems_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRunePrideUsedItems.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600248D")]
    [Address(RVA = "0xDF9B30", Offset = "0xDF8930", VA = "0x10DF9B30")]
    public FlowNode_ReqRunePrideUsedItems_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600248E")]
    [Address(RVA = "0xDF9840", Offset = "0xDF8640", VA = "0x10DF9840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRunePrideUsedItems.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600248F")]
    [Address(RVA = "0xDF9410", Offset = "0xDF8210", VA = "0x10DF9410", Slot = "5")]
    public FlowNode_ReqRunePrideUsedItems.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRunePrideUsedItems.MP_Response) null;
    }
  }
}
