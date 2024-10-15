// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidBattleRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000623")]
  public sealed class JSON_RaidBattleRewardParamFormatter : 
    IMessagePackFormatter<JSON_RaidBattleRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BB7")]
    [Address(RVA = "0xBBF360", Offset = "0xBBE160", VA = "0x10BBF360")]
    public JSON_RaidBattleRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001BB8")]
    [Address(RVA = "0xBBF1C0", Offset = "0xBBDFC0", VA = "0x10BBF1C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidBattleRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BB9")]
    [Address(RVA = "0xBBEEB0", Offset = "0xBBDCB0", VA = "0x10BBEEB0", Slot = "5")]
    public JSON_RaidBattleRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidBattleRewardParam) null;
    }
  }
}
