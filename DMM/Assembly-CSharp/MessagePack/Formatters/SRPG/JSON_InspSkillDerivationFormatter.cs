// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InspSkillDerivationFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200064A")]
  public sealed class JSON_InspSkillDerivationFormatter : 
    IMessagePackFormatter<JSON_InspSkillDerivation>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400112C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400112D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C2C")]
    [Address(RVA = "0xBDAFD0", Offset = "0xBD9DD0", VA = "0x10BDAFD0")]
    public JSON_InspSkillDerivationFormatter()
    {
    }

    [Token(Token = "0x6001C2D")]
    [Address(RVA = "0xBDAEA0", Offset = "0xBD9CA0", VA = "0x10BDAEA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InspSkillDerivation value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C2E")]
    [Address(RVA = "0xBDAB90", Offset = "0xBD9990", VA = "0x10BDAB90", Slot = "5")]
    public JSON_InspSkillDerivation Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InspSkillDerivation) null;
    }
  }
}
