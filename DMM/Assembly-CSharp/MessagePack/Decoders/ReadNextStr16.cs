// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextStr16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200044E")]
  internal sealed class ReadNextStr16 : IReadNextDecoder
  {
    [Token(Token = "0x4000E9D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x600151F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextStr16()
    {
    }

    [Token(Token = "0x6001520")]
    [Address(RVA = "0x5C9670", Offset = "0x5C8470", VA = "0x105C9670", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001521")]
    [Address(RVA = "0x5C9E80", Offset = "0x5C8C80", VA = "0x105C9E80")]
    static ReadNextStr16()
    {
    }
  }
}
