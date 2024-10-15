// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MasteryRewardStatusDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D5")]
  public sealed class JSON_MasteryRewardStatusDataFormatter : 
    IMessagePackFormatter<JSON_MasteryRewardStatusData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400143A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400143B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020CD")]
    [Address(RVA = "0xD1A440", Offset = "0xD19240", VA = "0x10D1A440")]
    public JSON_MasteryRewardStatusDataFormatter()
    {
    }

    [Token(Token = "0x60020CE")]
    [Address(RVA = "0xD1A310", Offset = "0xD19110", VA = "0x10D1A310", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MasteryRewardStatusData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020CF")]
    [Address(RVA = "0xD1A000", Offset = "0xD18E00", VA = "0x10D1A000", Slot = "5")]
    public JSON_MasteryRewardStatusData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MasteryRewardStatusData) null;
    }
  }
}
