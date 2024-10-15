// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt1Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000432")]
  internal sealed class FixExt1Header : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E83")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014CF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt1Header()
    {
    }

    [Token(Token = "0x60014D0")]
    [Address(RVA = "0x5BF190", Offset = "0x5BDF90", VA = "0x105BF190", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014D1")]
    [Address(RVA = "0x5BF1F0", Offset = "0x5BDFF0", VA = "0x105BF1F0")]
    static FixExt1Header()
    {
    }
  }
}
