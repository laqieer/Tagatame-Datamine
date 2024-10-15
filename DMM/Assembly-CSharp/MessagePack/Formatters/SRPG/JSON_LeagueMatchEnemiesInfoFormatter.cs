// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchEnemiesInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200081D")]
  public sealed class JSON_LeagueMatchEnemiesInfoFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchEnemiesInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021A5")]
    [Address(RVA = "0xD45690", Offset = "0xD44490", VA = "0x10D45690")]
    public JSON_LeagueMatchEnemiesInfoFormatter()
    {
    }

    [Token(Token = "0x60021A6")]
    [Address(RVA = "0xD45590", Offset = "0xD44390", VA = "0x10D45590", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchEnemiesInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021A7")]
    [Address(RVA = "0xD452B0", Offset = "0xD440B0", VA = "0x10D452B0", Slot = "5")]
    public JSON_LeagueMatchEnemiesInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchEnemiesInfo) null;
    }
  }
}
