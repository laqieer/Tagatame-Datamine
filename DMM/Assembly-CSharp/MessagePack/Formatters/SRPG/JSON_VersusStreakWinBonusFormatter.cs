// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusStreakWinBonusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A6F")]
  public sealed class JSON_VersusStreakWinBonusFormatter : 
    IMessagePackFormatter<JSON_VersusStreakWinBonus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400196E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400196F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600289B")]
    [Address(RVA = "0xECFC80", Offset = "0xECEA80", VA = "0x10ECFC80")]
    public JSON_VersusStreakWinBonusFormatter()
    {
    }

    [Token(Token = "0x600289C")]
    [Address(RVA = "0xECFAA0", Offset = "0xECE8A0", VA = "0x10ECFAA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusStreakWinBonus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600289D")]
    [Address(RVA = "0xECF750", Offset = "0xECE550", VA = "0x10ECF750", Slot = "5")]
    public JSON_VersusStreakWinBonus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusStreakWinBonus) null;
    }
  }
}
