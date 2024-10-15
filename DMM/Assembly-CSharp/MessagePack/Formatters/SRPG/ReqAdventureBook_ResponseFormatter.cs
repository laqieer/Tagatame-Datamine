// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAdventureBook_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A9F")]
  public sealed class ReqAdventureBook_ResponseFormatter : 
    IMessagePackFormatter<ReqAdventureBook.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600292B")]
    [Address(RVA = "0xEFDA10", Offset = "0xEFC810", VA = "0x10EFDA10")]
    public ReqAdventureBook_ResponseFormatter()
    {
    }

    [Token(Token = "0x600292C")]
    [Address(RVA = "0xEFD8A0", Offset = "0xEFC6A0", VA = "0x10EFD8A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAdventureBook.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600292D")]
    [Address(RVA = "0xEFD5D0", Offset = "0xEFC3D0", VA = "0x10EFD5D0", Slot = "5")]
    public ReqAdventureBook.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAdventureBook.Response) null;
    }
  }
}
