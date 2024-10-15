// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelBattleResultDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A01")]
  public sealed class JSON_DuelBattleResultDataFormatter : 
    IMessagePackFormatter<JSON_DuelBattleResultData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001892")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001893")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002751")]
    [Address(RVA = "0xE828E0", Offset = "0xE816E0", VA = "0x10E828E0")]
    public JSON_DuelBattleResultDataFormatter()
    {
    }

    [Token(Token = "0x6002752")]
    [Address(RVA = "0xE825B0", Offset = "0xE813B0", VA = "0x10E825B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelBattleResultData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002753")]
    [Address(RVA = "0xE82120", Offset = "0xE80F20", VA = "0x10E82120", Slot = "5")]
    public JSON_DuelBattleResultData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelBattleResultData) null;
    }
  }
}
