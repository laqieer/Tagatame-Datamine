// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPointQuestReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000929")]
  public sealed class FlowNode_ReqPointQuestReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPointQuestReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024C9")]
    [Address(RVA = "0xDF8690", Offset = "0xDF7490", VA = "0x10DF8690")]
    public FlowNode_ReqPointQuestReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024CA")]
    [Address(RVA = "0xDF83A0", Offset = "0xDF71A0", VA = "0x10DF83A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPointQuestReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024CB")]
    [Address(RVA = "0xDF7F70", Offset = "0xDF6D70", VA = "0x10DF7F70", Slot = "5")]
    public FlowNode_ReqPointQuestReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPointQuestReward.MP_Response) null;
    }
  }
}
