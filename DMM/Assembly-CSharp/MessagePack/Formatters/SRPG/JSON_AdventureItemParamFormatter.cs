// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E9")]
  public sealed class JSON_AdventureItemParamFormatter : 
    IMessagePackFormatter<JSON_AdventureItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001862")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001863")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002709")]
    [Address(RVA = "0xE81FA0", Offset = "0xE80DA0", VA = "0x10E81FA0")]
    public JSON_AdventureItemParamFormatter()
    {
    }

    [Token(Token = "0x600270A")]
    [Address(RVA = "0xE81E70", Offset = "0xE80C70", VA = "0x10E81E70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600270B")]
    [Address(RVA = "0xE81B60", Offset = "0xE80960", VA = "0x10E81B60", Slot = "5")]
    public JSON_AdventureItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureItemParam) null;
    }
  }
}
