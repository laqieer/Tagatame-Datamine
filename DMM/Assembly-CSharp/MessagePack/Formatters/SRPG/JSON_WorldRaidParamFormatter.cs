// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000975")]
  public sealed class JSON_WorldRaidParamFormatter : 
    IMessagePackFormatter<JSON_WorldRaidParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400177A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400177B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025AD")]
    [Address(RVA = "0xE2FD10", Offset = "0xE2EB10", VA = "0x10E2FD10")]
    public JSON_WorldRaidParamFormatter()
    {
    }

    [Token(Token = "0x60025AE")]
    [Address(RVA = "0xE2F6F0", Offset = "0xE2E4F0", VA = "0x10E2F6F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025AF")]
    [Address(RVA = "0xE2EFC0", Offset = "0xE2DDC0", VA = "0x10E2EFC0", Slot = "5")]
    public JSON_WorldRaidParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidParam) null;
    }
  }
}
