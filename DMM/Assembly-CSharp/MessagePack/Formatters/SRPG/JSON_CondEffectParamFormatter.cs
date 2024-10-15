// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CondEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005DC")]
  public sealed class JSON_CondEffectParamFormatter : 
    IMessagePackFormatter<JSON_CondEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001050")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001051")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AE2")]
    [Address(RVA = "0xB3CF90", Offset = "0xB3BD90", VA = "0x10B3CF90")]
    public JSON_CondEffectParamFormatter()
    {
    }

    [Token(Token = "0x6001AE3")]
    [Address(RVA = "0xB3C4A0", Offset = "0xB3B2A0", VA = "0x10B3C4A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CondEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AE4")]
    [Address(RVA = "0xB3B7B0", Offset = "0xB3A5B0", VA = "0x10B3B7B0", Slot = "5")]
    public JSON_CondEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CondEffectParam) null;
    }
  }
}
