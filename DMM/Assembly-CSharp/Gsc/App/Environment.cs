// Decompiled with JetBrains decompiler
// Type: Gsc.App.Environment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;

#nullable disable
namespace Gsc.App
{
  [Token(Token = "0x2003546")]
  public struct Environment : Configuration.IEnvironment
  {
    [Token(Token = "0x400FCBA")]
    private const string NATIVEBASE_URL = "https://production-alchemist.nativebase.gu3.jp";
    [Token(Token = "0x400FCBB")]
    private const string AUTH_API_PREFIX = "/gauth";
    [Token(Token = "0x400FCBC")]
    private const string PURCHASE_API_PREFIX = "/charge";

    [Token(Token = "0x170021B3")]
    public string ServerUrl
    {
      [Token(Token = "0x600EBF4"), Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060", Slot = "4")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EBF5"), Address(RVA = "0xB01110", Offset = "0xAFFF10", VA = "0x10B01110")] set
      {
      }
    }

    [Token(Token = "0x170021B4")]
    public string NativeBaseUrl
    {
      [Token(Token = "0x600EBF6"), Address(RVA = "0x28E4C0", Offset = "0x28D2C0", VA = "0x1028E4C0", Slot = "5")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EBF7"), Address(RVA = "0x2EC6F0", Offset = "0x2EB4F0", VA = "0x102EC6F0")] set
      {
      }
    }

    [Token(Token = "0x170021B5")]
    public string LogCollectionUrl
    {
      [Token(Token = "0x600EBF8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0", Slot = "6")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EBF9"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x170021B6")]
    public string LogCollectionActionLogUrl
    {
      [Token(Token = "0x600EBFA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0", Slot = "7")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EBFB"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x170021B7")]
    public string LogCollectionNativebaseLogUrl
    {
      [Token(Token = "0x600EBFC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0", Slot = "8")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EBFD"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x170021B8")]
    public string ClientErrorApi
    {
      [Token(Token = "0x600EBFE"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70", Slot = "9")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EBFF"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x170021B9")]
    public string AuthApiPrefix
    {
      [Token(Token = "0x600EC00"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190", Slot = "10")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC01"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x170021BA")]
    public string PurchaseApiPrefix
    {
      [Token(Token = "0x600EC02"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0", Slot = "11")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC03"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x170021BB")]
    public string DLHost
    {
      [Token(Token = "0x600EC04"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC05"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170021BC")]
    public string SiteHost
    {
      [Token(Token = "0x600EC06"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC07"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x170021BD")]
    public string NewsHost
    {
      [Token(Token = "0x600EC08"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC09"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x170021BE")]
    public string Assets
    {
      [Token(Token = "0x600EC0A"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC0B"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
      {
      }
    }

    [Token(Token = "0x170021BF")]
    public string AssetsEx
    {
      [Token(Token = "0x600EC0C"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC0D"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
    }

    [Token(Token = "0x170021C0")]
    public string MasterDigest
    {
      [Token(Token = "0x600EC0E"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC0F"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] set
      {
      }
    }

    [Token(Token = "0x170021C1")]
    public string QuestDigest
    {
      [Token(Token = "0x600EC10"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC11"), Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")] set
      {
      }
    }

    [Token(Token = "0x170021C2")]
    public string EnvFlg2
    {
      [Token(Token = "0x600EC12"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC13"), Address(RVA = "0x36F610", Offset = "0x36E410", VA = "0x1036F610")] set
      {
      }
    }

    [Token(Token = "0x170021C3")]
    public string Pub
    {
      [Token(Token = "0x600EC14"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC15"), Address(RVA = "0x36F630", Offset = "0x36E430", VA = "0x1036F630")] set
      {
      }
    }

    [Token(Token = "0x170021C4")]
    public string PubU
    {
      [Token(Token = "0x600EC16"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC17"), Address(RVA = "0x2886E0", Offset = "0x2874E0", VA = "0x102886E0")] set
      {
      }
    }

    [Token(Token = "0x170021C5")]
    public Network.EErrCode Stat
    {
      [Token(Token = "0x600EC18"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] readonly get
      {
        return new Network.EErrCode();
      }
      [Token(Token = "0x600EC19"), Address(RVA = "0x370680", Offset = "0x36F480", VA = "0x10370680")] set
      {
      }
    }

    [Token(Token = "0x170021C6")]
    public string StatMsg
    {
      [Token(Token = "0x600EC1A"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC1B"), Address(RVA = "0x2B4CC0", Offset = "0x2B3AC0", VA = "0x102B4CC0")] set
      {
      }
    }

    [Token(Token = "0x170021C7")]
    public string StatCode
    {
      [Token(Token = "0x600EC1C"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC1D"), Address(RVA = "0x6855E0", Offset = "0x6843E0", VA = "0x106855E0")] set
      {
      }
    }

    [Token(Token = "0x170021C8")]
    public long ServerTime
    {
      [Token(Token = "0x600EC1E"), Address(RVA = "0xB09510", Offset = "0xB08310", VA = "0x10B09510")] readonly get
      {
        return new long();
      }
      [Token(Token = "0x600EC1F"), Address(RVA = "0x3706D0", Offset = "0x36F4D0", VA = "0x103706D0")] set
      {
      }
    }

    [Token(Token = "0x170021C9")]
    public string BattleVersion
    {
      [Token(Token = "0x600EC20"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC21"), Address(RVA = "0x3706F0", Offset = "0x36F4F0", VA = "0x103706F0")] set
      {
      }
    }

    [Token(Token = "0x170021CA")]
    public Environment.EnvironmentFlagBit EnvironmentFlag
    {
      [Token(Token = "0x600EC22"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] readonly get
      {
        return new Environment.EnvironmentFlagBit();
      }
      [Token(Token = "0x600EC23"), Address(RVA = "0x352460", Offset = "0x351260", VA = "0x10352460")] private set
      {
      }
    }

    [Token(Token = "0x600EC24")]
    [Address(RVA = "0xB08C40", Offset = "0xB07A40", VA = "0x10B08C40")]
    public bool IsEnvironmentFlag(Environment.EnvironmentFlagBit flag) => new bool();

    [Token(Token = "0x600EC25")]
    [Address(RVA = "0xB08DD0", Offset = "0xB07BD0", VA = "0x10B08DD0", Slot = "12")]
    public void SetValue(string key, string value)
    {
    }

    [Token(Token = "0x600EC26")]
    [Address(RVA = "0xB08C60", Offset = "0xB07A60", VA = "0x10B08C60")]
    public static string ProcessMsgPackEncryptionEnvFlags2(string value) => (string) null;

    [Token(Token = "0x600EC27")]
    [Address(RVA = "0xB08BB0", Offset = "0xB079B0", VA = "0x10B08BB0")]
    private static string EndsSlashDelete(string value) => (string) null;

    [Token(Token = "0x600EC28")]
    [Address(RVA = "0xB08CD0", Offset = "0xB07AD0", VA = "0x10B08CD0")]
    public static Configuration.Builder<Environment> SetEnvironment(
      Configuration.Builder<Environment> builder)
    {
      return (Configuration.Builder<Environment>) null;
    }

    [Token(Token = "0x2003547")]
    [Flags]
    public enum EnvironmentFlagBit
    {
      [Token(Token = "0x400FCBE")] ENV_FLG_NONE = 0,
      [Token(Token = "0x400FCBF")] ENV_FLG_DLC_DOWNLOAD_OLD = 1,
      [Token(Token = "0x400FCC0")] ENV_FLG_FORCE_SERIALIZATION = 2,
      [Token(Token = "0x400FCC1")] ENV_FLG_FORCE_ENCRYPTION = 4,
      [Token(Token = "0x400FCC2")] ENV_FLG_RANKMATCH = 32, // 0x00000020
      [Token(Token = "0x400FCC3")] ENV_FLG_DLC_CHECKBOX_OFF = 64, // 0x00000040
      [Token(Token = "0x400FCC4")] ENV_FLG_PHOTONVERSION_OFF = 128, // 0x00000080
    }
  }
}
