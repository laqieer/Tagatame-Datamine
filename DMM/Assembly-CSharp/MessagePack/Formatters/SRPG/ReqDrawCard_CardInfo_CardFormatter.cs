// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDrawCard_CardInfo_CardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A37")]
  public sealed class ReqDrawCard_CardInfo_CardFormatter : 
    IMessagePackFormatter<ReqDrawCard.CardInfo.Card>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027F3")]
    [Address(RVA = "0xEB5F30", Offset = "0xEB4D30", VA = "0x10EB5F30")]
    public ReqDrawCard_CardInfo_CardFormatter()
    {
    }

    [Token(Token = "0x60027F4")]
    [Address(RVA = "0xEB5DD0", Offset = "0xEB4BD0", VA = "0x10EB5DD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDrawCard.CardInfo.Card value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027F5")]
    [Address(RVA = "0xEB5A80", Offset = "0xEB4880", VA = "0x10EB5A80", Slot = "5")]
    public ReqDrawCard.CardInfo.Card Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDrawCard.CardInfo.Card) null;
    }
  }
}
