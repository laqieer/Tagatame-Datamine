// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RankingQuestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008CA")]
  public sealed class JSON_RankingQuestParamFormatter : 
    IMessagePackFormatter<JSON_RankingQuestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001624")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001625")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023AC")]
    [Address(RVA = "0xDD48C0", Offset = "0xDD36C0", VA = "0x10DD48C0")]
    public JSON_RankingQuestParamFormatter()
    {
    }

    [Token(Token = "0x60023AD")]
    [Address(RVA = "0xDD4720", Offset = "0xDD3520", VA = "0x10DD4720", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RankingQuestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023AE")]
    [Address(RVA = "0xDD43A0", Offset = "0xDD31A0", VA = "0x10DD43A0", Slot = "5")]
    public JSON_RankingQuestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RankingQuestParam) null;
    }
  }
}
