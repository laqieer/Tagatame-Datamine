// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqQuestBookMarkBulkSkip_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200092A")]
  public sealed class FlowNode_ReqQuestBookMarkBulkSkip_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqQuestBookMarkBulkSkip.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024CC")]
    [Address(RVA = "0xDF90E0", Offset = "0xDF7EE0", VA = "0x10DF90E0")]
    public FlowNode_ReqQuestBookMarkBulkSkip_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024CD")]
    [Address(RVA = "0xDF8DF0", Offset = "0xDF7BF0", VA = "0x10DF8DF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqQuestBookMarkBulkSkip.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024CE")]
    [Address(RVA = "0xDF89C0", Offset = "0xDF77C0", VA = "0x10DF89C0", Slot = "5")]
    public FlowNode_ReqQuestBookMarkBulkSkip.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqQuestBookMarkBulkSkip.MP_Response) null;
    }
  }
}
