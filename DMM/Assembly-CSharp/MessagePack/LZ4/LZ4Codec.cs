// Decompiled with JetBrains decompiler
// Type: MessagePack.LZ4.LZ4Codec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Diagnostics;

#nullable disable
namespace MessagePack.LZ4
{
  [Token(Token = "0x2000456")]
  public static class LZ4Codec
  {
    [Token(Token = "0x4000EA5")]
    private const int MEMORY_USAGE = 12;
    [Token(Token = "0x4000EA6")]
    private const int NOTCOMPRESSIBLE_DETECTIONLEVEL = 6;
    [Token(Token = "0x4000EA7")]
    private const int MINMATCH = 4;
    [Token(Token = "0x4000EA8")]
    private const int SKIPSTRENGTH = 6;
    [Token(Token = "0x4000EA9")]
    private const int COPYLENGTH = 8;
    [Token(Token = "0x4000EAA")]
    private const int LASTLITERALS = 5;
    [Token(Token = "0x4000EAB")]
    private const int MFLIMIT = 12;
    [Token(Token = "0x4000EAC")]
    private const int MINLENGTH = 13;
    [Token(Token = "0x4000EAD")]
    private const int MAXD_LOG = 16;
    [Token(Token = "0x4000EAE")]
    private const int MAXD = 65536;
    [Token(Token = "0x4000EAF")]
    private const int MAXD_MASK = 65535;
    [Token(Token = "0x4000EB0")]
    private const int MAX_DISTANCE = 65535;
    [Token(Token = "0x4000EB1")]
    private const int ML_BITS = 4;
    [Token(Token = "0x4000EB2")]
    private const int ML_MASK = 15;
    [Token(Token = "0x4000EB3")]
    private const int RUN_BITS = 4;
    [Token(Token = "0x4000EB4")]
    private const int RUN_MASK = 15;
    [Token(Token = "0x4000EB5")]
    private const int STEPSIZE_64 = 8;
    [Token(Token = "0x4000EB6")]
    private const int STEPSIZE_32 = 4;
    [Token(Token = "0x4000EB7")]
    private const int LZ4_64KLIMIT = 65547;
    [Token(Token = "0x4000EB8")]
    private const int HASH_LOG = 10;
    [Token(Token = "0x4000EB9")]
    private const int HASH_TABLESIZE = 1024;
    [Token(Token = "0x4000EBA")]
    private const int HASH_ADJUST = 22;
    [Token(Token = "0x4000EBB")]
    private const int HASH64K_LOG = 11;
    [Token(Token = "0x4000EBC")]
    private const int HASH64K_TABLESIZE = 2048;
    [Token(Token = "0x4000EBD")]
    private const int HASH64K_ADJUST = 21;
    [Token(Token = "0x4000EBE")]
    private const int HASHHC_LOG = 15;
    [Token(Token = "0x4000EBF")]
    private const int HASHHC_TABLESIZE = 32768;
    [Token(Token = "0x4000EC0")]
    private const int HASHHC_ADJUST = 17;
    [Token(Token = "0x4000EC1")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int[] DECODER_TABLE_32;
    [Token(Token = "0x4000EC2")]
    [FieldOffset(Offset = "0x4")]
    private static readonly int[] DECODER_TABLE_64;
    [Token(Token = "0x4000EC3")]
    [FieldOffset(Offset = "0x8")]
    private static readonly int[] DEBRUIJN_TABLE_32;
    [Token(Token = "0x4000EC4")]
    [FieldOffset(Offset = "0xC")]
    private static readonly int[] DEBRUIJN_TABLE_64;
    [Token(Token = "0x4000EC5")]
    private const int MAX_NB_ATTEMPTS = 256;
    [Token(Token = "0x4000EC6")]
    private const int OPTIMAL_ML = 18;
    [Token(Token = "0x4000EC7")]
    private const int BLOCK_COPY_LIMIT = 16;

    [Token(Token = "0x6001537")]
    [Address(RVA = "0x5C8420", Offset = "0x5C7220", VA = "0x105C8420")]
    public static int MaximumOutputLength(int inputLength) => new int();

    [Token(Token = "0x6001538")]
    [Address(RVA = "0x5C4650", Offset = "0x5C3450", VA = "0x105C4650")]
    internal static void CheckArguments(
      byte[] input,
      int inputOffset,
      int inputLength,
      byte[] output,
      int outputOffset,
      int outputLength)
    {
    }

    [Token(Token = "0x6001539")]
    [Address(RVA = "0x5C4FA0", Offset = "0x5C3DA0", VA = "0x105C4FA0")]
    public static int Encode(
      byte[] input,
      int inputOffset,
      int inputLength,
      byte[] output,
      int outputOffset,
      int outputLength)
    {
      return new int();
    }

    [Token(Token = "0x600153A")]
    [Address(RVA = "0x5C4BA0", Offset = "0x5C39A0", VA = "0x105C4BA0")]
    public static int Decode(
      byte[] input,
      int inputOffset,
      int inputLength,
      byte[] output,
      int outputOffset,
      int outputLength)
    {
      return new int();
    }

    [Token(Token = "0x600153B")]
    [Address(RVA = "0x5C4270", Offset = "0x5C3070", VA = "0x105C4270")]
    [Conditional("DEBUG")]
    private static void Assert(bool condition, string errorMessage)
    {
    }

    [Token(Token = "0x600153C")]
    [Address(RVA = "0x5C84F0", Offset = "0x5C72F0", VA = "0x105C84F0")]
    internal static void Poke2(byte[] buffer, int offset, ushort value)
    {
    }

    [Token(Token = "0x600153D")]
    [Address(RVA = "0x5C8440", Offset = "0x5C7240", VA = "0x105C8440")]
    internal static ushort Peek2(byte[] buffer, int offset) => new ushort();

    [Token(Token = "0x600153E")]
    [Address(RVA = "0x5C8480", Offset = "0x5C7280", VA = "0x105C8480")]
    internal static uint Peek4(byte[] buffer, int offset) => new uint();

    [Token(Token = "0x600153F")]
    [Address(RVA = "0x5C88D0", Offset = "0x5C76D0", VA = "0x105C88D0")]
    private static uint Xor4(byte[] buffer, int offset1, int offset2) => new uint();

    [Token(Token = "0x6001540")]
    [Address(RVA = "0x5C89B0", Offset = "0x5C77B0", VA = "0x105C89B0")]
    private static ulong Xor8(byte[] buffer, int offset1, int offset2) => new ulong();

    [Token(Token = "0x6001541")]
    [Address(RVA = "0x5C51E0", Offset = "0x5C3FE0", VA = "0x105C51E0")]
    private static bool Equal2(byte[] buffer, int offset1, int offset2) => new bool();

    [Token(Token = "0x6001542")]
    [Address(RVA = "0x5C5240", Offset = "0x5C4040", VA = "0x105C5240")]
    private static bool Equal4(byte[] buffer, int offset1, int offset2) => new bool();

    [Token(Token = "0x6001543")]
    [Address(RVA = "0x5C4840", Offset = "0x5C3640", VA = "0x105C4840")]
    private static void Copy4(byte[] buf, int src, int dst)
    {
    }

    [Token(Token = "0x6001544")]
    [Address(RVA = "0x5C48D0", Offset = "0x5C36D0", VA = "0x105C48D0")]
    private static void Copy8(byte[] buf, int src, int dst)
    {
    }

    [Token(Token = "0x6001545")]
    [Address(RVA = "0x5C42C0", Offset = "0x5C30C0", VA = "0x105C42C0")]
    private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len)
    {
    }

