// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqUnitEquipRuneBulkRelease_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200094C")]
  public sealed class FlowNode_ReqUnitEquipRuneBulkRelease_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqUnitEquipRuneBulkRelease.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001728")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001729")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002532")]
    [Address(RVA = "0xE13720", Offset = "0xE12520", VA = "0x10E13720")]
    public FlowNode_ReqUnitEquipRuneBulkRelease_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002533")]
    [Address(RVA = "0xE13430", Offset = "0xE12230", VA = "0x10E13430", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqUnitEquipRuneBulkRelease.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002534")]
    [Address(RVA = "0xE13000", Offset = "0xE11E00", VA = "0x10E13000", Slot = "5")]
    public FlowNode_ReqUnitEquipRuneBulkRelease.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqUnitEquipRuneBulkRelease.MP_Response) null;
    }
  }
}
