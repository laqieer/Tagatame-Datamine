// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D8B")]
  public class TrophyBase
  {
    [Token(Token = "0x40074E8")]
    [FieldOffset(Offset = "0x8")]
    protected List<TrophyState> mTrophyStates;
    [Token(Token = "0x40074E9")]
    [FieldOffset(Offset = "0xC")]
    protected Dictionary<string, List<TrophyState>> mTrophyStatesInameDict;
    [Token(Token = "0x40074EA")]
    [FieldOffset(Offset = "0x10")]
    private long mMissionClearAt;

    [Token(Token = "0x17001047")]
    public List<TrophyState> TrophyStatesList
    {
      [Token(Token = "0x60078D4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x60078D5")]
    [Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")]
    public void SetMissionClearAt(long unixTimeStamp)
    {
    }

    [Token(Token = "0x60078D6")]
    [Address(RVA = "0x3A7C10", Offset = "0x3A6A10", VA = "0x103A7C10")]
    public void ResetMissionClearAt()
    {
    }

    [Token(Token = "0x60078D7")]
    [Address(RVA = "0x3A7570", Offset = "0x3A6370", VA = "0x103A7570")]
    public DateTime GetMissionClearAt() => new DateTime();

    [Token(Token = "0x60078D8")]
    [Address(RVA = "0x3A7420", Offset = "0x3A6220", VA = "0x103A7420")]
    public bool DictTryGetValue(string iname, out List<TrophyState> tState) => new bool();

    [Token(Token = "0x60078D9")]
    [Address(RVA = "0x3A6C60", Offset = "0x3A5A60", VA = "0x103A6C60")]
    public void ClearTrophies()
    {
    }

    [Token(Token = "0x60078DA")]
    [Address(RVA = "0x3A7280", Offset = "0x3A6080", VA = "0x103A7280")]
    public void DeleteTrophies(JSON_TrophyProgress[] trophies)
    {
    }

    [Token(Token = "0x60078DB")]
    [Address(RVA = "0x3A7AA0", Offset = "0x3A68A0", VA = "0x103A7AA0")]
    public bool IsTrophyDirty() => new bool();

    [Token(Token = "0x60078DC")]
    [Address(RVA = "0x3A7E40", Offset = "0x3A6C40", VA = "0x103A7E40")]
    private void UpdateTrophyState(TrophyState st, int currentYMD)
    {
    }

    [Token(Token = "0x60078DD")]
    [Address(RVA = "0x3A7470", Offset = "0x3A6270", VA = "0x103A7470")]
    public int GetCompletedTrophiesCount() => new int();

    [Token(Token = "0x60078DE")]
    [Address(RVA = "0x3A7B20", Offset = "0x3A6920", VA = "0x103A7B20")]
    public void MarkTrophiesEnded(TrophyParam[] trophies)
    {
    }

    [Token(Token = "0x60078DF")]
    [Address(RVA = "0x3A6CE0", Offset = "0x3A5AE0", VA = "0x103A6CE0")]
    private void ClearTrophyCounter(TrophyState _st)
    {
    }

    [Token(Token = "0x60078E0")]
    [Address(RVA = "0x3A7FD0", Offset = "0x3A6DD0", VA = "0x103A7FD0")]
    public void UpdateTrophyStates()
    {
    }

    [Token(Token = "0x60078E1")]
    [Address(RVA = "0x3A7BC0", Offset = "0x3A69C0", VA = "0x103A7BC0")]
    public TrophyState RegistTrophyStateDictByProg(TrophyParam _trophy, JSON_TrophyProgress _prog)
    {
      return (TrophyState) null;
    }

    [Token(Token = "0x60078E2")]
    [Address(RVA = "0x3A6E10", Offset = "0x3A5C10", VA = "0x103A6E10")]
    public void CreateInheritingExtraTrophy(Dictionary<int, List<JSON_TrophyProgress>> progs)
    {
    }

    [Token(Token = "0x60078E3")]
    [Address(RVA = "0x3A75F0", Offset = "0x3A63F0", VA = "0x103A75F0")]
    public TrophyState GetTrophyCounter(TrophyParam trophy, bool daily_old_data = false)
    {
      return (TrophyState) null;
    }

    [Token(Token = "0x60078E4")]
    [Address(RVA = "0x3A70A0", Offset = "0x3A5EA0", VA = "0x103A70A0")]
    protected TrophyState CreateTrophyState(TrophyParam _trophy) => (TrophyState) null;

    [Token(Token = "0x60078E5")]
    [Address(RVA = "0x3A68A0", Offset = "0x3A56A0", VA = "0x103A68A0")]
    protected void AddTrophyStateDict(TrophyState _state)
    {
    }

    [Token(Token = "0x60078E6")]
    [Address(RVA = "0x3A79C0", Offset = "0x3A67C0", VA = "0x103A79C0")]
    private bool IsMakeTrophyPlate(TrophyParam trophy, TrophyState st, bool is_achievement)
    {
      return new bool();
    }

    [Token(Token = "0x60078E7")]
    [Address(RVA = "0x3A71C0", Offset = "0x3A5FC0", VA = "0x103A71C0")]
    public void DailyAllCompleteCheck()
    {
    }

    [Token(Token = "0x60078E8")]
    [Address(RVA = "0x3A77A0", Offset = "0x3A65A0", VA = "0x103A77A0")]
    public bool IsDailyAllComplete() => new bool();

    [Token(Token = "0x60078E9")]
    [Address(RVA = "0x3A6B50", Offset = "0x3A5950", VA = "0x103A6B50")]
    private bool CheckTrophyCount(
      TrophyParam trophyParam,
      int countIndex,
      int value,
      ref TrophyState state)
    {
      return new bool();
    }

    [Token(Token = "0x60078EA")]
    [Address(RVA = "0x3A6AB0", Offset = "0x3A58B0", VA = "0x103A6AB0")]
    private bool CheckDailyMissionDayChange(TrophyState state, int countIndex) => new bool();

    [Token(Token = "0x60078EB")]
    [Address(RVA = "0x3A6830", Offset = "0x3A5630", VA = "0x103A6830")]
    public void AddTrophyCounter(TrophyObjective obj, int value)
    {
    }

    [Token(Token = "0x60078EC")]
    [Address(RVA = "0x3A6870", Offset = "0x3A5670", VA = "0x103A6870")]
    public void AddTrophyCounter(TrophyParam trophyParam, int countIndex, int value)
    {
    }

    [Token(Token = "0x60078ED")]
    [Address(RVA = "0x3A66A0", Offset = "0x3A54A0", VA = "0x103A66A0")]
    private bool AddTrophyCounterExec(TrophyParam trophyParam, int countIndex, int value)
    {
      return new bool();
    }

    [Token(Token = "0x60078EE")]
    [Address(RVA = "0x3A7E00", Offset = "0x3A6C00", VA = "0x103A7E00")]
    public void SetTrophyCounter(TrophyObjective obj, int value)
    {
    }

    [Token(Token = "0x60078EF")]
    [Address(RVA = "0x3A7DD0", Offset = "0x3A6BD0", VA = "0x103A7DD0")]
    private void SetTrophyCounter(TrophyParam trophyParam, int countIndex, int value)
    {
    }

    [Token(Token = "0x60078F0")]
    [Address(RVA = "0x3A7C30", Offset = "0x3A6A30", VA = "0x103A7C30")]
    private bool SetTrophyCounterExec(TrophyParam trophyParam, int countIndex, int value)
    {
      return new bool();
    }

    [Token(Token = "0x60078F1")]
    [Address(RVA = "0x3A80B0", Offset = "0x3A6EB0", VA = "0x103A80B0")]
    public TrophyBase()
    {
    }
  }
}
