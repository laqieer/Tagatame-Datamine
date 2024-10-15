// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureCostParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A8B")]
  public sealed class JSON_AdventureCostParamFormatter : 
    IMessagePackFormatter<JSON_AdventureCostParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019A6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028EF")]
    [Address(RVA = "0xED9150", Offset = "0xED7F50", VA = "0x10ED9150")]
    public JSON_AdventureCostParamFormatter()
    {
    }

    [Token(Token = "0x60028F0")]
    [Address(RVA = "0xED8F30", Offset = "0xED7D30", VA = "0x10ED8F30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureCostParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028F1")]
    [Address(RVA = "0xED8BB0", Offset = "0xED79B0", VA = "0x10ED8BB0", Slot = "5")]
    public JSON_AdventureCostParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureCostParam) null;
    }
  }
}
