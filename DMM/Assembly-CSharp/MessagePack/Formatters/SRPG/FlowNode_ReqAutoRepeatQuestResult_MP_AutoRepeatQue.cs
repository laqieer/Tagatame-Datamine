// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAutoRepeatQuestResult_MP_AutoRepeatQuestEndResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008ED")]
  public sealed class FlowNode_ReqAutoRepeatQuestResult_MP_AutoRepeatQuestEndResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAutoRepeatQuestResult.MP_AutoRepeatQuestEndResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400166A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400166B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002415")]
    [Address(RVA = "0xDDD910", Offset = "0xDDC710", VA = "0x10DDD910")]
    public FlowNode_ReqAutoRepeatQuestResult_MP_AutoRepeatQuestEndResponseFormatter()
    {
    }

    [Token(Token = "0x6002416")]
    [Address(RVA = "0xDDD620", Offset = "0xDDC420", VA = "0x10DDD620", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAutoRepeatQuestResult.MP_AutoRepeatQuestEndResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002417")]
    [Address(RVA = "0xDDD1F0", Offset = "0xDDBFF0", VA = "0x10DDD1F0", Slot = "5")]
    public FlowNode_ReqAutoRepeatQuestResult.MP_AutoRepeatQuestEndResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAutoRepeatQuestResult.MP_AutoRepeatQuestEndResponse) null;
    }
  }
}
