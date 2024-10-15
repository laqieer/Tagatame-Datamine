// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeBuff_ResistStatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000740")]
  public sealed class MultiPlayResumeBuff_ResistStatusFormatter : 
    IMessagePackFormatter<MultiPlayResumeBuff.ResistStatus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001318")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001319")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F0E")]
    [Address(RVA = "0xC8B8B0", Offset = "0xC8A6B0", VA = "0x10C8B8B0")]
    public MultiPlayResumeBuff_ResistStatusFormatter()
    {
    }

    [Token(Token = "0x6001F0F")]
    [Address(RVA = "0xC8B7B0", Offset = "0xC8A5B0", VA = "0x10C8B7B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeBuff.ResistStatus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F10")]
    [Address(RVA = "0xC8B4D0", Offset = "0xC8A2D0", VA = "0x10C8B4D0", Slot = "5")]
    public MultiPlayResumeBuff.ResistStatus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeBuff.ResistStatus) null;
    }
  }
}
