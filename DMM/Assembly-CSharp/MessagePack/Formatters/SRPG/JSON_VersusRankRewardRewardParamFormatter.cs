// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankRewardRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A1D")]
  public sealed class JSON_VersusRankRewardRewardParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankRewardRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027A5")]
    [Address(RVA = "0xEA3F90", Offset = "0xEA2D90", VA = "0x10EA3F90")]
    public JSON_VersusRankRewardRewardParamFormatter()
    {
    }

    [Token(Token = "0x60027A6")]
    [Address(RVA = "0xEA3E30", Offset = "0xEA2C30", VA = "0x10EA3E30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankRewardRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027A7")]
    [Address(RVA = "0xEA3AE0", Offset = "0xEA28E0", VA = "0x10EA3AE0", Slot = "5")]
    public JSON_VersusRankRewardRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankRewardRewardParam) null;
    }
  }
}
