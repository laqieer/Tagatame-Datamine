// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_DuelBattleRecodeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A02")]
  public sealed class Json_DuelBattleRecodeFormatter : 
    IMessagePackFormatter<Json_DuelBattleRecode>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001894")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001895")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002754")]
    [Address(RVA = "0xEA5310", Offset = "0xEA4110", VA = "0x10EA5310")]
    public Json_DuelBattleRecodeFormatter()
    {
    }

    [Token(Token = "0x6002755")]
    [Address(RVA = "0xEA51E0", Offset = "0xEA3FE0", VA = "0x10EA51E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_DuelBattleRecode value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002756")]
    [Address(RVA = "0xEA4EC0", Offset = "0xEA3CC0", VA = "0x10EA4EC0", Slot = "5")]
    public Json_DuelBattleRecode Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_DuelBattleRecode) null;
    }
  }
}
