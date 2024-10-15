// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNextStr8
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200044D")]
  internal sealed class ReadNextStr8 : IReadNextDecoder
  {
    [Token(Token = "0x4000E9C")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x600151C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNextStr8()
    {
    }

    [Token(Token = "0x600151D")]
    [Address(RVA = "0x5C97E0", Offset = "0x5C85E0", VA = "0x105C97E0", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x600151E")]
    [Address(RVA = "0x5C9F40", Offset = "0x5C8D40", VA = "0x105C9F40")]
    static ReadNextStr8()
    {
    }
  }
}
