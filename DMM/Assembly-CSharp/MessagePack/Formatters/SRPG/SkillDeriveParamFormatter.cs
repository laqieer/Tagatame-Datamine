// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillDeriveParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A2")]
  public sealed class SkillDeriveParamFormatter : 
    IMessagePackFormatter<SkillDeriveParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002034")]
    [Address(RVA = "0xCFD4A0", Offset = "0xCFC2A0", VA = "0x10CFD4A0")]
    public SkillDeriveParamFormatter()
    {
    }

    [Token(Token = "0x6002035")]
    [Address(RVA = "0xCFD0E0", Offset = "0xCFBEE0", VA = "0x10CFD0E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillDeriveParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002036")]
    [Address(RVA = "0xCFCCC0", Offset = "0xCFBAC0", VA = "0x10CFCCC0", Slot = "5")]
    public SkillDeriveParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillDeriveParam) null;
    }
  }
}
