// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillRevivalParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000759")]
  public sealed class SkillRevivalParamFormatter : 
    IMessagePackFormatter<SkillRevivalParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400134A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400134B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F59")]
    [Address(RVA = "0xCAA0E0", Offset = "0xCA8EE0", VA = "0x10CAA0E0")]
    public SkillRevivalParamFormatter()
    {
    }

    [Token(Token = "0x6001F5A")]
    [Address(RVA = "0xCA9E30", Offset = "0xCA8C30", VA = "0x10CA9E30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillRevivalParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F5B")]
    [Address(RVA = "0xCA9AD0", Offset = "0xCA88D0", VA = "0x10CA9AD0", Slot = "5")]
    public SkillRevivalParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillRevivalParam) null;
    }
  }
}
