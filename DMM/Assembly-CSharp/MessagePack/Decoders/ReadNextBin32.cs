// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextBin32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000452")]
  internal sealed class ReadNextBin32 : IReadNextDecoder
  {
    [Token(Token = "0x4000EA1")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x600152B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextBin32()
    {
    }

    [Token(Token = "0x600152C")]
    [Address(RVA = "0x5C9710", Offset = "0x5C8510", VA = "0x105C9710", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x600152D")]
    [Address(RVA = "0x5C9780", Offset = "0x5C8580", VA = "0x105C9780")]
    static ReadNextBin32()
    {
    }
  }
}
