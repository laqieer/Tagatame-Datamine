// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalSetBonusFilterCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A1B")]
  public sealed class JSON_CrystalSetBonusFilterCondParamFormatter : 
    IMessagePackFormatter<JSON_CrystalSetBonusFilterCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018C6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018C7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600279F")]
    [Address(RVA = "0xEA0CB0", Offset = "0xE9FAB0", VA = "0x10EA0CB0")]
    public JSON_CrystalSetBonusFilterCondParamFormatter()
    {
    }

    [Token(Token = "0x60027A0")]
    [Address(RVA = "0xEA0AF0", Offset = "0xE9F8F0", VA = "0x10EA0AF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalSetBonusFilterCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027A1")]
    [Address(RVA = "0xEA0760", Offset = "0xE9F560", VA = "0x10EA0760", Slot = "5")]
    public JSON_CrystalSetBonusFilterCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalSetBonusFilterCondParam) null;
    }
  }
}
