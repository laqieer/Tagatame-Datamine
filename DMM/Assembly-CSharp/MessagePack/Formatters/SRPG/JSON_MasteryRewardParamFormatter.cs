// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MasteryRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C1")]
  public sealed class JSON_MasteryRewardParamFormatter : 
    IMessagePackFormatter<JSON_MasteryRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400121A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400121B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D91")]
    [Address(RVA = "0xC17740", Offset = "0xC16540", VA = "0x10C17740")]
    public JSON_MasteryRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001D92")]
    [Address(RVA = "0xC17490", Offset = "0xC16290", VA = "0x10C17490", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MasteryRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D93")]
    [Address(RVA = "0xC17090", Offset = "0xC15E90", VA = "0x10C17090", Slot = "5")]
    public JSON_MasteryRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MasteryRewardParam) null;
    }
  }
}
