// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRunePrideBoardOpen_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A6")]
  public sealed class FlowNode_ReqRunePrideBoardOpen_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRunePrideBoardOpen.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002640")]
    [Address(RVA = "0xE389D0", Offset = "0xE377D0", VA = "0x10E389D0")]
    public FlowNode_ReqRunePrideBoardOpen_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002641")]
    [Address(RVA = "0xE386E0", Offset = "0xE374E0", VA = "0x10E386E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRunePrideBoardOpen.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002642")]
    [Address(RVA = "0xE382B0", Offset = "0xE370B0", VA = "0x10E382B0", Slot = "5")]
    public FlowNode_ReqRunePrideBoardOpen.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRunePrideBoardOpen.MP_Response) null;
    }
  }
}
