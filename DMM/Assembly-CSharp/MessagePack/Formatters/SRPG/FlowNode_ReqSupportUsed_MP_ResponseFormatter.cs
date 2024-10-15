// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqSupportUsed_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B0B")]
  public sealed class FlowNode_ReqSupportUsed_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqSupportUsed.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AA6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AA7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A6F")]
    [Address(RVA = "0xF3B880", Offset = "0xF3A680", VA = "0x10F3B880")]
    public FlowNode_ReqSupportUsed_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A70")]
    [Address(RVA = "0xF3B590", Offset = "0xF3A390", VA = "0x10F3B590", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqSupportUsed.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A71")]
    [Address(RVA = "0xF3B160", Offset = "0xF39F60", VA = "0x10F3B160", Slot = "5")]
    public FlowNode_ReqSupportUsed.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqSupportUsed.MP_Response) null;
    }
  }
}
