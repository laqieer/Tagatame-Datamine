// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalUnitSet_MP_Response_BaseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000962")]
  public sealed class FlowNode_ReqCrystalUnitSet_MP_Response_BaseFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalUnitSet.MP_Response_Base>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001754")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001755")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002574")]
    [Address(RVA = "0xE0C5B0", Offset = "0xE0B3B0", VA = "0x10E0C5B0")]
    public FlowNode_ReqCrystalUnitSet_MP_Response_BaseFormatter()
    {
    }

    [Token(Token = "0x6002575")]
    [Address(RVA = "0xE0C2C0", Offset = "0xE0B0C0", VA = "0x10E0C2C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalUnitSet.MP_Response_Base value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002576")]
    [Address(RVA = "0xE0BE90", Offset = "0xE0AC90", VA = "0x10E0BE90", Slot = "5")]
    public FlowNode_ReqCrystalUnitSet.MP_Response_Base Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalUnitSet.MP_Response_Base) null;
    }
  }
}
