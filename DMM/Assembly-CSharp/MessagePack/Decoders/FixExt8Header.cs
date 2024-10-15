// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt8Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000435")]
  internal sealed class FixExt8Header : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E86")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014D8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt8Header()
    {
    }

    [Token(Token = "0x60014D9")]
    [Address(RVA = "0x5BFC00", Offset = "0x5BEA00", VA = "0x105BFC00", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014DA")]
    [Address(RVA = "0x5BFC60", Offset = "0x5BEA60", VA = "0x105BFC60")]
    static FixExt8Header()
    {
    }
  }
}
