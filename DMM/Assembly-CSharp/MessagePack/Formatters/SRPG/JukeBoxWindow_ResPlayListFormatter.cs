// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JukeBoxWindow_ResPlayListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C7")]
  public sealed class JukeBoxWindow_ResPlayListFormatter : 
    IMessagePackFormatter<JukeBoxWindow.ResPlayList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400161E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400161F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023A3")]
    [Address(RVA = "0xDD5D80", Offset = "0xDD4B80", VA = "0x10DD5D80")]
    public JukeBoxWindow_ResPlayListFormatter()
    {
    }

    [Token(Token = "0x60023A4")]
    [Address(RVA = "0xDD5C50", Offset = "0xDD4A50", VA = "0x10DD5C50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JukeBoxWindow.ResPlayList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023A5")]
    [Address(RVA = "0xDD5940", Offset = "0xDD4740", VA = "0x10DD5940", Slot = "5")]
    public JukeBoxWindow.ResPlayList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JukeBoxWindow.ResPlayList) null;
    }
  }
}
