// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidNoticeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D62")]
  [Serializable]
  public class WorldRaidNoticeData
  {
    [Token(Token = "0x400E23F")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private string iname;
    [Token(Token = "0x400E240")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private int home;
    [Token(Token = "0x400E241")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int lap;
    [Token(Token = "0x400E242")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int lastboss;
    [Token(Token = "0x400E243")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int[] boss;
    [Token(Token = "0x400E244")]
    [FieldOffset(Offset = "0x1C")]
    private bool is_dirty;
    [Token(Token = "0x400E245")]
    [FieldOffset(Offset = "0x20")]
    private WorldRaidParam world_raid_param;

    [Token(Token = "0x600D37B")]
    [Address(RVA = "0x9E8ED0", Offset = "0x9E7CD0", VA = "0x109E8ED0")]
    private WorldRaidNoticeData(WorldRaidParam param)
    {
    }

    [Token(Token = "0x600D37C")]
    [Address(RVA = "0x9E8A90", Offset = "0x9E7890", VA = "0x109E8A90")]
    public static WorldRaidNoticeData Load(WorldRaidParam param) => (WorldRaidNoticeData) null;

    [Token(Token = "0x600D37D")]
    [Address(RVA = "0x9E8C20", Offset = "0x9E7A20", VA = "0x109E8C20")]
    public static bool Save(WorldRaidNoticeData notice_data) => new bool();

    [Token(Token = "0x600D37E")]
    [Address(RVA = "0x9E8E90", Offset = "0x9E7C90", VA = "0x109E8E90")]
    public void SetHome(bool value)
    {
    }

    [Token(Token = "0x600D37F")]
    [Address(RVA = "0x9E8EB0", Offset = "0x9E7CB0", VA = "0x109E8EB0")]
    public void SetLastBoss(bool value)
    {
    }

    [Token(Token = "0x600D380")]
    [Address(RVA = "0x9E8E50", Offset = "0x9E7C50", VA = "0x109E8E50")]
    public void SetBoss(bool value, int index)
    {
    }

    [Token(Token = "0x600D381")]
    [Address(RVA = "0x9E8D40", Offset = "0x9E7B40", VA = "0x109E8D40")]
    public void SetBoss(bool value, string boss_iname)
    {
    }

    [Token(Token = "0x600D382")]
    [Address(RVA = "0x9E8A10", Offset = "0x9E7810", VA = "0x109E8A10")]
    public void LapUpReset(int _now_lap, WorldRaidParam _param)
    {
    }

    [Token(Token = "0x600D383")]
    [Address(RVA = "0x2B0B60", Offset = "0x2AF960", VA = "0x102B0B60")]
    public bool IsNeedNotice_Home() => new bool();

    [Token(Token = "0x600D384")]
    [Address(RVA = "0x9E89F0", Offset = "0x9E77F0", VA = "0x109E89F0")]
    public bool IsNeedNotice_LastBoss(int _now_lap) => new bool();

    [Token(Token = "0x600D385")]
    [Address(RVA = "0x9E89C0", Offset = "0x9E77C0", VA = "0x109E89C0")]
    public bool IsNeedNotice_BeatBoss(int index) => new bool();

    [Token(Token = "0x600D386")]
    [Address(RVA = "0x9E89A0", Offset = "0x9E77A0", VA = "0x109E89A0")]
    public bool IsLapChanging(int _now_lap) => new bool();
  }
}
