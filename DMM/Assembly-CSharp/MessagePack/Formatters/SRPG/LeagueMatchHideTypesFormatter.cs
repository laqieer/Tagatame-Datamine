// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchHideTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000597")]
  public sealed class LeagueMatchHideTypesFormatter : 
    IMessagePackFormatter<LeagueMatchHideTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001A13")]
    [Address(RVA = "0x7A3DA0", Offset = "0x7A2BA0", VA = "0x107A3DA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchHideTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A14")]
    [Address(RVA = "0x7A3D50", Offset = "0x7A2B50", VA = "0x107A3D50", Slot = "5")]
    public LeagueMatchHideTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new LeagueMatchHideTypes();
    }

    [Token(Token = "0x6001A15")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchHideTypesFormatter()
    {
    }
  }
}
