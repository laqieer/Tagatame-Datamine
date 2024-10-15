// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResetCostParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000696")]
  public sealed class JSON_ResetCostParamFormatter : 
    IMessagePackFormatter<JSON_ResetCostParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D10")]
    [Address(RVA = "0xC025E0", Offset = "0xC013E0", VA = "0x10C025E0")]
    public JSON_ResetCostParamFormatter()
    {
    }

    [Token(Token = "0x6001D11")]
    [Address(RVA = "0xC02400", Offset = "0xC01200", VA = "0x10C02400", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResetCostParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D12")]
    [Address(RVA = "0xC020C0", Offset = "0xC00EC0", VA = "0x10C020C0", Slot = "5")]
    public JSON_ResetCostParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResetCostParam) null;
    }
  }
}
