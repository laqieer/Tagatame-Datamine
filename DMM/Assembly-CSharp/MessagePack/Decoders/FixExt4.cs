// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200042A")]
  internal sealed class FixExt4 : IExtDecoder
  {
    [Token(Token = "0x4000E7C")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014B9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt4()
    {
    }

    [Token(Token = "0x60014BA")]
    [Address(RVA = "0x5BF7F0", Offset = "0x5BE5F0", VA = "0x105BF7F0", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014BB")]
    [Address(RVA = "0x5BF8E0", Offset = "0x5BE6E0", VA = "0x105BF8E0")]
    static FixExt4()
    {
    }
  }
}
