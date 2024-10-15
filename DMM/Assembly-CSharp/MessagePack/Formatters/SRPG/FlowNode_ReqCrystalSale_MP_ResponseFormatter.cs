// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalSale_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E7")]
  public sealed class FlowNode_ReqCrystalSale_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalSale.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400165E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400165F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002403")]
    [Address(RVA = "0xDC74A0", Offset = "0xDC62A0", VA = "0x10DC74A0")]
    public FlowNode_ReqCrystalSale_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002404")]
    [Address(RVA = "0xDC71B0", Offset = "0xDC5FB0", VA = "0x10DC71B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalSale.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002405")]
    [Address(RVA = "0xDC6D80", Offset = "0xDC5B80", VA = "0x10DC6D80", Slot = "5")]
    public FlowNode_ReqCrystalSale.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalSale.MP_Response) null;
    }
  }
}
