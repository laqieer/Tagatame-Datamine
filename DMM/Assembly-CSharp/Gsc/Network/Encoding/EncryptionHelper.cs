// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Encoding.EncryptionHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Gsc.Network.Encoding
{
  [Token(Token = "0x20035A7")]
  public class EncryptionHelper
  {
    [Token(Token = "0x400FD93")]
    [FieldOffset(Offset = "0x0")]
    private static OByte[] aoba;
    [Token(Token = "0x400FD94")]
    [FieldOffset(Offset = "0x4")]
    private static OByte[] doba;

    [Token(Token = "0x600EE34")]
    [Address(RVA = "0xB078F0", Offset = "0xB066F0", VA = "0x10B078F0")]
    static EncryptionHelper()
    {
    }

    [Token(Token = "0x600EE35")]
    [Address(RVA = "0xB05FE0", Offset = "0xB04DE0", VA = "0x10B05FE0")]
    internal static byte[] Decrypt(
      EncryptionHelper.KeyType keyType,
      byte[] input,
      string keySalt,
      EncryptionHelper.DecryptOptions options)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600EE36")]
    [Address(RVA = "0xB06420", Offset = "0xB05220", VA = "0x10B06420")]
    internal static byte[] Encrypt(EncryptionHelper.KeyType keyType, byte[] input, string keySalt)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600EE37")]
    [Address(RVA = "0xB07450", Offset = "0xB06250", VA = "0x10B07450")]
    public static bool IsUseAPPSharedKey(string apiName) => new bool();

    [Token(Token = "0x600EE38")]
    [Address(RVA = "0xB07660", Offset = "0xB06460", VA = "0x10B07660")]
    private static EncryptionHelper.DecryptOptions UseWhatExtraKeySalt(string apiName)
    {
      return new EncryptionHelper.DecryptOptions();
    }

    [Token(Token = "0x600EE39")]
    [Address(RVA = "0xB06930", Offset = "0xB05730", VA = "0x10B06930")]
    private static byte[] GetSharedKey(EncryptionHelper.KeyType keyType, Texture2D useThisImage = null)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600EE3A")]
    [Address(RVA = "0xB07580", Offset = "0xB06380", VA = "0x10B07580")]
    private static void KeyNotEmbeddedError(EncryptionHelper.KeyType keyType, Exception e)
    {
    }

    [Token(Token = "0x600EE3B")]
    [Address(RVA = "0xB05F80", Offset = "0xB04D80", VA = "0x10B05F80")]
    public static byte[] DecryptEmbeddedTutorialMasterData(byte[] input) => (byte[]) null;

    [Token(Token = "0x600EE3C")]
    [Address(RVA = "0xB067D0", Offset = "0xB055D0", VA = "0x10B067D0")]
    private static Texture2D GetKeyImageAsset(EncryptionHelper.KeyType keyType) => (Texture2D) null;

    [Token(Token = "0x600EE3D")]
    [Address(RVA = "0xB072A0", Offset = "0xB060A0", VA = "0x10B072A0")]
    private static byte[] Hex2Byte(string hex) => (byte[]) null;

    [Token(Token = "0x600EE3E")]
    [Address(RVA = "0xB075A0", Offset = "0xB063A0", VA = "0x10B075A0")]
    private static int ReverseBits(int n) => new int();

    [Token(Token = "0x600EE3F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EncryptionHelper()
    {
    }

    [Token(Token = "0x20035A8")]
    public enum KeyType
    {
      [Token(Token = "0x400FD96")] APP,
      [Token(Token = "0x400FD97")] DLC,
    }

    [Token(Token = "0x20035A9")]
    internal enum DecryptOptions
    {
      [Token(Token = "0x400FD99")] None,
      [Token(Token = "0x400FD9A")] IsFile,
      [Token(Token = "0x400FD9B")] ExtraKeySaltAT,
      [Token(Token = "0x400FD9C")] ExtraKeySaltATDI,
    }
  }
}
