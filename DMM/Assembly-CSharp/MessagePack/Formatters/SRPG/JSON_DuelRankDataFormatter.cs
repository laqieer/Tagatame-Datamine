// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelRankDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009FF")]
  public sealed class JSON_DuelRankDataFormatter : 
    IMessagePackFormatter<JSON_DuelRankData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400188E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400188F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600274B")]
    [Address(RVA = "0xE83130", Offset = "0xE81F30", VA = "0x10E83130")]
    public JSON_DuelRankDataFormatter()
    {
    }

    [Token(Token = "0x600274C")]
    [Address(RVA = "0xE83000", Offset = "0xE81E00", VA = "0x10E83000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelRankData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600274D")]
    [Address(RVA = "0xE82CF0", Offset = "0xE81AF0", VA = "0x10E82CF0", Slot = "5")]
    public JSON_DuelRankData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelRankData) null;
    }
  }
}
