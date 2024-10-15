// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchBuffResetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F3")]
  public sealed class JSON_LeagueMatchBuffResetParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchBuffResetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400127E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400127F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E27")]
    [Address(RVA = "0xC29600", Offset = "0xC28400", VA = "0x10C29600")]
    public JSON_LeagueMatchBuffResetParamFormatter()
    {
    }

    [Token(Token = "0x6001E28")]
    [Address(RVA = "0xC29420", Offset = "0xC28220", VA = "0x10C29420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchBuffResetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E29")]
    [Address(RVA = "0xC290E0", Offset = "0xC27EE0", VA = "0x10C290E0", Slot = "5")]
    public JSON_LeagueMatchBuffResetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchBuffResetParam) null;
    }
  }
}
