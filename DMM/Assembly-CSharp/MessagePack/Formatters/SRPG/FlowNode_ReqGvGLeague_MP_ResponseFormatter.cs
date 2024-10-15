// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGLeague_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A51")]
  public sealed class FlowNode_ReqGvGLeague_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGLeague.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001932")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001933")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002841")]
    [Address(RVA = "0xEAB450", Offset = "0xEAA250", VA = "0x10EAB450")]
    public FlowNode_ReqGvGLeague_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002842")]
    [Address(RVA = "0xEAB160", Offset = "0xEA9F60", VA = "0x10EAB160", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGLeague.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002843")]
    [Address(RVA = "0xEAAD30", Offset = "0xEA9B30", VA = "0x10EAAD30", Slot = "5")]
    public FlowNode_ReqGvGLeague.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGLeague.MP_Response) null;
    }
  }
}
