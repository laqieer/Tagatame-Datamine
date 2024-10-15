// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchEnemiesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200081E")]
  public sealed class JSON_LeagueMatchEnemiesFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchEnemies>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021A8")]
    [Address(RVA = "0xD44CF0", Offset = "0xD43AF0", VA = "0x10D44CF0")]
    public JSON_LeagueMatchEnemiesFormatter()
    {
    }

    [Token(Token = "0x60021A9")]
    [Address(RVA = "0xD44740", Offset = "0xD43540", VA = "0x10D44740", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchEnemies value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021AA")]
    [Address(RVA = "0xD440D0", Offset = "0xD42ED0", VA = "0x10D440D0", Slot = "5")]
    public JSON_LeagueMatchEnemies Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchEnemies) null;
    }
  }
}
