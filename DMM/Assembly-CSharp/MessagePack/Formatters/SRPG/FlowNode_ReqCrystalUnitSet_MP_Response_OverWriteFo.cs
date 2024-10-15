// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqCrystalUnitSet_MP_Response_OverWriteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000964")]
  public sealed class FlowNode_ReqCrystalUnitSet_MP_Response_OverWriteFormatter : 
    IMessagePackFormatter<FlowNode_ReqCrystalUnitSet.MP_Response_OverWrite>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001758")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001759")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600257A")]
    [Address(RVA = "0xE27AA0", Offset = "0xE268A0", VA = "0x10E27AA0")]
    public FlowNode_ReqCrystalUnitSet_MP_Response_OverWriteFormatter()
    {
    }

    [Token(Token = "0x600257B")]
    [Address(RVA = "0xE277B0", Offset = "0xE265B0", VA = "0x10E277B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqCrystalUnitSet.MP_Response_OverWrite value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600257C")]
    [Address(RVA = "0xE27380", Offset = "0xE26180", VA = "0x10E27380", Slot = "5")]
    public FlowNode_ReqCrystalUnitSet.MP_Response_OverWrite Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqCrystalUnitSet.MP_Response_OverWrite) null;
    }
  }
}
