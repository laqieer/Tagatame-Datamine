// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt4Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000434")]
  internal sealed class FixExt4Header : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E85")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014D5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt4Header()
    {
    }

    [Token(Token = "0x60014D6")]
    [Address(RVA = "0x5BF730", Offset = "0x5BE530", VA = "0x105BF730", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014D7")]
    [Address(RVA = "0x5BF790", Offset = "0x5BE590", VA = "0x105BF790")]
    static FixExt4Header()
    {
    }
  }
}
