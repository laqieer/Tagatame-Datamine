// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNext1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000441")]
  internal sealed class ReadNext1 : IReadNextDecoder
  {
    [Token(Token = "0x4000E90")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x60014F8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNext1()
    {
    }

    [Token(Token = "0x60014F9")]
    [Address(RVA = "0x2B8A30", Offset = "0x2B7830", VA = "0x102B8A30", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x60014FA")]
    [Address(RVA = "0x5C90E0", Offset = "0x5C7EE0", VA = "0x105C90E0")]
    static ReadNext1()
    {
    }
  }
}
