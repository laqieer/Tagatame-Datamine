// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchDefenseFixInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200080F")]
  public sealed class JSON_LeagueMatchDefenseFixInfoFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchDefenseFixInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600217B")]
    [Address(RVA = "0xD43F50", Offset = "0xD42D50", VA = "0x10D43F50")]
    public JSON_LeagueMatchDefenseFixInfoFormatter()
    {
    }

    [Token(Token = "0x600217C")]
    [Address(RVA = "0xD43DF0", Offset = "0xD42BF0", VA = "0x10D43DF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchDefenseFixInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600217D")]
    [Address(RVA = "0xD43AB0", Offset = "0xD428B0", VA = "0x10D43AB0", Slot = "5")]
    public JSON_LeagueMatchDefenseFixInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchDefenseFixInfo) null;
    }
  }
}
