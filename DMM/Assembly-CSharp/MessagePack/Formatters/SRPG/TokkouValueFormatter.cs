// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TokkouValueFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200076B")]
  public sealed class TokkouValueFormatter : 
    IMessagePackFormatter<TokkouValue>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400136E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400136F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F8F")]
    [Address(RVA = "0xCB9C40", Offset = "0xCB8A40", VA = "0x10CB9C40")]
    public TokkouValueFormatter()
    {
    }

    [Token(Token = "0x6001F90")]
    [Address(RVA = "0xCB9B10", Offset = "0xCB8910", VA = "0x10CB9B10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TokkouValue value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F91")]
    [Address(RVA = "0xCB9800", Offset = "0xCB8600", VA = "0x10CB9800", Slot = "5")]
    public TokkouValue Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TokkouValue) null;
    }
  }
}
