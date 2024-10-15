// Decompiled with JetBrains decompiler
// Type: SRPG.BaseListItemBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002968")]
  [AddComponentMenu("UI/BaseListItemBadge")]
  public class BaseListItemBadge : MonoBehaviour
  {
    [Token(Token = "0x400C786")]
    [FieldOffset(Offset = "0xC")]
    public float CHANGE_INTERBAL;
    [Token(Token = "0x400C787")]
    [FieldOffset(Offset = "0x10")]
    public ListItemUnitBadge m_Badge;
    [Token(Token = "0x400C788")]
    [FieldOffset(Offset = "0x14")]
    public ListItemUnitBadge m_Arena;
    [Token(Token = "0x400C789")]
    [FieldOffset(Offset = "0x18")]
    public ListItemUnitBadge m_Support;
    [Token(Token = "0x400C78A")]
    [FieldOffset(Offset = "0x1C")]
    public ListItemUnitBadge m_GvG;
    [Token(Token = "0x400C78B")]
    [FieldOffset(Offset = "0x20")]
    public ListItemUnitBadge m_LeagueMatch;
    [Token(Token = "0x400C78C")]
    [FieldOffset(Offset = "0x24")]
    private List<GameObject> m_DispOn;
    [Token(Token = "0x400C78D")]
    [FieldOffset(Offset = "0x28")]
    private int m_Index;
    [Token(Token = "0x400C78E")]
    [FieldOffset(Offset = "0x2C")]
    private float m_Time;
    [Token(Token = "0x400C78F")]
    [FieldOffset(Offset = "0x30")]
    protected SpriteSheet mLoadSheet;
    [Token(Token = "0x400C790")]
    [FieldOffset(Offset = "0x34")]
    private List<ListItemUnitBadge> list;

    [Token(Token = "0x600BB45")]
    [Address(RVA = "0x82BF20", Offset = "0x82AD20", VA = "0x1082BF20")]
    private void Start()
    {
    }

    [Token(Token = "0x600BB46")]
    [Address(RVA = "0x82B480", Offset = "0x82A280", VA = "0x1082B480", Slot = "4")]
    public virtual void ClearDisableObject()
    {
    }

    [Token(Token = "0x600BB47")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public virtual void GetRefreshUnits()
    {
    }

    [Token(Token = "0x600BB48")]
    [Address(RVA = "0x82C070", Offset = "0x82AE70", VA = "0x1082C070")]
    private void Update()
    {
    }

    [Token(Token = "0x600BB49")]
    [Address(RVA = "0x82C070", Offset = "0x82AE70", VA = "0x1082C070")]
    private void UpdateBadge()
    {
    }

    [Token(Token = "0x600BB4A")]
    [Address(RVA = "0x82BF50", Offset = "0x82AD50", VA = "0x1082BF50")]
    public void UpdateBadgeAlternate(int _index)
    {
    }

    [Token(Token = "0x600BB4B")]
    [Address(RVA = "0x82B8B0", Offset = "0x82A6B0", VA = "0x1082B8B0")]
    public void SetUnitAllIcon(List<UnitData> _units, ListItemUnitBadge _template)
    {
    }

    [Token(Token = "0x600BB4C")]
    [Address(RVA = "0x82BDA0", Offset = "0x82ABA0", VA = "0x1082BDA0")]
    public bool SetUnitIcon(UnitData _unit, ListItemUnitBadge _template) => new bool();

    [Token(Token = "0x600BB4D")]
    [Address(RVA = "0x82BA40", Offset = "0x82A840", VA = "0x1082BA40")]
    public void SetUnitAllIcon(List<BadgeViewUnitData> _units, ListItemUnitBadge _template)
    {
    }

    [Token(Token = "0x600BB4E")]
    [Address(RVA = "0x82BBD0", Offset = "0x82A9D0", VA = "0x1082BBD0")]
    public bool SetUnitIcon(string iname, ListItemUnitBadge _template) => new bool();

    [Token(Token = "0x600BB4F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public virtual void Refresh()
    {
    }

    [Token(Token = "0x600BB50")]
    [Address(RVA = "0x82B700", Offset = "0x82A500", VA = "0x1082B700")]
    public void DrawReset()
    {
    }

    [Token(Token = "0x600BB51")]
    [Address(RVA = "0x82B390", Offset = "0x82A190", VA = "0x1082B390")]
    public void AddDispOn(GameObject _obj)
    {
    }

    [Token(Token = "0x600BB52")]
    [Address(RVA = "0x82B6A0", Offset = "0x82A4A0", VA = "0x1082B6A0")]
    public void ClearDispOn()
    {
    }

    [Token(Token = "0x600BB53")]
    [Address(RVA = "0x82B730", Offset = "0x82A530", VA = "0x1082B730")]
    public bool IsFindDispOn(GameObject _obj) => new bool();

    [Token(Token = "0x600BB54")]
    [Address(RVA = "0x82B7B0", Offset = "0x82A5B0", VA = "0x1082B7B0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600BB55")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600BB56")]
    [Address(RVA = "0x82C100", Offset = "0x82AF00", VA = "0x1082C100")]
    public BaseListItemBadge()
    {
    }
  }
}
