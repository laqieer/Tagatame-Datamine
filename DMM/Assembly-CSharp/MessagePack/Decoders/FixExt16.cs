// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200042C")]
  internal sealed class FixExt16 : IExtDecoder
  {
    [Token(Token = "0x4000E7E")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014BF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt16()
    {
    }

    [Token(Token = "0x60014C0")]
    [Address(RVA = "0x5BEEE0", Offset = "0x5BDCE0", VA = "0x105BEEE0", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014C1")]
    [Address(RVA = "0x5BF130", Offset = "0x5BDF30", VA = "0x105BF130")]
    static FixExt16()
    {
    }
  }
}
