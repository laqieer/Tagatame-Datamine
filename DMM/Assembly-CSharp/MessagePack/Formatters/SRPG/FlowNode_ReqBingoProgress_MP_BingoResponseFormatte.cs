// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqBingoProgress_MP_BingoResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200073C")]
  public sealed class FlowNode_ReqBingoProgress_MP_BingoResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqBingoProgress.MP_BingoResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001310")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001311")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F02")]
    [Address(RVA = "0xC80E50", Offset = "0xC7FC50", VA = "0x10C80E50")]
    public FlowNode_ReqBingoProgress_MP_BingoResponseFormatter()
    {
    }

    [Token(Token = "0x6001F03")]
    [Address(RVA = "0xC80B60", Offset = "0xC7F960", VA = "0x10C80B60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqBingoProgress.MP_BingoResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F04")]
    [Address(RVA = "0xC80730", Offset = "0xC7F530", VA = "0x10C80730", Slot = "5")]
    public FlowNode_ReqBingoProgress.MP_BingoResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqBingoProgress.MP_BingoResponse) null;
    }
  }
}
