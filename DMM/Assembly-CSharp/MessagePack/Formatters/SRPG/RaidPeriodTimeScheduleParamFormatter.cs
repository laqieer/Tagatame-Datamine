// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RaidPeriodTimeScheduleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A6C")]
  public sealed class RaidPeriodTimeScheduleParamFormatter : 
    IMessagePackFormatter<RaidPeriodTimeScheduleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001968")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001969")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002892")]
    [Address(RVA = "0xED16C0", Offset = "0xED04C0", VA = "0x10ED16C0")]
    public RaidPeriodTimeScheduleParamFormatter()
    {
    }

    [Token(Token = "0x6002893")]
    [Address(RVA = "0xED1570", Offset = "0xED0370", VA = "0x10ED1570", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RaidPeriodTimeScheduleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002894")]
    [Address(RVA = "0xED12B0", Offset = "0xED00B0", VA = "0x10ED12B0", Slot = "5")]
    public RaidPeriodTimeScheduleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RaidPeriodTimeScheduleParam) null;
    }
  }
}
