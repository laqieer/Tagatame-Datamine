// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchResultBeforeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000818")]
  public sealed class JSON_LeagueMatchResultBeforeFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchResultBefore>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002196")]
    [Address(RVA = "0xD485C0", Offset = "0xD473C0", VA = "0x10D485C0")]
    public JSON_LeagueMatchResultBeforeFormatter()
    {
    }

    [Token(Token = "0x6002197")]
    [Address(RVA = "0xD482B0", Offset = "0xD470B0", VA = "0x10D482B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchResultBefore value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002198")]
    [Address(RVA = "0xD47F00", Offset = "0xD46D00", VA = "0x10D47F00", Slot = "5")]
    public JSON_LeagueMatchResultBefore Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchResultBefore) null;
    }
  }
}
