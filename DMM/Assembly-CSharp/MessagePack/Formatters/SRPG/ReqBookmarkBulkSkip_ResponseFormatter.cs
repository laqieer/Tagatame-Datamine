// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBookmarkBulkSkip_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007EA")]
  public sealed class ReqBookmarkBulkSkip_ResponseFormatter : 
    IMessagePackFormatter<ReqBookmarkBulkSkip.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001464")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001465")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600210C")]
    [Address(RVA = "0xD3AB90", Offset = "0xD39990", VA = "0x10D3AB90")]
    public ReqBookmarkBulkSkip_ResponseFormatter()
    {
    }

    [Token(Token = "0x600210D")]
    [Address(RVA = "0xD3A000", Offset = "0xD38E00", VA = "0x10D3A000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBookmarkBulkSkip.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600210E")]
    [Address(RVA = "0xD39730", Offset = "0xD38530", VA = "0x10D39730", Slot = "5")]
    public ReqBookmarkBulkSkip.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBookmarkBulkSkip.Response) null;
    }
  }
}
