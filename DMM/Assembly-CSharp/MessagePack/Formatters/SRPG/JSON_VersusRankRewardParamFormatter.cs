// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A1E")]
  public sealed class JSON_VersusRankRewardParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027A8")]
    [Address(RVA = "0xEA3960", Offset = "0xEA2760", VA = "0x10EA3960")]
    public JSON_VersusRankRewardParamFormatter()
    {
    }

    [Token(Token = "0x60027A9")]
    [Address(RVA = "0xEA3780", Offset = "0xEA2580", VA = "0x10EA3780", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027AA")]
    [Address(RVA = "0xEA3440", Offset = "0xEA2240", VA = "0x10EA3440", Slot = "5")]
    public JSON_VersusRankRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankRewardParam) null;
    }
  }
}
