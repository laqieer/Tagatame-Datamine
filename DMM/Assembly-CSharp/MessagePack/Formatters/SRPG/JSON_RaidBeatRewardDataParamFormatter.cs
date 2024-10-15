// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidBeatRewardDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000624")]
  public sealed class JSON_RaidBeatRewardDataParamFormatter : 
    IMessagePackFormatter<JSON_RaidBeatRewardDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BBA")]
    [Address(RVA = "0xBBFEE0", Offset = "0xBBECE0", VA = "0x10BBFEE0")]
    public JSON_RaidBeatRewardDataParamFormatter()
    {
    }

    [Token(Token = "0x6001BBB")]
    [Address(RVA = "0xBBFDB0", Offset = "0xBBEBB0", VA = "0x10BBFDB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidBeatRewardDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BBC")]
    [Address(RVA = "0xBBFAA0", Offset = "0xBBE8A0", VA = "0x10BBFAA0", Slot = "5")]
    public JSON_RaidBeatRewardDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidBeatRewardDataParam) null;
    }
  }
}
