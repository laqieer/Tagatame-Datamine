// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffEffect_BuffValuesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000788")]
  public sealed class BuffEffect_BuffValuesFormatter : 
    IMessagePackFormatter<BuffEffect.BuffValues>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FE6")]
    [Address(RVA = "0xCC5F10", Offset = "0xCC4D10", VA = "0x10CC5F10")]
    public BuffEffect_BuffValuesFormatter()
    {
    }

    [Token(Token = "0x6001FE7")]
    [Address(RVA = "0xCC5DB0", Offset = "0xCC4BB0", VA = "0x10CC5DB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffEffect.BuffValues value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FE8")]
    [Address(RVA = "0xCC5A40", Offset = "0xCC4840", VA = "0x10CC5A40", Slot = "5")]
    public BuffEffect.BuffValues Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new BuffEffect.BuffValues();
    }
  }
}
