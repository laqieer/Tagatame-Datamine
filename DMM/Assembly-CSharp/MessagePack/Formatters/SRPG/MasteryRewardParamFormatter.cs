// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MasteryRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000917")]
  public sealed class MasteryRewardParamFormatter : 
    IMessagePackFormatter<MasteryRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002493")]
    [Address(RVA = "0xE03D20", Offset = "0xE02B20", VA = "0x10E03D20")]
    public MasteryRewardParamFormatter()
    {
    }

    [Token(Token = "0x6002494")]
    [Address(RVA = "0xE03A70", Offset = "0xE02870", VA = "0x10E03A70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MasteryRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002495")]
    [Address(RVA = "0xE03670", Offset = "0xE02470", VA = "0x10E03670", Slot = "5")]
    public MasteryRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MasteryRewardParam) null;
    }
  }
}
