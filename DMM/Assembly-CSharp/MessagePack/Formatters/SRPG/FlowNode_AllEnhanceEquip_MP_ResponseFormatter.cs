// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_AllEnhanceEquip_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ACA")]
  public sealed class FlowNode_AllEnhanceEquip_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_AllEnhanceEquip.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A24")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A25")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029AC")]
    [Address(RVA = "0xF030C0", Offset = "0xF01EC0", VA = "0x10F030C0")]
    public FlowNode_AllEnhanceEquip_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029AD")]
    [Address(RVA = "0xF02DD0", Offset = "0xF01BD0", VA = "0x10F02DD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_AllEnhanceEquip.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029AE")]
    [Address(RVA = "0xF029A0", Offset = "0xF017A0", VA = "0x10F029A0", Slot = "5")]
    public FlowNode_AllEnhanceEquip.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_AllEnhanceEquip.MP_Response) null;
    }
  }
}
