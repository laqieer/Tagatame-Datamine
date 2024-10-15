// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAutoRepeatQuestSetApItemPriority_MP_ReqAutoRepeatQuestSetApItemPriorityFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A0D")]
  public sealed class FlowNode_ReqAutoRepeatQuestSetApItemPriority_MP_ReqAutoRepeatQuestSetApItemPriorityFormatter : 
    IMessagePackFormatter<FlowNode_ReqAutoRepeatQuestSetApItemPriority.MP_ReqAutoRepeatQuestSetApItemPriority>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002775")]
    [Address(RVA = "0xE97D20", Offset = "0xE96B20", VA = "0x10E97D20")]
    public FlowNode_ReqAutoRepeatQuestSetApItemPriority_MP_ReqAutoRepeatQuestSetApItemPriorityFormatter()
    {
    }

    [Token(Token = "0x6002776")]
    [Address(RVA = "0xE97A30", Offset = "0xE96830", VA = "0x10E97A30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAutoRepeatQuestSetApItemPriority.MP_ReqAutoRepeatQuestSetApItemPriority value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002777")]
    [Address(RVA = "0xE97600", Offset = "0xE96400", VA = "0x10E97600", Slot = "5")]
    public FlowNode_ReqAutoRepeatQuestSetApItemPriority.MP_ReqAutoRepeatQuestSetApItemPriority Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAutoRepeatQuestSetApItemPriority.MP_ReqAutoRepeatQuestSetApItemPriority) null;
    }
  }
}
