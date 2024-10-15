// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitPieceShopBuypaid_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200090E")]
  public sealed class ReqUnitPieceShopBuypaid_ResponseFormatter : 
    IMessagePackFormatter<ReqUnitPieceShopBuypaid.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002478")]
    [Address(RVA = "0xDECD50", Offset = "0xDEBB50", VA = "0x10DECD50")]
    public ReqUnitPieceShopBuypaid_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002479")]
    [Address(RVA = "0xDECA90", Offset = "0xDEB890", VA = "0x10DECA90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitPieceShopBuypaid.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600247A")]
    [Address(RVA = "0xDEC6A0", Offset = "0xDEB4A0", VA = "0x10DEC6A0", Slot = "5")]
    public ReqUnitPieceShopBuypaid.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitPieceShopBuypaid.Response) null;
    }
  }
}
