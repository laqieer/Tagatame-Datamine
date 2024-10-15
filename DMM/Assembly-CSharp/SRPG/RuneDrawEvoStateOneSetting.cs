// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawEvoStateOneSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002993")]
  [AddComponentMenu("UI/Rune/RuneDrawEvoStateOneSetting")]
  public class RuneDrawEvoStateOneSetting : MonoBehaviour
  {
    [Token(Token = "0x400C8D6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private StatusList mEvoStatusList;
    [Token(Token = "0x400C8D7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mEvoStatusTexts;
    [Token(Token = "0x400C8D8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mEvoStatusLock;
    [Token(Token = "0x400C8D9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image mEvoStatusGauge;
    [Token(Token = "0x400C8DA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image mFrameImage;
    [Token(Token = "0x400C8DB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mNewIconObject;
    [Token(Token = "0x400C8DC")]
    [FieldOffset(Offset = "0x24")]
    [Space(10f)]
    [SerializeField]
    private float mAnimTime;
    [Token(Token = "0x400C8DD")]
    [FieldOffset(Offset = "0x28")]
    private BaseStatus mAddStatus;
    [Token(Token = "0x400C8DE")]
    [FieldOffset(Offset = "0x2C")]
    private BaseStatus mScaleStatus;
    [Token(Token = "0x400C8DF")]
    [FieldOffset(Offset = "0x30")]
    private float mPercentage;
    [Token(Token = "0x400C8E0")]
    [FieldOffset(Offset = "0x34")]
    private float mStartPercentage;
    [Token(Token = "0x400C8E1")]
    [FieldOffset(Offset = "0x38")]
    private bool mIsShowFrame;
    [Token(Token = "0x400C8E2")]
    [FieldOffset(Offset = "0x39")]
    private bool mIsAnim;

    [Token(Token = "0x600BC67")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC68")]
    [Address(RVA = "0x8400E0", Offset = "0x83EEE0", VA = "0x108400E0")]
    public void StartGaugeAnim()
    {
    }

    [Token(Token = "0x600BC69")]
    [Address(RVA = "0x83FD90", Offset = "0x83EB90", VA = "0x1083FD90")]
    public IEnumerator GaugeAnim() => (IEnumerator) null;

    [Token(Token = "0x600BC6A")]
    [Address(RVA = "0x840080", Offset = "0x83EE80", VA = "0x10840080")]
    public void SetStatus(
      BaseStatus add_status,
      BaseStatus scale_status,
      float percentage,
      bool is_anim = false,
      float start_percentage = 0.0f)
    {
    }

    [Token(Token = "0x600BC6B")]
    [Address(RVA = "0x840060", Offset = "0x83EE60", VA = "0x10840060")]
    public void SetShowFrame(bool is_show)
    {
    }

    [Token(Token = "0x600BC6C")]
    [Address(RVA = "0x83FFF0", Offset = "0x83EDF0", VA = "0x1083FFF0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC6D")]
    [Address(RVA = "0x83FE70", Offset = "0x83EC70", VA = "0x1083FE70")]
    private void RefreshParam()
    {
    }

    [Token(Token = "0x600BC6E")]
    [Address(RVA = "0x83FE00", Offset = "0x83EC00", VA = "0x1083FE00")]
    private void RefreshFrame()
    {
    }

    [Token(Token = "0x600BC6F")]
    [Address(RVA = "0x840010", Offset = "0x83EE10", VA = "0x10840010")]
    public void SetNewIconVisible(bool isVisible)
    {
    }

    [Token(Token = "0x600BC70")]
    [Address(RVA = "0x840150", Offset = "0x83EF50", VA = "0x10840150")]
    public RuneDrawEvoStateOneSetting()
    {
    }
  }
}
