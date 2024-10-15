// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankMissionScheduleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B5")]
  public sealed class JSON_VersusRankMissionScheduleParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankMissionScheduleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600266D")]
    [Address(RVA = "0xE3B2D0", Offset = "0xE3A0D0", VA = "0x10E3B2D0")]
    public JSON_VersusRankMissionScheduleParamFormatter()
    {
    }

    [Token(Token = "0x600266E")]
    [Address(RVA = "0xE3B1A0", Offset = "0xE39FA0", VA = "0x10E3B1A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankMissionScheduleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600266F")]
    [Address(RVA = "0xE3AE90", Offset = "0xE39C90", VA = "0x10E3AE90", Slot = "5")]
    public JSON_VersusRankMissionScheduleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankMissionScheduleParam) null;
    }
  }
}
