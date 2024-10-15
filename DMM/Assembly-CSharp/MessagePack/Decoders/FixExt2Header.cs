// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt2Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000433")]
  internal sealed class FixExt2Header : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E84")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014D2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt2Header()
    {
    }

    [Token(Token = "0x60014D3")]
    [Address(RVA = "0x5BF360", Offset = "0x5BE160", VA = "0x105BF360", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014D4")]
    [Address(RVA = "0x5BF3C0", Offset = "0x5BE1C0", VA = "0x105BF3C0")]
    static FixExt2Header()
    {
    }
  }
}
