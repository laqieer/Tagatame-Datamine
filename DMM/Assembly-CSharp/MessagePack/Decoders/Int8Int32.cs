// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int8Int32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F7")]
  internal sealed class Int8Int32 : IInt32Decoder
  {
    [Token(Token = "0x4000E50")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x600142E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int8Int32()
    {
    }

    [Token(Token = "0x600142F")]
    [Address(RVA = "0x5C29D0", Offset = "0x5C17D0", VA = "0x105C29D0", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x6001430")]
    [Address(RVA = "0x5C2A00", Offset = "0x5C1800", VA = "0x105C2A00")]
    static Int8Int32()
    {
    }
  }
}
