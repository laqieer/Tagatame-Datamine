// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200080D")]
  public sealed class JSON_DuelRewardParamFormatter : 
    IMessagePackFormatter<JSON_DuelRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002175")]
    [Address(RVA = "0xD42A30", Offset = "0xD41830", VA = "0x10D42A30")]
    public JSON_DuelRewardParamFormatter()
    {
    }

    [Token(Token = "0x6002176")]
    [Address(RVA = "0xD42850", Offset = "0xD41650", VA = "0x10D42850", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002177")]
    [Address(RVA = "0xD42510", Offset = "0xD41310", VA = "0x10D42510", Slot = "5")]
    public JSON_DuelRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelRewardParam) null;
    }
  }
}
