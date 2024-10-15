// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidPeriodTimeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200061F")]
  public sealed class JSON_RaidPeriodTimeParamFormatter : 
    IMessagePackFormatter<JSON_RaidPeriodTimeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BAB")]
    [Address(RVA = "0xBC53D0", Offset = "0xBC41D0", VA = "0x10BC53D0")]
    public JSON_RaidPeriodTimeParamFormatter()
    {
    }

    [Token(Token = "0x6001BAC")]
    [Address(RVA = "0xBC5120", Offset = "0xBC3F20", VA = "0x10BC5120", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidPeriodTimeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BAD")]
    [Address(RVA = "0xBC4D20", Offset = "0xBC3B20", VA = "0x10BC4D20", Slot = "5")]
    public JSON_RaidPeriodTimeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidPeriodTimeParam) null;
    }
  }
}
