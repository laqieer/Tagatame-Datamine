// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AbilityDeriveParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A5")]
  public sealed class AbilityDeriveParamFormatter : 
    IMessagePackFormatter<AbilityDeriveParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600203D")]
    [Address(RVA = "0xCED5D0", Offset = "0xCEC3D0", VA = "0x10CED5D0")]
    public AbilityDeriveParamFormatter()
    {
    }

    [Token(Token = "0x600203E")]
    [Address(RVA = "0xCED210", Offset = "0xCEC010", VA = "0x10CED210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AbilityDeriveParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600203F")]
    [Address(RVA = "0xCECDF0", Offset = "0xCEBBF0", VA = "0x10CECDF0", Slot = "5")]
    public AbilityDeriveParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AbilityDeriveParam) null;
    }
  }
}
