// Decompiled with JetBrains decompiler
// Type: MessagePack.Float32Bits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Runtime.InteropServices;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200034C")]
  [StructLayout(LayoutKind.Explicit)]
  internal struct Float32Bits
  {
    [Token(Token = "0x4000D24")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    public readonly float Value;
    [Token(Token = "0x4000D25")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    public readonly byte Byte0;
    [Token(Token = "0x4000D26")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x1")]
    public readonly byte Byte1;
    [Token(Token = "0x4000D27")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x2")]
    public readonly byte Byte2;
    [Token(Token = "0x4000D28")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x3")]
    public readonly byte Byte3;

    [Token(Token = "0x6001189")]
    [Address(RVA = "0x2EC7F0", Offset = "0x2EB5F0", VA = "0x102EC7F0")]
    public Float32Bits(float value)
    {
    }

    [Token(Token = "0x600118A")]
    [Address(RVA = "0x2EC710", Offset = "0x2EB510", VA = "0x102EC710")]
    public Float32Bits(byte[] bigEndianBytes, int offset)
    {
    }
  }
}
