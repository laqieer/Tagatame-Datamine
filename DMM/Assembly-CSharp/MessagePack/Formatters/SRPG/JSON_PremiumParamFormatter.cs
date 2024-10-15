// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PremiumParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200063B")]
  public sealed class JSON_PremiumParamFormatter : 
    IMessagePackFormatter<JSON_PremiumParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400110E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400110F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BFF")]
    [Address(RVA = "0xBDD230", Offset = "0xBDC030", VA = "0x10BDD230")]
    public JSON_PremiumParamFormatter()
    {
    }

    [Token(Token = "0x6001C00")]
    [Address(RVA = "0xBDCF00", Offset = "0xBDBD00", VA = "0x10BDCF00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PremiumParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C01")]
    [Address(RVA = "0xBDCA20", Offset = "0xBDB820", VA = "0x10BDCA20", Slot = "5")]
    public JSON_PremiumParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PremiumParam) null;
    }
  }
}
