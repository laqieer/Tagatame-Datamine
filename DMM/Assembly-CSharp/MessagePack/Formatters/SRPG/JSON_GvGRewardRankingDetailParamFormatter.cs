// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGRewardRankingDetailParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200095D")]
  public sealed class JSON_GvGRewardRankingDetailParamFormatter : 
    IMessagePackFormatter<JSON_GvGRewardRankingDetailParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400174A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400174B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002565")]
    [Address(RVA = "0xE15680", Offset = "0xE14480", VA = "0x10E15680")]
    public JSON_GvGRewardRankingDetailParamFormatter()
    {
    }

    [Token(Token = "0x6002566")]
    [Address(RVA = "0xE15550", Offset = "0xE14350", VA = "0x10E15550", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGRewardRankingDetailParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002567")]
    [Address(RVA = "0xE15240", Offset = "0xE14040", VA = "0x10E15240", Slot = "5")]
    public JSON_GvGRewardRankingDetailParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGRewardRankingDetailParam) null;
    }
  }
}
