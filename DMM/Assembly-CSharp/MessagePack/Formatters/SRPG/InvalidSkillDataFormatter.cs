// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.InvalidSkillDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000777")]
  public sealed class InvalidSkillDataFormatter : 
    IMessagePackFormatter<InvalidSkillData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001386")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001387")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FB3")]
    [Address(RVA = "0xCCC220", Offset = "0xCCB020", VA = "0x10CCC220")]
    public InvalidSkillDataFormatter()
    {
    }

    [Token(Token = "0x6001FB4")]
    [Address(RVA = "0xCCC070", Offset = "0xCCAE70", VA = "0x10CCC070", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      InvalidSkillData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FB5")]
    [Address(RVA = "0xCCBD90", Offset = "0xCCAB90", VA = "0x10CCBD90", Slot = "5")]
    public InvalidSkillData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (InvalidSkillData) null;
    }
  }
}
