// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraLearnAbilityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000607")]
  public sealed class JSON_TobiraLearnAbilityParamFormatter : 
    IMessagePackFormatter<JSON_TobiraLearnAbilityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010A6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B63")]
    [Address(RVA = "0xBAC410", Offset = "0xBAB210", VA = "0x10BAC410")]
    public JSON_TobiraLearnAbilityParamFormatter()
    {
    }

    [Token(Token = "0x6001B64")]
    [Address(RVA = "0xBAC1F0", Offset = "0xBAAFF0", VA = "0x10BAC1F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraLearnAbilityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B65")]
    [Address(RVA = "0xBABE10", Offset = "0xBAAC10", VA = "0x10BABE10", Slot = "5")]
    public JSON_TobiraLearnAbilityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraLearnAbilityParam) null;
    }
  }
}
