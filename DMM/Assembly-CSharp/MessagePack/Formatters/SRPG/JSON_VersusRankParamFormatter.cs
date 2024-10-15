// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A6A")]
  public sealed class JSON_VersusRankParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001964")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001965")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600288C")]
    [Address(RVA = "0xECE9C0", Offset = "0xECD7C0", VA = "0x10ECE9C0")]
    public JSON_VersusRankParamFormatter()
    {
    }

    [Token(Token = "0x600288D")]
    [Address(RVA = "0xECE6A0", Offset = "0xECD4A0", VA = "0x10ECE6A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600288E")]
    [Address(RVA = "0xECE1C0", Offset = "0xECCFC0", VA = "0x10ECE1C0", Slot = "5")]
    public JSON_VersusRankParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankParam) null;
    }
  }
}
