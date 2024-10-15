// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillAntiShieldParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000757")]
  public sealed class SkillAntiShieldParamFormatter : 
    IMessagePackFormatter<SkillAntiShieldParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001346")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001347")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F53")]
    [Address(RVA = "0xC99E20", Offset = "0xC98C20", VA = "0x10C99E20")]
    public SkillAntiShieldParamFormatter()
    {
    }

    [Token(Token = "0x6001F54")]
    [Address(RVA = "0xC99BE0", Offset = "0xC989E0", VA = "0x10C99BE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillAntiShieldParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F55")]
    [Address(RVA = "0xC998A0", Offset = "0xC986A0", VA = "0x10C998A0", Slot = "5")]
    public SkillAntiShieldParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillAntiShieldParam) null;
    }
  }
}
