// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidBeatRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000625")]
  public sealed class JSON_RaidBeatRewardParamFormatter : 
    IMessagePackFormatter<JSON_RaidBeatRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010E2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010E3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BBD")]
    [Address(RVA = "0xBC0510", Offset = "0xBBF310", VA = "0x10BC0510")]
    public JSON_RaidBeatRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001BBE")]
    [Address(RVA = "0xBC0370", Offset = "0xBBF170", VA = "0x10BC0370", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidBeatRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BBF")]
    [Address(RVA = "0xBC0060", Offset = "0xBBEE60", VA = "0x10BC0060", Slot = "5")]
    public JSON_RaidBeatRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidBeatRewardParam) null;
    }
  }
}
