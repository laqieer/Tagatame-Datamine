// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixUInt32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200040D")]
  internal sealed class FixUInt32 : IUInt32Decoder
  {
    [Token(Token = "0x4000E63")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt32Decoder Instance;

    [Token(Token = "0x600146A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixUInt32()
    {
    }

    [Token(Token = "0x600146B")]
    [Address(RVA = "0x5BFF60", Offset = "0x5BED60", VA = "0x105BFF60", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x600146C")]
    [Address(RVA = "0x5C0750", Offset = "0x5BF550", VA = "0x105C0750")]
    static FixUInt32()
    {
    }
  }
}
