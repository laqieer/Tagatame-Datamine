// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNext3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000443")]
  internal sealed class ReadNext3 : IReadNextDecoder
  {
    [Token(Token = "0x4000E92")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x60014FE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNext3()
    {
    }

    [Token(Token = "0x60014FF")]
    [Address(RVA = "0x5C91A0", Offset = "0x5C7FA0", VA = "0x105C91A0", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001500")]
    [Address(RVA = "0x5C91B0", Offset = "0x5C7FB0", VA = "0x105C91B0")]
    static ReadNext3()
    {
    }
  }
}
