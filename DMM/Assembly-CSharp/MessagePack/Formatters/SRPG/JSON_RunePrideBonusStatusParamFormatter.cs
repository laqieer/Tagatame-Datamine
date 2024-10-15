// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideBonusStatusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E6")]
  public sealed class JSON_RunePrideBonusStatusParamFormatter : 
    IMessagePackFormatter<JSON_RunePrideBonusStatusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001264")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001265")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E00")]
    [Address(RVA = "0xC2FE50", Offset = "0xC2EC50", VA = "0x10C2FE50")]
    public JSON_RunePrideBonusStatusParamFormatter()
    {
    }

    [Token(Token = "0x6001E01")]
    [Address(RVA = "0xC2FC70", Offset = "0xC2EA70", VA = "0x10C2FC70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideBonusStatusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E02")]
    [Address(RVA = "0xC2F930", Offset = "0xC2E730", VA = "0x10C2F930", Slot = "5")]
    public JSON_RunePrideBonusStatusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideBonusStatusParam) null;
    }
  }
}
