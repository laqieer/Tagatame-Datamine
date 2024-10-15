// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchSettingParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A9B")]
  public sealed class LeagueMatchSettingParamFormatter : 
    IMessagePackFormatter<LeagueMatchSettingParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019C6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019C7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600291F")]
    [Address(RVA = "0xEFC830", Offset = "0xEFB630", VA = "0x10EFC830")]
    public LeagueMatchSettingParamFormatter()
    {
    }

    [Token(Token = "0x6002920")]
    [Address(RVA = "0xEFBDB0", Offset = "0xEFABB0", VA = "0x10EFBDB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchSettingParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002921")]
    [Address(RVA = "0xEFB620", Offset = "0xEFA420", VA = "0x10EFB620", Slot = "5")]
    public LeagueMatchSettingParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchSettingParam) null;
    }
  }
}
