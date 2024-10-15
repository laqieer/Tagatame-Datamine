// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchAttackScheduleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F8")]
  public sealed class JSON_LeagueMatchAttackScheduleParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchAttackScheduleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001288")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001289")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E36")]
    [Address(RVA = "0xC283C0", Offset = "0xC271C0", VA = "0x10C283C0")]
    public JSON_LeagueMatchAttackScheduleParamFormatter()
    {
    }

    [Token(Token = "0x6001E37")]
    [Address(RVA = "0xC28270", Offset = "0xC27070", VA = "0x10C28270", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchAttackScheduleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E38")]
    [Address(RVA = "0xC27F40", Offset = "0xC26D40", VA = "0x10C27F40", Slot = "5")]
    public JSON_LeagueMatchAttackScheduleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchAttackScheduleParam) null;
    }
  }
}
