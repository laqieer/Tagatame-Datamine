// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRoleBonus_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A5D")]
  public sealed class FlowNode_ReqGuildRoleBonus_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRoleBonus.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400194A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400194B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002865")]
    [Address(RVA = "0xEC2E10", Offset = "0xEC1C10", VA = "0x10EC2E10")]
    public FlowNode_ReqGuildRoleBonus_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002866")]
    [Address(RVA = "0xEC2B20", Offset = "0xEC1920", VA = "0x10EC2B20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRoleBonus.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002867")]
    [Address(RVA = "0xEC26F0", Offset = "0xEC14F0", VA = "0x10EC26F0", Slot = "5")]
    public FlowNode_ReqGuildRoleBonus.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRoleBonus.MP_Response) null;
    }
  }
}
