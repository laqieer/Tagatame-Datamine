// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ELeagueMatchBuffTargetFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000591")]
  public sealed class ELeagueMatchBuffTargetFormatter : 
    IMessagePackFormatter<ELeagueMatchBuffTarget>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001A01")]
    [Address(RVA = "0x78DDD0", Offset = "0x78CBD0", VA = "0x1078DDD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ELeagueMatchBuffTarget value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A02")]
    [Address(RVA = "0x78DD80", Offset = "0x78CB80", VA = "0x1078DD80", Slot = "5")]
    public ELeagueMatchBuffTarget Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ELeagueMatchBuffTarget();
    }

    [Token(Token = "0x6001A03")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ELeagueMatchBuffTargetFormatter()
    {
    }
  }
}
