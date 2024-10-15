// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBossManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D4E")]
  [AddComponentMenu("UI/WorldRaid/WorldRaidBossManager")]
  public class WorldRaidBossManager : MonoBehaviour
  {
    [Token(Token = "0x400E1D4")]
    [FieldOffset(Offset = "0x0")]
    private static WorldRaidBossManager mInstance;
    [Token(Token = "0x400E1D5")]
    [FieldOffset(Offset = "0x4")]
    private static int mBossIndex;
    [Token(Token = "0x400E1D6")]
    [FieldOffset(Offset = "0xC")]
    private WorldRaidParam mCurrentWorldRaidParam;
    [Token(Token = "0x400E1D7")]
    [FieldOffset(Offset = "0x10")]
    private WorldRaidParam.BossInfo mCurrentWorldRaidBossInfo;
    [Token(Token = "0x400E1D8")]
    [FieldOffset(Offset = "0x14")]
    private WorldRaidBossDetailData mBoss;

    [Token(Token = "0x17001BA3")]
    public static WorldRaidBossManager Instance
    {
      [Token(Token = "0x600D313"), Address(RVA = "0x9E38E0", Offset = "0x9E26E0", VA = "0x109E38E0")] get
      {
        return (WorldRaidBossManager) null;
      }
    }

    [Token(Token = "0x600D314")]
    [Address(RVA = "0x9E34E0", Offset = "0x9E22E0", VA = "0x109E34E0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600D315")]
    [Address(RVA = "0x9E3460", Offset = "0x9E2260", VA = "0x109E3460")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600D316")]
    [Address(RVA = "0x9E3560", Offset = "0x9E2360", VA = "0x109E3560")]
    private void RefreshParam()
    {
    }

    [Token(Token = "0x600D317")]
    [Address(RVA = "0x9E2F70", Offset = "0x9E1D70", VA = "0x109E2F70")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D318")]
    [Address(RVA = "0x9E3350", Offset = "0x9E2150", VA = "0x109E3350")]
    public WorldRaidBossParam GetCurrentWorldRaidBossParam() => (WorldRaidBossParam) null;

    [Token(Token = "0x600D319")]
    [Address(RVA = "0x9E3440", Offset = "0x9E2240", VA = "0x109E3440")]
    public bool IsLastBoss() => new bool();

    [Token(Token = "0x600D31A")]
    [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
    public WorldRaidParam.BossInfo GetCurrentBossInfo() => (WorldRaidParam.BossInfo) null;

    [Token(Token = "0x600D31B")]
    [Address(RVA = "0x9E37E0", Offset = "0x9E25E0", VA = "0x109E37E0")]
    public static void SetBossIndex(int boss_idx)
    {
    }

    [Token(Token = "0x600D31C")]
    [Address(RVA = "0x9E3260", Offset = "0x9E2060", VA = "0x109E3260")]
    public static int GetBossIndex() => new int();

    [Token(Token = "0x600D31D")]
    [Address(RVA = "0x9E30B0", Offset = "0x9E1EB0", VA = "0x109E30B0")]
    public void BossIndexSub(bool _is_last_boss)
    {
    }

    [Token(Token = "0x600D31E")]
    [Address(RVA = "0x9E2F80", Offset = "0x9E1D80", VA = "0x109E2F80")]
    public void BossIndexAdd(bool _is_last_boss)
    {
    }

    [Token(Token = "0x600D31F")]
    [Address(RVA = "0x9E3160", Offset = "0x9E1F60", VA = "0x109E3160")]
    public static BuffEffectParam GetBossBuff(string wr_iname, string wrb_iname)
    {
      return (BuffEffectParam) null;
    }

    [Token(Token = "0x600D320")]
    [Address(RVA = "0x9E31C0", Offset = "0x9E1FC0", VA = "0x109E31C0")]
    public static WorldRaidBossDetailData GetBossData() => (WorldRaidBossDetailData) null;

    [Token(Token = "0x600D321")]
    [Address(RVA = "0x9E3290", Offset = "0x9E2090", VA = "0x109E3290")]
    public static List<string> GetCurrentBossUsedUnitInameList() => (List<string>) null;

    [Token(Token = "0x600D322")]
    [Address(RVA = "0x9E3660", Offset = "0x9E2460", VA = "0x109E3660")]
    public static bool SetBossData(JSON_WorldRaidBossDetailData boss) => new bool();

    [Token(Token = "0x600D323")]
    [Address(RVA = "0x9E3380", Offset = "0x9E2180", VA = "0x109E3380")]
    public static Sprite GetWorldRaidBossIcon(string _boss_iname) => (Sprite) null;

    [Token(Token = "0x600D324")]
    [Address(RVA = "0x9E3870", Offset = "0x9E2670", VA = "0x109E3870")]
    public WorldRaidBossManager()
    {
    }
  }
}
