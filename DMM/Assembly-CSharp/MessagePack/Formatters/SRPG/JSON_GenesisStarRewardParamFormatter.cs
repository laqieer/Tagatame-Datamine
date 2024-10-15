// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisStarRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C5")]
  public sealed class JSON_GenesisStarRewardParamFormatter : 
    IMessagePackFormatter<JSON_GenesisStarRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400161A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400161B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600239D")]
    [Address(RVA = "0xDD15A0", Offset = "0xDD03A0", VA = "0x10DD15A0")]
    public JSON_GenesisStarRewardParamFormatter()
    {
    }

    [Token(Token = "0x600239E")]
    [Address(RVA = "0xDD1470", Offset = "0xDD0270", VA = "0x10DD1470", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisStarRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600239F")]
    [Address(RVA = "0xDD1160", Offset = "0xDCFF60", VA = "0x10DD1160", Slot = "5")]
    public JSON_GenesisStarRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisStarRewardParam) null;
    }
  }
}
