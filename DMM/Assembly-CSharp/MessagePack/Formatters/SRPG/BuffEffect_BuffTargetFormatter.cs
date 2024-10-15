// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffEffect_BuffTargetFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200077D")]
  public sealed class BuffEffect_BuffTargetFormatter : 
    IMessagePackFormatter<BuffEffect.BuffTarget>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001392")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001393")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FC5")]
    [Address(RVA = "0xCC5710", Offset = "0xCC4510", VA = "0x10CC5710")]
    public BuffEffect_BuffTargetFormatter()
    {
    }

    [Token(Token = "0x6001FC6")]
    [Address(RVA = "0xCC5350", Offset = "0xCC4150", VA = "0x10CC5350", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffEffect.BuffTarget value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FC7")]
    [Address(RVA = "0xCC4E60", Offset = "0xCC3C60", VA = "0x10CC4E60", Slot = "5")]
    public BuffEffect.BuffTarget Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BuffEffect.BuffTarget) null;
    }
  }
}
