// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqBondLevelUp_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000966")]
  public sealed class FlowNode_ReqBondLevelUp_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqBondLevelUp.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400175C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400175D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002580")]
    [Address(RVA = "0xE27050", Offset = "0xE25E50", VA = "0x10E27050")]
    public FlowNode_ReqBondLevelUp_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002581")]
    [Address(RVA = "0xE26D60", Offset = "0xE25B60", VA = "0x10E26D60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqBondLevelUp.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002582")]
    [Address(RVA = "0xE26930", Offset = "0xE25730", VA = "0x10E26930", Slot = "5")]
    public FlowNode_ReqBondLevelUp.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqBondLevelUp.MP_Response) null;
    }
  }
}
