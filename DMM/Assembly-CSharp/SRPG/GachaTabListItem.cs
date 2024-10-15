// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTabListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002452")]
  [AddComponentMenu("UI/GachaTabListItem")]
  public class GachaTabListItem : GachaTabListItemBase
  {
    [Token(Token = "0x400A51C")]
    [FieldOffset(Offset = "0x24")]
    private GachaTabListItemModel mModel;
    [Token(Token = "0x400A51D")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine mUpdateCoroutine;
    [Token(Token = "0x400A51E")]
    [FieldOffset(Offset = "0x2C")]
    private float mNextUpdateTime;
    [Token(Token = "0x400A51F")]
    [FieldOffset(Offset = "0x30")]
    private long mEndAt;
    [Token(Token = "0x400A520")]
    [FieldOffset(Offset = "0x38")]
    private bool mDisabled;
    [Token(Token = "0x400A521")]
    [FieldOffset(Offset = "0x3C")]
    private Sprite mTabSprite;
    [Token(Token = "0x400A522")]
    [FieldOffset(Offset = "0x40")]
    private long mGachaEndAt;

    [Token(Token = "0x6009EB9")]
    [Address(RVA = "0x613D40", Offset = "0x612B40", VA = "0x10613D40")]
    public void Initialize(
      GachaTabListItem.GachaTabSpecialSetupData data,
      GachaTabListItemBase.GachaTabListItemBaseSetupData baseSetupData)
    {
    }

    [Token(Token = "0x6009EBA")]
    [Address(RVA = "0x614100", Offset = "0x612F00", VA = "0x10614100", Slot = "5")]
    protected override void SetExhibit(
      GachaTabListItemBase.GachaTabListItemBaseSetupData data)
    {
    }

    [Token(Token = "0x6009EBB")]
    [Address(RVA = "0x613DE0", Offset = "0x612BE0", VA = "0x10613DE0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009EBC")]
    [Address(RVA = "0x614330", Offset = "0x613130", VA = "0x10614330")]
    private IEnumerator UpdateTimer() => (IEnumerator) null;

    [Token(Token = "0x6009EBD")]
    [Address(RVA = "0x614250", Offset = "0x613050", VA = "0x10614250")]
    private void SetUpdateTimer(float interval)
    {
    }

    [Token(Token = "0x6009EBE")]
    [Address(RVA = "0x613E20", Offset = "0x612C20", VA = "0x10613E20")]
    private void RefreshTimer()
    {
    }

    [Token(Token = "0x6009EBF")]
    [Address(RVA = "0x613CD0", Offset = "0x612AD0", VA = "0x10613CD0")]
    public GachaTabListItem()
    {
    }

    [Token(Token = "0x2002453")]
    public struct GachaTabSpecialSetupData
    {
      [Token(Token = "0x400A523")]
      [FieldOffset(Offset = "0x0")]
      public long EndAt;
      [Token(Token = "0x400A524")]
      [FieldOffset(Offset = "0x8")]
      public bool Disabled;
      [Token(Token = "0x400A525")]
      [FieldOffset(Offset = "0x10")]
      public long GachaEndAt;
      [Token(Token = "0x400A526")]
      [FieldOffset(Offset = "0x18")]
      public int ListIndex;
      [Token(Token = "0x400A527")]
      [FieldOffset(Offset = "0x1C")]
      public Sprite TabSprite;

      [Token(Token = "0x6009EC0")]
      [Address(RVA = "0x614510", Offset = "0x613310", VA = "0x10614510")]
      public GachaTabSpecialSetupData(
        long _endAt,
        bool _disabled,
        long _gachaEndAt,
        int _listIndex,
        Sprite _tabSprite)
      {
      }
    }
  }
}
