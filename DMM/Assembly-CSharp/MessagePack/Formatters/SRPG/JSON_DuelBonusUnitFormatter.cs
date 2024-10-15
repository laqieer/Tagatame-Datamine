// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelBonusUnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000805")]
  public sealed class JSON_DuelBonusUnitFormatter : 
    IMessagePackFormatter<JSON_DuelBonusUnit>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400149A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400149B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600215D")]
    [Address(RVA = "0xD3FED0", Offset = "0xD3ECD0", VA = "0x10D3FED0")]
    public JSON_DuelBonusUnitFormatter()
    {
    }

    [Token(Token = "0x600215E")]
    [Address(RVA = "0xD3FDA0", Offset = "0xD3EBA0", VA = "0x10D3FDA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelBonusUnit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600215F")]
    [Address(RVA = "0xD3FA90", Offset = "0xD3E890", VA = "0x10D3FA90", Slot = "5")]
    public JSON_DuelBonusUnit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelBonusUnit) null;
    }
  }
}
