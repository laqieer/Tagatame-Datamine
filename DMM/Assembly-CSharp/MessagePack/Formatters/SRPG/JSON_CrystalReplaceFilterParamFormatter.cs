// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalReplaceFilterParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006DF")]
  public sealed class JSON_CrystalReplaceFilterParamFormatter : 
    IMessagePackFormatter<JSON_CrystalReplaceFilterParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001256")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001257")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DEB")]
    [Address(RVA = "0xC265B0", Offset = "0xC253B0", VA = "0x10C265B0")]
    public JSON_CrystalReplaceFilterParamFormatter()
    {
    }

    [Token(Token = "0x6001DEC")]
    [Address(RVA = "0xC262A0", Offset = "0xC250A0", VA = "0x10C262A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalReplaceFilterParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DED")]
    [Address(RVA = "0xC25E50", Offset = "0xC24C50", VA = "0x10C25E50", Slot = "5")]
    public JSON_CrystalReplaceFilterParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalReplaceFilterParam) null;
    }
  }
}
