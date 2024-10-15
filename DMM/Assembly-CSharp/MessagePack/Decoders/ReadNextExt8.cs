// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextExt8
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000453")]
  internal sealed class ReadNextExt8 : IReadNextDecoder
  {
    [Token(Token = "0x4000EA2")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x600152E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextExt8()
    {
    }

    [Token(Token = "0x600152F")]
    [Address(RVA = "0x5C99E0", Offset = "0x5C87E0", VA = "0x105C99E0", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001530")]
    [Address(RVA = "0x5C9A10", Offset = "0x5C8810", VA = "0x105C9A10")]
    static ReadNextExt8()
    {
    }
  }
}
