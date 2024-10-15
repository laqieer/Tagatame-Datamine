// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneResetDedicated_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B33")]
  public sealed class FlowNode_ReqRuneResetDedicated_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneResetDedicated.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AF6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AF7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AE7")]
    [Address(RVA = "0xF63550", Offset = "0xF62350", VA = "0x10F63550")]
    public FlowNode_ReqRuneResetDedicated_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AE8")]
    [Address(RVA = "0xF63260", Offset = "0xF62060", VA = "0x10F63260", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneResetDedicated.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AE9")]
    [Address(RVA = "0xF62E30", Offset = "0xF61C30", VA = "0x10F62E30", Slot = "5")]
    public FlowNode_ReqRuneResetDedicated.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneResetDedicated.MP_Response) null;
    }
  }
}
