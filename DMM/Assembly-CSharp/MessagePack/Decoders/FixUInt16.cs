// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixUInt16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000408")]
  internal sealed class FixUInt16 : IUInt16Decoder
  {
    [Token(Token = "0x4000E5F")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt16Decoder Instance;

    [Token(Token = "0x600145D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixUInt16()
    {
    }

    [Token(Token = "0x600145E")]
    [Address(RVA = "0x5BFF60", Offset = "0x5BED60", VA = "0x105BFF60", Slot = "4")]
    public ushort Read(byte[] bytes, int offset, out int readSize) => new ushort();

    [Token(Token = "0x600145F")]
    [Address(RVA = "0x5C06F0", Offset = "0x5BF4F0", VA = "0x105C06F0")]
    static FixUInt16()
    {
    }
  }
}
