// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidCompleteRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200062D")]
  public sealed class JSON_RaidCompleteRewardParamFormatter : 
    IMessagePackFormatter<JSON_RaidCompleteRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BD5")]
    [Address(RVA = "0xBC2430", Offset = "0xBC1230", VA = "0x10BC2430")]
    public JSON_RaidCompleteRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001BD6")]
    [Address(RVA = "0xBC2290", Offset = "0xBC1090", VA = "0x10BC2290", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidCompleteRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BD7")]
    [Address(RVA = "0xBC1F80", Offset = "0xBC0D80", VA = "0x10BC1F80", Slot = "5")]
    public JSON_RaidCompleteRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidCompleteRewardParam) null;
    }
  }
}
