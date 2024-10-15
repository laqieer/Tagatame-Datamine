// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x2003694")]
  public static class ObscuredPrefs
  {
    [Token(Token = "0x401000D")]
    private const byte Version = 2;
    [Token(Token = "0x401000E")]
    private const string RawNotFound = "{not_found}";
    [Token(Token = "0x401000F")]
    private const string DataSeparator = "|";
    [Token(Token = "0x4010010")]
    [FieldOffset(Offset = "0x0")]
    private static bool alterationReported;
    [Token(Token = "0x4010011")]
    [FieldOffset(Offset = "0x1")]
    private static bool foreignSavesReported;
    [Token(Token = "0x4010012")]
    [FieldOffset(Offset = "0x4")]
    private static string cryptoKey;
    [Token(Token = "0x4010013")]
    [FieldOffset(Offset = "0x8")]
    private static string deviceId;
    [Token(Token = "0x4010014")]
    [FieldOffset(Offset = "0xC")]
    private static uint deviceIdHash;
    [Token(Token = "0x4010015")]
    [FieldOffset(Offset = "0x10")]
    [Obsolete("Please use OnAlterationDetected event instead.")]
    public static Action onAlterationDetected;
    [Token(Token = "0x4010017")]
    [FieldOffset(Offset = "0x18")]
    [Obsolete("Please use OnPossibleForeignSavesDetected event instead.")]
    public static Action onPossibleForeignSavesDetected;
    [Token(Token = "0x4010019")]
    [FieldOffset(Offset = "0x20")]
    public static bool preservePlayerPrefs;
    [Token(Token = "0x401001A")]
    [FieldOffset(Offset = "0x21")]
    public static ObscuredPrefs.DeviceLockLevel lockToDevice;
    [Token(Token = "0x401001B")]
    [FieldOffset(Offset = "0x22")]
    public static bool readForeignSaves;
    [Token(Token = "0x401001C")]
    [FieldOffset(Offset = "0x23")]
    public static bool emergencyMode;
    [Token(Token = "0x401001D")]
    private const char DEPRECATED_RAW_SEPARATOR = ':';
    [Token(Token = "0x401001E")]
    [FieldOffset(Offset = "0x24")]
    private static string deprecatedDeviceId;

    [Token(Token = "0x1700235B")]
    public static string CryptoKey
    {
      [Token(Token = "0x600F50C"), Address(RVA = "0xB56880", Offset = "0xB55680", VA = "0x10B56880")] set
      {
      }
      [Token(Token = "0x600F50D"), Address(RVA = "0xB56450", Offset = "0xB55250", VA = "0x10B56450")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700235C")]
    public static string DeviceId
    {
      [Token(Token = "0x600F50E"), Address(RVA = "0xB56620", Offset = "0xB55420", VA = "0x10B56620")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F50F"), Address(RVA = "0xB56970", Offset = "0xB55770", VA = "0x10B56970")] set
      {
      }
    }

    [Token(Token = "0x1700235D")]
    [Obsolete("This property is obsolete, please use DeviceId instead.")]
    internal static string DeviceID
    {
      [Token(Token = "0x600F510"), Address(RVA = "0xB56540", Offset = "0xB55340", VA = "0x10B56540")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F511"), Address(RVA = "0xB568E0", Offset = "0xB556E0", VA = "0x10B568E0")] set
      {
      }
    }

    [Token(Token = "0x1700235E")]
    private static uint DeviceIdHash
    {
      [Token(Token = "0x600F512"), Address(RVA = "0xB56580", Offset = "0xB55380", VA = "0x10B56580")] get
      {
        return new uint();
      }
    }

    [Token(Token = "0x14000015")]
    public static event Action OnAlterationDetected
    {
      [Token(Token = "0x600F513"), Address(RVA = "0xB562D0", Offset = "0xB550D0", VA = "0x10B562D0")] add
      {
      }
      [Token(Token = "0x600F514"), Address(RVA = "0xB56700", Offset = "0xB55500", VA = "0x10B56700")] remove
      {
      }
    }

    [Token(Token = "0x14000016")]
    public static event Action OnPossibleForeignSavesDetected
    {
      [Token(Token = "0x600F515"), Address(RVA = "0xB56390", Offset = "0xB55190", VA = "0x10B56390")] add
      {
      }
      [Token(Token = "0x600F516"), Address(RVA = "0xB567C0", Offset = "0xB555C0", VA = "0x10B567C0")] remove
      {
      }
    }

    [Token(Token = "0x600F517")]
    [Address(RVA = "0xB52EB0", Offset = "0xB51CB0", VA = "0x10B52EB0")]
    public static void ForceLockToDeviceInit()
    {
    }

    [Token(Token = "0x600F518")]
    [Address(RVA = "0xB558E0", Offset = "0xB546E0", VA = "0x10B558E0")]
    [Obsolete("This method is obsolete, use property CryptoKey instead")]
    internal static void SetNewCryptoKey(string newKey)
    {
    }

    [Token(Token = "0x600F519")]
    [Address(RVA = "0xB55740", Offset = "0xB54540", VA = "0x10B55740")]
    public static void SetInt(string key, int value)
    {
    }

    [Token(Token = "0x600F51A")]
    [Address(RVA = "0xB53C30", Offset = "0xB52A30", VA = "0x10B53C30")]
    public static int GetInt(string key) => new int();

    [Token(Token = "0x600F51B")]
    [Address(RVA = "0xB53C80", Offset = "0xB52A80", VA = "0x10B53C80")]
    public static int GetInt(string key, int defaultValue) => new int();

    [Token(Token = "0x600F51C")]
    [Address(RVA = "0xB52730", Offset = "0xB51530", VA = "0x10B52730")]
    public static string EncryptIntValue(string key, int value) => (string) null;

    [Token(Token = "0x600F51D")]
    [Address(RVA = "0xB505E0", Offset = "0xB4F3E0", VA = "0x10B505E0")]
    public static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
    {
      return new int();
    }

    [Token(Token = "0x600F51E")]
    [Address(RVA = "0xB55E10", Offset = "0xB54C10", VA = "0x10B55E10")]
    public static void SetUInt(string key, uint value)
    {
    }

    [Token(Token = "0x600F51F")]
    [Address(RVA = "0xB54890", Offset = "0xB53690", VA = "0x10B54890")]
    public static uint GetUInt(string key) => new uint();

    [Token(Token = "0x600F520")]
    [Address(RVA = "0xB547F0", Offset = "0xB535F0", VA = "0x10B547F0")]
    public static uint GetUInt(string key, uint defaultValue) => new uint();

    [Token(Token = "0x600F521")]
    [Address(RVA = "0xB52BF0", Offset = "0xB519F0", VA = "0x10B52BF0")]
    public static string EncryptUIntValue(string key, uint value) => (string) null;

    [Token(Token = "0x600F522")]
    [Address(RVA = "0xB510B0", Offset = "0xB4FEB0", VA = "0x10B510B0")]
    public static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
    {
      return new uint();
    }

    [Token(Token = "0x600F523")]
    [Address(RVA = "0xB55CE0", Offset = "0xB54AE0", VA = "0x10B55CE0")]
    public static void SetString(string key, string value)
    {
    }

    [Token(Token = "0x600F524")]
    [Address(RVA = "0xB54570", Offset = "0xB53370", VA = "0x10B54570")]
    public static string GetString(string key) => (string) null;

    [Token(Token = "0x600F525")]
    [Address(RVA = "0xB545D0", Offset = "0xB533D0", VA = "0x10B545D0")]
    public static string GetString(string key, string defaultValue) => (string) null;

    [Token(Token = "0x600F526")]
    [Address(RVA = "0xB52B70", Offset = "0xB51970", VA = "0x10B52B70")]
    public static string EncryptStringValue(string key, string value) => (string) null;

    [Token(Token = "0x600F527")]
    [Address(RVA = "0xB50FB0", Offset = "0xB4FDB0", VA = "0x10B50FB0")]
    public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
    {
      return (string) null;
    }

    [Token(Token = "0x600F528")]
    [Address(RVA = "0xB55670", Offset = "0xB54470", VA = "0x10B55670")]
    public static void SetFloat(string key, float value)
    {
    }

    [Token(Token = "0x600F529")]
    [Address(RVA = "0xB53BE0", Offset = "0xB529E0", VA = "0x10B53BE0")]
    public static float GetFloat(string key) => new float();

    [Token(Token = "0x600F52A")]
    [Address(RVA = "0xB53960", Offset = "0xB52760", VA = "0x10B53960")]
    public static float GetFloat(string key, float defaultValue) => new float();

    [Token(Token = "0x600F52B")]
    [Address(RVA = "0xB526B0", Offset = "0xB514B0", VA = "0x10B526B0")]
    public static string EncryptFloatValue(string key, float value) => (string) null;

    [Token(Token = "0x600F52C")]
    [Address(RVA = "0xB504A0", Offset = "0xB4F2A0", VA = "0x10B504A0")]
    public static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
    {
      return new float();
    }

    [Token(Token = "0x600F52D")]
    [Address(RVA = "0xB555A0", Offset = "0xB543A0", VA = "0x10B555A0")]
    public static void SetDouble(string key, double value)
    {
    }

    [Token(Token = "0x600F52E")]
    [Address(RVA = "0xB53700", Offset = "0xB52500", VA = "0x10B53700")]
    public static double GetDouble(string key) => new double();

    [Token(Token = "0x600F52F")]
    [Address(RVA = "0xB537F0", Offset = "0xB525F0", VA = "0x10B537F0")]
    public static double GetDouble(string key, double defaultValue) => new double();

    [Token(Token = "0x600F530")]
    [Address(RVA = "0xB52630", Offset = "0xB51430", VA = "0x10B52630")]
    private static string EncryptDoubleValue(string key, double value) => (string) null;

    [Token(Token = "0x600F531")]
    [Address(RVA = "0xB502B0", Offset = "0xB4F0B0", VA = "0x10B502B0")]
    private static double DecryptDoubleValue(
      string key,
      string encryptedInput,
      double defaultValue)
    {
      return new double();
    }

    [Token(Token = "0x600F532")]
    [Address(RVA = "0xB553E0", Offset = "0xB541E0", VA = "0x10B553E0")]
    public static void SetDecimal(string key, Decimal value)
    {
    }

    [Token(Token = "0x600F533")]
    [Address(RVA = "0xB534D0", Offset = "0xB522D0", VA = "0x10B534D0")]
    public static Decimal GetDecimal(string key) => 0M;

    [Token(Token = "0x600F534")]
    [Address(RVA = "0xB535F0", Offset = "0xB523F0", VA = "0x10B535F0")]
    public static Decimal GetDecimal(string key, Decimal defaultValue) => 0M;

    [Token(Token = "0x600F535")]
    [Address(RVA = "0xB52410", Offset = "0xB51210", VA = "0x10B52410")]
    private static string EncryptDecimalValue(string key, Decimal value) => (string) null;

    [Token(Token = "0x600F536")]
    [Address(RVA = "0xB50070", Offset = "0xB4EE70", VA = "0x10B50070")]
    private static Decimal DecryptDecimalValue(
      string key,
      string encryptedInput,
      Decimal defaultValue)
    {
      return 0M;
    }

    [Token(Token = "0x600F537")]
    [Address(RVA = "0xB55810", Offset = "0xB54610", VA = "0x10B55810")]
    public static void SetLong(string key, long value)
    {
    }

    [Token(Token = "0x600F538")]
    [Address(RVA = "0xB53EB0", Offset = "0xB52CB0", VA = "0x10B53EB0")]
    public static long GetLong(string key) => new long();

    [Token(Token = "0x600F539")]
    [Address(RVA = "0xB53F90", Offset = "0xB52D90", VA = "0x10B53F90")]
    public static long GetLong(string key, long defaultValue) => new long();

    [Token(Token = "0x600F53A")]
    [Address(RVA = "0xB52880", Offset = "0xB51680", VA = "0x10B52880")]
    private static string EncryptLongValue(string key, long value) => (string) null;

    [Token(Token = "0x600F53B")]
    [Address(RVA = "0xB50710", Offset = "0xB4F510", VA = "0x10B50710")]
    private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
    {
      return new long();
    }

    [Token(Token = "0x600F53C")]
    [Address(RVA = "0xB55EE0", Offset = "0xB54CE0", VA = "0x10B55EE0")]
    public static void SetULong(string key, ulong value)
    {
    }

    [Token(Token = "0x600F53D")]
    [Address(RVA = "0xB54A00", Offset = "0xB53800", VA = "0x10B54A00")]
    public static ulong GetULong(string key) => new ulong();

    [Token(Token = "0x600F53E")]
    [Address(RVA = "0xB54960", Offset = "0xB53760", VA = "0x10B54960")]
    public static ulong GetULong(string key, ulong defaultValue) => new ulong();

    [Token(Token = "0x600F53F")]
    [Address(RVA = "0xB52C70", Offset = "0xB51A70", VA = "0x10B52C70")]
    private static string EncryptULongValue(string key, ulong value) => (string) null;

    [Token(Token = "0x600F540")]
    [Address(RVA = "0xB51290", Offset = "0xB50090", VA = "0x10B51290")]
    private static ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue)
    {
      return new ulong();
    }

    [Token(Token = "0x600F541")]
    [Address(RVA = "0xB55190", Offset = "0xB53F90", VA = "0x10B55190")]
    public static void SetBool(string key, bool value)
    {
    }

    [Token(Token = "0x600F542")]
    [Address(RVA = "0xB53070", Offset = "0xB51E70", VA = "0x10B53070")]
    public static bool GetBool(string key) => new bool();

    [Token(Token = "0x600F543")]
    [Address(RVA = "0xB52FD0", Offset = "0xB51DD0", VA = "0x10B52FD0")]
    public static bool GetBool(string key, bool defaultValue) => new bool();

    [Token(Token = "0x600F544")]
    [Address(RVA = "0xB52060", Offset = "0xB50E60", VA = "0x10B52060")]
    private static string EncryptBoolValue(string key, bool value) => (string) null;

    [Token(Token = "0x600F545")]
    [Address(RVA = "0xB4F900", Offset = "0xB4E700", VA = "0x10B4F900")]
    private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
    {
      return new bool();
    }

    [Token(Token = "0x600F546")]
    [Address(RVA = "0xB55260", Offset = "0xB54060", VA = "0x10B55260")]
    public static void SetByteArray(string key, byte[] value)
    {
    }

    [Token(Token = "0x600F547")]
    [Address(RVA = "0xB53140", Offset = "0xB51F40", VA = "0x10B53140")]
    public static byte[] GetByteArray(string key) => (byte[]) null;

    [Token(Token = "0x600F548")]
    [Address(RVA = "0xB53250", Offset = "0xB52050", VA = "0x10B53250")]
    public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600F549")]
    [Address(RVA = "0xB520E0", Offset = "0xB50EE0", VA = "0x10B520E0")]
    private static string EncryptByteArrayValue(string key, byte[] value) => (string) null;

    [Token(Token = "0x600F54A")]
    [Address(RVA = "0xB4FAF0", Offset = "0xB4E8F0", VA = "0x10B4FAF0")]
    private static byte[] DecryptByteArrayValue(
      string key,
      string encryptedInput,
      byte defaultValue,
      int defaultLength)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600F54B")]
    [Address(RVA = "0xB4F8A0", Offset = "0xB4E6A0", VA = "0x10B4F8A0")]
    private static byte[] ConstructByteArray(byte value, int length) => (byte[]) null;

    [Token(Token = "0x600F54C")]
    [Address(RVA = "0xB55FC0", Offset = "0xB54DC0", VA = "0x10B55FC0")]
    public static void SetVector2(string key, Vector2 value)
    {
    }

    [Token(Token = "0x600F54D")]
    [Address(RVA = "0xB54AE0", Offset = "0xB538E0", VA = "0x10B54AE0")]
    public static Vector2 GetVector2(string key) => new Vector2();

    [Token(Token = "0x600F54E")]
    [Address(RVA = "0xB54C10", Offset = "0xB53A10", VA = "0x10B54C10")]
    public static Vector2 GetVector2(string key, Vector2 defaultValue) => new Vector2();

    [Token(Token = "0x600F54F")]
    [Address(RVA = "0xB52CF0", Offset = "0xB51AF0", VA = "0x10B52CF0")]
    private static string EncryptVector2Value(string key, Vector2 value) => (string) null;

    [Token(Token = "0x600F550")]
    [Address(RVA = "0xB51480", Offset = "0xB50280", VA = "0x10B51480")]
    private static Vector2 DecryptVector2Value(
      string key,
      string encryptedInput,
      Vector2 defaultValue)
    {
      return new Vector2();
    }

    [Token(Token = "0x600F551")]
    [Address(RVA = "0xB560E0", Offset = "0xB54EE0", VA = "0x10B560E0")]
    public static void SetVector3(string key, Vector3 value)
    {
    }

    [Token(Token = "0x600F552")]
    [Address(RVA = "0xB54D90", Offset = "0xB53B90", VA = "0x10B54D90")]
    public static Vector3 GetVector3(string key) => new Vector3();

    [Token(Token = "0x600F553")]
    [Address(RVA = "0xB54CB0", Offset = "0xB53AB0", VA = "0x10B54CB0")]
    public static Vector3 GetVector3(string key, Vector3 defaultValue) => new Vector3();

    [Token(Token = "0x600F554")]
    [Address(RVA = "0xB52DC0", Offset = "0xB51BC0", VA = "0x10B52DC0")]
    private static string EncryptVector3Value(string key, Vector3 value) => (string) null;

    [Token(Token = "0x600F555")]
    [Address(RVA = "0xB51780", Offset = "0xB50580", VA = "0x10B51780")]
    private static Vector3 DecryptVector3Value(
      string key,
      string encryptedInput,
      Vector3 defaultValue)
    {
      return new Vector3();
    }

    [Token(Token = "0x600F556")]
    [Address(RVA = "0xB55970", Offset = "0xB54770", VA = "0x10B55970")]
    public static void SetQuaternion(string key, Quaternion value)
    {
    }

    [Token(Token = "0x600F557")]
    [Address(RVA = "0xB540F0", Offset = "0xB52EF0", VA = "0x10B540F0")]
    public static Quaternion GetQuaternion(string key) => new Quaternion();

    [Token(Token = "0x600F558")]
    [Address(RVA = "0xB54030", Offset = "0xB52E30", VA = "0x10B54030")]
    public static Quaternion GetQuaternion(string key, Quaternion defaultValue) => new Quaternion();

    [Token(Token = "0x600F559")]
    [Address(RVA = "0xB52900", Offset = "0xB51700", VA = "0x10B52900")]
    private static string EncryptQuaternionValue(string key, Quaternion value) => (string) null;

    [Token(Token = "0x600F55A")]
    [Address(RVA = "0xB50900", Offset = "0xB4F700", VA = "0x10B50900")]
    private static Quaternion DecryptQuaternionValue(
      string key,
      string encryptedInput,
      Quaternion defaultValue)
    {
      return new Quaternion();
    }

    [Token(Token = "0x600F55B")]
    [Address(RVA = "0xB55300", Offset = "0xB54100", VA = "0x10B55300")]
    public static void SetColor(string key, Color32 value)
    {
    }

    [Token(Token = "0x600F55C")]
    [Address(RVA = "0xB53310", Offset = "0xB52110", VA = "0x10B53310")]
    public static Color32 GetColor(string key) => new Color32();

    [Token(Token = "0x600F55D")]
    [Address(RVA = "0xB53410", Offset = "0xB52210", VA = "0x10B53410")]
    public static Color32 GetColor(string key, Color32 defaultValue) => new Color32();

    [Token(Token = "0x600F55E")]
    [Address(RVA = "0xB52130", Offset = "0xB50F30", VA = "0x10B52130")]
    private static string EncryptColorValue(string key, uint value) => (string) null;

    [Token(Token = "0x600F55F")]
    [Address(RVA = "0xB55B30", Offset = "0xB54930", VA = "0x10B55B30")]
    public static void SetRect(string key, Rect value)
    {
    }

    [Token(Token = "0x600F560")]
    [Address(RVA = "0xB54440", Offset = "0xB53240", VA = "0x10B54440")]
    public static Rect GetRect(string key) => new Rect();

    [Token(Token = "0x600F561")]
    [Address(RVA = "0xB54380", Offset = "0xB53180", VA = "0x10B54380")]
    public static Rect GetRect(string key, Rect defaultValue) => new Rect();

    [Token(Token = "0x600F562")]
    [Address(RVA = "0xB52A20", Offset = "0xB51820", VA = "0x10B52A20")]
    private static string EncryptRectValue(string key, Rect value) => (string) null;

    [Token(Token = "0x600F563")]
    [Address(RVA = "0xB50CC0", Offset = "0xB4FAC0", VA = "0x10B50CC0")]
    private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
    {
      return new Rect();
    }

    [Token(Token = "0x600F564")]
    [Address(RVA = "0xB55AD0", Offset = "0xB548D0", VA = "0x10B55AD0")]
    public static void SetRawValue(string key, string encryptedValue)
    {
    }

    [Token(Token = "0x600F565")]
    [Address(RVA = "0xB54320", Offset = "0xB53120", VA = "0x10B54320")]
    public static string GetRawValue(string key) => (string) null;

    [Token(Token = "0x600F566")]
    [Address(RVA = "0xB54210", Offset = "0xB53010", VA = "0x10B54210")]
    public static ObscuredPrefs.DataType GetRawValueType(string value)
    {
      return new ObscuredPrefs.DataType();
    }

    [Token(Token = "0x600F567")]
    [Address(RVA = "0xB527B0", Offset = "0xB515B0", VA = "0x10B527B0")]
    public static string EncryptKey(string key) => (string) null;

    [Token(Token = "0x600F568")]
    [Address(RVA = "0xB54ED0", Offset = "0xB53CD0", VA = "0x10B54ED0")]
    public static bool HasKey(string key) => new bool();

    [Token(Token = "0x600F569")]
    [Address(RVA = "0xB51B10", Offset = "0xB50910", VA = "0x10B51B10")]
    public static void DeleteKey(string key)
    {
    }

    [Token(Token = "0x600F56A")]
    [Address(RVA = "0xB51B00", Offset = "0xB50900", VA = "0x10B51B00")]
    public static void DeleteAll()
    {
    }

    [Token(Token = "0x600F56B")]
    [Address(RVA = "0xB55060", Offset = "0xB53E60", VA = "0x10B55060")]
    public static void Save()
    {
    }

    [Token(Token = "0x600F56C")]
    [Address(RVA = "0xB538A0", Offset = "0xB526A0", VA = "0x10B538A0")]
    private static string GetEncryptedPrefsString(string key, string encryptedKey) => (string) null;

    [Token(Token = "0x600F56D")]
    [Address(RVA = "0xB521B0", Offset = "0xB50FB0", VA = "0x10B521B0")]
    private static string EncryptData(string key, byte[] cleanBytes, ObscuredPrefs.DataType type)
    {
      return (string) null;
    }

    [Token(Token = "0x600F56E")]
    [Address(RVA = "0xB4FCA0", Offset = "0xB4EAA0", VA = "0x10B4FCA0")]
    internal static byte[] DecryptData(string key, string encryptedInput) => (byte[]) null;

    [Token(Token = "0x600F56F")]
    [Address(RVA = "0xB4F810", Offset = "0xB4E610", VA = "0x10B4F810")]
    private static uint CalculateChecksum(string input) => new uint();

    [Token(Token = "0x600F570")]
    [Address(RVA = "0xB55070", Offset = "0xB53E70", VA = "0x10B55070")]
    private static void SavesTampered()
    {
    }

    [Token(Token = "0x600F571")]
    [Address(RVA = "0xB54F40", Offset = "0xB53D40", VA = "0x10B54F40")]
    private static void PossibleForeignSavesDetected()
    {
    }

    [Token(Token = "0x600F572")]
    [Address(RVA = "0xB536B0", Offset = "0xB524B0", VA = "0x10B536B0")]
    private static string GetDeviceId() => (string) null;

    [Token(Token = "0x600F573")]
    [Address(RVA = "0xB52580", Offset = "0xB51380", VA = "0x10B52580")]
    private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600F574")]
    [Address(RVA = "0xB51C90", Offset = "0xB50A90", VA = "0x10B51C90")]
    private static string DeprecatedDecryptValue(string value) => (string) null;

    [Token(Token = "0x600F575")]
    [Address(RVA = "0xB51B80", Offset = "0xB50980", VA = "0x10B51B80")]
    private static string DeprecatedCalculateChecksum(string input) => (string) null;

    [Token(Token = "0x1700235F")]
    private static string DeprecatedDeviceId
    {
      [Token(Token = "0x600F576"), Address(RVA = "0xB56490", Offset = "0xB55290", VA = "0x10B56490")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F577")]
    [Address(RVA = "0xB56220", Offset = "0xB55020", VA = "0x10B56220")]
    static ObscuredPrefs()
    {
    }

    [Token(Token = "0x2003695")]
    public enum DataType : byte
    {
      [Token(Token = "0x4010020")] Unknown = 0,
      [Token(Token = "0x4010021")] Int = 5,
      [Token(Token = "0x4010022")] UInt = 10, // 0x0A
      [Token(Token = "0x4010023")] String = 15, // 0x0F
      [Token(Token = "0x4010024")] Float = 20, // 0x14
      [Token(Token = "0x4010025")] Double = 25, // 0x19
      [Token(Token = "0x4010026")] Decimal = 27, // 0x1B
      [Token(Token = "0x4010027")] Long = 30, // 0x1E
      [Token(Token = "0x4010028")] ULong = 32, // 0x20
      [Token(Token = "0x4010029")] Bool = 35, // 0x23
      [Token(Token = "0x401002A")] ByteArray = 40, // 0x28
      [Token(Token = "0x401002B")] Vector2 = 45, // 0x2D
      [Token(Token = "0x401002C")] Vector3 = 50, // 0x32
      [Token(Token = "0x401002D")] Quaternion = 55, // 0x37
      [Token(Token = "0x401002E")] Color = 60, // 0x3C
      [Token(Token = "0x401002F")] Rect = 65, // 0x41
    }

    [Token(Token = "0x2003696")]
    public enum DeviceLockLevel : byte
    {
      [Token(Token = "0x4010031")] None,
      [Token(Token = "0x4010032")] Soft,
      [Token(Token = "0x4010033")] Strict,
    }
  }
}
