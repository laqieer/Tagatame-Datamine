// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ArenaWinResultFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F3")]
  public sealed class JSON_ArenaWinResultFormatter : 
    IMessagePackFormatter<JSON_ArenaWinResult>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400107E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400107F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B27")]
    [Address(RVA = "0xBA2B70", Offset = "0xBA1970", VA = "0x10BA2B70")]
    public JSON_ArenaWinResultFormatter()
    {
    }

    [Token(Token = "0x6001B28")]
    [Address(RVA = "0xBA25D0", Offset = "0xBA13D0", VA = "0x10BA25D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ArenaWinResult value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B29")]
    [Address(RVA = "0xBA1EB0", Offset = "0xBA0CB0", VA = "0x10BA1EB0", Slot = "5")]
    public JSON_ArenaWinResult Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ArenaWinResult) null;
    }
  }
}
