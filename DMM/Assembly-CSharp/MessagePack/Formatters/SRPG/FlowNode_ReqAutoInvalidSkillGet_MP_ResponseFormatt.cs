// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAutoInvalidSkillGet_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000923")]
  public sealed class FlowNode_ReqAutoInvalidSkillGet_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAutoInvalidSkillGet.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024B7")]
    [Address(RVA = "0xDF3E60", Offset = "0xDF2C60", VA = "0x10DF3E60")]
    public FlowNode_ReqAutoInvalidSkillGet_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024B8")]
    [Address(RVA = "0xDF3B70", Offset = "0xDF2970", VA = "0x10DF3B70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAutoInvalidSkillGet.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024B9")]
    [Address(RVA = "0xDF3740", Offset = "0xDF2540", VA = "0x10DF3740", Slot = "5")]
    public FlowNode_ReqAutoInvalidSkillGet.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAutoInvalidSkillGet.MP_Response) null;
    }
  }
}
