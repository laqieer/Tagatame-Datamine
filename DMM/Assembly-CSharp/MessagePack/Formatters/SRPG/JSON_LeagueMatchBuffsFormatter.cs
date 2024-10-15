// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchBuffsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007DA")]
  public sealed class JSON_LeagueMatchBuffsFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchBuffs>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001444")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001445")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020DC")]
    [Address(RVA = "0xD18460", Offset = "0xD17260", VA = "0x10D18460")]
    public JSON_LeagueMatchBuffsFormatter()
    {
    }

    [Token(Token = "0x60020DD")]
    [Address(RVA = "0xD18300", Offset = "0xD17100", VA = "0x10D18300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchBuffs value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020DE")]
    [Address(RVA = "0xD17FB0", Offset = "0xD16DB0", VA = "0x10D17FB0", Slot = "5")]
    public JSON_LeagueMatchBuffs Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchBuffs) null;
    }
  }
}
