// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D68")]
  [AddComponentMenu("UI/WorldRaid/WorldRaidManager")]
  public class WorldRaidManager : MonoBehaviour, IWebHelp
  {
    [Token(Token = "0x400E265")]
    public const int LAP_START = 1;
    [Token(Token = "0x400E266")]
    [FieldOffset(Offset = "0x0")]
    private static WorldRaidManager mInstance;
    [Token(Token = "0x400E267")]
    [FieldOffset(Offset = "0xC")]
    private WorldRaidParam mCurrentWorldRaidParam;
    [Token(Token = "0x400E268")]
    [FieldOffset(Offset = "0x10")]
    private int mSelectHealBpNum;
    [Token(Token = "0x400E269")]
    [FieldOffset(Offset = "0x14")]
    private int mHealWindowOpenBp;
    [Token(Token = "0x400E26A")]
    [FieldOffset(Offset = "0x18")]
    private List<WorldRaidBossChallengedData> mBosses;
    [Token(Token = "0x400E26B")]
    [FieldOffset(Offset = "0x1C")]
    private int mTotalChallengeUserCount;
    [Token(Token = "0x400E26C")]
    [FieldOffset(Offset = "0x20")]
    private List<WorldRaidLogData> mLogs;
    [Token(Token = "0x400E26D")]
    [FieldOffset(Offset = "0x24")]
    private float mRefreshWaitSec;
    [Token(Token = "0x400E26E")]
    [FieldOffset(Offset = "0x28")]
    private float mAutoRefreshWaitSec;
    [Token(Token = "0x400E26F")]
    [FieldOffset(Offset = "0x2C")]
    private int mLap;
    [Token(Token = "0x400E270")]
    [FieldOffset(Offset = "0x30")]
    private int mCurrentBp;
    [Token(Token = "0x400E271")]
    [FieldOffset(Offset = "0x34")]
    private int mRecoveryStartTime;
    [Token(Token = "0x400E272")]
    [FieldOffset(Offset = "0x38")]
    private int mHealNum;
    [Token(Token = "0x400E273")]
    [FieldOffset(Offset = "0x3C")]
    private List<WorldRaidBossChallengedData> mLastAccessBossList;

    [Token(Token = "0x17001BB9")]
    public static WorldRaidManager Instance
    {
      [Token(Token = "0x600D39A"), Address(RVA = "0x9E8970", Offset = "0x9E7770", VA = "0x109E8970")] get
      {
        return (WorldRaidManager) null;
      }
    }

    [Token(Token = "0x600D39B")]
    [Address(RVA = "0x9E80A0", Offset = "0x9E6EA0", VA = "0x109E80A0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600D39C")]
    [Address(RVA = "0x9E8020", Offset = "0x9E6E20", VA = "0x109E8020")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x17001BBA")]
    public int SelectHealBpNum
    {
      [Token(Token = "0x600D39D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D39E"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] set
      {
      }
    }

    [Token(Token = "0x17001BBB")]
    public int HealWindowOpenBp
    {
      [Token(Token = "0x600D39F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600D3A0"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] set
      {
      }
    }

    [Token(Token = "0x600D3A1")]
    [Address(RVA = "0x9E7130", Offset = "0x9E5F30", VA = "0x109E7130")]
    private static WorldRaidParam GetInternalCurrentWorldRaidParam() => (WorldRaidParam) null;

    [Token(Token = "0x600D3A2")]
    [Address(RVA = "0x9E8850", Offset = "0x9E7650", VA = "0x109E8850")]
    private void Start()
    {
    }

    [Token(Token = "0x600D3A3")]
    private IEnumerator LoadAssetCoroutine<T>(
      string name,
      WorldRaidManager.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D3A4")]
    private bool InternalLoadAssets<T>(string name, WorldRaidManager.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x600D3A5")]
    public static bool LoadAssets<T>(string name, WorldRaidManager.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x600D3A6")]
    [Address(RVA = "0x9E7020", Offset = "0x9E5E20", VA = "0x109E7020")]
    public static WorldRaidParam GetCurrentWorldRaidParam() => (WorldRaidParam) null;

    [Token(Token = "0x600D3A7")]
    [Address(RVA = "0x9E8000", Offset = "0x9E6E00", VA = "0x109E8000")]
    public static bool IsWithinPeriod() => new bool();

    [Token(Token = "0x600D3A8")]
    [Address(RVA = "0x9E7FE0", Offset = "0x9E6DE0", VA = "0x109E7FE0")]
    public static bool IsWithinChallenge() => new bool();

    [Token(Token = "0x600D3A9")]
    [Address(RVA = "0x9E6990", Offset = "0x9E5790", VA = "0x109E6990")]
    public void ClearCasheWorldRaidParam()
    {
    }

    [Token(Token = "0x600D3AA")]
    [Address(RVA = "0x9E69B0", Offset = "0x9E57B0", VA = "0x109E69B0")]
    public static List<WorldRaidBossChallengedData> GetAllBossesData()
    {
      return (List<WorldRaidBossChallengedData>) null;
    }

    [Token(Token = "0x600D3AB")]
    [Address(RVA = "0x9E7CC0", Offset = "0x9E6AC0", VA = "0x109E7CC0")]
    public static bool IsChallengeLastBoss() => new bool();

    [Token(Token = "0x600D3AC")]
    [Address(RVA = "0x9E76B0", Offset = "0x9E64B0", VA = "0x109E76B0")]
    public static List<WorldRaidBossChallengedData> GetNormalBossData()
    {
      return (List<WorldRaidBossChallengedData>) null;
    }

    [Token(Token = "0x600D3AD")]
    [Address(RVA = "0x9E73E0", Offset = "0x9E61E0", VA = "0x109E73E0")]
    public static List<WorldRaidBossChallengedData> GetLastBossData()
    {
      return (List<WorldRaidBossChallengedData>) null;
    }

    [Token(Token = "0x600D3AE")]
    [Address(RVA = "0x9E6FF0", Offset = "0x9E5DF0", VA = "0x109E6FF0")]
    public static List<WorldRaidBossChallengedData> GetChallengedList()
    {
      return (List<WorldRaidBossChallengedData>) null;
    }

    [Token(Token = "0x600D3AF")]
    [Address(RVA = "0x9E7F50", Offset = "0x9E6D50", VA = "0x109E7F50")]
    public static bool IsLastBossDefeat() => new bool();

    [Token(Token = "0x600D3B0")]
    [Address(RVA = "0x9E7C40", Offset = "0x9E6A40", VA = "0x109E7C40")]
    public static int GetTotalChallengeUserCount() => new int();

    [Token(Token = "0x600D3B1")]
    [Address(RVA = "0x3A3940", Offset = "0x3A2740", VA = "0x103A3940")]
    public float GetRefreshWaitSec() => new float();

    [Token(Token = "0x600D3B2")]
    [Address(RVA = "0x2CD6D0", Offset = "0x2CC4D0", VA = "0x102CD6D0")]
    public float GetAutoRefreshWaitSec() => new float();

    [Token(Token = "0x600D3B3")]
    [Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")]
    public List<WorldRaidLogData> GetLogData() => (List<WorldRaidLogData>) null;

    [Token(Token = "0x600D3B4")]
    [Address(RVA = "0x9E7980", Offset = "0x9E6780", VA = "0x109E7980")]
    public static string GetRemainTimeText() => (string) null;

    [Token(Token = "0x600D3B5")]
    [Address(RVA = "0x9E72E0", Offset = "0x9E60E0", VA = "0x109E72E0")]
    public static int GetLap() => new int();

    [Token(Token = "0x600D3B6")]
    [Address(RVA = "0x9E6A30", Offset = "0x9E5830", VA = "0x109E6A30")]
    public static string GetBPRecoveryRemainTimeText() => (string) null;

    [Token(Token = "0x600D3B7")]
    [Address(RVA = "0x9E6DA0", Offset = "0x9E5BA0", VA = "0x109E6DA0")]
    public static int GetBattlePoint() => new int();

    [Token(Token = "0x600D3B8")]
    [Address(RVA = "0x9E7360", Offset = "0x9E6160", VA = "0x109E7360")]
    public static List<WorldRaidBossChallengedData> GetLastAccessBossList()
    {
      return (List<WorldRaidBossChallengedData>) null;
    }

    [Token(Token = "0x600D3B9")]
    [Address(RVA = "0x9E6F70", Offset = "0x9E5D70", VA = "0x109E6F70")]
    public static int GetBpHealNum() => new int();

    [Token(Token = "0x600D3BA")]
    [Address(RVA = "0x9E8120", Offset = "0x9E6F20", VA = "0x109E8120")]
    public static bool SetAllBossesData(JSON_WorldRaidBossChallengedData[] bosses) => new bool();

    [Token(Token = "0x600D3BB")]
    [Address(RVA = "0x9E87D0", Offset = "0x9E75D0", VA = "0x109E87D0")]
    public static bool SetTotalChallengeUserCount(int count) => new bool();

    [Token(Token = "0x600D3BC")]
    [Address(RVA = "0x9E8590", Offset = "0x9E7390", VA = "0x109E8590")]
    public static bool SetLogs(JSON_WorldRaidLogData[] logs) => new bool();

    [Token(Token = "0x600D3BD")]
    [Address(RVA = "0x9E8730", Offset = "0x9E7530", VA = "0x109E8730")]
    public static bool SetRefreshTime(float refresh_wait_sec, float auto_refresh_wait_sec)
    {
      return new bool();
    }

    [Token(Token = "0x600D3BE")]
    [Address(RVA = "0x9E8370", Offset = "0x9E7170", VA = "0x109E8370")]
    public static bool SetLap(int _lap) => new bool();

    [Token(Token = "0x600D3BF")]
    [Address(RVA = "0x9E82C0", Offset = "0x9E70C0", VA = "0x109E82C0")]
    public static bool SetBattlePointData(JSON_WorldRaidBattlePoint _json) => new bool();

    [Token(Token = "0x600D3C0")]
    [Address(RVA = "0x9E83F0", Offset = "0x9E71F0", VA = "0x109E83F0")]
    public static bool SetLastAccessBossList(JSON_WorldRaidLastAccess _json) => new bool();

    [Token(Token = "0x600D3C1")]
    [Address(RVA = "0x9E70A0", Offset = "0x9E5EA0", VA = "0x109E70A0", Slot = "4")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600D3C2")]
    [Address(RVA = "0x9E8880", Offset = "0x9E7680", VA = "0x109E8880")]
    public WorldRaidManager()
    {
    }

    [Token(Token = "0x2002D69")]
    public delegate void LoadAssetCallback<T>(T obj) where T : UnityEngine.Object;
  }
}
