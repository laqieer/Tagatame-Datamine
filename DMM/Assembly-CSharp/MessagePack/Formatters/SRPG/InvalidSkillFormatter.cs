// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.InvalidSkillFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000776")]
  public sealed class InvalidSkillFormatter : 
    IMessagePackFormatter<InvalidSkill>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001384")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001385")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FB0")]
    [Address(RVA = "0xCCC990", Offset = "0xCCB790", VA = "0x10CCC990")]
    public InvalidSkillFormatter()
    {
    }

    [Token(Token = "0x6001FB1")]
    [Address(RVA = "0xCCC780", Offset = "0xCCB580", VA = "0x10CCC780", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      InvalidSkill value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FB2")]
    [Address(RVA = "0xCCC3A0", Offset = "0xCCB1A0", VA = "0x10CCC3A0", Slot = "5")]
    public InvalidSkill Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (InvalidSkill) null;
    }
  }
}
