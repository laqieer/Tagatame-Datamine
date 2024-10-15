// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeManipulateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200074B")]
  public sealed class MultiPlayResumeManipulateFormatter : 
    IMessagePackFormatter<MultiPlayResumeManipulate>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400132E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400132F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F2F")]
    [Address(RVA = "0xC8CAF0", Offset = "0xC8B8F0", VA = "0x10C8CAF0")]
    public MultiPlayResumeManipulateFormatter()
    {
    }

    [Token(Token = "0x6001F30")]
    [Address(RVA = "0xC8C850", Offset = "0xC8B650", VA = "0x10C8C850", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeManipulate value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F31")]
    [Address(RVA = "0xC8C480", Offset = "0xC8B280", VA = "0x10C8C480", Slot = "5")]
    public MultiPlayResumeManipulate Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeManipulate) null;
    }
  }
}
