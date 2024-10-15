// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200092F")]
  public sealed class LeagueMatchBuffParamFormatter : 
    IMessagePackFormatter<LeagueMatchBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024DB")]
    [Address(RVA = "0xE02270", Offset = "0xE01070", VA = "0x10E02270")]
    public LeagueMatchBuffParamFormatter()
    {
    }

    [Token(Token = "0x60024DC")]
    [Address(RVA = "0xE02090", Offset = "0xE00E90", VA = "0x10E02090", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024DD")]
    [Address(RVA = "0xE01D80", Offset = "0xE00B80", VA = "0x10E01D80", Slot = "5")]
    public LeagueMatchBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchBuffParam) null;
    }
  }
}
