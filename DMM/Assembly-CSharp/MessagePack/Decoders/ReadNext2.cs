// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNext2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000442")]
  internal sealed class ReadNext2 : IReadNextDecoder
  {
    [Token(Token = "0x4000E91")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x60014FB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNext2()
    {
    }

    [Token(Token = "0x60014FC")]
    [Address(RVA = "0x34FD10", Offset = "0x34EB10", VA = "0x1034FD10", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x60014FD")]
    [Address(RVA = "0x5C9140", Offset = "0x5C7F40", VA = "0x105C9140")]
    static ReadNext2()
    {
    }
  }
}
