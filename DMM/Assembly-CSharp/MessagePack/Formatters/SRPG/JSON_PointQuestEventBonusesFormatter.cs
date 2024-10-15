// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestEventBonusesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A92")]
  public sealed class JSON_PointQuestEventBonusesFormatter : 
    IMessagePackFormatter<JSON_PointQuestEventBonuses>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002904")]
    [Address(RVA = "0xEE38F0", Offset = "0xEE26F0", VA = "0x10EE38F0")]
    public JSON_PointQuestEventBonusesFormatter()
    {
    }

    [Token(Token = "0x6002905")]
    [Address(RVA = "0xEE3790", Offset = "0xEE2590", VA = "0x10EE3790", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestEventBonuses value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002906")]
    [Address(RVA = "0xEE3440", Offset = "0xEE2240", VA = "0x10EE3440", Slot = "5")]
    public JSON_PointQuestEventBonuses Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestEventBonuses) null;
    }
  }
}
