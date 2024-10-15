// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAutoRepeatQuestStart_MP_AutoRepeatQuestStartResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A23")]
  public sealed class FlowNode_ReqAutoRepeatQuestStart_MP_AutoRepeatQuestStartResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAutoRepeatQuestStart.MP_AutoRepeatQuestStartResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027B7")]
    [Address(RVA = "0xE98770", Offset = "0xE97570", VA = "0x10E98770")]
    public FlowNode_ReqAutoRepeatQuestStart_MP_AutoRepeatQuestStartResponseFormatter()
    {
    }

    [Token(Token = "0x60027B8")]
    [Address(RVA = "0xE98480", Offset = "0xE97280", VA = "0x10E98480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAutoRepeatQuestStart.MP_AutoRepeatQuestStartResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027B9")]
    [Address(RVA = "0xE98050", Offset = "0xE96E50", VA = "0x10E98050", Slot = "5")]
    public FlowNode_ReqAutoRepeatQuestStart.MP_AutoRepeatQuestStartResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAutoRepeatQuestStart.MP_AutoRepeatQuestStartResponse) null;
    }
  }
}
