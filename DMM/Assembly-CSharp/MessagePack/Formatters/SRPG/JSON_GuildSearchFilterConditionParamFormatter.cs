// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildSearchFilterConditionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000698")]
  public sealed class JSON_GuildSearchFilterConditionParamFormatter : 
    IMessagePackFormatter<JSON_GuildSearchFilterConditionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D16")]
    [Address(RVA = "0xBFE3E0", Offset = "0xBFD1E0", VA = "0x10BFE3E0")]
    public JSON_GuildSearchFilterConditionParamFormatter()
    {
    }

    [Token(Token = "0x6001D17")]
    [Address(RVA = "0xBFE240", Offset = "0xBFD040", VA = "0x10BFE240", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildSearchFilterConditionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D18")]
    [Address(RVA = "0xBFDEC0", Offset = "0xBFCCC0", VA = "0x10BFDEC0", Slot = "5")]
    public JSON_GuildSearchFilterConditionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildSearchFilterConditionParam) null;
    }
  }
}
