// Decompiled with JetBrains decompiler
// Type: MyGUID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000251")]
public class MyGUID
{
  [Token(Token = "0x40009D9")]
  [FieldOffset(Offset = "0x0")]
  public static readonly OInt GUID_SEED;
  [Token(Token = "0x40009DD")]
  [FieldOffset(Offset = "0x14")]
  private bool mSetup;

  [Token(Token = "0x17000176")]
  public string udid
  {
    [Token(Token = "0x6000C56"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000C57"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
    {
    }
  }

  [Token(Token = "0x17000177")]
  public string secret_key
  {
    [Token(Token = "0x6000C58"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000C59"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
    {
    }
  }

  [Token(Token = "0x17000178")]
  public string device_id
  {
    [Token(Token = "0x6000C5A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000C5B"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
    {
    }
  }

  [Token(Token = "0x6000C5C")]
  [Address(RVA = "0x321E60", Offset = "0x320C60", VA = "0x10321E60")]
  private static byte[] Encrypt(int seed, string src) => (byte[]) null;

  [Token(Token = "0x6000C5D")]
  [Address(RVA = "0x321D30", Offset = "0x320B30", VA = "0x10321D30")]
  private static string Decrypt(int seed, byte[] src) => (string) null;

  [Token(Token = "0x6000C5E")]
  [Address(RVA = "0x10836F0", Offset = "0x10824F0", VA = "0x110836F0")]
  private static string GetPersistFileNameOld() => (string) null;

  [Token(Token = "0x6000C5F")]
  [Address(RVA = "0x10833F0", Offset = "0x10821F0", VA = "0x110833F0")]
  private static string GetCacheFileNameOld() => (string) null;

  [Token(Token = "0x6000C60")]
  [Address(RVA = "0x1083F70", Offset = "0x1082D70", VA = "0x11083F70")]
  private static byte[] ReadPersistOld() => (byte[]) null;

  [Token(Token = "0x6000C61")]
  [Address(RVA = "0x1083D40", Offset = "0x1082B40", VA = "0x11083D40")]
  private static byte[] ReadCacheOld() => (byte[]) null;

  [Token(Token = "0x6000C62")]
  [Address(RVA = "0x1083270", Offset = "0x1082070", VA = "0x11083270")]
  private static byte[] ConvertOldCache(int seed) => (byte[]) null;

  [Token(Token = "0x6000C63")]
  [Address(RVA = "0x1083330", Offset = "0x1082130", VA = "0x11083330")]
  private static byte[] ConvertOldPersist(int seed) => (byte[]) null;

  [Token(Token = "0x6000C64")]
  [Address(RVA = "0x1083730", Offset = "0x1082530", VA = "0x11083730")]
  private static string GetPersistFileName() => (string) null;

  [Token(Token = "0x6000C65")]
  [Address(RVA = "0x1083430", Offset = "0x1082230", VA = "0x11083430")]
  private static string GetCacheFileName() => (string) null;

  [Token(Token = "0x6000C66")]
  [Address(RVA = "0x1084630", Offset = "0x1083430", VA = "0x11084630")]
  private static bool SavePersist(byte[] value) => new bool();

  [Token(Token = "0x6000C67")]
  [Address(RVA = "0x10840A0", Offset = "0x1082EA0", VA = "0x110840A0")]
  private static byte[] ReadPersist() => (byte[]) null;

  [Token(Token = "0x6000C68")]
  [Address(RVA = "0x1084460", Offset = "0x1083260", VA = "0x11084460")]
  private static bool SaveCache(byte[] value) => new bool();

  [Token(Token = "0x6000C69")]
  [Address(RVA = "0x10841A0", Offset = "0x1082FA0", VA = "0x110841A0")]
  public bool ResetCache() => new bool();

  [Token(Token = "0x6000C6A")]
  [Address(RVA = "0x1083E70", Offset = "0x1082C70", VA = "0x11083E70")]
  private static byte[] ReadCache() => (byte[]) null;

  [Token(Token = "0x6000C6B")]
  [Address(RVA = "0x1083AD0", Offset = "0x10828D0", VA = "0x11083AD0")]
  public bool Init(int seed) => new bool();

  [Token(Token = "0x6000C6C")]
  [Address(RVA = "0x1084390", Offset = "0x1083190", VA = "0x11084390")]
  public bool SaveAuth(int seed, string secretKey, string deviceId, string udId) => new bool();

  [Token(Token = "0x6000C6D")]
  [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
  public void SetSecretKey(string key)
  {
  }

  [Token(Token = "0x6000C6E")]
  [Address(RVA = "0x1083570", Offset = "0x1082370", VA = "0x11083570")]
  public string GetDeletionTokenFileName() => (string) null;

  [Token(Token = "0x6000C6F")]
  [Address(RVA = "0x1084550", Offset = "0x1083350", VA = "0x11084550")]
  public void SaveDeletionToken(string token)
  {
  }

  [Token(Token = "0x6000C70")]
  [Address(RVA = "0x10842B0", Offset = "0x10830B0", VA = "0x110842B0")]
  public bool ResetDeletionToken() => new bool();

  [Token(Token = "0x6000C71")]
  [Address(RVA = "0x10835B0", Offset = "0x10823B0", VA = "0x110835B0")]
  public static string GetDeviceId() => (string) null;

  [Token(Token = "0x6000C72")]
  [Address(RVA = "0x1083870", Offset = "0x1082670", VA = "0x11083870")]
  public static string GetSecretKey() => (string) null;

  [Token(Token = "0x6000C73")]
  [Address(RVA = "0x10839C0", Offset = "0x10827C0", VA = "0x110839C0")]
  public static string GetUDID() => (string) null;

  [Token(Token = "0x6000C74")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public static void ResetUDID()
  {
  }

  [Token(Token = "0x6000C75")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public MyGUID()
  {
  }

  [Token(Token = "0x6000C76")]
  [Address(RVA = "0x1084720", Offset = "0x1083520", VA = "0x11084720")]
  static MyGUID()
  {
  }
}
