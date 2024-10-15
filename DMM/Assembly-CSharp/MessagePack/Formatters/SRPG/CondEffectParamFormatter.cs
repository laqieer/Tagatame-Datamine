// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CondEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A8")]
  public sealed class CondEffectParamFormatter : 
    IMessagePackFormatter<CondEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002046")]
    [Address(RVA = "0xCF4520", Offset = "0xCF3320", VA = "0x10CF4520")]
    public CondEffectParamFormatter()
    {
    }

    [Token(Token = "0x6002047")]
    [Address(RVA = "0xCF33C0", Offset = "0xCF21C0", VA = "0x10CF33C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CondEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002048")]
    [Address(RVA = "0xCF2230", Offset = "0xCF1030", VA = "0x10CF2230", Slot = "5")]
    public CondEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CondEffectParam) null;
    }
  }
}
