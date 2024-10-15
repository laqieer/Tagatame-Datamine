// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqQuestParam_MP_QuestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B15")]
  public sealed class FlowNode_ReqQuestParam_MP_QuestParamFormatter : 
    IMessagePackFormatter<FlowNode_ReqQuestParam.MP_QuestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ABA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ABB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A8D")]
    [Address(RVA = "0xF38F40", Offset = "0xF37D40", VA = "0x10F38F40")]
    public FlowNode_ReqQuestParam_MP_QuestParamFormatter()
    {
    }

    [Token(Token = "0x6002A8E")]
    [Address(RVA = "0xF38C50", Offset = "0xF37A50", VA = "0x10F38C50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqQuestParam.MP_QuestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A8F")]
    [Address(RVA = "0xF38820", Offset = "0xF37620", VA = "0x10F38820", Slot = "5")]
    public FlowNode_ReqQuestParam.MP_QuestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqQuestParam.MP_QuestParam) null;
    }
  }
}
