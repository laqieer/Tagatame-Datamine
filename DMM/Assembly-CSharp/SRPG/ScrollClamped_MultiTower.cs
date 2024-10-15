// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollClamped_MultiTower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A6C")]
  [AddComponentMenu("UI/ScrollClamped_MultiTower")]
  [RequireComponent(typeof (ScrollListController))]
  public class ScrollClamped_MultiTower : MonoBehaviour, ScrollListSetUp
  {
    [Token(Token = "0x400CE79")]
    [FieldOffset(Offset = "0xC")]
    private readonly float OFFSET;
    [Token(Token = "0x400CE7A")]
    [FieldOffset(Offset = "0x10")]
    private readonly int MARGIN;
    [Token(Token = "0x400CE7B")]
    [FieldOffset(Offset = "0x14")]
    private int mMax;
    [Token(Token = "0x400CE7C")]
    [FieldOffset(Offset = "0x18")]
    public float Space;
    [Token(Token = "0x400CE7D")]
    [FieldOffset(Offset = "0x1C")]
    public ScrollAutoFit AutoFit;
    [Token(Token = "0x400CE7E")]
    [FieldOffset(Offset = "0x20")]
    public MultiTowerInfo TowerInfo;

    [Token(Token = "0x600C1AE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Start()
    {
    }

    [Token(Token = "0x600C1AF")]
    [Address(RVA = "0x89D230", Offset = "0x89C030", VA = "0x1089D230", Slot = "4")]
    public void OnSetUpItems()
    {
    }

    [Token(Token = "0x600C1B0")]
    [Address(RVA = "0x89D4C0", Offset = "0x89C2C0", VA = "0x1089D4C0", Slot = "5")]
    public void OnUpdateItems(int idx, GameObject obj)
    {
    }

    [Token(Token = "0x600C1B1")]
    [Address(RVA = "0x89D660", Offset = "0x89C460", VA = "0x1089D660")]
    public ScrollClamped_MultiTower()
    {
    }
  }
}
