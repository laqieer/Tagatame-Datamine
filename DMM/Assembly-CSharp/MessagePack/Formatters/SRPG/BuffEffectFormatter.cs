// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffEffectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200077E")]
  public sealed class BuffEffectFormatter : IMessagePackFormatter<BuffEffect>, IMessagePackFormatter
  {
    [Token(Token = "0x4001394")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001395")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FC8")]
    [Address(RVA = "0xCC1F00", Offset = "0xCC0D00", VA = "0x10CC1F00")]
    public BuffEffectFormatter()
    {
    }

    [Token(Token = "0x6001FC9")]
    [Address(RVA = "0xCC1C80", Offset = "0xCC0A80", VA = "0x10CC1C80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffEffect value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FCA")]
    [Address(RVA = "0xCC1900", Offset = "0xCC0700", VA = "0x10CC1900", Slot = "5")]
    public BuffEffect Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BuffEffect) null;
    }
  }
}
