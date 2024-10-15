// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRunePridePotentialSet_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C9")]
  public sealed class FlowNode_ReqRunePridePotentialSet_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRunePridePotentialSet.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001622")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001623")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023A9")]
    [Address(RVA = "0xDCA830", Offset = "0xDC9630", VA = "0x10DCA830")]
    public FlowNode_ReqRunePridePotentialSet_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023AA")]
    [Address(RVA = "0xDCA540", Offset = "0xDC9340", VA = "0x10DCA540", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRunePridePotentialSet.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023AB")]
    [Address(RVA = "0xDCA110", Offset = "0xDC8F10", VA = "0x10DCA110", Slot = "5")]
    public FlowNode_ReqRunePridePotentialSet.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRunePridePotentialSet.MP_Response) null;
    }
  }
}
