// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt8
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200042B")]
  internal sealed class FixExt8 : IExtDecoder
  {
    [Token(Token = "0x4000E7D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014BC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt8()
    {
    }

    [Token(Token = "0x60014BD")]
    [Address(RVA = "0x5BFCC0", Offset = "0x5BEAC0", VA = "0x105BFCC0", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014BE")]
    [Address(RVA = "0x5BFE20", Offset = "0x5BEC20", VA = "0x105BFE20")]
    static FixExt8()
    {
    }
  }
}
