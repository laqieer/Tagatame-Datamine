// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqDuelTop_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A58")]
  public sealed class FlowNode_ReqDuelTop_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqDuelTop.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001940")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001941")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002856")]
    [Address(RVA = "0xEC1970", Offset = "0xEC0770", VA = "0x10EC1970")]
    public FlowNode_ReqDuelTop_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002857")]
    [Address(RVA = "0xEC1680", Offset = "0xEC0480", VA = "0x10EC1680", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqDuelTop.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002858")]
    [Address(RVA = "0xEC1250", Offset = "0xEC0050", VA = "0x10EC1250", Slot = "5")]
    public FlowNode_ReqDuelTop.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqDuelTop.MP_Response) null;
    }
  }
}
