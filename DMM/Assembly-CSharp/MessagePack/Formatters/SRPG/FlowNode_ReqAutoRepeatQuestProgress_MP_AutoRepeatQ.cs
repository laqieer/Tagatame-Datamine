// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAutoRepeatQuestProgress_MP_AutoRepeatQuestProgressResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B0C")]
  public sealed class FlowNode_ReqAutoRepeatQuestProgress_MP_AutoRepeatQuestProgressResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAutoRepeatQuestProgress.MP_AutoRepeatQuestProgressResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AA8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AA9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A72")]
    [Address(RVA = "0xF33270", Offset = "0xF32070", VA = "0x10F33270")]
    public FlowNode_ReqAutoRepeatQuestProgress_MP_AutoRepeatQuestProgressResponseFormatter()
    {
    }

    [Token(Token = "0x6002A73")]
    [Address(RVA = "0xF32F80", Offset = "0xF31D80", VA = "0x10F32F80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAutoRepeatQuestProgress.MP_AutoRepeatQuestProgressResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A74")]
    [Address(RVA = "0xF32B50", Offset = "0xF31950", VA = "0x10F32B50", Slot = "5")]
    public FlowNode_ReqAutoRepeatQuestProgress.MP_AutoRepeatQuestProgressResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAutoRepeatQuestProgress.MP_AutoRepeatQuestProgressResponse) null;
    }
  }
}
