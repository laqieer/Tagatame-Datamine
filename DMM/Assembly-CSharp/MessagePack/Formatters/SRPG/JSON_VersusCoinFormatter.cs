// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusCoinFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E5")]
  public sealed class JSON_VersusCoinFormatter : 
    IMessagePackFormatter<JSON_VersusCoin>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400185A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400185B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026FD")]
    [Address(RVA = "0xE85150", Offset = "0xE83F50", VA = "0x10E85150")]
    public JSON_VersusCoinFormatter()
    {
    }

    [Token(Token = "0x60026FE")]
    [Address(RVA = "0xE84F50", Offset = "0xE83D50", VA = "0x10E84F50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusCoin value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026FF")]
    [Address(RVA = "0xE84B80", Offset = "0xE83980", VA = "0x10E84B80", Slot = "5")]
    public JSON_VersusCoin Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusCoin) null;
    }
  }
}
