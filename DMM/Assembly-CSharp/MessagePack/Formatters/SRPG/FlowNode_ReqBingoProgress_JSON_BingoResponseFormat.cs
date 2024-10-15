// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqBingoProgress_JSON_BingoResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200073B")]
  public sealed class FlowNode_ReqBingoProgress_JSON_BingoResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqBingoProgress.JSON_BingoResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400130E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400130F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EFF")]
    [Address(RVA = "0xC80610", Offset = "0xC7F410", VA = "0x10C80610")]
    public FlowNode_ReqBingoProgress_JSON_BingoResponseFormatter()
    {
    }

    [Token(Token = "0x6001F00")]
    [Address(RVA = "0xC80510", Offset = "0xC7F310", VA = "0x10C80510", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqBingoProgress.JSON_BingoResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F01")]
    [Address(RVA = "0xC80240", Offset = "0xC7F040", VA = "0x10C80240", Slot = "5")]
    public FlowNode_ReqBingoProgress.JSON_BingoResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqBingoProgress.JSON_BingoResponse) null;
    }
  }
}
