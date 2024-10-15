// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidPeriodTimeScheduleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200061E")]
  public sealed class JSON_RaidPeriodTimeScheduleParamFormatter : 
    IMessagePackFormatter<JSON_RaidPeriodTimeScheduleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BA8")]
    [Address(RVA = "0xBC5B20", Offset = "0xBC4920", VA = "0x10BC5B20")]
    public JSON_RaidPeriodTimeScheduleParamFormatter()
    {
    }

    [Token(Token = "0x6001BA9")]
    [Address(RVA = "0xBC59D0", Offset = "0xBC47D0", VA = "0x10BC59D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidPeriodTimeScheduleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BAA")]
    [Address(RVA = "0xBC56A0", Offset = "0xBC44A0", VA = "0x10BC56A0", Slot = "5")]
    public JSON_RaidPeriodTimeScheduleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidPeriodTimeScheduleParam) null;
    }
  }
}
