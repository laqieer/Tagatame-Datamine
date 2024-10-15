// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBattlePointFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E2")]
  public sealed class JSON_WorldRaidBattlePointFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBattlePoint>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001454")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001455")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020F4")]
    [Address(RVA = "0xD35460", Offset = "0xD34260", VA = "0x10D35460")]
    public JSON_WorldRaidBattlePointFormatter()
    {
    }

    [Token(Token = "0x60020F5")]
    [Address(RVA = "0xD35330", Offset = "0xD34130", VA = "0x10D35330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBattlePoint value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020F6")]
    [Address(RVA = "0xD35010", Offset = "0xD33E10", VA = "0x10D35010", Slot = "5")]
    public JSON_WorldRaidBattlePoint Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBattlePoint) null;
    }
  }
}
