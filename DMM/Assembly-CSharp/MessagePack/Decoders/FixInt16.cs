// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixInt16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003EB")]
  internal sealed class FixInt16 : IInt16Decoder
  {
    [Token(Token = "0x4000E45")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt16Decoder Instance;

    [Token(Token = "0x600140C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixInt16()
    {
    }

    [Token(Token = "0x600140D")]
    [Address(RVA = "0x5BFF60", Offset = "0x5BED60", VA = "0x105BFF60", Slot = "4")]
    public short Read(byte[] bytes, int offset, out int readSize) => new short();

    [Token(Token = "0x600140E")]
    [Address(RVA = "0x5BFF90", Offset = "0x5BED90", VA = "0x105BFF90")]
    static FixInt16()
    {
    }
  }
}
