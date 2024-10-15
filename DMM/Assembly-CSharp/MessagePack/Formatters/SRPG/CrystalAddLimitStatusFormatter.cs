// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.CrystalAddLimitStatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000885")]
  public sealed class CrystalAddLimitStatusFormatter : 
    IMessagePackFormatter<CrystalAddLimitStatus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400159A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400159B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022DD")]
    [Address(RVA = "0xD994E0", Offset = "0xD982E0", VA = "0x10D994E0")]
    public CrystalAddLimitStatusFormatter()
    {
    }

    [Token(Token = "0x60022DE")]
    [Address(RVA = "0xD991F0", Offset = "0xD97FF0", VA = "0x10D991F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      CrystalAddLimitStatus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022DF")]
    [Address(RVA = "0xD98E60", Offset = "0xD97C60", VA = "0x10D98E60", Slot = "5")]
    public CrystalAddLimitStatus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (CrystalAddLimitStatus) null;
    }
  }
}
