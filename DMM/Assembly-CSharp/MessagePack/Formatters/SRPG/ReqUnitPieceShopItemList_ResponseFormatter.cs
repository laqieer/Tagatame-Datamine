// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitPieceShopItemList_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD1")]
  public sealed class ReqUnitPieceShopItemList_ResponseFormatter : 
    IMessagePackFormatter<ReqUnitPieceShopItemList.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A32")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A33")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029C1")]
    [Address(RVA = "0xF17870", Offset = "0xF16670", VA = "0x10F17870")]
    public ReqUnitPieceShopItemList_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029C2")]
    [Address(RVA = "0xF17630", Offset = "0xF16430", VA = "0x10F17630", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitPieceShopItemList.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029C3")]
    [Address(RVA = "0xF17290", Offset = "0xF16090", VA = "0x10F17290", Slot = "5")]
    public ReqUnitPieceShopItemList.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitPieceShopItemList.Response) null;
    }
  }
}
