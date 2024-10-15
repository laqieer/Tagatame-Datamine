// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchBuffResetDateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F2")]
  public sealed class JSON_LeagueMatchBuffResetDateParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchBuffResetDateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400127C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400127D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E24")]
    [Address(RVA = "0xC28FC0", Offset = "0xC27DC0", VA = "0x10C28FC0")]
    public JSON_LeagueMatchBuffResetDateParamFormatter()
    {
    }

    [Token(Token = "0x6001E25")]
    [Address(RVA = "0xC28EB0", Offset = "0xC27CB0", VA = "0x10C28EB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchBuffResetDateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E26")]
    [Address(RVA = "0xC28BE0", Offset = "0xC279E0", VA = "0x10C28BE0", Slot = "5")]
    public JSON_LeagueMatchBuffResetDateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchBuffResetDateParam) null;
    }
  }
}
