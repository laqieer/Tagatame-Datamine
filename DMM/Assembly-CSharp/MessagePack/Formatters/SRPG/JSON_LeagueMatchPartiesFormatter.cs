// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchPartiesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000810")]
  public sealed class JSON_LeagueMatchPartiesFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchParties>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600217E")]
    [Address(RVA = "0xD47110", Offset = "0xD45F10", VA = "0x10D47110")]
    public JSON_LeagueMatchPartiesFormatter()
    {
    }

    [Token(Token = "0x600217F")]
    [Address(RVA = "0xD46FE0", Offset = "0xD45DE0", VA = "0x10D46FE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchParties value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002180")]
    [Address(RVA = "0xD46CC0", Offset = "0xD45AC0", VA = "0x10D46CC0", Slot = "5")]
    public JSON_LeagueMatchParties Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchParties) null;
    }
  }
}
