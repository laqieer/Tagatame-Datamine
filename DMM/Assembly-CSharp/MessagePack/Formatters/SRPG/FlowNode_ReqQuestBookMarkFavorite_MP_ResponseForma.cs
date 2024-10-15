// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqQuestBookMarkFavorite_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E3")]
  public sealed class FlowNode_ReqQuestBookMarkFavorite_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqQuestBookMarkFavorite.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001656")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001657")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023F7")]
    [Address(RVA = "0xDC9390", Offset = "0xDC8190", VA = "0x10DC9390")]
    public FlowNode_ReqQuestBookMarkFavorite_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023F8")]
    [Address(RVA = "0xDC90A0", Offset = "0xDC7EA0", VA = "0x10DC90A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqQuestBookMarkFavorite.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023F9")]
    [Address(RVA = "0xDC8C70", Offset = "0xDC7A70", VA = "0x10DC8C70", Slot = "5")]
    public FlowNode_ReqQuestBookMarkFavorite.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqQuestBookMarkFavorite.MP_Response) null;
    }
  }
}
