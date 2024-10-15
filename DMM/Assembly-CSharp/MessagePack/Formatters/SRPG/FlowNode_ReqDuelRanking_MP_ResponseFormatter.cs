// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqDuelRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A5F")]
  public sealed class FlowNode_ReqDuelRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqDuelRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400194E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400194F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600286B")]
    [Address(RVA = "0xEC0F20", Offset = "0xEBFD20", VA = "0x10EC0F20")]
    public FlowNode_ReqDuelRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600286C")]
    [Address(RVA = "0xEC0C30", Offset = "0xEBFA30", VA = "0x10EC0C30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqDuelRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600286D")]
    [Address(RVA = "0xEC0800", Offset = "0xEBF600", VA = "0x10EC0800", Slot = "5")]
    public FlowNode_ReqDuelRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqDuelRanking.MP_Response) null;
    }
  }
}
