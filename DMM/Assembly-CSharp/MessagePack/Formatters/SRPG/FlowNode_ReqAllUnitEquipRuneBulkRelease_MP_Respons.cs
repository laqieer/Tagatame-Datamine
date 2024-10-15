// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAllUnitEquipRuneBulkRelease_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B05")]
  public sealed class FlowNode_ReqAllUnitEquipRuneBulkRelease_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAllUnitEquipRuneBulkRelease.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A9A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A9B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A5D")]
    [Address(RVA = "0xF1A680", Offset = "0xF19480", VA = "0x10F1A680")]
    public FlowNode_ReqAllUnitEquipRuneBulkRelease_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A5E")]
    [Address(RVA = "0xF1A390", Offset = "0xF19190", VA = "0x10F1A390", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAllUnitEquipRuneBulkRelease.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A5F")]
    [Address(RVA = "0xF19F60", Offset = "0xF18D60", VA = "0x10F19F60", Slot = "5")]
    public FlowNode_ReqAllUnitEquipRuneBulkRelease.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAllUnitEquipRuneBulkRelease.MP_Response) null;
    }
  }
}
