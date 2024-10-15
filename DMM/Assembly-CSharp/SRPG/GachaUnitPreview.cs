// Decompiled with JetBrains decompiler
// Type: SRPG.GachaUnitPreview
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F29")]
  [AddComponentMenu("Common/GachaUnitPreview")]
  public class GachaUnitPreview : UnitController
  {
    [Token(Token = "0x4002F40")]
    public const string ID_IDLE = "idle";
    [Token(Token = "0x4002F41")]
    public const string ID_ACTION = "action";
    [Token(Token = "0x4002F42")]
    public const string ID_BATTLE_CHANT = "B_CHA";
    [Token(Token = "0x4002F43")]
    public const string ID_BATTLE_SKILL = "B_SKL";
    [Token(Token = "0x4002F44")]
    public const string ID_BATTLE_BACKSTEP = "B_BS";
    [Token(Token = "0x4002F45")]
    [FieldOffset(Offset = "0x128")]
    public bool PlayAction;
    [Token(Token = "0x4002F46")]
    [FieldOffset(Offset = "0x129")]
    private bool mPlayingAction;
    [Token(Token = "0x4002F47")]
    [FieldOffset(Offset = "0x12C")]
    public int DefaultLayer;
    [Token(Token = "0x4002F48")]
    [FieldOffset(Offset = "0x130")]
    public UnitData mGUnitData;
    [Token(Token = "0x4002F49")]
    [FieldOffset(Offset = "0x134")]
    private string mCurrentJobID;

    [Token(Token = "0x17000551")]
    public UnitData GUnitData
    {
      [Token(Token = "0x6003F46"), Address(RVA = "0x349290", Offset = "0x348090", VA = "0x10349290")] get
      {
        return (UnitData) null;
      }
      [Token(Token = "0x6003F47"), Address(RVA = "0xA42310", Offset = "0xA41110", VA = "0x10A42310")] set
      {
      }
    }

    [Token(Token = "0x6003F48")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "11")]
    protected override bool IsEventAllowed(AnimEvent e) => new bool();

    [Token(Token = "0x6003F49")]
    [Address(RVA = "0x483E30", Offset = "0x482C30", VA = "0x10483E30", Slot = "4")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6003F4A")]
    [Address(RVA = "0x1179180", Offset = "0x1177F80", VA = "0x11179180")]
    public void SetGachaUnitData(UnitData unit, string jobId)
    {
    }

    [Token(Token = "0x6003F4B")]
    [Address(RVA = "0x1178FB0", Offset = "0x1177DB0", VA = "0x11178FB0", Slot = "21")]
    protected override void PostSetup()
    {
    }

    [Token(Token = "0x6003F4C")]
    [Address(RVA = "0x11791F0", Offset = "0x1177FF0", VA = "0x111791F0", Slot = "15")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6003F4D")]
    [Address(RVA = "0x1178F40", Offset = "0x1177D40", VA = "0x11178F40")]
    private IEnumerator LoadThread() => (IEnumerator) null;

    [Token(Token = "0x6003F4E")]
    [Address(RVA = "0x11792C0", Offset = "0x11780C0", VA = "0x111792C0")]
    public GachaUnitPreview()
    {
    }
  }
}
