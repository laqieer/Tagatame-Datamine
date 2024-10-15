// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffEffectParam_BuffFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200077B")]
  public sealed class BuffEffectParam_BuffFormatter : 
    IMessagePackFormatter<BuffEffectParam.Buff>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400138E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400138F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FBF")]
    [Address(RVA = "0xCC4B30", Offset = "0xCC3930", VA = "0x10CC4B30")]
    public BuffEffectParam_BuffFormatter()
    {
    }

    [Token(Token = "0x6001FC0")]
    [Address(RVA = "0xCC48A0", Offset = "0xCC36A0", VA = "0x10CC48A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffEffectParam.Buff value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FC1")]
    [Address(RVA = "0xCC4460", Offset = "0xCC3260", VA = "0x10CC4460", Slot = "5")]
    public BuffEffectParam.Buff Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BuffEffectParam.Buff) null;
    }
  }
}
