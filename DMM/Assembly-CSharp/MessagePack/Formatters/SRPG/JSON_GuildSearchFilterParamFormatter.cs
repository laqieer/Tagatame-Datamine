// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildSearchFilterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000699")]
  public sealed class JSON_GuildSearchFilterParamFormatter : 
    IMessagePackFormatter<JSON_GuildSearchFilterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D19")]
    [Address(RVA = "0xBFEB70", Offset = "0xBFD970", VA = "0x10BFEB70")]
    public JSON_GuildSearchFilterParamFormatter()
    {
    }

    [Token(Token = "0x6001D1A")]
    [Address(RVA = "0xBFE990", Offset = "0xBFD790", VA = "0x10BFE990", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildSearchFilterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D1B")]
    [Address(RVA = "0xBFE640", Offset = "0xBFD440", VA = "0x10BFE640", Slot = "5")]
    public JSON_GuildSearchFilterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildSearchFilterParam) null;
    }
  }
}
