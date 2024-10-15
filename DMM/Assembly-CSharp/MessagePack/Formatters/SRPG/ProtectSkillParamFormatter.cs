// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ProtectSkillParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000754")]
  public sealed class ProtectSkillParamFormatter : 
    IMessagePackFormatter<ProtectSkillParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001340")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001341")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F4A")]
    [Address(RVA = "0xC98800", Offset = "0xC97600", VA = "0x10C98800")]
    public ProtectSkillParamFormatter()
    {
    }

    [Token(Token = "0x6001F4B")]
    [Address(RVA = "0xC982F0", Offset = "0xC970F0", VA = "0x10C982F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ProtectSkillParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F4C")]
    [Address(RVA = "0xC97D00", Offset = "0xC96B00", VA = "0x10C97D00", Slot = "5")]
    public ProtectSkillParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ProtectSkillParam) null;
    }
  }
}
