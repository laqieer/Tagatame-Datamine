// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeUnitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D9F")]
  [MessagePackObject(true)]
  [Serializable]
  public class MultiPlayResumeUnitData
  {
    [Token(Token = "0x40026DD")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x40026DE")]
    [FieldOffset(Offset = "0xC")]
    public int hp;
    [Token(Token = "0x40026DF")]
    [FieldOffset(Offset = "0x10")]
    public int chp;
    [Token(Token = "0x40026E0")]
    [FieldOffset(Offset = "0x14")]
    public int gem;
    [Token(Token = "0x40026E1")]
    [FieldOffset(Offset = "0x18")]
    public int dir;
    [Token(Token = "0x40026E2")]
    [FieldOffset(Offset = "0x1C")]
    public int x;
    [Token(Token = "0x40026E3")]
    [FieldOffset(Offset = "0x20")]
    public int y;
    [Token(Token = "0x40026E4")]
    [FieldOffset(Offset = "0x24")]
    public int target;
    [Token(Token = "0x40026E5")]
    [FieldOffset(Offset = "0x28")]
    public int ragetarget;
    [Token(Token = "0x40026E6")]
    [FieldOffset(Offset = "0x2C")]
    public string castskill;
    [Token(Token = "0x40026E7")]
    [FieldOffset(Offset = "0x30")]
    public int chargetime;
    [Token(Token = "0x40026E8")]
    [FieldOffset(Offset = "0x34")]
    public int casttime;
    [Token(Token = "0x40026E9")]
    [FieldOffset(Offset = "0x38")]
    public int[] castgrid;
    [Token(Token = "0x40026EA")]
    [FieldOffset(Offset = "0x3C")]
    public int casttarget;
    [Token(Token = "0x40026EB")]
    [FieldOffset(Offset = "0x40")]
    public int castindex;
    [Token(Token = "0x40026EC")]
    [FieldOffset(Offset = "0x44")]
    public int grid_w;
    [Token(Token = "0x40026ED")]
    [FieldOffset(Offset = "0x48")]
    public int grid_h;
    [Token(Token = "0x40026EE")]
    [FieldOffset(Offset = "0x4C")]
    public int isDead;
    [Token(Token = "0x40026EF")]
    [FieldOffset(Offset = "0x50")]
    public int deathcnt;
    [Token(Token = "0x40026F0")]
    [FieldOffset(Offset = "0x54")]
    public int autojewel;
    [Token(Token = "0x40026F1")]
    [FieldOffset(Offset = "0x58")]
    public int waitturn;
    [Token(Token = "0x40026F2")]
    [FieldOffset(Offset = "0x5C")]
    public int moveturn;
    [Token(Token = "0x40026F3")]
    [FieldOffset(Offset = "0x60")]
    public int actcnt;
    [Token(Token = "0x40026F4")]
    [FieldOffset(Offset = "0x64")]
    public int turncnt;
    [Token(Token = "0x40026F5")]
    [FieldOffset(Offset = "0x68")]
    public int trgcnt;
    [Token(Token = "0x40026F6")]
    [FieldOffset(Offset = "0x6C")]
    public int killcnt;
    [Token(Token = "0x40026F7")]
    [FieldOffset(Offset = "0x70")]
    public int[] etr;
    [Token(Token = "0x40026F8")]
    [FieldOffset(Offset = "0x74")]
    public int aiindex;
    [Token(Token = "0x40026F9")]
    [FieldOffset(Offset = "0x78")]
    public int aiturn;
    [Token(Token = "0x40026FA")]
    [FieldOffset(Offset = "0x7C")]
    public int aipatrol;
    [Token(Token = "0x40026FB")]
    [FieldOffset(Offset = "0x80")]
    public int search;
    [Token(Token = "0x40026FC")]
    [FieldOffset(Offset = "0x84")]
    public int entry;
    [Token(Token = "0x40026FD")]
    [FieldOffset(Offset = "0x88")]
    public int to_dying;
    [Token(Token = "0x40026FE")]
    [FieldOffset(Offset = "0x8C")]
    public int paralyse;
    [Token(Token = "0x40026FF")]
    [FieldOffset(Offset = "0x90")]
    public long flag;
    [Token(Token = "0x4002700")]
    [FieldOffset(Offset = "0x98")]
    public int ctx;
    [Token(Token = "0x4002701")]
    [FieldOffset(Offset = "0x9C")]
    public int cty;
    [Token(Token = "0x4002702")]
    [FieldOffset(Offset = "0xA0")]
    public string boi;
    [Token(Token = "0x4002703")]
    [FieldOffset(Offset = "0xA4")]
    public int boc;
    [Token(Token = "0x4002704")]
    [FieldOffset(Offset = "0xA8")]
    public int own;
    [Token(Token = "0x4002705")]
    [FieldOffset(Offset = "0xAC")]
    public int ist;
    [Token(Token = "0x4002706")]
    [FieldOffset(Offset = "0xB0")]
    public int isd;
    [Token(Token = "0x4002707")]
    [FieldOffset(Offset = "0xB4")]
    public string did;
    [Token(Token = "0x4002708")]
    [FieldOffset(Offset = "0xB8")]
    public int dfu;
    [Token(Token = "0x4002709")]
    [FieldOffset(Offset = "0xBC")]
    public int drt;
    [Token(Token = "0x400270A")]
    [FieldOffset(Offset = "0xC0")]
    public int okd;
    [Token(Token = "0x400270B")]
    [FieldOffset(Offset = "0xC4")]
    public MultiPlayResumeBuff[] buff;
    [Token(Token = "0x400270C")]
    [FieldOffset(Offset = "0xC8")]
    public MultiPlayResumeBuff[] cond;
    [Token(Token = "0x400270D")]
    [FieldOffset(Offset = "0xCC")]
    public MultiPlayResumeShield[] shields;
    [Token(Token = "0x400270E")]
    [FieldOffset(Offset = "0xD0")]
    public string[] hpis;
    [Token(Token = "0x400270F")]
    [FieldOffset(Offset = "0xD4")]
    public MultiPlayResumeMhmDmg[] mhm_dmgs;
    [Token(Token = "0x4002710")]
    [FieldOffset(Offset = "0xD8")]
    public MultiPlayResumeFtgt[] tfl;
    [Token(Token = "0x4002711")]
    [FieldOffset(Offset = "0xDC")]
    public MultiPlayResumeFtgt[] ffl;
    [Token(Token = "0x4002712")]
    [FieldOffset(Offset = "0xE0")]
    public MultiPlayResumeAbilChg[] abilchgs;
    [Token(Token = "0x4002713")]
    [FieldOffset(Offset = "0xE4")]
    public MultiPlayResumeAddedAbil[] addedabils;
    [Token(Token = "0x4002714")]
    [FieldOffset(Offset = "0xE8")]
    public List<MultiPlayResumeProtect> protects;
    [Token(Token = "0x4002715")]
    [FieldOffset(Offset = "0xEC")]
    public List<MultiPlayResumeProtect> guards;
    [Token(Token = "0x4002716")]
    [FieldOffset(Offset = "0xF0")]
    public List<MultiPlayResumeRevival> revivals;
    [Token(Token = "0x4002717")]
    [FieldOffset(Offset = "0xF4")]
    public List<MultiPlayResumeAutoHpJudge> autohpjudges;
    [Token(Token = "0x4002718")]
    [FieldOffset(Offset = "0xF8")]
    public List<MultiPlayResumeManipulate> Manipulates;
    [Token(Token = "0x4002719")]
    [FieldOffset(Offset = "0xFC")]
    public List<MultiPlayResumeManipulateBreak> ManipulateBreaks;
    [Token(Token = "0x400271A")]
    [FieldOffset(Offset = "0x100")]
    public List<MultiPlayResumeSkillDistance> SkillDistanceList;
    [Token(Token = "0x400271B")]
    [FieldOffset(Offset = "0x104")]
    public string[] skillname;
    [Token(Token = "0x400271C")]
    [FieldOffset(Offset = "0x108")]
    public int[] skillcnt;
    [Token(Token = "0x400271D")]
    [FieldOffset(Offset = "0x10C")]
    public int initx;
    [Token(Token = "0x400271E")]
    [FieldOffset(Offset = "0x110")]
    public int inity;

    [Token(Token = "0x600373C")]
    [Address(RVA = "0x10A2680", Offset = "0x10A1480", VA = "0x110A2680")]
    public MultiPlayResumeUnitData()
    {
    }
  }
}
