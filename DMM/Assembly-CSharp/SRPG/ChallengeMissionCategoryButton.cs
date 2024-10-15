// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMissionCategoryButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002129")]
  [AddComponentMenu("UI/ChallengeMissionCategoryButton")]
  public class ChallengeMissionCategoryButton : MonoBehaviour
  {
    [Token(Token = "0x4008FDE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SwitchingBadge mSwitchingBadge;
    [Token(Token = "0x4008FDF")]
    [FieldOffset(Offset = "0x10")]
    public Button Button;
    [Token(Token = "0x4008FE0")]
    [FieldOffset(Offset = "0x14")]
    public Image Badge;
    [Token(Token = "0x4008FE1")]
    [FieldOffset(Offset = "0x18")]
    public Image SelectionFrame;
    [Token(Token = "0x4008FE2")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject TimerBase;
    [Token(Token = "0x4008FE3")]
    [FieldOffset(Offset = "0x20")]
    public Text Timer;
    [Token(Token = "0x4008FE4")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ObjComplete;
    [Token(Token = "0x4008FE5")]
    [FieldOffset(Offset = "0x28")]
    private float mRefreshInterval;
    [Token(Token = "0x4008FE6")]
    [FieldOffset(Offset = "0x2C")]
    private ChallengeCategoryParam mCategoryParam;

    [Token(Token = "0x6008B00")]
    [Address(RVA = "0x4E62D0", Offset = "0x4E50D0", VA = "0x104E62D0")]
    public void SetChallengeCategory(ChallengeCategoryParam category)
    {
    }

    [Token(Token = "0x6008B01")]
    [Address(RVA = "0x4E6300", Offset = "0x4E5100", VA = "0x104E6300")]
    private void Update()
    {
    }

    [Token(Token = "0x6008B02")]
    [Address(RVA = "0x4E6080", Offset = "0x4E4E80", VA = "0x104E6080")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008B03")]
    [Address(RVA = "0x4E5AB0", Offset = "0x4E48B0", VA = "0x104E5AB0")]
    public void RefreshSwitchingBadge()
    {
    }

    [Token(Token = "0x6008B04")]
    [Address(RVA = "0x4E5B80", Offset = "0x4E4980", VA = "0x104E5B80")]
    private void RefreshTimerObj()
    {
    }

    [Token(Token = "0x6008B05")]
    [Address(RVA = "0x4E5C40", Offset = "0x4E4A40", VA = "0x104E5C40")]
    private void RefreshTimer()
    {
    }

    [Token(Token = "0x6008B06")]
    [Address(RVA = "0x4E59E0", Offset = "0x4E47E0", VA = "0x104E59E0")]
    private void RefreshComplete()
    {
    }

    [Token(Token = "0x6008B07")]
    [Address(RVA = "0x4E5960", Offset = "0x4E4760", VA = "0x104E5960")]
    public bool IsCompleted() => new bool();

    [Token(Token = "0x6008B08")]
    [Address(RVA = "0x4E6350", Offset = "0x4E5150", VA = "0x104E6350")]
    public ChallengeMissionCategoryButton()
    {
    }
  }
}
