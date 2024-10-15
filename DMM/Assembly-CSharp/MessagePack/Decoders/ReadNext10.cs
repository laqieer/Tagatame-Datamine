// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNext10
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000448")]
  internal sealed class ReadNext10 : IReadNextDecoder
  {
    [Token(Token = "0x4000E97")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x600150D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNext10()
    {
    }

    [Token(Token = "0x600150E")]
    [Address(RVA = "0x5C9000", Offset = "0x5C7E00", VA = "0x105C9000", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x600150F")]
    [Address(RVA = "0x5C9010", Offset = "0x5C7E10", VA = "0x105C9010")]
    static ReadNext10()
    {
    }
  }
}
