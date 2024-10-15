// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPointQuestGuild_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D6")]
  public sealed class FlowNode_ReqPointQuestGuild_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPointQuestGuild.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400183C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400183D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026D0")]
    [Address(RVA = "0xE6B130", Offset = "0xE69F30", VA = "0x10E6B130")]
    public FlowNode_ReqPointQuestGuild_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026D1")]
    [Address(RVA = "0xE6AE40", Offset = "0xE69C40", VA = "0x10E6AE40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPointQuestGuild.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026D2")]
    [Address(RVA = "0xE6AA10", Offset = "0xE69810", VA = "0x10E6AA10", Slot = "5")]
    public FlowNode_ReqPointQuestGuild.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPointQuestGuild.MP_Response) null;
    }
  }
}
