// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAutoRepeatQuestBox_MP_ReqAutoRepeatQuestBoxResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009AB")]
  public sealed class FlowNode_ReqAutoRepeatQuestBox_MP_ReqAutoRepeatQuestBoxResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAutoRepeatQuestBox.MP_ReqAutoRepeatQuestBoxResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600264F")]
    [Address(RVA = "0xE37F80", Offset = "0xE36D80", VA = "0x10E37F80")]
    public FlowNode_ReqAutoRepeatQuestBox_MP_ReqAutoRepeatQuestBoxResponseFormatter()
    {
    }

    [Token(Token = "0x6002650")]
    [Address(RVA = "0xE37C90", Offset = "0xE36A90", VA = "0x10E37C90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAutoRepeatQuestBox.MP_ReqAutoRepeatQuestBoxResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002651")]
    [Address(RVA = "0xE37860", Offset = "0xE36660", VA = "0x10E37860", Slot = "5")]
    public FlowNode_ReqAutoRepeatQuestBox.MP_ReqAutoRepeatQuestBoxResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAutoRepeatQuestBox.MP_ReqAutoRepeatQuestBoxResponse) null;
    }
  }
}
