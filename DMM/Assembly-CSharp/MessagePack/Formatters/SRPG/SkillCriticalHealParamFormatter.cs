// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillCriticalHealParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200075C")]
  public sealed class SkillCriticalHealParamFormatter : 
    IMessagePackFormatter<SkillCriticalHealParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001350")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001351")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F62")]
    [Address(RVA = "0xC9B300", Offset = "0xC9A100", VA = "0x10C9B300")]
    public SkillCriticalHealParamFormatter()
    {
    }

    [Token(Token = "0x6001F63")]
    [Address(RVA = "0xC9B150", Offset = "0xC99F50", VA = "0x10C9B150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillCriticalHealParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F64")]
    [Address(RVA = "0xC9AE10", Offset = "0xC99C10", VA = "0x10C9AE10", Slot = "5")]
    public SkillCriticalHealParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillCriticalHealParam) null;
    }
  }
}
