// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRunePrideBoardReset_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B32")]
  public sealed class FlowNode_ReqRunePrideBoardReset_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRunePrideBoardReset.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AF4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AF5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AE4")]
    [Address(RVA = "0xF62B00", Offset = "0xF61900", VA = "0x10F62B00")]
    public FlowNode_ReqRunePrideBoardReset_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AE5")]
    [Address(RVA = "0xF62810", Offset = "0xF61610", VA = "0x10F62810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRunePrideBoardReset.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AE6")]
    [Address(RVA = "0xF623E0", Offset = "0xF611E0", VA = "0x10F623E0", Slot = "5")]
    public FlowNode_ReqRunePrideBoardReset.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRunePrideBoardReset.MP_Response) null;
    }
  }
}
