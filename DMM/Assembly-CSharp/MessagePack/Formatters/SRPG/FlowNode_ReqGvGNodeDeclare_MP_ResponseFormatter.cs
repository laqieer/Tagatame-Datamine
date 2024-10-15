// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGNodeDeclare_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000979")]
  public sealed class FlowNode_ReqGvGNodeDeclare_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGNodeDeclare.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001782")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001783")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025B9")]
    [Address(RVA = "0xE284F0", Offset = "0xE272F0", VA = "0x10E284F0")]
    public FlowNode_ReqGvGNodeDeclare_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025BA")]
    [Address(RVA = "0xE28200", Offset = "0xE27000", VA = "0x10E28200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGNodeDeclare.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025BB")]
    [Address(RVA = "0xE27DD0", Offset = "0xE26BD0", VA = "0x10E27DD0", Slot = "5")]
    public FlowNode_ReqGvGNodeDeclare.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGNodeDeclare.MP_Response) null;
    }
  }
}
