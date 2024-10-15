// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TowerScoreThresholdFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005FF")]
  public sealed class JSON_TowerScoreThresholdFormatter : 
    IMessagePackFormatter<JSON_TowerScoreThreshold>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001096")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001097")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B4B")]
    [Address(RVA = "0xBAF1A0", Offset = "0xBADFA0", VA = "0x10BAF1A0")]
    public JSON_TowerScoreThresholdFormatter()
    {
    }

    [Token(Token = "0x6001B4C")]
    [Address(RVA = "0xBAEF90", Offset = "0xBADD90", VA = "0x10BAEF90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TowerScoreThreshold value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B4D")]
    [Address(RVA = "0xBAEBA0", Offset = "0xBAD9A0", VA = "0x10BAEBA0", Slot = "5")]
    public JSON_TowerScoreThreshold Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TowerScoreThreshold) null;
    }
  }
}
