// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchSettingParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006FA")]
  public sealed class JSON_LeagueMatchSettingParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchSettingParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400128C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400128D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E3C")]
    [Address(RVA = "0xC2DF50", Offset = "0xC2CD50", VA = "0x10C2DF50")]
    public JSON_LeagueMatchSettingParamFormatter()
    {
    }

    [Token(Token = "0x6001E3D")]
    [Address(RVA = "0xC2DAD0", Offset = "0xC2C8D0", VA = "0x10C2DAD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchSettingParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E3E")]
    [Address(RVA = "0xC2D4A0", Offset = "0xC2C2A0", VA = "0x10C2D4A0", Slot = "5")]
    public JSON_LeagueMatchSettingParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchSettingParam) null;
    }
  }
}
