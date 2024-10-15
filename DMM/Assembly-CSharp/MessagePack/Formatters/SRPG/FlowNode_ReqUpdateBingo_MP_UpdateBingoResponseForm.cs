// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqUpdateBingo_MP_UpdateBingoResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D4")]
  public sealed class FlowNode_ReqUpdateBingo_MP_UpdateBingoResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqUpdateBingo.MP_UpdateBingoResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001838")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001839")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026CA")]
    [Address(RVA = "0xE6D020", Offset = "0xE6BE20", VA = "0x10E6D020")]
    public FlowNode_ReqUpdateBingo_MP_UpdateBingoResponseFormatter()
    {
    }

    [Token(Token = "0x60026CB")]
    [Address(RVA = "0xE6CD30", Offset = "0xE6BB30", VA = "0x10E6CD30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqUpdateBingo.MP_UpdateBingoResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026CC")]
    [Address(RVA = "0xE6C900", Offset = "0xE6B700", VA = "0x10E6C900", Slot = "5")]
    public FlowNode_ReqUpdateBingo.MP_UpdateBingoResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqUpdateBingo.MP_UpdateBingoResponse) null;
    }
  }
}
