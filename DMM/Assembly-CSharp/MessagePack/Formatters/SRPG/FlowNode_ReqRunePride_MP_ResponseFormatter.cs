// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRunePride_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200059F")]
  public sealed class FlowNode_ReqRunePride_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRunePride.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FD6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FD7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A2B")]
    [Address(RVA = "0x78F030", Offset = "0x78DE30", VA = "0x1078F030")]
    public FlowNode_ReqRunePride_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001A2C")]
    [Address(RVA = "0x78ED40", Offset = "0x78DB40", VA = "0x1078ED40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRunePride.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A2D")]
    [Address(RVA = "0x78E910", Offset = "0x78D710", VA = "0x1078E910", Slot = "5")]
    public FlowNode_ReqRunePride.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRunePride.MP_Response) null;
    }
  }
}
