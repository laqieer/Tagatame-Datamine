// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalBulkUpgrade_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ABE")]
  public sealed class FlowNode_ReqCrystalBulkUpgrade_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalBulkUpgrade.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A0C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A0D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002988")]
    [Address(RVA = "0xF06450", Offset = "0xF05250", VA = "0x10F06450")]
    public FlowNode_ReqCrystalBulkUpgrade_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002989")]
    [Address(RVA = "0xF06160", Offset = "0xF04F60", VA = "0x10F06160", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalBulkUpgrade.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600298A")]
    [Address(RVA = "0xF05D30", Offset = "0xF04B30", VA = "0x10F05D30", Slot = "5")]
    public FlowNode_ReqCrystalBulkUpgrade.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalBulkUpgrade.MP_Response) null;
    }
  }
}
