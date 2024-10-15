// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeShieldFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000742")]
  public sealed class MultiPlayResumeShieldFormatter : 
    IMessagePackFormatter<MultiPlayResumeShield>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400131C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400131D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F14")]
    [Address(RVA = "0xC8E5E0", Offset = "0xC8D3E0", VA = "0x10C8E5E0")]
    public MultiPlayResumeShieldFormatter()
    {
    }

    [Token(Token = "0x6001F15")]
    [Address(RVA = "0xC8E3A0", Offset = "0xC8D1A0", VA = "0x10C8E3A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeShield value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F16")]
    [Address(RVA = "0xC8DF80", Offset = "0xC8CD80", VA = "0x10C8DF80", Slot = "5")]
    public MultiPlayResumeShield Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeShield) null;
    }
  }
}
