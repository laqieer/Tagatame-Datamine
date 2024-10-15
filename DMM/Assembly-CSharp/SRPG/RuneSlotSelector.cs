// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSlotSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029F0")]
  [AddComponentMenu("UI/Rune/RuneSlotSelector")]
  public class RuneSlotSelector : MonoBehaviour
  {
    [Token(Token = "0x400CBC5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject[] mRuneSlotParent;
    [Token(Token = "0x400CBC6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRuneSlotTemplate;
    [Token(Token = "0x400CBC7")]
    [FieldOffset(Offset = "0x14")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400CBC8")]
    [FieldOffset(Offset = "0x18")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400CBC9")]
    [FieldOffset(Offset = "0x1C")]
    private List<RuneSlot> mRuneSlotList;

    [Token(Token = "0x600BF29")]
    [Address(RVA = "0x866AB0", Offset = "0x8658B0", VA = "0x10866AB0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BF2A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Init()
    {
    }

    [Token(Token = "0x600BF2B")]
    [Address(RVA = "0x866B60", Offset = "0x865960", VA = "0x10866B60")]
    public void Initialize(RuneManager manager, UnitData unit)
    {
    }

    [Token(Token = "0x600BF2C")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void SetUnit(UnitData unit)
    {
    }

    [Token(Token = "0x600BF2D")]
    [Address(RVA = "0x866F70", Offset = "0x865D70", VA = "0x10866F70")]
    public void SelectedSlot(RuneSlotIndex slot)
    {
    }

    [Token(Token = "0x600BF2E")]
    [Address(RVA = "0x866BD0", Offset = "0x8659D0", VA = "0x10866BD0")]
    public void Refresh(bool is_play_equip_effect = true)
    {
    }

    [Token(Token = "0x600BF2F")]
    [Address(RVA = "0x866BA0", Offset = "0x8659A0", VA = "0x10866BA0")]
    private bool IsChangeEquipState(BindRuneData current, BindRuneData prev) => new bool();

    [Token(Token = "0x600BF30")]
    [Address(RVA = "0x867040", Offset = "0x865E40", VA = "0x10867040")]
    public RuneSlotSelector()
    {
    }
  }
}
