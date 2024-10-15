// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGBeatRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B11")]
  public sealed class FlowNode_ReqGvGBeatRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGBeatRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AB2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AB3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A81")]
    [Address(RVA = "0xF35BB0", Offset = "0xF349B0", VA = "0x10F35BB0")]
    public FlowNode_ReqGvGBeatRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A82")]
    [Address(RVA = "0xF358C0", Offset = "0xF346C0", VA = "0x10F358C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGBeatRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A83")]
    [Address(RVA = "0xF35490", Offset = "0xF34290", VA = "0x10F35490", Slot = "5")]
    public FlowNode_ReqGvGBeatRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGBeatRanking.MP_Response) null;
    }
  }
}
