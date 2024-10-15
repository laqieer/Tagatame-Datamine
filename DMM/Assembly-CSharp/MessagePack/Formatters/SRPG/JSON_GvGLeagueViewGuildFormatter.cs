// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGLeagueViewGuildFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005CE")]
  public sealed class JSON_GvGLeagueViewGuildFormatter : 
    IMessagePackFormatter<JSON_GvGLeagueViewGuild>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001034")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001035")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AB8")]
    [Address(RVA = "0x952140", Offset = "0x950F40", VA = "0x10952140")]
    public JSON_GvGLeagueViewGuildFormatter()
    {
    }

    [Token(Token = "0x6001AB9")]
    [Address(RVA = "0x951E10", Offset = "0x950C10", VA = "0x10951E10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGLeagueViewGuild value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ABA")]
    [Address(RVA = "0x951910", Offset = "0x950710", VA = "0x10951910", Slot = "5")]
    public JSON_GvGLeagueViewGuild Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGLeagueViewGuild) null;
    }
  }
}