    [Token(Token = "0x6001546")]
    [Address(RVA = "0x5C8700", Offset = "0x5C7500", VA = "0x105C8700")]
    private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end)
    {
      return new int();
    }

    [Token(Token = "0x6001547")]
    [Address(RVA = "0x5C8530", Offset = "0x5C7330", VA = "0x105C8530")]
    private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end) => new int();

    [Token(Token = "0x6001548")]
    [Address(RVA = "0x5C4DA0", Offset = "0x5C3BA0", VA = "0x105C4DA0")]
    public static int Encode32Safe(
      byte[] input,
      int inputOffset,
      int inputLength,
      byte[] output,
      int outputOffset,
      int outputLength)
    {
      return new int();
    }

    [Token(Token = "0x6001549")]
    [Address(RVA = "0x5C4EA0", Offset = "0x5C3CA0", VA = "0x105C4EA0")]
    public static int Encode64Safe(
      byte[] input,
      int inputOffset,
      int inputLength,
      byte[] output,
      int outputOffset,
      int outputLength)
    {
      return new int();
    }

    [Token(Token = "0x600154A")]
    [Address(RVA = "0x5C49E0", Offset = "0x5C37E0", VA = "0x105C49E0")]
    public static int Decode32Safe(
      byte[] input,
      int inputOffset,
      int inputLength,
      byte[] output,
      int outputOffset,
      int outputLength)
    {
      return new int();
    }

    [Token(Token = "0x600154B")]
    [Address(RVA = "0x5C4AC0", Offset = "0x5C38C0", VA = "0x105C4AC0")]
    public static int Decode64Safe(
      byte[] input,
      int inputOffset,
      int inputLength,
      byte[] output,
      int outputOffset,
      int outputLength)
    {
      return new int();
    }

    [Token(Token = "0x600154C")]
    [Address(RVA = "0x5C6590", Offset = "0x5C5390", VA = "0x105C6590")]
    private static int LZ4_compressCtx_safe32(
      int[] hash_table,
      byte[] src,
      byte[] dst,
      int src_0,
      int dst_0,
      int src_len,
      int dst_maxlen)
    {
      return new int();
    }

    [Token(Token = "0x600154D")]
    [Address(RVA = "0x5C52D0", Offset = "0x5C40D0", VA = "0x105C52D0")]
    private static int LZ4_compress64kCtx_safe32(
      ushort[] hash_table,
      byte[] src,
      byte[] dst,
      int src_0,
      int dst_0,
      int src_len,
      int dst_maxlen)
    {
      return new int();
    }

    [Token(Token = "0x600154E")]
    [Address(RVA = "0x5C79E0", Offset = "0x5C67E0", VA = "0x105C79E0")]
    private static int LZ4_uncompress_safe32(
      byte[] src,
      byte[] dst,
      int src_0,
      int dst_0,
      int dst_len)
    {
      return new int();
    }

    [Token(Token = "0x600154F")]
    [Address(RVA = "0x5C6F20", Offset = "0x5C5D20", VA = "0x105C6F20")]
    private static int LZ4_compressCtx_safe64(
      int[] hash_table,
      byte[] src,
      byte[] dst,
      int src_0,
      int dst_0,
      int src_len,
      int dst_maxlen)
    {
      return new int();
    }

    [Token(Token = "0x6001550")]
    [Address(RVA = "0x5C5B90", Offset = "0x5C4990", VA = "0x105C5B90")]
    private static int LZ4_compress64kCtx_safe64(
      ushort[] hash_table,
      byte[] src,
      byte[] dst,
      int src_0,
      int dst_0,
      int src_len,
      int dst_maxlen)
    {
      return new int();
    }

    [Token(Token = "0x6001551")]
    [Address(RVA = "0x5C7EA0", Offset = "0x5C6CA0", VA = "0x105C7EA0")]
    private static int LZ4_uncompress_safe64(
      byte[] src,
      byte[] dst,
      int src_0,
      int dst_0,
      int dst_len)
    {
      return new int();
    }

    [Token(Token = "0x6001552")]
    [Address(RVA = "0x5C8BF0", Offset = "0x5C79F0", VA = "0x105C8BF0")]
    static LZ4Codec()
    {
    }

    [Token(Token = "0x2000457")]
    internal static class HashTablePool
    {
      [Token(Token = "0x4000EC8")]
      [ThreadStatic]
      private static ushort[] ushortPool;
      [Token(Token = "0x4000EC9")]
      [ThreadStatic]
      private static uint[] uintPool;
      [Token(Token = "0x4000ECA")]
      [ThreadStatic]
      private static int[] intPool;

      [Token(Token = "0x6001553")]
      [Address(RVA = "0x5C1D00", Offset = "0x5C0B00", VA = "0x105C1D00")]
      public static ushort[] GetUShortHashTablePool() => (ushort[]) null;

      [Token(Token = "0x6001554")]
      [Address(RVA = "0x5C1C20", Offset = "0x5C0A20", VA = "0x105C1C20")]
      public static uint[] GetUIntHashTablePool() => (uint[]) null;

      [Token(Token = "0x6001555")]
      [Address(RVA = "0x5C1B40", Offset = "0x5C0940", VA = "0x105C1B40")]
      public static int[] GetIntHashTablePool() => (int[]) null;
    }
  }
}
