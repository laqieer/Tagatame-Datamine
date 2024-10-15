// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGDefenseRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B1C")]
  public sealed class FlowNode_ReqGvGDefenseRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGDefenseRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AC8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AC9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AA2")]
    [Address(RVA = "0xF36600", Offset = "0xF35400", VA = "0x10F36600")]
    public FlowNode_ReqGvGDefenseRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AA3")]
    [Address(RVA = "0xF36310", Offset = "0xF35110", VA = "0x10F36310", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGDefenseRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AA4")]
    [Address(RVA = "0xF35EE0", Offset = "0xF34CE0", VA = "0x10F35EE0", Slot = "5")]
    public FlowNode_ReqGvGDefenseRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGDefenseRanking.MP_Response) null;
    }
  }
}
