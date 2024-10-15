// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusStreakWinScheduleFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A59")]
  public sealed class JSON_VersusStreakWinScheduleFormatter : 
    IMessagePackFormatter<JSON_VersusStreakWinSchedule>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001942")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001943")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002859")]
    [Address(RVA = "0xED03D0", Offset = "0xECF1D0", VA = "0x10ED03D0")]
    public JSON_VersusStreakWinScheduleFormatter()
    {
    }

    [Token(Token = "0x600285A")]
    [Address(RVA = "0xED0210", Offset = "0xECF010", VA = "0x10ED0210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusStreakWinSchedule value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600285B")]
    [Address(RVA = "0xECFE70", Offset = "0xECEC70", VA = "0x10ECFE70", Slot = "5")]
    public JSON_VersusStreakWinSchedule Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusStreakWinSchedule) null;
    }
  }
}
