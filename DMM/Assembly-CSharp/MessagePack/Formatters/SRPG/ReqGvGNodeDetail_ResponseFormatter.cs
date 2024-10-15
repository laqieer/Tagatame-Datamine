// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGNodeDetail_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD7")]
  public sealed class ReqGvGNodeDetail_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGNodeDetail.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A3E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A3F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029D3")]
    [Address(RVA = "0xF13EA0", Offset = "0xF12CA0", VA = "0x10F13EA0")]
    public ReqGvGNodeDetail_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029D4")]
    [Address(RVA = "0xF13D40", Offset = "0xF12B40", VA = "0x10F13D40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGNodeDetail.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029D5")]
    [Address(RVA = "0xF139F0", Offset = "0xF127F0", VA = "0x10F139F0", Slot = "5")]
    public ReqGvGNodeDetail.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGNodeDetail.Response) null;
    }
  }
}
