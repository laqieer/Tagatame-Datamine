// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePridePotentialParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E7")]
  public sealed class JSON_RunePridePotentialParamFormatter : 
    IMessagePackFormatter<JSON_RunePridePotentialParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001266")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001267")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E03")]
    [Address(RVA = "0xC33C10", Offset = "0xC32A10", VA = "0x10C33C10")]
    public JSON_RunePridePotentialParamFormatter()
    {
    }

    [Token(Token = "0x6001E04")]
    [Address(RVA = "0xC33AB0", Offset = "0xC328B0", VA = "0x10C33AB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePridePotentialParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E05")]
    [Address(RVA = "0xC33770", Offset = "0xC32570", VA = "0x10C33770", Slot = "5")]
    public JSON_RunePridePotentialParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePridePotentialParam) null;
    }
  }
}
