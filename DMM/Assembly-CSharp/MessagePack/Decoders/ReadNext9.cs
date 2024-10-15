// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNext9
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000447")]
  internal sealed class ReadNext9 : IReadNextDecoder
  {
    [Token(Token = "0x4000E96")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x600150A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNext9()
    {
    }

    [Token(Token = "0x600150B")]
    [Address(RVA = "0x5C9360", Offset = "0x5C8160", VA = "0x105C9360", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x600150C")]
    [Address(RVA = "0x5C9370", Offset = "0x5C8170", VA = "0x105C9370")]
    static ReadNext9()
    {
    }
  }
}
