// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Ext8Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000437")]
  internal sealed class Ext8Header : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E88")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014DE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Ext8Header()
    {
    }

    [Token(Token = "0x60014DF")]
    [Address(RVA = "0x5BE6C0", Offset = "0x5BD4C0", VA = "0x105BE6C0", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014E0")]
    [Address(RVA = "0x5BE730", Offset = "0x5BD530", VA = "0x105BE730")]
    static Ext8Header()
    {
    }
  }
}
