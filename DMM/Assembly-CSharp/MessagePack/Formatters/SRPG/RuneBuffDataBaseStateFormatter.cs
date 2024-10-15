// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneBuffDataBaseStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000782")]
  public sealed class RuneBuffDataBaseStateFormatter : 
    IMessagePackFormatter<RuneBuffDataBaseState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400139C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400139D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FD4")]
    [Address(RVA = "0xCD0950", Offset = "0xCCF750", VA = "0x10CD0950")]
    public RuneBuffDataBaseStateFormatter()
    {
    }

    [Token(Token = "0x6001FD5")]
    [Address(RVA = "0xCD0760", Offset = "0xCCF560", VA = "0x10CD0760", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneBuffDataBaseState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FD6")]
    [Address(RVA = "0xCD0400", Offset = "0xCCF200", VA = "0x10CD0400", Slot = "5")]
    public RuneBuffDataBaseState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneBuffDataBaseState) null;
    }
  }
}
