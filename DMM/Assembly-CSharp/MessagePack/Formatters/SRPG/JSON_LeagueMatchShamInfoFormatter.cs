// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchShamInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000819")]
  public sealed class JSON_LeagueMatchShamInfoFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchShamInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002199")]
    [Address(RVA = "0xD49B70", Offset = "0xD48970", VA = "0x10D49B70")]
    public JSON_LeagueMatchShamInfoFormatter()
    {
    }

    [Token(Token = "0x600219A")]
    [Address(RVA = "0xD497C0", Offset = "0xD485C0", VA = "0x10D497C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchShamInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600219B")]
    [Address(RVA = "0xD492E0", Offset = "0xD480E0", VA = "0x10D492E0", Slot = "5")]
    public JSON_LeagueMatchShamInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchShamInfo) null;
    }
  }
}
