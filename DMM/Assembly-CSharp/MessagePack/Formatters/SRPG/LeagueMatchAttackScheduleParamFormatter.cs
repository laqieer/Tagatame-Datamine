// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchAttackScheduleParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B16")]
  public sealed class LeagueMatchAttackScheduleParamFormatter : 
    IMessagePackFormatter<LeagueMatchAttackScheduleParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ABC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ABD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A90")]
    [Address(RVA = "0xF3DA90", Offset = "0xF3C890", VA = "0x10F3DA90")]
    public LeagueMatchAttackScheduleParamFormatter()
    {
    }

    [Token(Token = "0x6002A91")]
    [Address(RVA = "0xF3D930", Offset = "0xF3C730", VA = "0x10F3D930", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchAttackScheduleParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A92")]
    [Address(RVA = "0xF3D670", Offset = "0xF3C470", VA = "0x10F3D670", Slot = "5")]
    public LeagueMatchAttackScheduleParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchAttackScheduleParam) null;
    }
  }
}
