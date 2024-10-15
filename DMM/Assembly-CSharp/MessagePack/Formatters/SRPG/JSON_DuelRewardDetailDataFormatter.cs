// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelRewardDetailDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009FE")]
  public sealed class JSON_DuelRewardDetailDataFormatter : 
    IMessagePackFormatter<JSON_DuelRewardDetailData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400188C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400188D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002748")]
    [Address(RVA = "0xE84080", Offset = "0xE82E80", VA = "0x10E84080")]
    public JSON_DuelRewardDetailDataFormatter()
    {
    }

    [Token(Token = "0x6002749")]
    [Address(RVA = "0xE83E80", Offset = "0xE82C80", VA = "0x10E83E80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelRewardDetailData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600274A")]
    [Address(RVA = "0xE83AB0", Offset = "0xE828B0", VA = "0x10E83AB0", Slot = "5")]
    public JSON_DuelRewardDetailData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelRewardDetailData) null;
    }
  }
}
