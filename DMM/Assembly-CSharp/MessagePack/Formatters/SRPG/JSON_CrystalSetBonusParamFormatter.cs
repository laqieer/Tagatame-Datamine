// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalSetBonusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D0")]
  public sealed class JSON_CrystalSetBonusParamFormatter : 
    IMessagePackFormatter<JSON_CrystalSetBonusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001238")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001239")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DBE")]
    [Address(RVA = "0xC12EF0", Offset = "0xC11CF0", VA = "0x10C12EF0")]
    public JSON_CrystalSetBonusParamFormatter()
    {
    }

    [Token(Token = "0x6001DBF")]
    [Address(RVA = "0xC12BC0", Offset = "0xC119C0", VA = "0x10C12BC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalSetBonusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DC0")]
    [Address(RVA = "0xC126F0", Offset = "0xC114F0", VA = "0x10C126F0", Slot = "5")]
    public JSON_CrystalSetBonusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalSetBonusParam) null;
    }
  }
}
