// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.True
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003B7")]
  internal sealed class True : IBooleanDecoder
  {
    [Token(Token = "0x4000E18")]
    [FieldOffset(Offset = "0x0")]
    internal static IBooleanDecoder Instance;

    [Token(Token = "0x600137E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private True()
    {
    }

    [Token(Token = "0x600137F")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "4")]
    public bool Read() => new bool();

    [Token(Token = "0x6001380")]
    [Address(RVA = "0x5CAC70", Offset = "0x5C9A70", VA = "0x105CAC70")]
    static True()
    {
    }
  }
}
