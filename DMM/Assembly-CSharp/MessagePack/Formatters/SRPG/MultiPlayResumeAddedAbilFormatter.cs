// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeAddedAbilFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000747")]
  public sealed class MultiPlayResumeAddedAbilFormatter : 
    IMessagePackFormatter<MultiPlayResumeAddedAbil>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001326")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001327")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F23")]
    [Address(RVA = "0xC89310", Offset = "0xC88110", VA = "0x10C89310")]
    public MultiPlayResumeAddedAbilFormatter()
    {
    }

    [Token(Token = "0x6001F24")]
    [Address(RVA = "0xC891A0", Offset = "0xC87FA0", VA = "0x10C891A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeAddedAbil value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F25")]
    [Address(RVA = "0xC88E50", Offset = "0xC87C50", VA = "0x10C88E50", Slot = "5")]
    public MultiPlayResumeAddedAbil Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeAddedAbil) null;
    }
  }
}
