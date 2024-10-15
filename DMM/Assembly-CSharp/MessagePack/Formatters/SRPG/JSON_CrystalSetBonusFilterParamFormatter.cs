// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalSetBonusFilterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D9")]
  public sealed class JSON_CrystalSetBonusFilterParamFormatter : 
    IMessagePackFormatter<JSON_CrystalSetBonusFilterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400124A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400124B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DD9")]
    [Address(RVA = "0xC12420", Offset = "0xC11220", VA = "0x10C12420")]
    public JSON_CrystalSetBonusFilterParamFormatter()
    {
    }

    [Token(Token = "0x6001DDA")]
    [Address(RVA = "0xC121D0", Offset = "0xC10FD0", VA = "0x10C121D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalSetBonusFilterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DDB")]
    [Address(RVA = "0xC11DC0", Offset = "0xC10BC0", VA = "0x10C11DC0", Slot = "5")]
    public JSON_CrystalSetBonusFilterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalSetBonusFilterParam) null;
    }
  }
}
