// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt16Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000436")]
  internal sealed class FixExt16Header : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E87")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014DB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt16Header()
    {
    }

    [Token(Token = "0x60014DC")]
    [Address(RVA = "0x5BEE20", Offset = "0x5BDC20", VA = "0x105BEE20", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014DD")]
    [Address(RVA = "0x5BEE80", Offset = "0x5BDC80", VA = "0x105BEE80")]
    static FixExt16Header()
    {
    }
  }
}
