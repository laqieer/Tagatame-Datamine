// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt16UInt32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200040F")]
  internal sealed class UInt16UInt32 : IUInt32Decoder
  {
    [Token(Token = "0x4000E65")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt32Decoder Instance;

    [Token(Token = "0x6001470")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16UInt32()
    {
    }

    [Token(Token = "0x6001471")]
    [Address(RVA = "0x5BAB80", Offset = "0x5B9980", VA = "0x105BAB80", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x6001472")]
    [Address(RVA = "0x5CBCB0", Offset = "0x5CAAB0", VA = "0x105CBCB0")]
    static UInt16UInt32()
    {
    }
  }
}
