// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopTimeLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FDC")]
  [AddComponentMenu("Common/LimitedShopTimeLimit")]
  public class LimitedShopTimeLimit : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x400380F")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Body;
    [Token(Token = "0x4003810")]
    [FieldOffset(Offset = "0x10")]
    public Text Timer;
    [Token(Token = "0x4003811")]
    [FieldOffset(Offset = "0x18")]
    private long mEndTime;
    [Token(Token = "0x4003812")]
    [FieldOffset(Offset = "0x20")]
    private float mRefreshInterval;

    [Token(Token = "0x60041F6")]
    [Address(RVA = "0x1199A20", Offset = "0x1198820", VA = "0x11199A20")]
    private void Start()
    {
    }

    [Token(Token = "0x60041F7")]
    [Address(RVA = "0x1199B90", Offset = "0x1198990", VA = "0x11199B90")]
    private void Update()
    {
    }

    [Token(Token = "0x60041F8")]
    [Address(RVA = "0x1199580", Offset = "0x1198380", VA = "0x11199580")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60041F9")]
    [Address(RVA = "0x1199AE0", Offset = "0x11988E0", VA = "0x11199AE0", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x60041FA")]
    [Address(RVA = "0x1190E20", Offset = "0x118FC20", VA = "0x11190E20")]
    public LimitedShopTimeLimit()
    {
    }
  }
}
