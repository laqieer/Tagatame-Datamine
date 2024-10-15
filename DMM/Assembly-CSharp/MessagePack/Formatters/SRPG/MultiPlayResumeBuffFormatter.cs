// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeBuffFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000741")]
  public sealed class MultiPlayResumeBuffFormatter : 
    IMessagePackFormatter<MultiPlayResumeBuff>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400131A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400131B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F11")]
    [Address(RVA = "0xC8AA90", Offset = "0xC89890", VA = "0x10C8AA90")]
    public MultiPlayResumeBuffFormatter()
    {
    }

    [Token(Token = "0x6001F12")]
    [Address(RVA = "0xC8A390", Offset = "0xC89190", VA = "0x10C8A390", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeBuff value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F13")]
    [Address(RVA = "0xC89BA0", Offset = "0xC889A0", VA = "0x10C89BA0", Slot = "5")]
    public MultiPlayResumeBuff Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeBuff) null;
    }
  }
}
