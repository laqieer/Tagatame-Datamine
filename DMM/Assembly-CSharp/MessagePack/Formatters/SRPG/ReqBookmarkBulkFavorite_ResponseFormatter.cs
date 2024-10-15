// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBookmarkBulkFavorite_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E2")]
  public sealed class ReqBookmarkBulkFavorite_ResponseFormatter : 
    IMessagePackFormatter<ReqBookmarkBulkFavorite.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001654")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001655")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023F4")]
    [Address(RVA = "0xDD6340", Offset = "0xDD5140", VA = "0x10DD6340")]
    public ReqBookmarkBulkFavorite_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023F5")]
    [Address(RVA = "0xDD6210", Offset = "0xDD5010", VA = "0x10DD6210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBookmarkBulkFavorite.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023F6")]
    [Address(RVA = "0xDD5F00", Offset = "0xDD4D00", VA = "0x10DD5F00", Slot = "5")]
    public ReqBookmarkBulkFavorite.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBookmarkBulkFavorite.Response) null;
    }
  }
}
