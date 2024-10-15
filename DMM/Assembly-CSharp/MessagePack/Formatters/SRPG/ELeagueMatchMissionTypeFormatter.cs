// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ELeagueMatchMissionTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000594")]
  public sealed class ELeagueMatchMissionTypeFormatter : 
    IMessagePackFormatter<ELeagueMatchMissionType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001A0A")]
    [Address(RVA = "0x78DE70", Offset = "0x78CC70", VA = "0x1078DE70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ELeagueMatchMissionType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A0B")]
    [Address(RVA = "0x78DE20", Offset = "0x78CC20", VA = "0x1078DE20", Slot = "5")]
    public ELeagueMatchMissionType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ELeagueMatchMissionType();
    }

    [Token(Token = "0x6001A0C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ELeagueMatchMissionTypeFormatter()
    {
    }
  }
}
