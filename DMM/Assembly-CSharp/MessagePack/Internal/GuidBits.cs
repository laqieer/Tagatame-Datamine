// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.GuidBits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x200046C")]
  [StructLayout(LayoutKind.Explicit)]
  internal struct GuidBits
  {
    [Token(Token = "0x4000F05")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    public readonly Guid Value;
    [Token(Token = "0x4000F06")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    public readonly byte Byte0;
    [Token(Token = "0x4000F07")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x1")]
    public readonly byte Byte1;
    [Token(Token = "0x4000F08")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x2")]
    public readonly byte Byte2;
    [Token(Token = "0x4000F09")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x3")]
    public readonly byte Byte3;
    [Token(Token = "0x4000F0A")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x4")]
    public readonly byte Byte4;
    [Token(Token = "0x4000F0B")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x5")]
    public readonly byte Byte5;
    [Token(Token = "0x4000F0C")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x6")]
    public readonly byte Byte6;
    [Token(Token = "0x4000F0D")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x7")]
    public readonly byte Byte7;
    [Token(Token = "0x4000F0E")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
    public readonly byte Byte8;
    [Token(Token = "0x4000F0F")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x9")]
    public readonly byte Byte9;
    [Token(Token = "0x4000F10")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xA")]
    public readonly byte Byte10;
    [Token(Token = "0x4000F11")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xB")]
    public readonly byte Byte11;
    [Token(Token = "0x4000F12")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xC")]
    public readonly byte Byte12;
    [Token(Token = "0x4000F13")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xD")]
    public readonly byte Byte13;
    [Token(Token = "0x4000F14")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xE")]
    public readonly byte Byte14;
    [Token(Token = "0x4000F15")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xF")]
    public readonly byte Byte15;
    [Token(Token = "0x4000F16")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    private static byte[] byteToHexStringHigh;
    [Token(Token = "0x4000F17")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x4")]
    private static byte[] byteToHexStringLow;

    [Token(Token = "0x60015DA")]
    [Address(RVA = "0x5C1B20", Offset = "0x5C0920", VA = "0x105C1B20")]
    public GuidBits(ref Guid value)
    {
    }

    [Token(Token = "0x60015DB")]
    [Address(RVA = "0x5C1590", Offset = "0x5C0390", VA = "0x105C1590")]
    public GuidBits(ArraySegment<byte> utf8string)
    {
    }

    [Token(Token = "0x60015DC")]
    [Address(RVA = "0x5C09A0", Offset = "0x5BF7A0", VA = "0x105C09A0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte Parse(byte[] bytes, int highOffset) => new byte();

    [Token(Token = "0x60015DD")]
    [Address(RVA = "0x5BAA90", Offset = "0x5B9890", VA = "0x105BAA90")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte SwitchParse(byte b) => new byte();

    [Token(Token = "0x60015DE")]
    [Address(RVA = "0x5C0A30", Offset = "0x5BF830", VA = "0x105C0A30")]
    public void Write(byte[] buffer, int offset)
    {
    }

    [Token(Token = "0x60015DF")]
    [Address(RVA = "0x5C14D0", Offset = "0x5C02D0", VA = "0x105C14D0")]
    static GuidBits()
    {
    }
  }
}
