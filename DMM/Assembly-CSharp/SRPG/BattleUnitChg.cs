// Decompiled with JetBrains decompiler
// Type: SRPG.BattleUnitChg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C6F")]
  [AddComponentMenu("Battle/BattleUnitChg")]
  public class BattleUnitChg : MonoBehaviour
  {
    [Token(Token = "0x4002192")]
    [FieldOffset(Offset = "0xC")]
    public BattleUnitChg.SelectEvent OnSelectUnit;
    [Token(Token = "0x4002193")]
    [FieldOffset(Offset = "0x10")]
    public RectTransform ListParent;
    [Token(Token = "0x4002194")]
    [FieldOffset(Offset = "0x14")]
    public ListItemEvents UnitTemplate;
    [Token(Token = "0x4002195")]
    [FieldOffset(Offset = "0x18")]
    public ListItemEvents EmptyTemplate;
    [Token(Token = "0x4002196")]
    private const int SUB_UNIT_MAX = 2;
    [Token(Token = "0x4002197")]
    [FieldOffset(Offset = "0x1C")]
    private List<Unit> mSubUnitLists;
    [Token(Token = "0x4002198")]
    [FieldOffset(Offset = "0x20")]
    private List<ListItemEvents> mUnitEvents;

    [Token(Token = "0x6003105")]
    [Address(RVA = "0x101E570", Offset = "0x101D370", VA = "0x1101E570")]
    private void Start()
    {
    }

    [Token(Token = "0x6003106")]
    [Address(RVA = "0x101DF70", Offset = "0x101CD70", VA = "0x1101DF70")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6003107")]
    [Address(RVA = "0x101E750", Offset = "0x101D550", VA = "0x1101E750")]
    public BattleUnitChg()
    {
    }

    [Token(Token = "0x2000C70")]
    public delegate void SelectEvent(Unit unit);
  }
}
