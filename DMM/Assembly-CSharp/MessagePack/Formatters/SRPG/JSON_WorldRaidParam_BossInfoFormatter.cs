// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidParam_BossInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000974")]
  public sealed class JSON_WorldRaidParam_BossInfoFormatter : 
    IMessagePackFormatter<JSON_WorldRaidParam.BossInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001778")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001779")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025AA")]
    [Address(RVA = "0xE30C20", Offset = "0xE2FA20", VA = "0x10E30C20")]
    public JSON_WorldRaidParam_BossInfoFormatter()
    {
    }

    [Token(Token = "0x60025AB")]
    [Address(RVA = "0xE308F0", Offset = "0xE2F6F0", VA = "0x10E308F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidParam.BossInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025AC")]
    [Address(RVA = "0xE30410", Offset = "0xE2F210", VA = "0x10E30410", Slot = "5")]
    public JSON_WorldRaidParam.BossInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidParam.BossInfo) null;
    }
  }
}
