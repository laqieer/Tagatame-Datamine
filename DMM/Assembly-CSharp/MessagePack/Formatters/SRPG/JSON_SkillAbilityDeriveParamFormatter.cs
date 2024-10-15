// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillAbilityDeriveParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200061C")]
  public sealed class JSON_SkillAbilityDeriveParamFormatter : 
    IMessagePackFormatter<JSON_SkillAbilityDeriveParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BA2")]
    [Address(RVA = "0xBC7410", Offset = "0xBC6210", VA = "0x10BC7410")]
    public JSON_SkillAbilityDeriveParamFormatter()
    {
    }

    [Token(Token = "0x6001BA3")]
    [Address(RVA = "0xBC6FD0", Offset = "0xBC5DD0", VA = "0x10BC6FD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillAbilityDeriveParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BA4")]
    [Address(RVA = "0xBC69F0", Offset = "0xBC57F0", VA = "0x10BC69F0", Slot = "5")]
    public JSON_SkillAbilityDeriveParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillAbilityDeriveParam) null;
    }
  }
}
