// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TrophyParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F0")]
  public sealed class JSON_TrophyParamFormatter : 
    IMessagePackFormatter<JSON_TrophyParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001078")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001079")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B1E")]
    [Address(RVA = "0xB9E940", Offset = "0xB9D740", VA = "0x10B9E940")]
    public JSON_TrophyParamFormatter()
    {
    }

    [Token(Token = "0x6001B1F")]
    [Address(RVA = "0xB9DE90", Offset = "0xB9CC90", VA = "0x10B9DE90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TrophyParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B20")]
    [Address(RVA = "0xB9D250", Offset = "0xB9C050", VA = "0x10B9D250", Slot = "5")]
    public JSON_TrophyParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TrophyParam) null;
    }
  }
}
