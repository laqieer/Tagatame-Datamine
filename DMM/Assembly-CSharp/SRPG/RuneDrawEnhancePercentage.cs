// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawEnhancePercentage
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
  [Token(Token = "0x200298D")]
  [AddComponentMenu("UI/Rune/RuneDrawEnhancePercentage")]
  public class RuneDrawEnhancePercentage : MonoBehaviour
  {
    [Token(Token = "0x400C8B8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mGaugeText;
    [Token(Token = "0x400C8B9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image mGauge;
    [Token(Token = "0x400C8BA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray mGaugeButtonImage;
    [Token(Token = "0x400C8BB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mPercentage;
    [Token(Token = "0x400C8BC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float mAnimTime;
    [Token(Token = "0x400C8BD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mGaugeStartSE;
    [Token(Token = "0x400C8BE")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mGaugeFullSE;
    [Token(Token = "0x400C8BF")]
    [FieldOffset(Offset = "0x28")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400C8C0")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsUseEnhanceGauge;
    [Token(Token = "0x400C8C1")]
    [FieldOffset(Offset = "0x2D")]
    private bool mIsGaugeAnim;
    [Token(Token = "0x400C8C2")]
    [FieldOffset(Offset = "0x30")]
    private float mStartGauge;

    [Token(Token = "0x600BC40")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC41")]
    [Address(RVA = "0x83F9B0", Offset = "0x83E7B0", VA = "0x1083F9B0")]
    public void OnEnable()
    {
    }

    [Token(Token = "0x600BC42")]
    [Address(RVA = "0x83FC30", Offset = "0x83EA30", VA = "0x1083FC30")]
    public void SetDrawParam(BindRuneData rune_data, bool is_use_enhance_gauge)
    {
    }

    [Token(Token = "0x600BC43")]
    [Address(RVA = "0x83FC60", Offset = "0x83EA60", VA = "0x1083FC60")]
    public void SetupGaugeAnim(float _start_gauge)
    {
    }

    [Token(Token = "0x600BC44")]
    [Address(RVA = "0x83FA20", Offset = "0x83E820", VA = "0x1083FA20")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC45")]
    [Address(RVA = "0x83F9B0", Offset = "0x83E7B0", VA = "0x1083F9B0")]
    public void StartGaugeAnim()
    {
    }

    [Token(Token = "0x600BC46")]
    [Address(RVA = "0x83F940", Offset = "0x83E740", VA = "0x1083F940")]
    private IEnumerator GaugeAnim() => (IEnumerator) null;

    [Token(Token = "0x600BC47")]
    [Address(RVA = "0x83FD70", Offset = "0x83EB70", VA = "0x1083FD70")]
    public RuneDrawEnhancePercentage()
    {
    }
  }
}
