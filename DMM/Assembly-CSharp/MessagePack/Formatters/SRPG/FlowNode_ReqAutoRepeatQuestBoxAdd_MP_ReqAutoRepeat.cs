// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAutoRepeatQuestBoxAdd_MP_ReqAutoRepeatQuestBoxAddResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200095C")]
  public sealed class FlowNode_ReqAutoRepeatQuestBoxAdd_MP_ReqAutoRepeatQuestBoxAddResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAutoRepeatQuestBoxAdd.MP_ReqAutoRepeatQuestBoxAddResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001748")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001749")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002562")]
    [Address(RVA = "0xE0B110", Offset = "0xE09F10", VA = "0x10E0B110")]
    public FlowNode_ReqAutoRepeatQuestBoxAdd_MP_ReqAutoRepeatQuestBoxAddResponseFormatter()
    {
    }

    [Token(Token = "0x6002563")]
    [Address(RVA = "0xE0AE20", Offset = "0xE09C20", VA = "0x10E0AE20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAutoRepeatQuestBoxAdd.MP_ReqAutoRepeatQuestBoxAddResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002564")]
    [Address(RVA = "0xE0A9F0", Offset = "0xE097F0", VA = "0x10E0A9F0", Slot = "5")]
    public FlowNode_ReqAutoRepeatQuestBoxAdd.MP_ReqAutoRepeatQuestBoxAddResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAutoRepeatQuestBoxAdd.MP_ReqAutoRepeatQuestBoxAddResponse) null;
    }
  }
}
