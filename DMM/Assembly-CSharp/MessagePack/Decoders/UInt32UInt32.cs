// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt32UInt32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000410")]
  internal sealed class UInt32UInt32 : IUInt32Decoder
  {
    [Token(Token = "0x4000E66")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt32Decoder Instance;

    [Token(Token = "0x6001473")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt32UInt32()
    {
    }

    [Token(Token = "0x6001474")]
    [Address(RVA = "0x5BAC30", Offset = "0x5B9A30", VA = "0x105BAC30", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x6001475")]
    [Address(RVA = "0x5CC180", Offset = "0x5CAF80", VA = "0x105CC180")]
    static UInt32UInt32()
    {
    }
  }
}
