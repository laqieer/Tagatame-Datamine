// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchDefenseInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007DD")]
  public sealed class JSON_LeagueMatchDefenseInfoFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchDefenseInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400144A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400144B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020E5")]
    [Address(RVA = "0xD18D60", Offset = "0xD17B60", VA = "0x10D18D60")]
    public JSON_LeagueMatchDefenseInfoFormatter()
    {
    }

    [Token(Token = "0x60020E6")]
    [Address(RVA = "0xD18A20", Offset = "0xD17820", VA = "0x10D18A20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchDefenseInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020E7")]
    [Address(RVA = "0xD18650", Offset = "0xD17450", VA = "0x10D18650", Slot = "5")]
    public JSON_LeagueMatchDefenseInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchDefenseInfo) null;
    }
  }
}
