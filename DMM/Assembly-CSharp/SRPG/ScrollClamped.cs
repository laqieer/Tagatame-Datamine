// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollClamped
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A68")]
  [AddComponentMenu("UI/ScrollClamped")]
  [RequireComponent(typeof (ScrollListController))]
  public class ScrollClamped : MonoBehaviour, ScrollListSetUp
  {
    [Token(Token = "0x400CE5B")]
    [FieldOffset(Offset = "0xC")]
    private int m_Max;
    [Token(Token = "0x400CE5C")]
    [FieldOffset(Offset = "0x10")]
    private int[] m_CategoryNum;

    [Token(Token = "0x600C192")]
    [Address(RVA = "0x89D980", Offset = "0x89C780", VA = "0x1089D980")]
    public void Start()
    {
    }

    [Token(Token = "0x600C193")]
    [Address(RVA = "0x89D690", Offset = "0x89C490", VA = "0x1089D690", Slot = "4")]
    public void OnSetUpItems()
    {
    }

    [Token(Token = "0x600C194")]
    [Address(RVA = "0x89D8E0", Offset = "0x89C6E0", VA = "0x1089D8E0", Slot = "5")]
    public void OnUpdateItems(int idx, GameObject obj)
    {
    }

    [Token(Token = "0x600C195")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ScrollClamped()
    {
    }
  }
}
