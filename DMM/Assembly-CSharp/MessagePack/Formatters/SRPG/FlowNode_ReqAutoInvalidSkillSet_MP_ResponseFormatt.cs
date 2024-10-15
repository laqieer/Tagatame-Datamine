// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAutoInvalidSkillSet_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000804")]
  public sealed class FlowNode_ReqAutoInvalidSkillSet_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAutoInvalidSkillSet.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001498")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001499")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600215A")]
    [Address(RVA = "0xD3F760", Offset = "0xD3E560", VA = "0x10D3F760")]
    public FlowNode_ReqAutoInvalidSkillSet_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600215B")]
    [Address(RVA = "0xD3F470", Offset = "0xD3E270", VA = "0x10D3F470", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAutoInvalidSkillSet.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600215C")]
    [Address(RVA = "0xD3F040", Offset = "0xD3DE40", VA = "0x10D3F040", Slot = "5")]
    public FlowNode_ReqAutoInvalidSkillSet.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAutoInvalidSkillSet.MP_Response) null;
    }
  }
}
