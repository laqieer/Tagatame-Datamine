// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollClamped_TownMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A6D")]
  [RequireComponent(typeof (ScrollListController))]
  [AddComponentMenu("UI/ScrollClamped_TownMenu")]
  public class ScrollClamped_TownMenu : MonoBehaviour, ScrollListSetUp
  {
    [Token(Token = "0x400CE7F")]
    [FieldOffset(Offset = "0xC")]
    private readonly float OFFSET_X_MIN;
    [Token(Token = "0x400CE80")]
    [FieldOffset(Offset = "0x10")]
    private readonly float OFFSET_X;
    [Token(Token = "0x400CE81")]
    [FieldOffset(Offset = "0x14")]
    private readonly float OFFSET_Y;
    [Token(Token = "0x400CE82")]
    [FieldOffset(Offset = "0x18")]
    public float Space;
    [Token(Token = "0x400CE83")]
    [FieldOffset(Offset = "0x1C")]
    public int Max;
    [Token(Token = "0x400CE84")]
    [FieldOffset(Offset = "0x20")]
    public RectTransform ViewObj;
    [Token(Token = "0x400CE85")]
    [FieldOffset(Offset = "0x24")]
    public ScrollAutoFit AutoFit;
    [Token(Token = "0x400CE86")]
    [FieldOffset(Offset = "0x28")]
    public GameObject Mask;
    [Token(Token = "0x400CE87")]
    [FieldOffset(Offset = "0x2C")]
    public Button back;
    [Token(Token = "0x400CE88")]
    [FieldOffset(Offset = "0x30")]
    private ScrollListController mController;
    [Token(Token = "0x400CE89")]
    [FieldOffset(Offset = "0x34")]
    private float mOffset;
    [Token(Token = "0x400CE8A")]
    [FieldOffset(Offset = "0x38")]
    private float mStartPos;
    [Token(Token = "0x400CE8B")]
    [FieldOffset(Offset = "0x3C")]
    private float mCenter;
    [Token(Token = "0x400CE8C")]
    [FieldOffset(Offset = "0x40")]
    private ScrollClamped_TownMenu.MENU_ID mSelectIdx;
    [Token(Token = "0x400CE8D")]
    [FieldOffset(Offset = "0x44")]
    private bool mIsSelected;
    [Token(Token = "0x400CE8E")]
    [FieldOffset(Offset = "0x48")]
    private GameObject ordealObj;

    [Token(Token = "0x600C1B2")]
    [Address(RVA = "0x89EFC0", Offset = "0x89DDC0", VA = "0x1089EFC0")]
    public void Start()
    {
    }

    [Token(Token = "0x600C1B3")]
    [Address(RVA = "0x89EFE0", Offset = "0x89DDE0", VA = "0x1089EFE0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C1B4")]
    [Address(RVA = "0x89E2F0", Offset = "0x89D0F0", VA = "0x1089E2F0", Slot = "4")]
    public void OnSetUpItems()
    {
    }

    [Token(Token = "0x600C1B5")]
    [Address(RVA = "0x89E650", Offset = "0x89D450", VA = "0x1089E650", Slot = "5")]
    public void OnUpdateItems(int idx, GameObject obj)
    {
    }

    [Token(Token = "0x600C1B6")]
    [Address(RVA = "0x89DBA0", Offset = "0x89C9A0", VA = "0x1089DBA0")]
    private void OnAfterStartup(bool success)
    {
    }

    [Token(Token = "0x600C1B7")]
    [Address(RVA = "0x89ECE0", Offset = "0x89DAE0", VA = "0x1089ECE0")]
    private IEnumerator OrdealReleaseAnimationCoroutine(GameObject obj, UnlockParam lockState)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600C1B8")]
    [Address(RVA = "0x89E8F0", Offset = "0x89D6F0", VA = "0x1089E8F0")]
    public void OnUpdateScale(List<RectTransform> rects)
    {
    }

    [Token(Token = "0x600C1B9")]
    [Address(RVA = "0x89ED60", Offset = "0x89DB60", VA = "0x1089ED60")]
    private void SetCenter(GameObject obj)
    {
    }

    [Token(Token = "0x600C1BA")]
    [Address(RVA = "0x89E0D0", Offset = "0x89CED0", VA = "0x1089E0D0")]
    public void OnNext()
    {
    }

    [Token(Token = "0x600C1BB")]
    [Address(RVA = "0x89E1E0", Offset = "0x89CFE0", VA = "0x1089E1E0")]
    public void OnPrev()
    {
    }

    [Token(Token = "0x600C1BC")]
    [Address(RVA = "0x89DDD0", Offset = "0x89CBD0", VA = "0x1089DDD0")]
    public void OnClick(GameObject obj)
    {
    }

    [Token(Token = "0x600C1BD")]
    [Address(RVA = "0x89EF30", Offset = "0x89DD30", VA = "0x1089EF30")]
    private void SetReleaseStoryPartAction(GameObject obj, int image_idx)
    {
    }

    [Token(Token = "0x600C1BE")]
    [Address(RVA = "0x89F210", Offset = "0x89E010", VA = "0x1089F210")]
    public ScrollClamped_TownMenu()
    {
    }

    [Token(Token = "0x2002A6E")]
    private enum MENU_ID
    {
      [Token(Token = "0x400CE90")] None = -1, // 0xFFFFFFFF
      [Token(Token = "0x400CE91")] Story = 0,
      [Token(Token = "0x400CE92")] Event = 1,
      [Token(Token = "0x400CE93")] Tower = 2,
      [Token(Token = "0x400CE94")] Chara = 3,
      [Token(Token = "0x400CE95")] Key = 4,
      [Token(Token = "0x400CE96")] Ordeal = 5,
      [Token(Token = "0x400CE97")] Multi = 6,
    }
  }
}
