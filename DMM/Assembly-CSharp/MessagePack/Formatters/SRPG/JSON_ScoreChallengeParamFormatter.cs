// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ScoreChallengeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000977")]
  public sealed class JSON_ScoreChallengeParamFormatter : 
    IMessagePackFormatter<JSON_ScoreChallengeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400177E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400177F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025B3")]
    [Address(RVA = "0xE2AF40", Offset = "0xE29D40", VA = "0x10E2AF40")]
    public JSON_ScoreChallengeParamFormatter()
    {
    }

    [Token(Token = "0x60025B4")]
    [Address(RVA = "0xE2AD80", Offset = "0xE29B80", VA = "0x10E2AD80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ScoreChallengeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025B5")]
    [Address(RVA = "0xE2A9F0", Offset = "0xE297F0", VA = "0x10E2A9F0", Slot = "5")]
    public JSON_ScoreChallengeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ScoreChallengeParam) null;
    }
  }
}
