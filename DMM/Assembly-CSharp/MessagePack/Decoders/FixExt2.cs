// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000429")]
  internal sealed class FixExt2 : IExtDecoder
  {
    [Token(Token = "0x4000E7B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014B6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt2()
    {
    }

    [Token(Token = "0x60014B7")]
    [Address(RVA = "0x5BF420", Offset = "0x5BE220", VA = "0x105BF420", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014B8")]
    [Address(RVA = "0x5BF4E0", Offset = "0x5BE2E0", VA = "0x105BF4E0")]
    static FixExt2()
    {
    }
  }
}
