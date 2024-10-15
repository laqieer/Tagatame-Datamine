// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePridePotentialStatusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E9")]
  public sealed class JSON_RunePridePotentialStatusParamFormatter : 
    IMessagePackFormatter<JSON_RunePridePotentialStatusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400126A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400126B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E09")]
    [Address(RVA = "0xC34DB0", Offset = "0xC33BB0", VA = "0x10C34DB0")]
    public JSON_RunePridePotentialStatusParamFormatter()
    {
    }

    [Token(Token = "0x6001E0A")]
    [Address(RVA = "0xC34B70", Offset = "0xC33970", VA = "0x10C34B70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePridePotentialStatusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E0B")]
    [Address(RVA = "0xC347D0", Offset = "0xC335D0", VA = "0x10C347D0", Slot = "5")]
    public JSON_RunePridePotentialStatusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePridePotentialStatusParam) null;
    }
  }
}
